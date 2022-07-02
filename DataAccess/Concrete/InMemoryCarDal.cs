using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    

   public class InMemoryCarDal: ICarDal
    {
        List<Car> _car;
        
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                //new Car{CarId=1,BrandId=01,ColorId=111 , ModelYear=2022,DailyPrice=150,Description="araba gibi araba" },
                //new Car{CarId=2,BrandId=02,ColorId=222 , ModelYear="1990",DailyPrice=600,Description="tank gibi" },
                //new Car{CarId=3,BrandId=03,ColorId=333 , ModelYear="2000",DailyPrice=10,Description="özel zırhlı" },
                //new Car{CarId=4,BrandId=04,ColorId=444 , ModelYear="2010",DailyPrice=1000,Description="bunu alan yaşar" },
                //new Car{CarId=5,BrandId=05,ColorId=555 , ModelYear="2020",DailyPrice=50000,Description="dosta gider" },
                //new Car{CarId=6,BrandId=06,ColorId=666 , ModelYear="2001",DailyPrice=200,Description="ön düzeninde sıkıntı yok" },



            };
            
            

    }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.CarId = car.CarId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;
        }
    }
}
