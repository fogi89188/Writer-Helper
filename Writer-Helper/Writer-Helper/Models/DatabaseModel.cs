using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Writer_Helper.Models
{
    public sealed class DatabaseModel
    {
        #region Private Members

        private static readonly DatabaseModel instance = new DatabaseModel();
        private static string connectionString = "server=localhost;user=root;database=writerhelper;port=3306;password=password";

        #endregion

        #region Public Members

        public static DatabaseModel Instance
        {
            get
            {
                return instance;
            }
        }

        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public static string currentEmail = "";

        public static bool isAdmin = false;

        #endregion

        #region Commands

        /// <summary>
        /// getter setter for currentEmail
        /// </summary>
        public static string CurrentEmail
        {
            get
            {
                return currentEmail;
            }
            set
            {
                currentEmail = value;
            }
        }

        /// <summary>
        /// getter setter for isAdmin
        /// </summary>
        public static bool IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
            }
        }

        public static void Initialize()
        {
            try
            {
                //opening the connection
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// checks if the login information is correct and if so, logs in the user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string email, string password)
        {
            if (email == null || password == null)
            {
                return false;
            }
            //create new command with statement mysqlStatement
            string mysqlStatement = $"SELECT password, isAdmin FROM Users WHERE email = \"{email}\"; ";
            MySqlCommand command = new MySqlCommand(mysqlStatement, connection);
            //creare a reader to comapre data from the database
            MySqlDataReader reader = command.ExecuteReader();
            //check if password exists
            if (reader.Read())
            {
                //checks if the password is correct
                bool passwordCheck = reader.GetString("password").Equals(password);
                if(passwordCheck == true)
                {
                    CurrentEmail = email;
                    IsAdmin = reader.GetBoolean("isAdmin");
                }
                reader.Close();
                return passwordCheck;
            }
            reader.Close();
            return false;
        }

        public void Logout()
        {
            CurrentEmail = null;
            IsAdmin = false;
        }

        /// <summary>
        /// creates a user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void AddUser(string email, string password)
        {
            string mysqlStatement = $"INSERT INTO Users (email, password, isAdmin) VALUES(\"{email}\", \"{password}\", false);";
            MySqlCommand command = new MySqlCommand(mysqlStatement, connection);
            command.ExecuteNonQuery();
        }

        #endregion

        #region Constructor
        private DatabaseModel()
        {
        }
        static DatabaseModel()
        { 
        }
        #endregion

    }
}
