using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
    {
        public List<UserDetailDTO> GetUserDetails()
        {
            using (ReCapContext context= new ReCapContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.UserId
                             select new UserDetailDTO 
                             {
                                 CompanyName = c.CompanyName, 
                                 FirstName = u.FirstName, 
                                 LastName = u.LastName 
                             };
                return result.ToList();
            }

        }
    }
}
