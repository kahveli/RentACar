using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car); // voidler için IResult
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarByBrandId(int brandId);
        IDataResult<List<Car>> GetCarByColorId(int colorId);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
    }
}