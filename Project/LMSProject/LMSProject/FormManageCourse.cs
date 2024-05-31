using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public partial class FormManageCourse : Form
    {
        Course course;
        public FormManageCourse(Course course)
        {
            InitializeComponent();
            this.course = course;
            titleTB_mng.Text = course.title;
            cId_mng.Text = "" + course.cid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            course.title = titleTB_mng.Text;
            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            int afkRows = 0;
            try
            {
                connection.Open();
                string query = $"UPDATE Courses set title = @title WHERE cId = {cId_mng.Text}";

                SqlCommand sc = new SqlCommand(query, connection);
                sc.Parameters.Clear();
                sc.Parameters.AddWithValue("@title", titleTB_mng.Text);
                afkRows = sc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (afkRows > 0)
            {
                MessageBox.Show("Update Successful!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormManageCourse_Load(object sender, EventArgs e)
        {

        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            int afkRows = 0;
            try
            {
                connection.Open();
                string query = $"DELETE Courses WHERE cId = {cId_mng.Text}";

                SqlCommand sc = new SqlCommand(query, connection);
                afkRows = sc.ExecuteNonQuery();
                connection.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (afkRows > 0)
            {
                MessageBox.Show("Deleted Successfully!");
            }
        }
    }
}
