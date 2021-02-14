using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, ModelYear = "2015", DailyPrice = 300, Description = "Dizel, Otomatik" },
                new Car{CarId = 2, BrandId = 1, ColorId = 2, ModelYear = "2017", DailyPrice = 350, Description = "Benzinli, Otomatik" },
                new Car{CarId = 3, BrandId = 2, ColorId = 5, ModelYear = "2019", DailyPrice = 400, Description = "Benzinli, Otomatik" },
                new Car{CarId = 4, BrandId = 3, ColorId = 4, ModelYear = "2014", DailyPrice = 275, Description = "Dizel, Manuel"},
                new Car{CarId = 5, BrandId = 3, ColorId = 3, ModelYear = "2013", DailyPrice = 250, Description = "Benzinli, Manuel" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

      

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

     

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
