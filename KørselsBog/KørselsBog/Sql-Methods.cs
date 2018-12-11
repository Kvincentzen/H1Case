using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KørselsBog
{
    class Sql_Methods
    {
        private static void opretKunde()
        {
            string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            //string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            SqlTest.Insert(statement);
        }
        //ConnectionString
        private static string ConnectionString = "Data Source=Skab5-PC-01;Initial Catalog=sqleksempler; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void Insert(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                //foreach (DataRow kunde in table.Rows)
                //{
                //    Console.WriteLine(kunde["id"].ToString());
                //    Console.WriteLine(kunde["navn"].ToString());
                //    Console.WriteLine(kunde["adr"].ToString());
                //    Console.WriteLine(kunde["alder"].ToString());
                //    Console.WriteLine();
                //}
                string denførsterække = table.Rows[0]["navn"].ToString();
                Console.WriteLine(denførsterække);
            }
        }
