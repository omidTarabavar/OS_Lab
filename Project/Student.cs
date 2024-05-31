namespace ProjectLMS
{
    internal class Student : User
    {
        int type = 2;
        public Student(int userId, string name, string email, string password) : base(userId, name, email, password, 2)
        { }
    }
}
