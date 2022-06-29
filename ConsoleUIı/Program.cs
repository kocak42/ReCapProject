using Business.concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUIı
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var carr in carManager.GetAll())
            {
                Console.WriteLine(carr.BrandId);
                Console.WriteLine( carr.Description);
            }
        }
    }
}
