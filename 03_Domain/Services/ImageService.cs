using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces.Repositories;

namespace Services
{
    public class ImageService : IImageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ImageService(
            IUnitOfWork unitOfWork
        )
        {
            _unitOfWork = unitOfWork;
        }

        public Image Consult(int idImage) =>
           _unitOfWork.ImageRepository.FirstOrDefault(item => item.Id == idImage);

        public IEnumerable<Image> GetAll() =>
          _unitOfWork.ImageRepository.GetAll();

        public async Task<int> RegisterAsync(string descripion, int? length, string picture) 
        {
            if (!length.HasValue)
                throw new ArgumentException("Tamaho é obrigatório");

            var image = new Image {
                Descripion = descripion,
                Length = length.Value,
                Picture = picture,
                Date = DateTime.Now
            };

            await _unitOfWork.ImageRepository.AddAsync(image);
            _unitOfWork.Commit();

            return image.Id;
        }

         public async Task UpdateAsync(int idImage, string descripion, int? length, string picture) 
        {
            Image image = Consult(idImage);

            image.Descripion = descripion;
            image.Length = length.Value;
            image.Picture = picture;

            await  _unitOfWork.ImageRepository.UpdateAsync(image);
            _unitOfWork.Commit();
        }

        public void Delete(int idImage) 
        {
            Image image = Consult(idImage);
            _unitOfWork.ImageRepository.Delete(image);
            _unitOfWork.Commit();
        }
    }
}