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
            listView1_mng.View = View.Details;
            listView1_mng.Columns.Add("Student Id", 80);
            listView1_mng.Columns.Add("Name", 90);
            listView1_mng.Columns.Add("Email", 150);
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
            titleTB_mng.Text = course.title;
            cId_mng.Text = "" + course.cid;
            getStudents();
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            int afkRows = 0;
            try
            {
                connection.Open();
                string query = "DELETE FROM Courses WHERE title = @Title AND professor = @Professor";

                SqlCommand sc = new SqlCommand(query, connection);
                sc.Parameters.Clear();
                sc.Parameters.AddWithValue("@Title", course.title);
                sc.Parameters.AddWithValue("@Professor", course.professor);
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
        private void getStudents()
        {
            listView1_mng.Items.Clear();

            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            try
            {
                connection.Open();
                string query = "SELECT u.uId, u.name, u.email FROM Users u JOIN Courses c ON u.uId = c.uId WHERE u.type = 2 AND c.professor = @prof AND c.title = @title";

                SqlCommand sc = new SqlCommand(query, connection);
                sc.Clone();
                sc.Parameters.AddWithValue("@prof", course.professor);
                sc.Parameters.AddWithValue("@title", course.title);
                SqlDataReader rdr = sc.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem listViewItem = new ListViewItem(rdr["uId"].ToString());
                    listViewItem.SubItems.Add(rdr["name"].ToString());
                    listViewItem.SubItems.Add(rdr["email"].ToString());
                    listView1_mng.Items.Add(listViewItem);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        int selectedStd = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedStd != 0)
            {
                string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(cs);
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Courses WHERE uId = @uId";

                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.Parameters.Clear();
                    sc.Parameters.AddWithValue("@uId", selectedStd);
                    SqlDataReader rdr = sc.ExecuteReader();
                    connection.Close();
                    getStudents();
                    selectedStd = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student!");
            }
        }
        private void listView1_mng_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1_mng.SelectedItems[0];
            selectedStd = int.Parse(selectedItem.SubItems[0].Text);


        }
    }
}
