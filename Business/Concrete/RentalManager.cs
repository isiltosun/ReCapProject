using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal; ;
        }
        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public List<Rental> GetById(int id)
        {
            return _rentalDal.GetAll(r => r.Id == id);
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentDate >= DateTime.Now.Date)
            {
                if (rental.ReturnDate <= DateTime.Now.Date)
                {
                    _rentalDal.Add(rental);

                    return new SuccessResult(Messages.Added);

                }
                else
                {
                    return new SuccessResult(Messages.NameInvalid);
                }

            }
            else
            {
                return new SuccessResult(Messages.NameInvalid);
            }
        }
    }
}
