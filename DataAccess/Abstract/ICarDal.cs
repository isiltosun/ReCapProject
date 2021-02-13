using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        Car GetById(int id);
        Car GetCarsByBrandId(int id);
        Car GetCarsByColorId(int id);
    }
}
