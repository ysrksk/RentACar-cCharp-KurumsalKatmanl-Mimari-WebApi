﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car2 = new Car()
            {
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 1000,
                ModelYear = 2022,
                Description = "5 günlük kiralandı. Hatası bulunmamaktadır. Depo full olarak verildi"
            };





            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer()
            {
                CompanyName = "Küskü",
                UserId = 1
            };

            customerManager.Add(customer1);
            Console.WriteLine("Customer Added");

            //carManager.Add(car2); 
            //Console.WriteLine("Giriş Başarılı");
            
            //var result = carManager.Get(1).Data;
            //result.ModelYear = 2021;
            //carManager.Update(result);

            //foreach (var car in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}


            //foreach (var car in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(car.CarId + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            //}
        }
    }
}
