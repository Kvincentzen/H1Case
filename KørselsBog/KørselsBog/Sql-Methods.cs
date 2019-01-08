using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KørselsBog
{
    class Sql_Methods
    {
        //ConnectionString
        private static string ConnectionString = "Data Source=(local);Initial Catalog=H1Case; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static void Sqlstatment(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        #region Oprettelser
        public static void opretKunde(string KundeID, string navn, string adr, string fødselsdagsdato)
        {
            string statement = ("insert into kunder values ('" + KundeID + "','" + navn + "','" + adr + "'," + fødselsdagsdato + ")");
            //string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            Sql_Methods.Sqlstatment(statement);
        }
        public static void opretBil(string KundeID, string RegNr, string Mærke, string Model, string Brændstoffstype, string OprettelsesDato, int KmKørt, int Årgang)
        {
            string statement = ("insert into bil values ('" + KundeID + "','" + RegNr + "','" + Mærke + "','" + Model + "','" + Brændstoffstype + "','" + OprettelsesDato + "','" + KmKørt + "'," + Årgang + ")");
            //string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            Sql_Methods.Sqlstatment(statement);
        }
        public static void opretVærkstedsbesøg(int DatoAnkomst, int Datoafgang, string Mekaniker, string RegNr)
        {
            string statement = ("insert into værkstedsbesøg values ('" + DatoAnkomst + "','" + Datoafgang + "','" + Mekaniker + "','" + RegNr + "')");
            //string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            Sql_Methods.Sqlstatment(statement);
        }
        #endregion

        #region Selects
        public static void SelectKunder(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow kunder in table.Rows)
                {
                    Console.WriteLine(kunder["KundeId"].ToString());
                    Console.WriteLine(kunder["Navn"].ToString());
                    Console.WriteLine(kunder["Adresse"].ToString());
                    Console.WriteLine(kunder["Fødselsdato"].ToString());
                    Console.WriteLine();
                }
                Console.WriteLine(table);
            }
        }
        public static void SelectBil(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow Bil in table.Rows)
                {
                    Console.WriteLine(Bil["KundeId"].ToString());
                    Console.WriteLine(Bil["RegNr"].ToString());
                    Console.WriteLine(Bil["Mærke"].ToString());
                    Console.WriteLine(Bil["Model"].ToString());
                    Console.WriteLine(Bil["Brændstoff"].ToString());
                    Console.WriteLine(Bil["Oprettelsesdato"].ToString());
                    Console.WriteLine(Bil["KmKørt"].ToString());
                    Console.WriteLine(Bil["Årgangkørt"].ToString());
                    Console.WriteLine();
                }
                Console.WriteLine(table);
            }
        }
        public static void SelectVærksted(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow Værkstedsbesøg in table.Rows)
                {
                    Console.WriteLine(Værkstedsbesøg["DatoAnkomst"].ToString());
                    Console.WriteLine(Værkstedsbesøg["DatoAfgang"].ToString());
                    Console.WriteLine(Værkstedsbesøg["Makinker"].ToString());
                    Console.WriteLine(Værkstedsbesøg["RegNr"].ToString());
                    Console.WriteLine();
                }
                Console.WriteLine(table);
            }
        }
        #endregion
        #region Update/Delete
        public static void DeleteFromBil(string regnr)
        {
            string statement = ("DELETE FROM Bil WHERE RegNr = '" + regnr+"'");
            Sql_Methods.Sqlstatment(statement);
        }
        public static void DeleteFromKunder(string KundeID)
        {
            string statement = ("DELETE FROM Kunder WHERE KundeID = '" + KundeID + "', ""DELETE FROM Bil WHERE RegNr = '" + regnr + "'");
            Sql_Methods.Sqlstatment(statement);
        }
        public static void DeleteFromVærksted(string regnr)
        {
            string statement = ("DELETE FROM Værkstedsbesøg WHERE RegNr = '" + regnr + "'");
            Sql_Methods.Sqlstatment(statement);
        }
        public static void UpdateFromBil(string regnr)
        {
            string statement = ("Update FROM Bil WHERE RegNr = '" + regnr+"'");
            Sql_Methods.Sqlstatment(statement);
        }
        #endregion

    }
}