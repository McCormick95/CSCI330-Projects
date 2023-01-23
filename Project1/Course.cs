using System;
using System.Text;

namespace School
{

    public class Course
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

    }

}