using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>();
            List<Manager> listManager = new List<Manager>();
            string conectionString = @"Data Source=laptop-0hsc4h8o;Initial Catalog=Office;Integrated Security=True;Pooling=False";
            BringsListFromTablbe(conectionString);
            AddNewEmployeeFromUser(listEmployee, conectionString);
            DeleteEmployee(3, conectionString);
        }
       private static void BringsListFromTablbe(string conectionString)
        {
            Console.WriteLine("name");
            string nameFromUser = Console.ReadLine();
            Console.WriteLine("date");
            string dateFromUser = Console.ReadLine();
            Console.WriteLine("email");
            string emailFromUser = Console.ReadLine();
            Console.WriteLine("wage");
            int wageFromUser = int.Parse(Console.ReadLine());
            //Console.WriteLine("id");
            //int idFromUser = int.Parse(Console.ReadLine());
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string query = $@"INSERT INTO Employee(name,dateBorn,email,wage) 
                                     values('{nameFromUser}','{dateFromUser}','{emailFromUser}',{wageFromUser})";
                SqlCommand cmd = new SqlCommand(query, connection);
                int rowEffect = cmd.ExecuteNonQuery();
                Console.WriteLine(rowEffect);
                connection.Close();
            }
        }
        static void DeleteEmployee(int id, string conectionString)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string queryDelete = $@"DELETE FROM Employee WHERE Employee.Id={id}";
                SqlCommand cmd = new SqlCommand(queryDelete, connection);
            }
        }
        static void AddNewEmployeeFromUser(List<Employee> listEmployee, string conectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Person";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader DataFromDB = command.ExecuteReader();
                    if (DataFromDB.HasRows)
                    {
                        while (DataFromDB.Read())
                        {
                            listEmployee.Add(new Employee(DataFromDB.GetString(0), DataFromDB.GetString(1), DataFromDB.GetString(2), DataFromDB.GetInt32(3)));
                            foreach(Employee person in listEmployee)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("no rows in table");
                    }

                    connection.Close();
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
