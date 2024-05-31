using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public partial class FormAdd : Form
    {
        public FormAdd(Professor prof)
        {
            InitializeComponent();
            profIdTB.Text = "" + prof.profId;
            profTB.Text = "" + prof.name;

        }

        private void addCourse_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = titleTB.Text;
            string prof = profTB.Text;
            string profId = profIdTB.Text;


            if (title == "" || prof == "" || profId == "")
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
                    string query = "INSERT INTO Courses (title, professor, uId) VALUES (@title, @prof, @profId)";
                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.Parameters.Clear();
                    sc.Parameters.AddWithValue("@title", title);
                    sc.Parameters.AddWithValue("@prof", prof);
                    sc.Parameters.AddWithValue("@profId", profId);
                    sc.ExecuteNonQuery();
                    connection.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
