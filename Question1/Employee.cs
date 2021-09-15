using System;



namespace Question1
{
    /*
 * Bir personel sınıfı tasarlayın. Birinci adı, ikinci adı ve soyadı bilgileri olsun.
 * Birinci adı ve soyadı boş geçilemez. İkinci adı 6 karakterden çok, 3 karakterden az olamaz.
 * Ayrıca tüm bilgileri girerken ilk harfi büyük olmalıdır.
 * Bu sınıf üzerinden nesnelerek yaratarak örnekleyin.
 */

    public class Employee
    {
        private string _firstName;
        private string _secondName;
        private string _surName;


        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string SurName { get; set; }


        public Employee()
        {
        }


        public string FirstLetterToUpperCase(string str)
        {
            try
            {
                str = char.ToUpper(str[0]) + str.Substring(1);
                return str;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool TestForNullOrEmpty(string str)
        {
            try
            {
                var result = string.IsNullOrEmpty(str);
                if (result)

                    Console.WriteLine("Isim ve Soyisim alani Bos Gecilemez....");
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool SecondNameLimit(string str)
        {
            try
            {
                const int maxLength = 6;
                const int minLength = 3;

                var result = str.Length >= minLength && str.Length <= maxLength;
                if (!result)

                    Console.WriteLine("Ikinci ad 3-6 karakter arasinda olabilir");


                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}