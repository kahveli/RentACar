using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entity;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
    //    List<Car> GetCarByBrandId { get; }

        List<CarDetailsDto> GetCarDetails();
    }
}
