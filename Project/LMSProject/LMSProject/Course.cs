namespace LMSProject
{
    public class Course
    {
        public int cid;
        public string title, professor;
        public Course(int cid, string title, string professor)
        {
            this.cid = cid;
            this.title = title;
            this.professor = professor;
        }
    }
}
