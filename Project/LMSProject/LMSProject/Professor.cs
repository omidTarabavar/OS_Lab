using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public class Professor
    {
        public int profId;
        public string name, email, password;
        public List<Course> courses;

        public Professor(int profId, string name, string email, string password)
        {
            this.profId = profId;
            this.name = name;
            this.email = email;
            this.password = password;
            courses = new List<Course>();

            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            try
            {
                connection.Open();
                string query = $"SELECT cId, title, professor FROM Courses WHERE uId = {profId}";

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
