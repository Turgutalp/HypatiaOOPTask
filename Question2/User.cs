using System.Collections;

namespace Question2
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public string NameSurname => Name + SurName;
    }
}