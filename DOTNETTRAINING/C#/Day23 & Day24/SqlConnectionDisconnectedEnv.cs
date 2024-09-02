using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Configuration;

namespace Program1
{
    internal class SqlConnectionDisconnectedEnv
    {

        public void DisplayDisconnectEnv()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlLocalDatabseConnection"].ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from item", con); //Instead of command, we need to used data adapter
            DataSet ds = new DataSet();
            sda.Fill(ds, "item");
            Console.WriteLine("The tables items are");
            foreach (DataRow row in ds.Tables["item"].Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3}", row[0], row[1], row[2], row[3]);
            }
            
        }

        public void InsertDisplayDisconnectEnvDataSet()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlLocalDatabseConnection"].ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from item", con); //Instead of command, we need to used data adapter
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds, "item");
            DataRow dataRow = ds.Tables["item"].NewRow();
            dataRow["item_id"] = 10;
            dataRow["item_name"] = "Wiper Blades";
            dataRow["item_quantity"] = 2;
            dataRow["item_description"] = "Two new wiper blades";

            ds.Tables["item"].Rows.Add(dataRow);
            Console.WriteLine("Values in the dataset");


            foreach (DataRow insertedRow in ds.Tables["item"].Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3}", insertedRow[0], insertedRow[1], insertedRow[2], insertedRow[3]);
            }
            sda.Update(ds, "item");

            Console.WriteLine("Values in the datbase");


            foreach (DataRow insertedRow in ds.Tables["item"].Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3}", insertedRow[0], insertedRow[1], insertedRow[2], insertedRow[3]);
            }

        }

        public static void Main (string[] args)
        {

            SqlConnectionDisconnectedEnv sqlConnectionDisconnectedEnv = new SqlConnectionDisconnectedEnv();
            sqlConnectionDisconnectedEnv.DisplayDisconnectEnv();
            sqlConnectionDisconnectedEnv.InsertDisplayDisconnectEnvDataSet();
            Console.ReadLine();

        }
    }
}
