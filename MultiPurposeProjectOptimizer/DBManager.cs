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
        }

        internal static List<Dictionary<string, string>> SelectProjects()
        {
            string sql = "SELECT projectId, projectName, isMultiPurpose FROM dbo.Project";
            List<Dictionary<string, string>> projectsList = executeReader(sql);
            return projectsList;
        }

        internal static List<Dictionary<string, string>> SelectProjects(string searchPrompt)
        {
            string sql = "SELECT projectId, projectName, isMultiPurpose FROM dbo.Project";
            List<Dictionary<string, string>> projectsList = executeReader(sql);
            return projectsList;
        }

        internal static void InsertProject(string projectName, int directionId, bool isMPP)
        {
            int isMPPInt = isMPP ? 1 : 0;
            string sql = string.Format("INSERT INTO dbo.Project (projectName, directionId, isMultiPurpose)" +
                    "VALUES ('{0}', {1}, {2})", projectName, directionId, isMPPInt);
            executeNonQuery(sql);
        }

        internal static List<Dictionary<string, string>> SelectProperty()
        {
            string sql = "SELECT propertyId, propertyName FROM dbo.Property";
            List<Dictionary<string, string>> propertiesList = executeReader(sql);
            return propertiesList;
        }

        internal static void InsertProperty(string propertyName)
        {
            string sql = string.Format("INSERT INTO dbo.Property (propertyName)" +
                    "VALUES ('{0}')", propertyName);
            executeNonQuery(sql);
        }

        internal static void DeleteProject(int removedId)
        {
            string sql = string.Format("DELETE FROM dbo.Project WHERE projectId = {0}", removedId);
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