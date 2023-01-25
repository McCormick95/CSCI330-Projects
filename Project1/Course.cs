using System;
using System.Text;

namespace School
{

    public class Course : IComparer<Course>, IComparable<Course>, ICreditable
    {

    //Name (ex. "CSCI 330)
        public string Name {get; set;}
    //Title (ex. "Systems Analysis and Software Engineering")
        public string Title {get; set;}
    //Credits (ex. 3.0)
        //public int Credits {get; set;}
        public int Credit {get; set;}


        //Description (ex. "Topics include requirements engineering, unite testting, etc...")
        public string Description {get; set;}
        

        public override string ToString()
        {
            return $"~~{Name}({Credit}): {Title}-\n    {Description}.";
        } 

        public int Compare(Course? x, Course? y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Course other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }

}