using System;


namespace Question2
{
    public class Student : User
    {
        public Course[] RegisteredLessons { get; set; }
        public Course[] AppliedLessons { get; set; }
        
    }
}