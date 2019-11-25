using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public class DatabaseUtilities
    {
        static readonly string dbPath = Path.GetFullPath(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\MonkeyPuzzleResultViewer\\App_Data\\monkeypuzzle.mdf"));
        static string CONNECTION_STRING
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + dbPath + "; Trusted_Connection=Yes; database=monkeypuzzle;";
            }
        }
        //_________Method adds a the specified table with specified columns to the db_________________________________________________
        public static void createTable(String table, String Params)
        {
            string sql = "Create table "+ table + "("+Params+")";
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //__________Method reads the db at table name passed to it and returns a List<String> of each row in the table seperated by # delim_____
        public static List<String> ReadDB(String table)
        {
            List<String> tableLines = new List<String>();

            string sql = "Select * From " + table;
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        int fields = reader.FieldCount;
                        String lineString;

                        while (reader.Read())
                        {
                            lineString = "";
                            for (int i = 0; i < fields; i++)
                            {
                                lineString += reader[i] + "#";
                            }
                            tableLines.Add(lineString);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableLines;
        }

        public static List<AllUsersObj> ReadDB(String table, List<AllUsersObj> list)
        {
            string sql = "Select * From " + table;
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        int fields = reader.FieldCount;

                        while (reader.Read())
                        {
                            list.Add(new AllUsersObj
                            {
                                UserID = int.Parse(reader[0].ToString()),
                                Name = (String)reader[1],
                                Surname = (String)reader[2],
                                Password = (String)reader[3],
                                AccessGroup = int.Parse(reader[4].ToString())
                            });
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        //_________Overloaded Methods to insert to specific table dependant on what object is passed to them___________________________
        public static void InsertToDB(String table, TestObj test)
        {
            string sql = "INSERT INTO " + table + " (testID,TestName,NumOfQuestions,userID) VALUES(@testID,@TestName,@NumOfQuestions,@userID);";

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@testID", test.TestID);
                        command.Parameters.AddWithValue("@TestName", test.TestName);
                        command.Parameters.AddWithValue("@NumOfQuestions", test.NumberOfQuestions);
                        command.Parameters.AddWithValue("@userID", test.UserID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InsertToDB(String table, Question question)
        {
            string sql = "INSERT INTO " + table + " (questionID, Question, testID, AnswerA,AnswerB,AnswerC,AnswerD,CorrectAnswer) VALUES(@questionID,@Question,@testID,@AnswerA,@AnswerB,@AnswerC,@AnswerD,@CorrectAnswer);";

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@questionID", question.QuestionID);
                        command.Parameters.AddWithValue("@Question", question.Quest);
                        command.Parameters.AddWithValue("@testID", question.TestID);
                        command.Parameters.AddWithValue("@AnswerA", question.ansA);
                        command.Parameters.AddWithValue("@AnswerB", question.ansB);
                        command.Parameters.AddWithValue("@AnswerC", question.ansC);
                        command.Parameters.AddWithValue("@AnswerD", question.ansD);
                        command.Parameters.AddWithValue("@CorrectAnswer", question.correctAns);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InsertToDB(String table, Mark mark)
        {
            string sql = "INSERT INTO " + table + " (markID, userID, testID, Mark, Percentage) VALUES(@markID,@userID,@testID,@Mark,@Percentage);";

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@markID", mark.MarkID);
                        command.Parameters.AddWithValue("@userID", mark.UserID);
                        command.Parameters.AddWithValue("@testID", mark.TestID);
                        command.Parameters.AddWithValue("@Mark", mark.MarkInt);
                        command.Parameters.AddWithValue("@Percentage", mark.MarkPercent);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InsertToDB(String table, Memorandum memo)
        {
            string sql = "INSERT INTO " + table + " (userID, questionID, StudentAnswer) VALUES(@userID,@questionID,@StudentAnswer);";

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@userID", memo.userID);
                        command.Parameters.AddWithValue("@questionID", memo.QuestionID);
                        command.Parameters.AddWithValue("@StudentAnswer", memo.SelectedAnswer);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InsertToDB(String table, UserObj user)
        {
            string sql = "INSERT INTO " + table + " (userID, Firstname, Surname, userPassword, AccessGroup) VALUES(@userID,@Firstname,@Surname,@userPassword,@AccessGroup);";

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@userID", user.UserID);
                        command.Parameters.AddWithValue("@Firstname", user.Name);
                        command.Parameters.AddWithValue("@Surname", user.Surname);
                        command.Parameters.AddWithValue("@userPassword", user.Password);
                        command.Parameters.AddWithValue("@AccessGroup", user.AccessGroup);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //_____________________________________________________________________________________________________________________________

        //_____________________________________Static to delete record from table where column = key__________________________________           
        public static void DeleteFromDB(String table, String column, int key)
        {
            string sql = "Delete From " + table + " Where " + column + " = " + key;
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //____________________________method to return a dataset derived from specific table and query_______________________________
        public static DataSet PopulateDataset(String table, String query)
        {
            DataSet ds;
            SqlDataAdapter sda = new SqlDataAdapter();

            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        using (sda)
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (ds = new DataSet())
                            {
                                sda.Fill(ds, table);
                            }
                        }
                    }
                }
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("The application is unable to connect to the database. Please contact your System Admin.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //____________________________method receives a dataset and updates the specified table_____________________________________-
        public static void SaveDataset(DataSet ds, String table, String query)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        using (sda)
                        {
                            cmd.Connection = con;
                            SqlCommandBuilder cb = new SqlCommandBuilder(sda);
                            sda.SelectCommand = cmd;
                            sda.UpdateCommand = cb.GetUpdateCommand();
                            sda.Update(ds, table);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("You are cannot do this. Please contact your System Admin for more information.\n\nError Message:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
