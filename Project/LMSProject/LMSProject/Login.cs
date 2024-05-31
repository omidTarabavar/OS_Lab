using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_login_Click(object sender, EventArgs e)
        {
            string enteredEmail = emailTbox_login.Text;
            string enteredPass = PassTBox_login.Text;
            if (enteredEmail == "" || enteredPass == "")
            {
                MessageBox.Show("Please complete the form!");
            }
            else
            {
                string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Github\\OS_Lab\\Project\\LMSProject\\LMSProject\\LMSDB.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(cs);
                try
                {
                    connection.Open();
                    string query = $"SELECT uId, name, email, password, type FROM Users WHERE email = '{enteredEmail}'" +
                        $"AND password = {enteredPass}";
                    SqlCommand sc = new SqlCommand(query, connection);
                    SqlDataReader rdr = sc.ExecuteReader();
                    if (rdr.HasRows)
                    {

                        rdr.Read();
                        int uId = int.Parse(rdr["uId"].ToString());

                        string name = rdr["name"].ToString();
                        string email = rdr["email"].ToString();
                        string password = rdr["password"].ToString();

                        if (int.Parse(rdr["type"].ToString()) == 1)
                        {
                            // create a prof
                            Professor prof = new Professor(uId, name, email, password);
                            ProfessorMenu profMenu = new ProfessorMenu(prof);
                            this.Hide();
                            profMenu.ShowDialog();
                        }
                        else
                        {

                            Student std = new Student(uId, name, email, password);
                            StudentMenu stdMenu = new StudentMenu(std);
                            this.Hide();
                            stdMenu.ShowDialog();

                        }
                        connection.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!");
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
