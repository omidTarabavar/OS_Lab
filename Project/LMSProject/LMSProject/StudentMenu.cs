using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public partial class StudentMenu : Form
    {
        private Student std;
        public StudentMenu(Student student)
        {
            InitializeComponent();
            this.std = student;
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            uIdTB_std.Text = "" + std.stdId;
            nameTBox_std.Text = std.name;
            emailTbox_std.Text = "" + std.email;
            PassTBox_std.Text = "" + std.password;
            stdNameLabel.Text = $"Welcome {std.name}";
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
                string query = $"SELECT cId, title, professor FROM Courses WHERE uId = {std.stdId}";

                SqlCommand sc = new SqlCommand(query, connection);
                SqlDataReader rdr = sc.ExecuteReader();
                listView1.View = View.Details;
                listView1.Columns.Add("Course ID", 100);
                listView1.Columns.Add("Title", 100);
                listView1.Columns.Add("Professor", 100);


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

        private void updateProf_std_Click(object sender, EventArgs e)
        {
            std.name = nameTBox_std.Text;
            std.email = emailTbox_std.Text;
            std.password = PassTBox_std.Text;


            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cs);
            int afkRows = 0;
            try
            {
                connection.Open();
                string query = $"UPDATE Users set name = @profName, email = @email, password = @pass WHERE uId = {std.stdId}";

                SqlCommand sc = new SqlCommand(query, connection);
                sc.Parameters.AddWithValue("@profName", std.name);
                sc.Parameters.AddWithValue("@email", std.email);
                sc.Parameters.AddWithValue("@pass", std.password);
                afkRows = sc.ExecuteNonQuery();
                stdNameLabel.Text = $"Welcome {std.name}";
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
    }
}
