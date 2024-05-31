namespace LMSProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show();

        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
            this.Show();
        }
    }
}
