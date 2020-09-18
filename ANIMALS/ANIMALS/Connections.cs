using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ANIMALS
{
    class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public Connection()
        {
            Init();
        }

        private void Init()
        {
            server = "localhost";
            database = "new_schema";
            uid = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public void Select()
        {
            List<ANIMALS> animalLst = new List<ANIMALS>();

            String query = "SELECT a_name, a_status FROM ANIMALS";

            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    animalLst.Add(new ANIMALS(reader["a_name"].ToString(), reader["a_status"].ToString()));

                }

                reader.Close();

                this.Close();

                foreach (ANIMALS animal in animalLst)
                {
                    Console.WriteLine(animal.a_name + ", " + animal.a_status);
                }
            }
            else
            {
                Console.WriteLine("Nesanak savienoties!");
            }
        }

        public List<ANIMALS> adlist()
        {
            List<ANIMALS> animalLst = new List<ANIMALS>();

            String query = "SELECT a_name, a_status FROM ANIMALS";

            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    animalLst.Add(new ANIMALS(reader["a_name"].ToString(), reader["a_status"].ToString()));

                }

                reader.Close();

                this.Close();

                
            }
            return animalLst;

        }

        public List<CLIENTS> adlist2()
        {
            List<CLIENTS> CLIENTSLst = new List<CLIENTS>();

            String query = "SELECT a_name, a_status FROM CLIENTS";

            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CLIENTSLst.Add(new CLIENTS(reader["a_name"].ToString(),
                        reader["a_status"].ToString()));

                }

                reader.Close();

                this.Close();


            }
            return CLIENTSLst;

        }

        public void Insert()
        {
            String query = "INSERT INTO ANIMALS (a_name, a_status)" +
                " VALUES('SHARIK', 'SOLD')";
            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                this.Close();
            }
            else
            {
                Console.WriteLine("Nesanak savienoties!");
            }
        }





        public bool Open()
        {
            try
            {
                connection.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool Close()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
