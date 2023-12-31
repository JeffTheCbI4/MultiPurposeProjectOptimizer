﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPurposeProjectOptimizer
{
    class PackOptimizer
    {
        public Dictionary<int, Project> Projects { get; private set; }
        public Dictionary<int, MultiPurposeProject> MultiPurposeProjects { get; private set; }
        public Dictionary<string, double> Caps { get; private set; }
        public List<string> MaximizedProperties { get; private set; }
        public string Mode { get; private set; }
        public double effectDifference { get; private set; }
        public int SolutionSetCap { get; private set; }
        public Solution OptimalSolution { get; private set; }

        public PackOptimizer(
            Dictionary<int, Project> projects,
            Dictionary<string, double> caps,
            List<string> maximizedProperties
            )
        {
            Projects = projects;
            Caps = caps;
            MaximizedProperties = maximizedProperties;
        }

        public PackOptimizer(
            Dictionary<int, Project> projects,
            Dictionary<int, MultiPurposeProject> multiPurposeProjects,
            Dictionary<string, double> caps,
            List<string> maximizedProperties
            )
        {
            Projects = projects;
            MultiPurposeProjects = multiPurposeProjects;
            Caps = caps;
            MaximizedProperties = maximizedProperties;
        }

        private void TestInputData()
        {
            if (Projects.Count == 0 && MultiPurposeProjects.Count == 0)
            {
                throw new Exception("Список проектов пуст.");
            }
            if (Caps.Count < 1)
            {
                throw new Exception("Список ограничений не должен быть пустым.");
            }
            if (MaximizedProperties.Count < 1)
            {
                throw new Exception("Не выбрано максимизируемое свойство.");
            }
            if (MaximizedProperties.Count > 1)
            {
                throw new Exception("Слишком много максимизируемых свойств.");
            }
            if (Caps.ContainsKey(MaximizedProperties[0]))
            {
                throw new Exception("Максимизируемое свойство не должно ограничиваться.");
            }
        }

        public void Solve()
        {
            TestInputData();

            List<List<Solution>> solutionLists = TurnProjectsIntoSolutionLists(Projects);
            if (MultiPurposeProjects == null || MultiPurposeProjects.Count == 0)
            {
                OptimalSolution = SolveWithoutMPP(solutionLists, Caps);
            } else
            {
                OptimalSolution = SolveWithMPP(solutionLists, Caps);
            }
        }

        /// <summary>
        /// Поиск решения c учетом многоцелевых проектов.
        /// </summary>
        /// <param name="solutionsLists">
        /// Готовые наборы решений
        /// </param>
        /// /// <param name="caps">
        /// Словарь ограничений для затрат, где ключ - это название типа затрат.
        /// </param>
        /// <returns>
        /// Оптимальное решение
        /// </returns>
        private Solution SolveWithMPP(List<List<Solution>> solutionsLists, Dictionary<string, double> caps)
        {
            Tuple<Solution, Dictionary<int, MultiPurposeProject>> optimalVariant;

            List<MultiPurposeProject> mppList = new List<MultiPurposeProject>();
            foreach (int key in MultiPurposeProjects.Keys)
            {
                mppList.Add(MultiPurposeProjects[key]);
            }
            optimalVariant = ExploreAllMPPVariants(mppList, new Dictionary<int, MultiPurposeProject>(), caps, 0);

            return optimalVariant.Item1;
        }

        private Tuple<Solution, Dictionary<int, MultiPurposeProject>> ExploreAllMPPVariants(
            List<MultiPurposeProject> mppList,
            Dictionary<int, MultiPurposeProject> currentSelection,
            Dictionary<string, double> caps,
            int index)
        {
            if (index == MultiPurposeProjects.Count)
            {
                // Базовый случай - все проекты рассмотрены
                // Копируем список проектов
                Dictionary<int, Project> newProjects = new Dictionary<int, Project>();
                foreach (int projectId in Projects.Keys)
                {
                    newProjects.Add(projectId, Projects[projectId].copyProject());
                }

                //Копируем список ограничений
                Dictionary<string, double> newCaps = new Dictionary<string, double>();
                foreach (string propertyName in caps.Keys)
                {
                    newCaps.Add(propertyName, caps[propertyName]);
                }

                List<Influence> influencesOnMPP = new List<Influence>();
                foreach (MultiPurposeProject mpp in currentSelection.Values)
                {
                    for (int i = 0; i < mpp.Influence.Count; i++)
                    {
                        int influencedProjectId = mpp.Influence[i].InfluencedProjectId;
                        string influencedPropertyName = mpp.Influence[i].InfluencedPropertyName;
                        double influenceValue = mpp.Influence[i].Value;

                        if(newProjects.ContainsKey(influencedProjectId))
                        {
                            newProjects[influencedProjectId].Properties[influencedPropertyName] += influenceValue;
                        } else if (currentSelection.ContainsKey(influencedProjectId))
                        {
                            influencesOnMPP.Add(mpp.Influence[i]);
                        }
                    }
                    foreach(string propertyName in caps.Keys)
                    {
                        if (mpp.Properties.ContainsKey(propertyName))
                        {
                            newCaps[propertyName] -= mpp.Properties[propertyName];
                        }
                    }
                }
                List<List<Solution>> solutionLists = TurnProjectsIntoSolutionLists(newProjects);
                Solution optimalSolution = SolveWithoutMPP(solutionLists, newCaps);
                if (optimalSolution == null)
                {
                    return new Tuple<Solution, Dictionary<int, MultiPurposeProject>>(null, currentSelection);
                }

                foreach (Influence influence in influencesOnMPP)
                {
                    int mppId = influence.InfluencedProjectId;
                    currentSelection[mppId] = currentSelection[mppId].copyProject();
                    currentSelection[mppId].Properties[influence.InfluencedPropertyName] += influence.Value;
                }
                optimalSolution.AddProjects(currentSelection.Values.ToList<Project>());
                return new Tuple<Solution, Dictionary<int, MultiPurposeProject>>(optimalSolution, currentSelection);
            }
            else
            {
                // Рекурсивный случай
                // Выбираем следующий проект и рекурсивно вызываем функцию для
                // случаев с взятием и без взятия этого проекта
                Dictionary<int, MultiPurposeProject> newSelection = new Dictionary<int, MultiPurposeProject>(currentSelection);
                newSelection.Add(mppList[index].Id, mppList[index]);
                Tuple<Solution, Dictionary<int, MultiPurposeProject>> optimalWithProject = 
                    ExploreAllMPPVariants(mppList, newSelection, caps, index + 1);
                Tuple<Solution, Dictionary<int, MultiPurposeProject>> optimalWithoutProject = 
                    ExploreAllMPPVariants(mppList, currentSelection, caps, index + 1);
                string maximizedPropertyName = MaximizedProperties[0];
                if (optimalWithProject.Item1 == null ||
                    !optimalWithProject.Item1.SolutionProperties.ContainsKey(maximizedPropertyName))
                {
                    return optimalWithoutProject;
                }
                else if ((optimalWithoutProject.Item1 != null && optimalWithProject.Item1 != null &&
                    optimalWithoutProject.Item1.SolutionProperties.ContainsKey(maximizedPropertyName) &&
                    optimalWithProject.Item1.SolutionProperties.ContainsKey(maximizedPropertyName) &&
                    optimalWithoutProject.Item1.SolutionProperties[maximizedPropertyName] >
                    optimalWithProject.Item1.SolutionProperties[maximizedPropertyName]))
                {
                    return optimalWithoutProject;
                }
                else
                {
                    return optimalWithProject;
                }
            }
        }

        /// <summary>
        /// Поиск решения без учета многоцелевых проектов.
        /// </summary>
        /// <param name="solutionsLists">
        /// Готовые наборы решений
        /// </param>
        /// /// <param name="caps">
        /// Словарь ограничений для затрат, где ключ - это название типа затрат.
        /// </param>
        /// <returns>
        /// Оптимальное решение
        /// </returns>
        private Solution SolveWithoutMPP(List<List<Solution>> solutionsLists, Dictionary<string, double> caps)
        {
            List<List<List<Solution>>> history = new List<List<List<Solution>>>();
            history.Add(solutionsLists);
            while (solutionsLists.Count > 1)
            {
                solutionsLists = MergeSolutionSets(solutionsLists, caps);
            }
            if (solutionsLists.Count == 0)
            {
                return null;
            }
            Solution optimalSolution = findOptimalInSolutionSet(solutionsLists[0], history, caps);

            
            return optimalSolution;
        }

        /// <summary>
        /// Переводит словарь проектов в наборы решений. Для каждого проекта создается
        /// отдельный набор. Каждый набор состоит из двух решений: в одном проект берётся
        /// в другом - нет.
        /// </summary>
        /// <param name="projects">Словарь проектов, где ключ - id проекта</param>
        /// <returns></returns>
        private List<List<Solution>> TurnProjectsIntoSolutionLists(Dictionary<int, Project> projects)
        {
            List<List<Solution>> solutionLists = new List<List<Solution>>();
            foreach (Project project in projects.Values)
            {
                var projectSolutions = new List<Solution>();

                Dictionary<string, double> zeroProperties = new Dictionary<string, double>();
                foreach (string propertyName in project.Properties.Keys)
                {
                    zeroProperties.Add(propertyName, 0);
                }
                var noProjectSolution = new Solution(zeroProperties, new Dictionary<int, bool?> { { project.Id, false } }, false);

                Dictionary<string, double> projectProperties = new Dictionary<string, double>();
                foreach (string propertyName in project.Properties.Keys)
                {
                    projectProperties.Add(propertyName, project.Properties[propertyName]);
                }
                var takeProjectSolution = new Solution(
                    projectProperties, new Dictionary<int, bool?> { { project.Id, true } }, false);

                projectSolutions.Add(noProjectSolution);
                projectSolutions.Add(takeProjectSolution);
                solutionLists.Add(projectSolutions);
            }
            return solutionLists;
        }

        /// <summary>
        /// Соединение наборов решений из списка. Каждые два набора соединяются в один.
        /// Если список наборов нечетный, последний набор остается как есть.
        /// </summary>
        /// <param name="solutionSets">Лист наборов решений.</param>
        /// <returns>Новый лист соединенных наборов решений.</returns>
        private List<List<Solution>> MergeSolutionSets(List<List<Solution>> solutionSets, Dictionary<string, double> caps)
        {
            var newSolutionSets = new List<List<Solution>>();
            for (int i = 1; i <= solutionSets.Count; i+=2)
            {
                if (i == solutionSets.Count)
                { 
                    newSolutionSets.Add(solutionSets[i - 1]);
                    break;
                }
                List<Solution> combinedSolutionSet = CombineTwoSolutionSets(solutionSets[i - 1], solutionSets[i], caps);
                combinedSolutionSet = DiscardBadSolutions(combinedSolutionSet, caps);
                combinedSolutionSet = DiscardDominatedSolutions(combinedSolutionSet);

                //TODO: разкомментировать код ниже когда разберемся со поиском оптимала в слитых решениях
                //Код ниже проверяет наличие слитого решения в наборе.
                /*bool hasProblematicSolutions = false;
                for (int j = 0; j < combinedSolutionSet.Count; j++)
                {
                    if (combinedSolutionSet[j].isMerged)
                    {
                        hasProblematicSolutions = true;
                        break;
                    }
                }*/

                //TODO: разкомментировать код ниже когда разберемся со поиском оптимала в слитых решениях
                //Код ниже сливает решения в наборе решений в зависимости от ограничения на количество решений
                /*if (!hasProblematicSolutions && combinedSolutionSet.Count > SolutionSetCap && solutionSets.Count > 2)
                {
                    combinedSolutionSet = MergeSolutionsInSet(combinedSolutionSet, SolutionSetCap);
                }*/

                newSolutionSets.Add(combinedSolutionSet);
            }
            return newSolutionSets;
        }

        /// <summary>
        /// Соединение двух наборов решений в один.
        /// </summary>
        /// <param name="solutionSet1">Первый набор решений.</param>
        /// <param name="solutionSet2">Второй набор решений.</param>
        /// <returns>Новый набор решений, созданный из двух других.</returns>
        //TODO: переписать, чтобы в project statuses вписывались только взятые проекты
        private List<Solution> CombineTwoSolutionSets(List<Solution> solutionSet1, List<Solution> solutionSet2,
            Dictionary<string, double> caps)
        {
            var combinedSolutionSet = new List<Solution>();
            for (int i = 0; i < solutionSet1.Count; i++)
            {
                for (int j = 0; j < solutionSet2.Count; j++)
                {
                    var combinedSolutionProperties = new Dictionary<string, double>();
                    foreach (string propertyName in this.MaximizedProperties)
                    {
                        double propertyValue = 0;
                        if (solutionSet1[i].SolutionProperties.ContainsKey(propertyName) &&
                            solutionSet2[j].SolutionProperties.ContainsKey(propertyName))
                        {
                            propertyValue = solutionSet1[i].SolutionProperties[propertyName] +
                            solutionSet2[j].SolutionProperties[propertyName];
                        }
                        else if (solutionSet1[i].SolutionProperties.ContainsKey(propertyName))
                        {
                            propertyValue = solutionSet1[i].SolutionProperties[propertyName];
                        }
                        else if (solutionSet2[j].SolutionProperties.ContainsKey(propertyName))
                        {
                            propertyValue = solutionSet2[j].SolutionProperties[propertyName];
                        }
                        combinedSolutionProperties.Add(propertyName, propertyValue);
                    }
                    foreach (string propertyName in caps.Keys)
                    {
                        double propertyValue = 0;
                        if (solutionSet1[i].SolutionProperties.ContainsKey(propertyName) &&
                            solutionSet2[j].SolutionProperties.ContainsKey(propertyName))
                        {
                            propertyValue = solutionSet1[i].SolutionProperties[propertyName] +
                            solutionSet2[j].SolutionProperties[propertyName];
                        }
                        else if (solutionSet1[i].SolutionProperties.ContainsKey(propertyName))
                        {
                            propertyValue = solutionSet1[i].SolutionProperties[propertyName];
                        }
                        else if (solutionSet2[j].SolutionProperties.ContainsKey(propertyName))
                        {
                            propertyValue = solutionSet2[j].SolutionProperties[propertyName];
                        }
                        combinedSolutionProperties.Add(propertyName, propertyValue);
                    }

                    var combinedProjectsStatus = new Dictionary<int, bool?>();
                    foreach (int projectId in solutionSet1[i].ProjectStatus.Keys)
                    {
                        combinedProjectsStatus.Add(projectId, solutionSet1[i].ProjectStatus[projectId]);
                    }
                    foreach (int projectId in solutionSet2[j].ProjectStatus.Keys)
                    {
                        combinedProjectsStatus.Add(projectId, solutionSet2[j].ProjectStatus[projectId]);
                    }
                    bool isMerged = solutionSet1[i].IsMerged || solutionSet2[j].IsMerged;
                    var mergedSolution = new Solution(
                        combinedSolutionProperties,
                        combinedProjectsStatus, isMerged, new List<Solution>() { solutionSet1[i], solutionSet2[j] });
                    combinedSolutionSet.Add(mergedSolution);
                }
            }
            return combinedSolutionSet;
        }

        /// <summary>
        /// Отбрасывание плохих решений из списка.
        /// Отбрасываются те решения, чьи затраты превышают ограничения.
        /// Лист решений возвращается новый. Старый лист остаётся неизменным.
        /// </summary>
        /// <param name="solutions">Лист решений.</param>
        /// <returns>Новый лист без плохих решений.</returns>
        private List<Solution> DiscardBadSolutions(List<Solution> solutions, Dictionary<string, double> caps)
        {
            var solutionsToDiscard = new List<int>();
            for (int i = 0; i < solutions.Count; i++)
            {
                foreach (string propertyName in caps.Keys)
                {
                    if (solutions[i].SolutionProperties.ContainsKey(propertyName) && 
                        solutions[i].SolutionProperties[propertyName] > caps[propertyName]) 
                    {
                        solutionsToDiscard.Add(i);
                        break;
                    }
                }
            }


            for (int i = solutionsToDiscard.Count - 1; i >= 0; i--)
            {
                solutions.RemoveAt(solutionsToDiscard[i]);
            }
            return solutions;
        }

        /// <summary>
        /// Отбрасывание доминируемых решений из списка.
        /// Если одно решение хуже другого по всем параметрам, оно отбрасывается
        /// Лист решений возвращается новый. Старый лист остаётся неизменным.
        /// </summary>
        /// <param name="solutions">Лист решений.</param>
        /// <returns>Новый лист без доминируемых решений.</returns>
        private List<Solution> DiscardDominatedSolutions(List<Solution> solutions)
        {
            var solutionsToDiscard = new List<int>();
            for (int i = 0; i < solutions.Count; i++)
            {
                for (int j = i + 1; j < solutions.Count; j++)
                {
                    var isLessValuableOrEqual = true;
                    var isMoreExpensiveOrEqual = true;
                    foreach(string propertyName in MaximizedProperties)
                    {
                        if (!solutions[i].SolutionProperties.ContainsKey(propertyName) ||
                            !solutions[j].SolutionProperties.ContainsKey(propertyName) ||
                            solutions[i].SolutionProperties[propertyName] > solutions[j].SolutionProperties[propertyName])
                        { 
                            isLessValuableOrEqual = false;
                            break;
                        }
                    }
                    foreach (string propertyName in Caps.Keys)
                    {
                        if (!solutions[i].SolutionProperties.ContainsKey(propertyName) ||
                            !solutions[j].SolutionProperties.ContainsKey(propertyName) ||
                            solutions[i].SolutionProperties[propertyName] < solutions[j].SolutionProperties[propertyName])
                        {
                            isMoreExpensiveOrEqual = false;
                            break;
                        }
                    }
                    if (isLessValuableOrEqual && isMoreExpensiveOrEqual) 
                    { 
                        solutionsToDiscard.Add(i);
                        break;
                    }
                }
            }
            solutionsToDiscard.Sort();
            for (int i = solutionsToDiscard.Count - 1; i >= 0; i--)
            {
                solutions.RemoveAt(solutionsToDiscard[i]);
            }
            return solutions;
        }

        /// <summary>
        /// Слияние решений в листе. Решения разбиваются на группы так,
        /// чтобы после их слияния в листе оставалось ровно столько решений, сколько
        /// максимально позволяет ограничение. Возвращается новый лист решений.
        /// Старый лист остается неизменным.
        /// </summary>
        /// <param name="solutions">Лист решений.</param>
        /// <param name="solutionsQuantityCap">Ограничение на количество решений в листе.</param>
        /// <returns>Новый лист слитых решений.</returns>
        private List<Solution> MergeSolutionsInSet(List<Solution> solutions, int solutionsQuantityCap)
        {
            SortSolutions(solutions);
            //int solutionsGroupQuantity = solutions.Count / SolutionSetCap;
            //int remainder = solutions.Count % SolutionSetCap;
            List<Solution> newSolutionsSet = new List<Solution>();
            for (int i = 0; i < SolutionSetCap; i++)
            {
                List<Solution> groupedSolutions = solutions.GetRange(i * solutionsQuantityCap, solutionsQuantityCap);
                Solution mergedSolution = MergeSolutionsGroup(groupedSolutions);
                newSolutionsSet.Add(mergedSolution);
            }
            return solutions;
        }
        
        /// <summary>
        /// Слияние листа решений в одно решение. Возвращаемое решение
        /// имеет максимальное из листа значение эффекта, и минимальные затраты.
        /// </summary>
        /// <param name="solutions">Лист решений</param>
        /// <returns>Решение, созданное из слияния листа решений.</returns>
        //TODO: Переписать, чтоб в project statuses вводилась инфа только по решению с макс эффектом
        private Solution MergeSolutionsGroup(List<Solution> solutions)
        {
            Dictionary<string, double> mergedProperties = new Dictionary<string, double>();
            foreach (string propertyName in MaximizedProperties)
            {
                double max = solutions[0].SolutionProperties[propertyName];
                for (int i = 1; i < solutions.Count; i++)
                {
                    double solutionPropertyValue = solutions[i].SolutionProperties[propertyName];
                    max = solutionPropertyValue > max ? solutionPropertyValue : max;
                }
                mergedProperties.Add(propertyName, max);
            }
            foreach (string propertyName in Caps.Keys)
            {
                double min = solutions[0].SolutionProperties[propertyName];
                for (int i = 1; i < solutions.Count; i++)
                {
                    double solutionPropertyValue = solutions[i].SolutionProperties[propertyName];
                    min = solutionPropertyValue < min ? solutionPropertyValue : min;
                }
                mergedProperties.Add(propertyName, min);
            }

            Dictionary<int, bool?> mergedProjectStatuses = new Dictionary<int, bool?>();
            for (int i = 0; i < solutions.Count; i++)
            {
                Solution currentSolution = solutions[i];
                foreach (int id in currentSolution.ProjectStatus.Keys)
                {
                    if (mergedProjectStatuses.ContainsKey(id)) continue;
                    bool? currentProjectStatus = currentSolution.ProjectStatus[id];
                    for (int j = 0; j < solutions.Count; i++)
                    {
                        if (i == j) continue;
                        if (solutions[j].ProjectStatus.ContainsKey(id)
                            && solutions[j].ProjectStatus[id] != currentProjectStatus) currentProjectStatus = null;
                    }
                    mergedProjectStatuses.Add(id, currentProjectStatus);
                }
            }
            
            Solution mergedSolution = new Solution(mergedProperties, mergedProjectStatuses, true,
                solutions);
            return mergedSolution;
        }

        //Устаревший метод, см. MergeSolutionsGroup
        private Solution MergeTwoSolutions(Solution firstSolution, Solution secondSolution)
        {
            Dictionary<string, double> mergedProperties = new Dictionary<string, double>();
            foreach (string propertyName in MaximizedProperties)
            {
                double firstSolutionPropertyValue = firstSolution.SolutionProperties[propertyName];
                double secondSolutionPropertyValue = secondSolution.SolutionProperties[propertyName];
                if (firstSolutionPropertyValue > secondSolutionPropertyValue)
                {
                    mergedProperties.Add(propertyName, firstSolutionPropertyValue);
                }
                else
                {
                    mergedProperties.Add(propertyName, secondSolutionPropertyValue);
                }
            }
            foreach (string propertyName in Caps.Keys)
            {
                double firstSolutionPropertyValue = firstSolution.SolutionProperties[propertyName];
                double secondSolutionPropertyValue = secondSolution.SolutionProperties[propertyName];
                if (firstSolutionPropertyValue < secondSolutionPropertyValue)
                {
                    mergedProperties.Add(propertyName, firstSolutionPropertyValue);
                }
                else
                {
                    mergedProperties.Add(propertyName, secondSolutionPropertyValue);
                }
            }
            Dictionary<int, bool?> mergedProjectStatuses = new Dictionary<int, bool?>();
            foreach (int id in firstSolution.ProjectStatus.Keys)
            {
                mergedProjectStatuses.Add(id, firstSolution.ProjectStatus[id]);
            }
            foreach (int id in secondSolution.ProjectStatus.Keys)
            {
                if (mergedProjectStatuses.ContainsKey(id)
                    && mergedProjectStatuses[id] != secondSolution.ProjectStatus[id])
                {
                    mergedProjectStatuses[id] = null;
                } else
                {
                    mergedProjectStatuses.Add(id, secondSolution.ProjectStatus[id]);
                }
            }
            /*Solution mergedSolution = new Solution(mergedProperties, mergedProjectStatuses,
                new List<Solution>() { firstSolution, secondSolution });*/
            /*return mergedSolution;*/
            return null;
        }

        /// <summary>
        /// Сортировка решений по эффекту, пузырьковым методом по возрастанию.
        /// Возвращается новый лист. Старый лист остается неизменным.
        /// </summary>
        /// <param name="solutions">Лист решений</param>
        /// <returns>Новый отсортированный лист решений</returns>
        private List<Solution> SortSolutions(List<Solution> solutions)
        {
            for (int i = 0; i < solutions.Count; i++)
            {
                for (int j = 0; j < solutions.Count - 1; j++)
                {
                    double firstSummaryEffect = 0;
                    double secondSummaryEffect = 0;
                    foreach (string propertyName in MaximizedProperties)
                    {
                        firstSummaryEffect += solutions[j].SolutionProperties[propertyName];
                    }
                    foreach (string propertyName in MaximizedProperties)
                    {
                        secondSummaryEffect += solutions[j + 1].SolutionProperties[propertyName];
                    }
                    if (firstSummaryEffect > secondSummaryEffect)
                    {
                        Solution temp = solutions[j];
                        solutions[j] = solutions[j + 1];
                        solutions[j + 1] = temp;
                    }
                }
            }
            return solutions;
        }

        /// <summary>
        /// Поиск оптимального решения в листе решений.
        /// Оптимальным считается решение с наивысшим значением эффекта,
        /// не выходящее за рамки ограничений. "Проблемные" решения
        /// дополнительно проверяются на допустимость.
        /// </summary>
        /// <param name="solutions">Лист решений</param>
        /// <returns>Наиболее оптимальное решение</returns>
        private Solution findOptimalInSolutionSet(
            List<Solution> solutions, 
            List<List<List<Solution>>> history,
            Dictionary<string, double> caps)
        {
            if (solutions.Count < 1) return null;
            DiscardBadSolutions(solutions, caps);
            List<Solution> sortedSolutions = SortSolutions(solutions);
            Solution optimalCandidate = sortedSolutions.Last();
            for (int i = solutions.Count - 1; i >= 0; i--)
            {
                optimalCandidate = sortedSolutions[i];
                if (!optimalCandidate.IsMerged) break;
                bool isAllowable = checkAllowability(optimalCandidate, caps);
                if (isAllowable) break;

                //TODO: разкомментить когда разберемся с поисками оптимала в слитых решениях
                //TODO: дописать метод. Нужно:
                //2) Если не допустимо, нужно перерешать всё, начиная с шага, на котором
                //проблематичные решение возникло.
                /*Dictionary<Solution, List<int>> problematicSolutionInfo = findProblematicSolutionOrigin(optimalCandidate);
                Solution problematicSolution = problematicSolutionInfo.Keys.First();
                List<int> path = problematicSolutionInfo[problematicSolution];
                int pathIndex = 0;
                int depth = history.Count - 1;
                for (int j = 0; j < path.Count; j++)
                {
                    while (depth > 0 && pathIndex == history[depth].Count - 1 && history[depth - 1].Count % 2 == 1)
                    {
                        pathIndex *= 2;
                        depth -= 1;
                    }
                    pathIndex = pathIndex * 2 + path[j];
                }
                List<List<Solution>> problematicStage = history[depth];
                List<List<Solution>> fixedStage = CopyStage(problematicStage);
                List<Solution> problematicList = fixedStage[pathIndex];
                int problematicSolutionIndex = 0;
                for (int j = 0; j < problematicList.Count; j++)
                {
                    if (problematicList[j] != problematicSolution) continue;
                    problematicSolutionIndex = j;
                    break;
                }*/

                //TODO: теперь надо как-то пройтись по всем не-проблемным решениям
                // 1) Выбираем случайное решение в проблемном решении
                // 2) Делаем 2 этапа. В одном проблемное решение заменяется на выбранное,
                // в другом заменяется на решение, слитое из всех остальных невыбранных решений
                // 3) Пересчитываем наборы решений в обоих множествах, пока не останется один набор
                // 4) Сравниваем. Если какое-то макс решение допустимо, то это оптимал
                // если оба недопустимы, переходим к другому проблемному решению в проблемном этапе и возвращаемся на шаг 1
                // 5) Если перебрали все проблемные решения, а допустимое не нашлось, переходим к i--;
                //TODO: разкомментить когда разберемся с поиском оптимала в слитых решениях
                /*foreach (Solution solution in problematicSolution.ContainedSolutions)
                {

                }

                List<Solution> solutionsWithoutProblematic = SolveWithoutMPP(problematicStage, Caps);*/

            }
            return optimalCandidate;
        }

        private List<List<Solution>> CopyStage (List<List<Solution>> problematicStage)
        {
            List<List<Solution>> fixedStage = new List<List<Solution>>();
            for (int i = 0; i < problematicStage.Count; i++)
            {
                List<Solution> solutionList = new List<Solution>();
                for (int j = 0; j < problematicStage[i].Count; j++)
                {
                    solutionList.Add(problematicStage[i][j]);
                }
                fixedStage.Add(solutionList);
            }
            return fixedStage;
        }

        /// <summary>
        /// Ищет путь до этапа, на котором решение становится проблемным
        /// </summary>
        /// <param name="upperSolution"></param>
        /// <returns></returns>
        //TODO: Решение с Solution костыльное, но придумать лучше времени нет. Возможно когда нибудь надо исправить.
        private Dictionary<Solution,List<int>> findProblematicSolutionOrigin(Solution upperSolution)
        {
            for (int i = 0; i < upperSolution.ContainedSolutions.Count; i++)
            {
                Solution solution = upperSolution.ContainedSolutions[i];
                if (!solution.IsMerged) continue;
                Dictionary<Solution, List<int>> path = findProblematicSolutionOrigin(solution);
                Solution problematicSolution = path.Keys.First();
                path[problematicSolution].Add(i);
                return path;
            }
            Dictionary<Solution, List<int>> pathStart = new Dictionary<Solution, List<int>>();
            pathStart.Add(upperSolution, new List<int>());
            return pathStart;
        }

        /// <summary>
        /// Проверка допустимости решения. Решение может быть проблемным,
        /// но составляющие решения проблемными быть не должны.
        /// Если реальные затраты решения не превышают ограничения,
        /// оно считается допустимым. В противном случае - недопустимым.
        /// </summary>
        /// <param name="solution">Решение</param>
        /// <param name="caps">Ограничения на затраты</param>
        /// <returns>Допустимость решения. True - допустимо, False - недопустимо</returns>
        private bool checkAllowability(Solution solution, Dictionary<string, double> caps)
        {
            foreach(string expendName in caps.Keys)
            {
                double realExpends = 0;
                foreach (int projectId in solution.ProjectStatus.Keys)
                {
                    if (Projects[projectId].Properties.ContainsKey(expendName))
                    {
                        realExpends += Projects[projectId].Properties[expendName];
                    }
                }
                if (realExpends > caps[expendName]) return false;
            }
            return true;
        }

        private Dictionary<int, Project> ApplyMPPInfluence (
            MultiPurposeProject multiPurposeProject, Dictionary<int, Project> projects)
        {
            return null;
        }
    }
}
