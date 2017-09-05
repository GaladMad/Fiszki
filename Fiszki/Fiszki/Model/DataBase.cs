using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiszki.Model
{
    public class DataBase
    {
        #region Fields
        private SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source ={0}", Path.Combine(Application.StartupPath, "DBFiszki.db")));
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        private string query = "";

        #endregion

        public DataBase()
        {
            
        }

        public void AddTable(string tableName)
        {
            tableName = tableName.Replace(" ", "_");

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    query = string.Format("CREATE TABLE IF NOT EXISTS {0} (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, english VARCHAR(100), polski  VARCHAR(100)); ", tableName);
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();

                    query = string.Format("INSERT INTO FlashcardsList (ListName) VALUES('{0}');", tableName);
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException myException)
            {
                ShowMessageBox(myException);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void RemoveTable(string tableName)
        {
            tableName = tableName.Replace(" ", "_");
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    query = string.Format("DROP TABLE IF EXISTS {0};", tableName);
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();

                    query = string.Format("DELETE FROM FlashcardsList WHERE ListName = '{0}';", tableName);
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        
            catch (SQLiteException myException)
            {
                ShowMessageBox(myException);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        
        public void AddFlashcards(string tableName, string[] word)
        {
            tableName = tableName.Replace(" ", "_");

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    query = string.Format("INSERT INTO {0} (english, polski) VALUES('{1}','{2}'); ", tableName, word[0], word[1]);
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }

            catch (SQLiteException myException)
            {
                ShowMessageBox(myException);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void RemoveFlashcards(string tableName)
        {
            tableName = tableName.Replace(" ", "_");

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    query = string.Format("DELETE FROM {0};", tableName);
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }

            catch (SQLiteException myException)
            {
                ShowMessageBox(myException);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<string[]> GetUItext()
        {
            List<string[]> UItext = new List<string[]>();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    query = string.Format("SELECT english, polski FROM UserInterface");
                    command = new SQLiteCommand(query, connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] record = new string[2];
                        record[0] = reader.GetString(0);
                        record[1] = reader.GetString(1);
                        UItext.Add(record);
                    }
                }
            }

            catch (SQLiteException myException)
            {
                ShowMessageBox(myException);
                UItext.Add(new string[] { "...", "..." });
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return UItext;
        }

        public List<string[]> GetFlashcards(string Theme)
        {
            List<string[]> Flashcards = new List<string[]>();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    query = string.Format("SELECT english, polski FROM {0}", Theme);
                    command = new SQLiteCommand(query, connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] record = new string[2];
                        record[0] = reader.GetString(0);
                        record[1] = reader.GetString(1);
                        Flashcards.Add(record);
                    }
                }
            }

            catch (SQLiteException myException)
            {
                ShowMessageBox(myException);
                Flashcards.Add(new string[] {"...","..."});
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return Flashcards;
        }

        public string[] GetListsOfFlashcards()
        {
            string[] ListsOfFlashcard;
            List<string> Lists = new List<string>();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    query = string.Format("SELECT ListName FROM FlashcardsList");
                    command = new SQLiteCommand(query, connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Lists.Add(Convert.ToString(reader["ListName"]));
                    }
                }
            }

            catch (SQLiteException myException)
            {
                ShowMessageBox(myException);
                Lists.Add("...");
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            ListsOfFlashcard = Lists.ToArray();

            return ListsOfFlashcard;
        }

        private void ShowMessageBox(SQLiteException myException)
        {
            MessageBox.Show("Message: " + myException.Message + "\n", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
