using System.Collections.Generic;

namespace Question2
{
    public class Course
    {
        public string CourseName { get; set; }
        public Homework[] Homeworks { get; set; }
        public Student[] RegisteredStudents { get; set; }
        public Student[] ApplyStudents { get; set; }
        
        
        // Burada [] yerine collection dondurmek daha mi mantikli olur ? 
        //list dondururken mssql'de bazi hatalar aldigimi hatirliyorum
    }
}