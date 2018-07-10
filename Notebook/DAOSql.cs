using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class DAOSql
    {

        private MySqlConnection conn = null;
        public DAOSql()
        {
            string connStr = "server=127.0.0.1;" +
                "user=root;" +
                "database=person;" +
                "port=3306;";
            conn = new MySqlConnection(connStr);

            conn.Open();
            conn.Close();
        }

        public void Create(int id, string fName, string lName, int number)
        {
            string sql = $"INSERT INTO`person1`(`id`, `fName`, `lName`, `number`)VALUES('{id}', '{fName}', '{lName}', '{number}')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            conn.Close();
        }

        public void Read()
        {
            ManagerNotebook.listPerson = new List<ModelPerson>();
            string sql = "SELECT * FROM person1";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ManagerNotebook.listPerson.Add(new ModelPerson(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)));
            }
            conn.Close();
        }

        public void Update()
        {
            conn.Open();
            conn.Close();
        }


        public void Delet(int id)
        {
            string sql = $"DELETE FROM person1 WHERE `id` = {id}";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            conn.Close();
        }
    }
}
