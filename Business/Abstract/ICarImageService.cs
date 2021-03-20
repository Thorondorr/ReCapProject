using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFileCollection filess, int carId);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFileCollection filess, int carId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetCarPictureWithCarId(CarImage carImage);
        //IResult StoreImageInResorceFile(string Path);
        //IResult GenerateGUID(string stringValue);
    }
}
