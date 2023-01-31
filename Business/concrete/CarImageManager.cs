using Business.Abstract;
using Business.Contans;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;
        private IFileHelper _fileHelper;
        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageLimitExceded(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            var resultOfUpload = _fileHelper.Upload(file, PathConstants.ImagesPath);
            if (!resultOfUpload.Success)
            {
                return resultOfUpload;
            }

            carImage.ImagePath = resultOfUpload.Message;
            carImage.Date = DateTime.Now;
            carImage.ImageId =1;

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            var result = _fileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            if (!result.Success)
            {
                return result;
            }
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckIfCarImageLimitExceded(carId));
            if (!result.Success)
            {
                return new SuccessDataResult<List<CarImage>>(GetDefaultCarImage(carId).Data);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }


        public IDataResult<CarImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.ImageId == imageId));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var result = _fileHelper.Update(file, PathConstants.ImagesPath + carImage.ImagePath, PathConstants.ImagesPath);
            if (!result.Success)
            {
                return result;
            }
            carImage.Date = DateTime.Now;
            carImage.ImagePath = result.Message;

            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }
        private IResult CheckIfCarImageLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceded);
            }
            return new SuccessResult();
        }
        private IDataResult<List<CarImage>> GetDefaultCarImage(int carId)
        {
            List<CarImage> carImages = new List<CarImage>();

            carImages.Add(new CarImage
            {
                CarId = carId,
                Date = DateTime.Now,
                ImagePath = "wwwroot\\Images\\Default\\DefaultImage.jpg"
            });
            return new SuccessDataResult<List<CarImage>>(carImages);
        }

    }
}
