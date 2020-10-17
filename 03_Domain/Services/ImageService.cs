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
           _unitOfWork.ImageRepository.FirstOrDefault(item => item.Id == idImage)
           ?? throw new ArgumentException("Imagem não encontrada");

        public IEnumerable<Image> GetAll() =>
          _unitOfWork.ImageRepository.GetAll()
          ?? throw new ArgumentNullException("Não possui nenhuma imagem");

        public async Task<int> RegisterAsync(string descripion, string length, string picture, string title)
        {

            Image image = new Image
            {
                Descripion = descripion,
                Length = length,
                Picture = picture,
                Title = title,
                Date = DateTime.Now
            };

            image.Validate();

            await _unitOfWork.ImageRepository.AddAsync(image);
            _unitOfWork.Commit();

            return image.Id;
        }

        public async Task UpdateAsync(int idImage, string descripion, string length, string picture, string title)
        {
            Image image = Consult(idImage);

            image.Descripion = descripion;
            image.Length = length;
            image.Picture = picture;
            image.Title = title;

            image.Validate();

            await _unitOfWork.ImageRepository.UpdateAsync(image);
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