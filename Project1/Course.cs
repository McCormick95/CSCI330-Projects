using System;
using System.Text;

namespace School
{

    public class Course : IComparer<Course>
    {

    //Name (ex. "CSCI 330)
        public string Name {get; set;}
    //Title (ex. "Systems Analysis and Software Engineering")
        public string Title {get; set;}
    //Credits (ex. 3.0)
        public int Credits {get; set;}
    //Description (ex. "Topics include requirements engineering, unite testting, etc...")
        public string Description {get; set;}

        public override string ToString()
        {
            return $"~~{Name}({Credits}): {Title}-\n    {Description}.";
        } 

        public int Compare(Course? x, Course? y)
        {
            if(x.Name.CompareTo(y.Name) != 0)
            {
                return x.Name.CompareTo(x.Name);
            }
            else if(x.Title.CompareTo(y.Title) != 0)
            {
                return x.Title.CompareTo(x.Title);
            }
            else if(x.Credits.CompareTo(y.Credits) != 0)
            {
                return x.Credits.CompareTo(x.Credits);
            }
            else if(x.Description.CompareTo(y.Description) != 0)
            {
                return x.Description.CompareTo(x.Description);
            }
            else
            {
                return 0;
            }
        }
        
    }

}