using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Day7Project
{
    class Program
    {
        SqlConnection conn;
        SqlCommand cmdGetStudents,cmdInsertStudent,cmdUpdateStudent,cmdDeleteStudent;
        List<Student> students;
        
        public Program()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-G30NC5Q\SQLEXPRESS;integrated security=true;Initial catalog= dbADOExample");
            //conn.Open();
            //Console.WriteLine("connection successful");
            students = new List<Student>();
        }
      
        public void GetStudentsFromDataBase()
        {
            try
            {
                cmdGetStudents = new SqlCommand();
                cmdGetStudents.CommandText = "select * from tblStudent";
                cmdGetStudents.Connection = conn;
                conn.Open();
                SqlDataReader drStudents = cmdGetStudents.ExecuteReader();
                Student student;
                while(drStudents.Read())
                {
                    student = new Student();
                    student.Id = Convert.ToInt32(drStudents[0]);
                    student.Name = drStudents[1].ToString();
                    try
                    {
                        student.Age = Convert.ToInt32(drStudents[2]);//for null values
                    }
                    catch(InvalidCastException ie)
                    {
                        students.Add(student);
                    }

                    Console.WriteLine("ID is "+drStudents[0]+" Name is "+drStudents[1]+" Age is "+drStudents[2]);
                }
               
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        public void PrintStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        public void InsertInto()
        {
            try
            {

                Student student = new Student();
                student.TakeStudentDataFromUser();
                cmdInsertStudent = new SqlCommand();
                cmdInsertStudent.CommandText = "insert into tblStudent(name,age) values(@studentname,@studentage)";
                cmdInsertStudent.Connection = conn;
                //cmdInsertStudent.Parameters.Add("@studentname", SqlDbType.VarChar, 20);
                //cmdInsertStudent.Parameters[0].Value = student.Name;
                cmdInsertStudent.Parameters.AddWithValue("@studentname", student.Name);

                cmdInsertStudent.Parameters.AddWithValue("@studentage", student.Age);
                conn.Open();
                int iRes = cmdInsertStudent.ExecuteNonQuery();
                if (iRes > 0)
                    Console.WriteLine("Student record inserted");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void UpdateStudent()
        {
            Console.WriteLine("Update student Name");
            Console.WriteLine("************************");
            Console.WriteLine("Enter student id");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            Student student = null;
            try
            {
                student = students.Where(s => s.Id == id).First();
            }
            catch(Exception e)
            {
                Console.WriteLine("no such student");
            }
            if(student!=null)
            {
                Console.WriteLine("student details are: ");
                Console.WriteLine(student);
                Console.WriteLine("enter student name for updation");
                string name = Console.ReadLine();
                cmdUpdateStudent = new SqlCommand("updateStudentName",conn);
                cmdUpdateStudent.Connection = conn;

                cmdUpdateStudent.CommandType = CommandType.StoredProcedure;
                cmdUpdateStudent.Parameters.AddWithValue("@sid", id);
                cmdUpdateStudent.Parameters.AddWithValue("@sname", name);
               // cmdUpdateStudent.Connection = conn;

                try
                {
                    conn.Open();
                    int iRes = cmdUpdateStudent.ExecuteNonQuery();
                    if(iRes>0)
                    {
                        Console.WriteLine("student name updated");
                    }
                    else
                    {
                        Console.WriteLine("student name not updated");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Console.WriteLine("no data found");
            }
        }

        public void DeleteStudentById()
        {
            Console.WriteLine("Delete student ");
            Console.WriteLine("**************");
            Console.WriteLine(" enter id ? ");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            Student student = null;
            try
            {
                student = students.Where(s=>s.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            if (student != null)
            {
                Console.WriteLine("student details");
                Console.WriteLine(student);
                //Console.WriteLine("new name ?");
                //string name = Console.ReadLine();
                cmdDeleteStudent = new SqlCommand("deleteStudent", conn);
                cmdDeleteStudent.CommandType = CommandType.StoredProcedure;
                cmdDeleteStudent.Parameters.AddWithValue("@sid", id);
                //cmdUpdateStudentName.Parameters.AddWithValue("@name", name);
                try
                {
                    conn.Open();
                    int iResult = cmdDeleteStudent.ExecuteNonQuery();
                    if (iResult > 0)
                    {
                        Console.WriteLine("deletion successfull");
                    }
                    else
                    {

                        Console.WriteLine("failed");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw;
                }
                finally
                {
                    conn.Close();
                }

            }
            else
            {
                Console.WriteLine("id not found");
            }


        }
        

        static void Main(string[] args)
        {
            Program p = new Program();
      
            p.GetStudentsFromDataBase();
            p.PrintStudents();
            p.DeleteStudentById();
            p.GetStudentsFromDataBase();
            p.PrintStudents();
            Console.ReadKey();
        }
    }
}
