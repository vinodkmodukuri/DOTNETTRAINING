using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Program1
{
    internal class SqlConnectionAskUserINput
    {
        public void AskUserInput()
        {
            try
            {
                int ID, Qunatity;
                string Name, Description;

                Console.WriteLine("Enter the item ID");
                ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the item name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the item quantity");
                Qunatity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the item description");
                Description = Console.ReadLine();

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlLocalDatabseConnection"].ConnectionString);
                SqlCommand cmd = new SqlCommand("insert into item values (@ItemID, @ItemName, @ItemQunatity, @ItemDescription)", con);

                con.Open();

                cmd.Parameters.AddWithValue("@ItemID", ID);
                cmd.Parameters.AddWithValue("@ItemName", Name);
                cmd.Parameters.AddWithValue("@ItemQunatity", Qunatity);
                cmd.Parameters.AddWithValue("@ItemDescription", Description);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Record inserted successfully");
                    Display();
                }

                else
                {
                    Console.WriteLine("Insertion failed");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message is {0}", ex.Message);
            }
        }

        public void Display()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlLocalDatabseConnection"].ConnectionString);

                SqlCommand cmd = new SqlCommand("select * from item", con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("ItemID \t Item Name \t Item Quantity \t Item Description");

                while (reader.Read())
                {
                    Console.WriteLine("{0}\t\t {1}\t\t {2}\t\t\t {3}\t\t", reader[0], reader[1], reader[2], reader[3]);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error message is :{0} ", ex.Message);
            }
        }
        public static void Main(string[] args)
        {
            SqlConnectionAskUserINput myobj = new SqlConnectionAskUserINput();

            myobj.AskUserInput();
            myobj.Display();
            Console.ReadLine();
        }
    }
}
