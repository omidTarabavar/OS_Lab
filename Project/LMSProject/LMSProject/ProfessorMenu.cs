using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public partial class ProfessorMenu : Form
    {
        private Professor professor;
        public ProfessorMenu(Professor prof)
        {
            InitializeComponent();
            professor = prof;
        }

        private void ProfessorMenu_Load(object sender, EventArgs e)
        {

            textBox1.Text = "" + professor.profId;
            nameTBox_prof.Text = professor.name;
            emailTbox_prof.Text = "" + professor.email;
            PassTBox_prof.Text = "" + professor.password;
            profNameLabel.Text = $"Welcome {professor.name}";
            listView1.View = View.Details;
            listView1.Columns.Add("Course ID", 100);
            listView1.Columns.Add("Title", 100);
            listView1.Columns.Add("Professor", 100);
            getCourses();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            professor.name = nameTBox_prof.Text;
            professor.email = emailTbox_prof.Text;
            professor.password = PassTBox_prof.Text;


            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            int afkRows = 0;
            try
            {
                connection.Open();
                string query = $"UPDATE Users set name = @profName, email = @email, password = @pass WHERE uId = {professor.profId}";

                SqlCommand sc = new SqlCommand(query, connection);
                sc.Parameters.AddWithValue("@profName", professor.name);
                sc.Parameters.AddWithValue("@email", professor.email);
                sc.Parameters.AddWithValue("@pass", professor.password);
                afkRows = sc.ExecuteNonQuery();
                profNameLabel.Text = $"Welcome {professor.name}";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1: " + ex.Message);
            }

            if (afkRows > 0)
            {
                MessageBox.Show("Update Successful!");
            }

        }
        Course selectedCourse;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            int cId = int.Parse(selectedItem.SubItems[0].Text);
            string title = selectedItem.SubItems[1].Text;
            string prof = selectedItem.SubItems[2].Text;
            selectedCourse = new Course(cId, title, prof);
        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdd addCourse = new FormAdd(professor);
            addCourse.ShowDialog();
            this.Show();
            getCourses();

        }

        private void getCourses()
        {
            listView1.Items.Clear();

            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            try
            {
                connection.Open();
                string query = $"SELECT cId, title, professor FROM Courses WHERE uId = {professor.profId}";

                SqlCommand sc = new SqlCommand(query, connection);
                SqlDataReader rdr = sc.ExecuteReader();



                while (rdr.Read())
                {
                    ListViewItem listViewItem = new ListViewItem(rdr["cId"].ToString());
                    listViewItem.SubItems.Add(rdr["title"].ToString());
                    listViewItem.SubItems.Add(rdr["professor"].ToString());
                    listView1.Items.Add(listViewItem);

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (selectedCourse == null)
            {
                MessageBox.Show("Please select a course");
            }
            else
            {
                FormManageCourse manageCourse = new FormManageCourse(selectedCourse);
                manageCourse.ShowDialog();
                getCourses();
                selectedCourse = null;
            }
            this.Show();
        }
    }
}
