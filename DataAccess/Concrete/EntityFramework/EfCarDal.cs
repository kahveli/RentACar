using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<Car> GetCarByBrandId { get; }

        public List<CarDetailsDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Cars
                    join b in context.Brands
                        on ca.BrandId equals b.BrandId
                    join co in context.Colors
                        on ca.ColorId equals co.ColorId
                    select new CarDetailsDto
                    {
                        CarName = ca.CarName, BrandName = b.BrandName,
                        ColorName = co.ColorName, DailyPrice = ca.DailyPrice
                        
                    };
                return result.ToList();
            }
        }
    }
}