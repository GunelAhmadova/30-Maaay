using System;
using System.Collections.Generic;
using System.Text;

namespace _30_May
{
    class Notebook
    {
        public string Name;
        public string Brandname;
        public double Price;
       

      
    } 
    class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;

        public void Drive()
        {
            Console.WriteLine("nece km surmek isteyirsiz?");
            double km = int.Parse(Console.ReadLine()); 
            if (CurrentFuel> km * FuelFor1Km)
            {
                Console.WriteLine("kifayyet qeder benzinimiz var");
                Millage += km;
                CurrentFuel -= km * FuelFor1Km;
                Console.WriteLine( $"gedisden sonra {CurrentFuel} litr qalacaq");

            } 
           

            else  {
              

                Console.WriteLine("kifayyet qeder benzin yoxdur");
            }
        } 

    }

    
}
