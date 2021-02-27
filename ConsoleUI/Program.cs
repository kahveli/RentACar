using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //CarTest();

            //BrandManager();

            //ColorManager();

            // hata döndürmesi için değeri null girdim.
            //RentalTest();

            // CustomerTest();
        }

        private static void RentalTest()
        {
            var rent = new RentalManager(new EfRentalDal());
            Console.WriteLine(rent.Add(new Rental
                {CarId = 1, CustomerId = 1, Id = 1, ReturnDate = null, RentDate = DateTime.Now}).Message);
        }

        private static void CustomerTest()
        {
            var customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer {CompanyName = "kodlama.io"});
        }

        private static void ColorManager()
        {
            var colorManager = new ColorManager(new EfColorDal());
            var byId = colorManager.GetById(8);
            Console.WriteLine(byId);
        }

        private static void BrandManager()
        {
            var brandManager = new BrandManager(new EfBrandDal());
            var a = brandManager.GetById(888);
            Console.WriteLine(a.Data.BrandName);
        }

        private static void CarTest()
        {
            var carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetCarDetails());
            carManager.Add(new Car
            {
                CarName = "Mazdaaaaaaaaaa", BrandId = 1003, ColorId = 1003, DailyPrice = 123, ModelYear = "2001",
                Description = "dizellll", Id = 2229
            });
            carManager.Update(new Car
            {
                Id = 11, CarName = "x", DailyPrice = 551, Description = "xxxxxxxxxx", ModelYear = "2050", BrandId = 120,
                ColorId = 31
            });
            carManager.Delete(new Car {Id = 250});
            carManager.GetCarByBrandId(30);
        }
    }
}