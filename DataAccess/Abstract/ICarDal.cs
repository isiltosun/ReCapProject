using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        Car GetCarsByColorId(int colorId);
        Car GetCarsByBrandId(int brandId);
        List<CarDetailDTO> GetCarDetails();
    }
}
