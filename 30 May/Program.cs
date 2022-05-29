using System;

namespace _30_May
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[3];
            notebooks[0] = new Notebook()
            {
                Name = "Acer",
                Brandname = "aspire",
                Price = 2000
            };
            notebooks[1] = new Notebook()
            {
                Name = "Hp",
                Brandname = "Paviiion",
                Price = 1500
            };
            notebooks[2] = new Notebook()
            {
                Name = "Lenovo",
                Brandname = "Yoga",
                Price = 2500
            };

            Console.WriteLine("Minimum qiymeti yazin");
            int minPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Maksimum qiymeti yazin");
            int maxPrice = int.Parse(Console.ReadLine());


            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price > minPrice && notebooks[i].Price < maxPrice)
                {
                    Console.WriteLine($"{notebooks[i].Name} {notebooks[i].Brandname} {notebooks[i].Price}");

                }


            }

            //Aşağıdaki parametrlərə sahib Car class yaradın
            //         -Brand
            //         - Model
            //         - CurrentFuel - masinin hazirki benzin miqdari
            //         - FuelFor1Km - masinin 1 km ucun xerclediyi benzin
            // -Millage - Masinin bu vaxtadək neçə km sürüldüyü
            //- Drive() - sürülmə metodu.Bu metod int parametr qeəbul edir(neçə km sürmək istədiyimiz)
            //  Car obyekti yaradın drive metodunu işə saldıqda arqument olaraq neçə km sürmək istədyimizi
            //  daxil edirik və əgər benzin kifayət edirsə maşının millage dəyəri və benzini azalır,
            //  benzin kifayət etmirsə console - da xəta mesajı yazılır


            Car car1 = new Car
            {
                Brand = "Ford",
                Model = "Mustang",
                CurrentFuel = 50,
                FuelFor1Km = 1,
                Millage = 30000
            };


        car1.Drive();
            
        }
        
        
            
       
    }
}
