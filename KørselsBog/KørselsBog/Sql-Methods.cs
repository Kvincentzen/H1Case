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
        public static void opretKunde(string KundeID, string navn, string adr, string oprettelsesdato, string fødselsdagsdato)
        {
            string statement = ("insert into kunder values ('" + KundeID + "','" + navn + "','" + adr + "','" + oprettelsesdato+"',"+fødselsdagsdato + ")");
            Sql_Methods.Sqlstatment(statement);
        }
        public static void opretBil(string KundeID, string RegNr, string Mærke, string Model, string Brændstoffstype, string OprettelsesDato, int KmKørt, int Årgang)
        {
            string statement = ("insert into bil values ('" + KundeID + "','" + RegNr + "','" + Mærke + "','" + Model + "','" + Brændstoffstype + "','" + OprettelsesDato + "','" + KmKørt + "'," + Årgang + ")");
            Sql_Methods.Sqlstatment(statement);
        }
        public static void opretVærkstedsbesøg(string DatoAnkomst, string Datoafgang, string Mekaniker, string RegNr)
        {
            string statement = ("insert into værkstedsbesøg values ('" + DatoAnkomst + "','" + Datoafgang + "','" + Mekaniker + "','" + RegNr + "')");
            Sql_Methods.Sqlstatment(statement);
        }
        #endregion

        #region Selects
        public static void SelectKunder(string sql) // henter info på kundeID fra databasen
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow kunder in table.Rows)
                {
                    Console.WriteLine("KundeID = "+kunder["KundeId"].ToString());
                    Console.WriteLine("Navn "+kunder["Navn"].ToString());
                    Console.WriteLine("Adresse = "+kunder["Adresse"].ToString());
                    Console.WriteLine("Fødselsdato = "+kunder["Fødselsdato"].ToString());
                    Console.WriteLine("Oprettelsesdato = " + kunder["Oprettelsesdato"].ToString());
                    Console.WriteLine();
                }
                Console.WriteLine(table);
            }
        }
        public static void SelectBil(string sql) // henter info omkring en bil på RegNr fra databasen
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow Bil in table.Rows)
                {
                    Console.WriteLine("KundeID = "+Bil["KundeId"].ToString());
                    Console.WriteLine("RegNr = "+Bil["RegNr"].ToString());
                    Console.WriteLine("Mærke = "+Bil["Mærke"].ToString());
                    Console.WriteLine("Model = "+Bil["Model"].ToString());
                    Console.WriteLine("Brændstofstype = "+Bil["Brændstoff"].ToString());
                    Console.WriteLine("Oprettelsesdato = "+Bil["Oprettelsesdato"].ToString());
                    Console.WriteLine("Km Kørt = "+Bil["KmKørt"].ToString());
                    Console.WriteLine("Årgang = "+Bil["Årgang"].ToString());
                    Console.WriteLine();
                }
                Console.WriteLine(table);
            }
        }
        public static void SelectVærksted(string sql) // henter info på værkstedsbesøg fra databasen
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow Værkstedsbesøg in table.Rows)
                {
                    Console.WriteLine("Dato Ankomst = "+Værkstedsbesøg["DatoAnkomst"].ToString());
                    Console.WriteLine("Dato Afgang = "+Værkstedsbesøg["DatoAfgang"].ToString());
                    Console.WriteLine("Mekaniker = "+Værkstedsbesøg["Mekaniker"].ToString());
                    Console.WriteLine("RegNr = "+Værkstedsbesøg["RegNr"].ToString());
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
            string statement = ("Delete from bil where KundeID = '" + KundeID + "'");
            Sql_Methods.Sqlstatment(statement);
            statement = ("DELETE FROM kunder WHERE KundeID = '" + KundeID + "'");
            Sql_Methods.Sqlstatment(statement);
        }
        public static void DeleteFromVærksted(string regnr, string datoankomst)
        {
            string statement = ("DELETE FROM Værkstedsbesøg WHERE RegNr = '" + regnr + "' and DatoAnkomst = " + datoankomst);
            Sql_Methods.Sqlstatment(statement);
        }
        public static void UpdateBil(string regnr, string KundeID, string mærke, string model, string brændstof, string opretdato, string kmkørt, int årgang)
        {
            string statement = ("Update Bil SET KundeID = '"+KundeID+"',Mærke = '"+mærke+"', Model = '"+model+"',Brændstoff = '"+brændstof+"', Oprettelsesdato = '"+opretdato+"', kmkørt = '"+kmkørt+"', Årgang = "+årgang+"WHERE RegNr = '" + regnr+"';");
            Sql_Methods.Sqlstatment(statement);
        }
        public static void UpdateKunde(string KundeID, string navn, string adresse, string fødselsdagsdato)
        {
            string statement = ("Update Kunder SET Navn = '" + navn + "',Adresse = '" + adresse + "', Fødselsdato = '" + fødselsdagsdato + "' WHERE KundeID = '" + KundeID + "';");
        }
        public static void UpdateVærkstedsbesøg(string regnr, string DatoAnkomst, string Datoafgang, string Mekaniker)
        {
            string statement = ("Update Værkstedsbesøg SET Datoankomst = '" + DatoAnkomst + "', Datoafgang = '" + Datoafgang + "',Mekaniker = '" + Mekaniker + "',WHERE RegNr = '" + regnr + "';");
            Sql_Methods.Sqlstatment(statement);
        }
        #endregion

    }
}