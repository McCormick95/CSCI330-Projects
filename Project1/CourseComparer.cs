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
            if(x.Name.CompareTo(y.Name)!= 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else if(x.Title.CompareTo(y.Title)!= 0)
            {
                return x.Title.CompareTo(y.Title);
            }
            else if(x.Credits.CompareTo(y.Credits)!= 0)
            {
                return x.Credits.CompareTo(y.Credits);
            }
            else if(x.Description.CompareTo(y.Description)!= 0)
            {
                return x.Description.CompareTo(y.Description);
            }
            else
            {
                return 0;
            }
        }
    }
}