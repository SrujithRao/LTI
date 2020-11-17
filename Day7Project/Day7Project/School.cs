using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Day7Project
{
    class School
    {
        SqlConnection conn;
        SqlDataAdapter daCourse;
        public School()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-G30NC5Q\SQLEXPRESS;integrated security=true;Initial catalog= dbADOExample");

        }
        public void GetAllCourses()
        {

        }
        static void Main(string[] args)
        {

        }
    }
   
}
