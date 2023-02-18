using Business.concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUIı
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //SystemTest();
            //ColorTest();
            //MessagessTest();


            //RentalTest();

        }

        //private static void RentalTest()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());

        //    //Rental rental = new Rental() { CarId = 1, CustomerId = 1, RentDate = new DateTime(2022, 07, 08), ReturnDate = new DateTime(2022, 09, 09) };
        //    //rentalManager.Add(rental);

        //    //Rental rental = new Rental() { Id = 100, CarId = 10, CustomerId = 20, RentDate = new DateTime(2022, 05, 05), ReturnDate = new DateTime(2022, 06, 12) };
        //    //rentalManager.Update(rental);

        //    //Rental rental = new Rental() { Id = 100, CarId = 10, CustomerId = 20, RentDate = new DateTime(2022, 08, 09), ReturnDate = new DateTime(2022, 10, 13) };
        //    //rentalManager.Delete(rental);

        //    var result = rentalManager.GetAll();

        //    foreach (var rental in result.Data)
        //    {
        //        Console.WriteLine("Id : {0} / CarId : {1} / RentDate : {2} / ReturnDate : {3}", rental.CustomerId, rental.CarId, rental.RentDate, rental.ReturnDate);
        //    }
        //}

        //private static void MessagessTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetails();

        //    if (result.Success == true)
        //    {

        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarName + "/" + car.BrandName);
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        ////private static void ColorTest()
        ////{
        ////    ColorManager colorManager = new ColorManager(new EfColorDal());
        ////    Color color1 = new Color { ColorId = 1, ColorName = "Green" };
        ////    Color color2 = new Color { ColorId = 2, ColorName = "Yellow" };
        ////    Color color3 = new Color { ColorId = 3, ColorName = "Purple" };

        ////    colorManager.Add(color1);
        ////    colorManager.Add(color2);
        ////    colorManager.Add(color3);

        ////    colorManager.Delete(color3);

        ////    color2.ColorName = "Blue";
        ////    colorManager.Update(color2);
        ////}

        ////private static void SystemTest()
        ////{
        ////    BrandManager brandManager = new BrandManager(new EfBrandDal());
        ////    Brand brand1 = new Brand { BrandId = 1, BrandName = "mercedes" };
        ////    Brand brand2 = new Brand { BrandId = 2, BrandName = "bmm" };
        ////    Brand brand3 = new Brand { BrandId = 3, BrandName = "fiat" };

        ////    brandManager.Add(brand1);
        ////    brandManager.Add(brand2);
        ////    brandManager.Add(brand3);

        ////    brandManager.Delete(brand3);

        ////    brand2.BrandName = "bmw";
        ////    brandManager.Update(brand2);
        ////}







        ////private static void ProductTest()
        ////{
        ////    CarManager carManager = new CarManager(new EfCarDal());
        ////    var result = CarManager.GetCarDetails();

        ////    foreach (var carr in carManager.GetAll())
        ////    {
        ////        Console.WriteLine(carr.BrandId);

        ////    }
        ////}
    }
}
