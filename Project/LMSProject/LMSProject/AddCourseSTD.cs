using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public partial class AddCourseSTD : Form
    {
        Student student;
        public AddCourseSTD(Student std)
        {
            InitializeComponent();
            this.student = std;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = titleTB_addCs.Text;
            string prof = profTB_addCs.Text;


            if (title == "" || prof == "")
            {
                MessageBox.Show("Please Complete the form!");
            }
            else
            {
                string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(cs);
                try
                {
                    connection.Open();
                    string query = "SELECT cId FROM Courses WHERE title = @title AND professor = @prof";
                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.Parameters.Clear();
                    sc.Parameters.AddWithValue("@title", title);
                    sc.Parameters.AddWithValue("@prof", prof);
                    int cId = Convert.ToInt32(sc.ExecuteScalar() ?? 0);
                    connection.Close();
                    if (cId > 0)
                    {
                        connection = new SqlConnection(cs);
                        connection.Open();
                        string innerQuery = "INSERT INTO Courses (title, professor, uId) VALUES (@title, @prof, @stdId)";
                        sc = new SqlCommand(innerQuery, connection);
                        sc.Parameters.Clear();
                        sc.Parameters.AddWithValue("@title", title);
                        sc.Parameters.AddWithValue("@stdId", student.stdId);
                        sc.Parameters.AddWithValue("@prof", prof);
                        sc.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Course added successfully");
                        this.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("No course found with the given title and professor.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
