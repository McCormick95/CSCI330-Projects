using System;
using System.Collections.Generic;

namespace School
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List of Classes:");

            Course one = new Course(){
                Name = "CSCI-330",
                Title= "Systems Analysis and Software Engineering",
                Credits= 3,
                Description="Topics include requirements engineering, unite testting, etc...", 
            };

            //Console.WriteLine(one);

            List<Course> courses = new List<Course>(){
                one
            };

            

        }
    }

}