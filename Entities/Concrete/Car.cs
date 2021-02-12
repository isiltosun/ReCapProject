using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int CarBrandId { get; set; }
        public int CarColorId { get; set; }
        public string CarModelYear { get; set; }
        public int CarDailyPrice { get; set; }
        public string CarDescription { get; set; }
        public bool ProductName { get; set; }
    }
}
