namespace Question2
{
    public class Instructor : User
    {
        public Course[] ActiveLessons { get; set; }
        public Course[] OpenApplicationLessons { get; set; }
        
        
    }
}