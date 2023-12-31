﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MultiPurposeProjectOptimizer
{
    public static class DBManager
    {
        public static string User { get; set; }
        public static string Password { get; set; }
        public static string DataSource { get; set; }
        public static string InitialCatalog { get; set; }
        public static bool IntegratedSecurity;
        public static SqlConnection connection;

        public static void ConnectToDB()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.UserID = User;
            builder.Password = Password;
            builder.DataSource = DataSource;
            builder.InitialCatalog = InitialCatalog;
            builder.IntegratedSecurity = IntegratedSecurity;
            builder.TrustServerCertificate = true;

            connection = new SqlConnection(builder.ConnectionString);
            //Проверяем подключение
            connection.Open();
            connection.Close();
        }

        internal static List<Dictionary<string, string>> SelectProjects()
        {
            string sql = "SELECT projectId, projectName, isMultiPurpose FROM dbo.Project";
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectPropertyCap(int solverInputsSetId)
        {
            string sql = string.Format("SELECT " +
                "propertyCapId, " +
                "solverInputsSetId, " +
                "pc.propertyId, " +
                "p.propertyName, " +
                "capValue " +
                "FROM dbo.PropertyCap pc " +
                "inner join dbo.Property p " +
                "on pc.propertyId = p.propertyId " +
                "where pc.solverInputsSetId = {0}", solverInputsSetId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectProjects(string searchPrompt)
        {
            string sql = "SELECT projectId, projectName, isMultiPurpose FROM dbo.Project";
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectProjectProperties(int projectId)
        {
            string sql = string.Format("SELECT projectPropertyId, prop.propertyName, propertyValue FROM dbo.ProjectProperty pp " +
                "inner join dbo.Property prop " +
                "on pp.propertyId = prop.propertyId " +
                "WHERE pp.projectId = {0} " +
                "order by propertyName", projectId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectInfluences(int projectId)
        {
            string sql = string.Format("select i.influenceId, " +
                "proj.projectId, " +
                "proj.projectName, " +
                "i.projectPropertyId, " +
                "prop.propertyId, " +
                "prop.propertyName, " +
                "i.influenceValue " +
                "from dbo.Influence i " +
                "inner join dbo.ProjectProperty pp " +
                "on i.projectPropertyId = pp.projectPropertyId " +
                "inner join dbo.Property prop " +
                "on pp.propertyId = prop.propertyId " +
                "inner join dbo.Project proj " +
                "on pp.projectId = proj.projectId " +
                "where i.projectId = {0}", projectId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectRelevantInfluences(int projectId, int solverInputsSetId)
        {
            string sql = string.Format("select i.influenceId, " +
                "proj.projectId, " +
                "proj.projectName, " +
                "i.projectPropertyId, " +
                "prop.propertyId, " +
                "prop.propertyName, " +
                "i.influenceValue " +
                "from dbo.Influence i " +
                "inner join dbo.ProjectProperty pp " +
                "on i.projectPropertyId = pp.projectPropertyId " +
                "inner join dbo.Property prop " +
                "on pp.propertyId = prop.propertyId " +
                "inner join dbo.Project proj " +
                "on pp.projectId = proj.projectId " +
                "inner join dbo.ProjectSolverLink psl " +
                "on pp.projectId = psl.projectId " +
                "where i.projectId = {0} and psl.solverInputsSetId = {1}", projectId, solverInputsSetId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectProjectByName(string projectName)
        {
            string sql = string.Format("SELECT projectId, projectName FROM dbo.Project " +
                "where projectName = '{0}'", projectName);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectSolverInputsSet()
        {
            string sql = string.Format("SELECT solverInputsSetId, setName, solutionQuantityCap FROM dbo.SolverInputsSet");
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectSolverInputsSetByName(string setName)
        {
            string sql = string.Format("SELECT solverInputsSetId, setName, solutionQuantityCap FROM dbo.SolverInputsSet " +
                "where setName = '{0}'", setName);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectProjectSolverLink(int solverInputsSetId)
        {
            string sql = string.Format("SELECT linkId, psl.projectId, p.projectName, isTaken from dbo.ProjectSolverLink psl " +
                "inner join dbo.Project p " +
                "on psl.projectId = p.projectId " +
                "where psl.solverInputsSetId = {0}", solverInputsSetId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectProjectSolverLinkByMP(int solverInputsSetId, bool isMultiPurpose)
        {
            int bitIsMPP = isMultiPurpose ? 1 : 0;
            string sql = string.Format("SELECT linkId, psl.projectId, p.projectName, isTaken from dbo.ProjectSolverLink psl " +
                "inner join dbo.Project p " +
                "on psl.projectId = p.projectId " +
                "where psl.solverInputsSetId = {0} and p.isMultiPurpose = {1}", solverInputsSetId, bitIsMPP);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectTakenProjectSolverLink(int solverInputsSetId)
        {
            string sql = string.Format("SELECT linkId, psl.projectId, p.projectName, p.isMultiPurpose from dbo.ProjectSolverLink psl " +
                "inner join dbo.Project p " +
                "on psl.projectId = p.projectId " +
                "where psl.solverInputsSetId = {0} and psl.isTaken = 1", solverInputsSetId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectProperty()
        {
            string sql = "SELECT propertyId, propertyName FROM dbo.Property";
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectPropertyByName(string propertyName)
        {
            string sql = string.Format("SELECT propertyId, propertyName FROM dbo.Property " +
                "where propertyName = '{0}'", propertyName);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectMaximizedProperty(int solverInputsSetId)
        {
            string sql = string.Format("SELECT maximizedPropertyId, mp.propertyId, p.propertyName FROM dbo.MaximizedProperty mp " +
                "inner join dbo.Property p " +
                "on mp.propertyId = p.propertyId " +
                "where solverInputsSetId = {0}", solverInputsSetId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static List<Dictionary<string, string>> SelectOptimalSolutionSumProperties(int solverInputsSetId)
        {
            string sql = string.Format("SELECT pp.propertyId, p.propertyName,  " +
                "sum(pp.propertyValue) + " +
                "sum(coalesce(i.influenceValue,0)) as propertyValueSum, " +
                "case when avg(pc.capValue) is null then 0 else avg(pc.capValue) end as avgCapValue " +
                "from dbo.ProjectSolverLink psl " +
                "inner join ProjectProperty pp " +
                "on psl.projectId = pp.projectId and psl.solverInputsSetId = {0} and psl.isTaken = 1 " +
                "inner join Property p " +
                "on pp.propertyId = p.propertyId " +
                "left join PropertyCap pc " +
                "on psl.solverInputsSetId = pc.solverInputsSetId and pp.propertyId = pc.propertyId " +
                "left join Influence i " +
                "on pp.projectPropertyId = i.projectPropertyId and " +
                "i.projectId in " +
                "(select projectId from ProjectSolverLink where solverInputsSetId = {0} and isTaken = 1) " +
                "group by pp.propertyId, p.propertyName", solverInputsSetId);
            List<Dictionary<string, string>> rowsList = executeReader(sql);
            return rowsList;
        }

        internal static void InsertProject(string projectName, int directionId, bool isMPP)
        {
            int isMPPInt = isMPP ? 1 : 0;
            string sql = string.Format("INSERT INTO dbo.Project (projectName, directionId, isMultiPurpose)" +
                    "VALUES ('{0}', {1}, {2})", projectName, directionId, isMPPInt);
            executeNonQuery(sql);
        }

        internal static void InsertInfluence(int influencingProjectId, int projectPropertyId, int influenceValue)
        {
            string sql = string.Format("INSERT INTO dbo.Influence (projectId, projectPropertyId, influenceValue)" +
                    "VALUES ({0}, {1}, {2})", influencingProjectId, projectPropertyId, influenceValue);
            executeNonQuery(sql);
        }

        internal static void InsertProperty(string propertyName)
        {
            string sql = string.Format("INSERT INTO dbo.Property (propertyName)" +
                    "VALUES ('{0}')", propertyName);
            executeNonQuery(sql);
        }

        internal static void InsertProjectProperty(int projectId, int propertyId, int propertyValue)
        {
            string sql = string.Format("INSERT INTO dbo.ProjectProperty (projectId, propertyId, propertyValue)" +
                    "VALUES ('{0}', {1}, {2})", projectId, propertyId, propertyValue);
            executeNonQuery(sql);
        }

        internal static void InsertSolverInputsSet(int mode, string setName, int solutionQuantityCap)
        {
            string sql = string.Format("INSERT INTO dbo.SolverInputsSet (modeId, setName, solutionQuantityCap)" +
                    "VALUES ({0}, '{1}', {2})", mode, setName, solutionQuantityCap);
            executeNonQuery(sql);
        }

        internal static void InsertPropertyCap(int solverInputsSetId, int propertyId, int capValue)
        {
            string sql = string.Format("INSERT INTO dbo.PropertyCap (solverInputsSetId, propertyId, capValue)" +
                    "VALUES ({0}, {1}, {2})", solverInputsSetId, propertyId, capValue);
            executeNonQuery(sql);
        }

        internal static void InsertProjectSolverLink(int solverInputsSetId, int projectId, bool isTaken)
        {
            int bitIsTaken = isTaken ? 1 : 0;
            string sql = string.Format("INSERT INTO dbo.ProjectSolverLink (solverInputsSetId, projectId, isTaken)" +
                    "VALUES ({0}, {1}, {2})", solverInputsSetId, projectId, bitIsTaken);
            executeNonQuery(sql);
        }

        internal static void InsertMaximizedProperty(int solverInputsSetId, int propertyId)
        {
            string sql = string.Format("INSERT INTO dbo.MaximizedProperty (solverInputsSetId, propertyId)" +
                    "VALUES ({0}, {1})", solverInputsSetId, propertyId);
            executeNonQuery(sql);
        }

        internal static void DeleteProject(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.Project WHERE projectId = {0}", removedId);
            executeNonQuery(sql);
        }

        internal static void DeleteProperty(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.Property WHERE propertyId = {0}", removedId);
            executeNonQuery(sql);
        }

        internal static void DeleteProjectProperty(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.ProjectProperty WHERE projectPropertyId = {0}", removedId);
            executeNonQuery(sql);
        }

        internal static void DeleteInfluence(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.Influence WHERE influenceId = {0}", removedId);
            executeNonQuery(sql);
        }

        internal static void DeleteSolverInputsSet(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.SolverInputsSet WHERE solverInputsSetId = {0}", removedId);
            executeNonQuery(sql);
        }

        internal static void DeletePropertyCap(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.PropertyCap WHERE propertyCapId = {0}", removedId);
            executeNonQuery(sql);
        }

        internal static void DeleteProjectSolverLink(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.ProjectSolverLink WHERE linkId = {0}", removedId);
            executeNonQuery(sql);
        }

        internal static void UpdateProjectName(string projectName, int projectId)
        {
            string sql = string.Format("UPDATE dbo.Project " +
                "SET projectName = '{0}' " +
                "WHERE projectId = {1}", projectName, projectId);
            executeNonQuery(sql);
        }

        internal static void UpdateProjectIsMPP(int projectId, bool isMPP)
        {
            int intIsMPP = isMPP ? 1 : 0;
            string sql = string.Format("UPDATE dbo.Project " +
                "SET isMultiPurpose = {0} " +
                "WHERE projectId = {1}", intIsMPP, projectId);
            executeNonQuery(sql);
        }

        internal static void UpdateProperty(string propertyName, int propertyId)
        {
            string sql = string.Format("UPDATE dbo.Property " +
                "SET propertyName = '{0}' " +
                "WHERE propertyId = {1}", propertyName, propertyId);
            executeNonQuery(sql);
        }

        internal static void UpdateProjectPropertyValue(int projectPropertyId, double value)
        {
            string sql = string.Format("UPDATE dbo.ProjectProperty " +
                "SET propertyValue = {0} " +
                "WHERE projectPropertyId = {1}", value.ToString(System.Globalization.CultureInfo.InvariantCulture), projectPropertyId);
            executeNonQuery(sql);
        }

        internal static void UpdateInfluenceValue(double influenceValue, int influenceId)
        {
            string sql = string.Format("UPDATE dbo.Influence " +
                "SET influenceValue = {0} " +
                "WHERE influenceId = {1}", influenceValue.ToString(System.Globalization.CultureInfo.InvariantCulture), influenceId);
            executeNonQuery(sql);
        }

        internal static void UpdateSolverInputsSet(string setName, int solutionQuantityCap, int solverInputsSetId)
        {
            string sql = string.Format("UPDATE dbo.SolverInputsSet " +
                "SET setName = '{0}', " +
                "solutionQuantityCap = {1} " +
                "WHERE solverInputsSetId = {2}", setName, solutionQuantityCap, solverInputsSetId);
            executeNonQuery(sql);
        }

        internal static void UpdatePropertyCapValue(int propertyCapId, double capValue)
        {
            string sql = string.Format("UPDATE dbo.PropertyCap " +
                "SET capValue = {0} " +
                "WHERE propertyCapId = {1}", capValue.ToString(System.Globalization.CultureInfo.InvariantCulture), propertyCapId);
            executeNonQuery(sql);
        }

        internal static void UpdateMaximizedProperty(int maximizedPropertyId, int propertyId)
        {
            string sql = string.Format("UPDATE dbo.MaximizedProperty " +
                "SET propertyId = {0} " +
                "WHERE maximizedPropertyId = {1}", propertyId, maximizedPropertyId);
            executeNonQuery(sql);
        }

        internal static void UpdateAllProjectSolverLink(int solverInputsSetId, bool isTaken)
        {
            int bitIsTaken = isTaken ? 1 : 0;
            string sql = string.Format("UPDATE dbo.ProjectSolverLink " +
                "SET isTaken = {0} " +
                "WHERE solverInputsSetId = {1}", bitIsTaken, solverInputsSetId);
            executeNonQuery(sql);
        }

        internal static void UpdateProjectSolverLink(int solverInputsSetId, int projectId, bool isTaken)
        {
            int bitIsTaken = isTaken ? 1 : 0;
            string sql = string.Format("UPDATE dbo.ProjectSolverLink " +
                "SET isTaken = {0} " +
                "WHERE solverInputsSetId = {1} and projectId = {2}", bitIsTaken, solverInputsSetId, projectId);
            executeNonQuery(sql);
        }

        public static void executeNonQuery(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("При обращении к базе данных произошла ошибка: \n" + e.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Dictionary<string, string>> executeReader(string sql)
        {
            List<Dictionary<string, string>> rowsInfo = new List<Dictionary<string, string>>();
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string fieldName = reader.GetName(i);
                        string fieldType = reader.GetDataTypeName(i);
                        string cellValue = null;
                        switch(fieldType)
                        {
                            case "nvarchar":
                                cellValue = reader.GetString(i);
                                break;
                            case "int":
                                cellValue = reader.GetInt32(i).ToString();
                                break;
                            case "float":
                                cellValue = reader.GetDouble(i).ToString();
                                break;
                            case "bit":
                                cellValue = reader.GetBoolean(i).ToString();
                                break;
                            default:
                                throw new Exception("Нет совпадения типов");
                        }
                        row.Add(fieldName, cellValue);
                    }
                    rowsInfo.Add(row);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("При обращении к базе данных произошла ошибка: \n" + e.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                if (reader != null) reader.Close();
            }
            return rowsInfo;
        }
    }
}
