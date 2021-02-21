using Business.Concrete;
using DataAccess.Concrete;
using System;
using Entities.Concrete;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService(new InMemoryCarDal());

            Console.WriteLine("Bir işlem seç");
            Console.WriteLine("1-ekle\n 2-sil\n 3-güncelle\n 4-getir\n 5-tümünü getir\n 6-çıkış");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 6)
            {
                Environment.Exit(0);
            }
            else if (choose == 1)
            {
                var car = carService.Add(new Car { Id = 1, BrandId = 2, ColorId = 2, DailyPrice = 10554455, Description = "bozuk", ModelYear = 1999 });
                Console.WriteLine($"{car.Description} {car.ModelYear} {car.DailyPrice}");
            }
            else if (choose == 2)
            {
                Console.WriteLine("bir adet id gir");
                int id = Convert.ToInt32(Console.ReadLine());
                carService.Delete(id);
            }
            else if (choose == 3)
            {
                var car = carService.Update(
                new Car
                {

                    Id = 1,
                    BrandId = 2,
                    ColorId = 2,
                    DailyPrice = 555555,
                    Description = "tamirde",
                    ModelYear = 1999

                });

                Console.WriteLine($"{car.Description} {car.ModelYear} {car.DailyPrice}");

            }
            else if (choose == 4)
            {
                Console.WriteLine("bir adet id gir");
                int id = Convert.ToInt32(Console.ReadLine());
                var car = carService.GetById(id);
                if (car == null)
                    Console.WriteLine("kayıt yok babuş");
                else
                    Console.WriteLine($"{car.Description} {car.ModelYear} {car.DailyPrice}");
            }
            else if (choose == 5)
            {
                var carList = carService.GetAll();
                foreach (var car in carList)
                {
                    Console.WriteLine($"{car.Description} {car.ModelYear} {car.DailyPrice}");
                }

                    
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
