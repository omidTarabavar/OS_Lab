using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public class Student
    {
        public int stdId;
        public string name, email, password;
        public List<Course> courses;
        public Student(int stdId, string name, string email, string password)
        {
            this.stdId = stdId;
            this.name = name;
            this.email = email;
            this.password = password;
            courses = new List<Course>();

            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            try
            {
                connection.Open();
                string query = $"SELECT cId, title, professor FROM Courses WHERE stdId = {stdId}";
                SqlCommand sc = new SqlCommand(query, connection);
                SqlDataReader rdr = sc.ExecuteReader();

                while (rdr.Read())
                {
                    courses.Add(new Course(int.Parse(rdr["cId"].ToString()), rdr["title"].ToString(), rdr["professor"].ToString()));
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
