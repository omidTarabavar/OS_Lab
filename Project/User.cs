namespace ProjectLMS
{
    internal class User
    {
        public int userId, type;
        public string name, email, password;
        public User(int userId, string name, string email, string password, int type)
        {
            this.userId = userId;
            this.name = name;
            this.email = email;
            this.password = password;
            this.type = type;
        }

    }
}
