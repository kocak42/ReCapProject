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
            //  ProductTest();
           // BrandManger brandManager = new BrandManger(new EfBrandDal());
            //Brand brand1 = new Brand { Id = 1, BrandName = "mercedes" };
            //Brand brand2 = new Brand { Id = 2, BrandName = "bmm" };
            //Brand brand3 = new Brand { Id = 3, BrandName = "fiat" };

            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //brandManager.Add(brand3);

            //brandManager.Delete(brand3);

            //brand2.BrandName = "bmw";
            //brandManager.Update(brand2);

            ColorManger colorManager = new ColorManger(new EfColorDal());
            Color color1 = new Color { Id = 1, ColorName = "Green" };
            Color color2 = new Color { Id = 2, ColorName = "Yellow" };
            Color color3 = new Color { Id = 3, ColorName = "Purple" };

            colorManager.Add(color1);
            colorManager.Add(color2);
            colorManager.Add(color3);

            colorManager.Delete(color3);

            color2.ColorName = "Blue";
            colorManager.update(color2);
            

        }
        


        // private static void ProductTest()
        //{
        //  CarManager carManager = new CarManager(new EfCarDal());

        //foreach (var carr in carManager.GetAll())
        //{
        //  Console.WriteLine(carr.BrandId);

        //}
        //}
    }
}
