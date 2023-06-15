using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DataAccess
    {
        public List<Employee> GetEmployees(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //var output = connection.Query<Employee>($"select * from employee2 where name = '{name}' ").ToList();


                var output = connection.Query<Employee>("dbo.getEmployeesByName @name ", new {name = Name}).ToList() ;

                return output;
            }
        }

        public void InsertPerson(string Id, string Name, string Gender, string Salary, string City)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                Employee newEmployee = new Employee
                {
                    id = int.Parse(Id),
                    name = Name,
                    gender = Gender,
                    salary = int.Parse(Salary),
                    city = City

                };

                List<Employee> employee = new List<Employee>();
                employee.Add(newEmployee);

                connection.Execute("sp_insert @id ,  @name , @gender, @salary, @city", employee);
            }
        }
    }
}
