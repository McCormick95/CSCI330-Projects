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

            Course two = new Course(){
                Name = "CSCI-270",
                Title= "Data Communications Systems and Networks",
                Credits= 6,
                Description="Fundamentals of data communications, including hardware, basic components of communications, etc...", 
            };

            Course three = new Course(){
                Name = "MATH-161",
                Title= "Calculus II",
                Credits= 4,
                Description="Topics include math, etc...", 
            };

            Course four = new Course(){
                Name = "CSCI-120",
                Title= "Intro to Web Interface Developent",
                Credits= 3,
                Description="An introduction to the design and development of interactive Web 2.0 user interfaces using client-side programming languages.", 
            };

            Course five = new Course(){
                Name = "MATH-174",
                Title= "Introduction to Discrete Mathmatics",
                Credits= 5,
                Description="Topics include math, etc...", 
            };

            Course six = new Course(){
                Name = "CSCI-356",
                Title= "Operating Systems",
                Credits= 3,
                Description="Basic concepts and terminology of operating systems, I/0 and interrupt structures, etc...", 
            };

            //Console.WriteLine(one);

            List<Course> courses = new List<Course>(){
                one, two, three, four, five, six
            };

            //courses.Sort();
            //foreach (Course c in courses){
            //    Console.WriteLine(c);
            //}

             Console.WriteLine("-------------------------------------------");

            courses.Sort(new CourseComparer());
            foreach (Course c in courses){
                Console.WriteLine(c);
            }
        }
    }

}