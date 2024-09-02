using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom.Compiler;

namespace Program1
{
    internal class ADODemo
    {

        public void Insert()
        {
            try
            {
                //Step 1: Create a Connection Object 
                SqlConnection con = new SqlConnection("data source=DESKTOP-TIKDAE2;  initial catalog=Dotnet; integrated security=true;");

                //Step 2: Create a Command Object 
                //SqlCommand cmd = new SqlCommand("insert into student values (2, 'John', 'Python', 'Austin')", con);
                SqlCommand cmd = new SqlCommand("insert into student values (3, 'John', 'Python', 'Austin')", con);

                //Step 3: Open the Connection Object
                con.Open();

                //Step 4: Execute SQL Statements in the Command Object
                //When we want to insert, update, delete use ExecuteNonQuery()
                //For select use ExecuteReader()
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Records inserted successfully");
                }
                else
                {
                    Console.WriteLine("Records are not updated");

                }
                //Step 5: Close the Connection Object

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message is :{0} ", ex.Message);
            }
        }

        public void Update()
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-TIKDAE2;  initial catalog=Dotnet; integrated security=true;");
                SqlCommand cmd = new SqlCommand("update student set studentLocation='Tulsa' where student=2", con);
                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Record updated successfully");
                }
                else
                {
                    Console.WriteLine("Records are not updated");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message is :{0} ", ex.Message);
            }

        }

        public void Delete()
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-TIKDAE2;  initial catalog=Dotnet; integrated security=true;");
                SqlCommand cmd = new SqlCommand("delete from student where student=3", con);
                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Record deleted successfully");
                }
                else
                {
                    Console.WriteLine("Record is not deleted");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message is :{0} ", ex.Message);
            }
        }
        public void Display()
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-TIKDAE2;  initial catalog=Dotnet; integrated security=true;");
                SqlCommand cmd = new SqlCommand("select * from student", con);
                con.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("StudentID \t Student Name \t Student Course \t Student Location");

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
            ADODemo aDODemo = new ADODemo();

            //aDODemo.Insert();
            //aDODemo.Update();
            //aDODemo.Delete();
            aDODemo.Display();

            Console.ReadLine();

        }

    }
}

//How to insert two 