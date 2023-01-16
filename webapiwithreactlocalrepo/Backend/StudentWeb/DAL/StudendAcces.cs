namespace DAL;
using System.Data;
using Model;

using MySql.Data.MySqlClient;

public class StudentAcces
{
    public static string conString=@"server=localhost; port=3306; user=root; password=Welcome@123;database=college";

    public static List<Student> GetAllStudent()
    {
        List<Student> allNotes=new List<Student>();

        MySqlConnection con=new MySqlConnection(conString);


        try
        {
            string query="select * from student";
            DataSet ds=new DataSet();
            MySqlCommand cmd=new MySqlCommand(query,con);

            MySqlDataAdapter da=new MySqlDataAdapter(cmd);

            da.Fill(ds);
            DataTable dt=ds.Tables[0];

            DataRowCollection rows=dt.Rows;

            foreach (DataRow row in rows)
            {
                Student student=new Student
                {
                    id=int.Parse(row["Id"].ToString()),
                    name=row["Name"].ToString(),
                    course=row["Course"].ToString()
                };

                allNotes.Add(student);
            }
            
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return allNotes;
    }

    // public static Student GetStudentById(int id)
    // {
    //     Student student=null;

    //     try
    //     {
    //         con.Open();
    //         string query="select * from student where id="+id;

    //         MySqlCommand command=new MySqlCommand()

    //     }
    // }

    public static void InsertNewUser(Student student)
    {
        MySqlConnection con=new MySqlConnection(conString);
        
        try{
            con.Open();
            string query=$"insert into student(name,course) values('{student.name}','{student.course}')";
            MySqlCommand command=new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }


    public static void DeleteById(int id)
    {
        MySqlConnection con=new MySqlConnection(conString);

        try{
            con.Open();
            string query="delete from student where id="+id;
            MySqlCommand command=new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
    }

}