using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{CarId = 1, CarBrandId = 1, CarColorId = 1, CarModelYear = "2015", CarDailyPrice = 300, CarDescription = "Dizel, Otomatik" },
                new Car{CarId = 2, CarBrandId = 1, CarColorId = 2, CarModelYear = "2017", CarDailyPrice = 350, CarDescription = "Benzinli, Otomatik" },
                new Car{CarId = 3, CarBrandId = 2, CarColorId = 5, CarModelYear = "2019", CarDailyPrice = 400, CarDescription = "Benzinli, Otomatik" },
                new Car{CarId = 4, CarBrandId = 3, CarColorId = 4, CarModelYear = "2014", CarDailyPrice = 275, CarDescription = "Dizel, Manuel"},
                new Car{CarId = 5, CarBrandId = 3, CarColorId = 3, CarModelYear = "2013", CarDailyPrice = 250, CarDescription = "Benzinli, Manuel" },
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carBrandId)
        {
            return _cars.Where(c => c.CarBrandId == carBrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
        }
    }
}
