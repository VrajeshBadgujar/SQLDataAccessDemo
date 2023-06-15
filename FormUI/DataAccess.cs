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
        public List<Employee> GetEmployees(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
               var output = connection.Query<Employee>($"select * from employee2 where name = '{name}' ").ToList();


                //ar output = connection.Query<Employee>("getEmployeeyIdAndName @id , @name ").ToList() ;
             
                return output;
            }
        }

        public void InsertPerson(string Id, string Name, string Gender, string Salary, string City)
        {
           
        }
    }
}
