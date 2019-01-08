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
        #region Oprettelser
        public static void opretKunde(string KundeID, string navn, string adr, int fødselsdagsdato)
        {
            string statement = ("insert into kunder values ('" + KundeID + "','" + navn + "','" + adr + "'," + fødselsdagsdato + ")");
            //string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            Sql_Methods.Sqlstatment(statement);
        }
        public static void opretBil(string KundeID, string RegNr, string Mærke, string Model, string Brændstoffstype,string OprettelsesDato, int KmKørt, int Årgang)
        {
            string statement = ("insert into bil values ('" + KundeID + "','" + RegNr + "','" + Mærke + "','" + Model + "','" + Brændstoffstype + "','" + OprettelsesDato + "','" + KmKørt + "'," + Årgang +")");
            //string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            Sql_Methods.Sqlstatment(statement);
        }
        public static void opretVærkstedsbesøg(int DatoAnkomst, int Datoafgang, string Mekaniker,string RegNr)
        {
            string statement = ("insert into værkstedsbesøg values ('" + DatoAnkomst + "','" + Datoafgang + "','" + Mekaniker + "','" + RegNr + "')");
            //string statement = "insert into kunder values ('Knud Andersen','Telegrafvej 9', 45)";
            Sql_Methods.Sqlstatment(statement);
        }
        #endregion

        #region Selects
        public static void SelectBil(string regnr)
        {
            string statement = ("SELECT * FROM Bil WHERE " + regnr);
            Sql_Methods.Sqlstatment(statement);
        }
        //public static void SelectKunder(string KundeID)
        //{
        //    string statement = ("SELECT * FROM Kunder WHERE " + KundeID);
        //    Sql_Methods.Sqlstatment(statement);
        //}
        public static void SelectVærkstedsbesøg(string regnr)
        {
            string statement = ("SELECT * FROM Værstedsbesøg WHERE " + regnr);
            Sql_Methods.Sqlstatment(statement);
        }
        #endregion
        //"DELETE FROM Bil WHERE RegNr = {RegNr}"
        public static void DeleteFromBil(string regnr)
        {
            string statement = ("DELETE * FROM Bil WHERE " + regnr);
            Sql_Methods.Sqlstatment(statement);
        }
        private static void Sqlstatment(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
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
                //string denførsterække = table.Rows[1]["navn"].ToString();
                Console.WriteLine(table);
            }
        }
        public static void DeleteKunde(string KundeID)
        {

        }

    }
}
