using Microsoft.Data.SqlClient;

namespace LMSProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUp_signUp_Click(object sender, EventArgs e)
        {
            string name = nameTBox_signUp.Text;
            string email = emailTbox_signUp.Text;
            string pass = PassTBox_signUp.Text;
            int type = 0;
            if (profRadioBut.Checked)
            {
                type = 1;
            }
            else if (stdRadioBut.Checked)
            {
                type = 2;
            }

            if (name == "" || email == "" || pass == "" || type == 0)
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
                    string query = "INSERT INTO Users (name, email, password, type) VALUES (" + "'" + name
                        + "'" + "," + "'" + email + "'" + "," + "'" + pass + "'" + "," + "'" + type + "'" + ")";
                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Registration Complete!");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
