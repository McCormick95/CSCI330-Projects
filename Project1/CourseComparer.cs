namespace School
{
    public class CourseComparer : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return x.Credit-y.Credit;
        }
    }
}