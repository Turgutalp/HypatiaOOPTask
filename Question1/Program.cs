using System;


namespace Question1
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();

            Console.WriteLine("Lutfen Isminizi Giriniz: \n");
            
            employee.FirstName = Console.ReadLine();
            
            Console.WriteLine("###################################");

            Console.WriteLine("Lutfen Varsa Ikinci Isminizi Giriniz: \n");

            employee.SecondName = Console.ReadLine();

            Console.WriteLine("###################################");

            Console.WriteLine("Lutfen Soyadinizi Giriniz \n");

            employee.SurName = Console.ReadLine();

            Console.WriteLine("###################################");

            if (!employee.TestForNullOrEmpty(employee.FirstName) && employee.SecondNameLimit(employee.SecondName) &&
                !employee.TestForNullOrEmpty(employee.SurName))
            {
                Console.WriteLine("Isminiz: {0} , Ikinci Adiniz: {1} , Soyadiniz: {2}",
                    employee.FirstLetterToUpperCase(employee.FirstName), employee.SecondName,
                    employee.FirstLetterToUpperCase(employee.SurName));
            }


            /*
            user input icin int validation ve hatali girisler icin yeniden yonlendirme yapmadim 
            bunlari data annotation'lar ile yapmak daha mantikli olabilirdi.Amac oop mantigi oldugu icin suslemedim..
            Bilginize..
            
            
            */
        }
    }
}