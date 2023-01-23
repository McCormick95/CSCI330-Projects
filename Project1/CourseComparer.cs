namespace School
{
    public class CourseComparer : IComparer<Course>
    {
        public enum SortBy
        {
            Name,
            Credits
        }
        private SortBy compareField = SortBy.Name;
        public int Compare(Course? x, Course? y)
        {
            switch(compareField)
            {
                case SortBy.Credits:
                    return x.Credits.CompareTo(y.Credits);
                    break;
                default:
                    break;

            }
            return x.Name.CompareTo(y.Name);
        }
    }
}