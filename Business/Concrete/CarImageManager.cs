using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Core.Helpers;
using System.Linq;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {      
        ICarImagesDal _ICarImagesDal;
        IHelper _Ihelper;
        

        public CarImageManager(ICarImagesDal carImagesDal,IHelper helper)
        {
            _ICarImagesDal = carImagesDal;
            _Ihelper = helper;
        }
        public IResult Add(IFormFileCollection filess,int carId)
        {
          if(CheckCarImageCount(carId).Succes)
            {
                CarImage carImage = new CarImage();

                var result = _Ihelper.CopyImageToFile(filess);

                _ICarImagesDal.Add(new CarImage
                {
                    CarId = carId,
                    Date = DateTime.Now,
                    ImagesPath = result.Data
                });

                return new SuccesResutl("Resim Kopyalandı.");
            }
            return new ErrorResult(CheckCarImageCount(carId).Message);
           
        }
     
        public IResult Delete(CarImage carImage)
        {
            
            if (_Ihelper.Delete(carImage.ImagesPath).Succes)
            {
                _ICarImagesDal.Delete(carImage);
                return new SuccesResutl("Başarı ile sonuçlandı.");
            }
            else
            {
                return new ErrorResult("Başaramadın kirmizi şortli.");
            }                                 
        }

        public IResult GetAll(CarImage carImage)
        {
            
            throw new NotImplementedException();
        }
        public IDataResult<List<CarImage>> GetCarPictureWithCarId(CarImage carImage)
        {
            
            var carImages = _ICarImagesDal.GetAll(p => p.CarId == carImage.CarId);
            if (carImages.Count >= 1)
            {
                return new SuccesDataResult<List<CarImage>>(carImages, "Resimler sıralandı");
            }
            else if (carImages.Count == 0 && carImage.CarId != null)
            {

                var path = Path.Combine("C:\\Users\\Fahrican\\source\\repos\\ArabaKiralamaRecap\\ArabaKiralama\\WebAPI\\wwwroot", "demoImages") + $@"\{"5ac35521ae784a0c2cce2c83"}";
                carImage.ImagesPath = @"demoImages\5ac35521ae784a0c2cce2c83";
                List<CarImage> carImgs = new List<CarImage> { carImage };
                return new SuccesDataResult<List<CarImage>>(carImgs, "Default resim getirildi."); ;
            }
            return new SuccesDataResult<List<CarImage>>("Resimler getirelemedi");
                        
        }

        public IResult Update(IFormFileCollection filess, int carId)
        {
            var result = GetCarImageByCarId(carId);
            _Ihelper.Update(filess, result.Data.ImagesPath);
            return new SuccesResutl("Resim Güncellendi.");
        }

        public IDataResult<CarImage> GetCarImageByCarId(int carId)
        {
            return new SuccesDataResult<CarImage>(_ICarImagesDal.Get(cı => cı.CarId == carId));
        }
       
        //İş kodları
        private IResult StoreImageInResorceFile(string Path)
        {
            throw new NotImplementedException();//resimleri GUID id ile resorce klasörüne kayıt edicek
        }

        private IResult GenerateGUID()
        {
            string NewGUID = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
            return new SuccesDataResult<string>(NewGUID, "GUID üretildi.");
            
        }

        private IResult CheckCarImageCount(int carId)
        {
            var result = _ICarImagesDal.GetAll(p => p.CarId == carId).Count;
            if (result < 5)
            {
                return new SuccesResutl();
            }
            return new ErrorResult("5 Taneden Fazla Resim yüklenemez.");
        }

        
    }
}
