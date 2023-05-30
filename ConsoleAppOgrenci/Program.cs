using System;

namespace ConsoleAppOgrenci
{

    // Öğrenci bilgilerini ekrana veren console app
    class Talebe
    {

        // Erişim belirleyicileri public
        // veri tipleri string ve int
        public string name;
        public int number;
        public int grade;


        // Bu method erkana vermek için yazıldı
        public void info()
        {
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("Student Number:{0}", number);
            Console.WriteLine("Student Grade:{0}", grade);

        }
    }


    class Program
    {

        // Program sınıfının içerisinde öğrenci sınıflarından bir nesne türetip
        // değişkenlere değer atandı
        // ardından info methodu çağırılıp veriler ekrana yazdırıldı.
        static void Main(string[]args)
        {
            Talebe tb1 = new Talebe();
            tb1.name = "Koray Çakır";
            tb1.number = 222;
            tb1.grade = 1;

            tb1.info();


        }

    }
}