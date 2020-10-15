using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IImageService
    {
        Image Consult(int idImage);
        IEnumerable<Image> GetAll();
        Task<int> RegisterAsync(string descripion, string length, string picture, string title);
        Task UpdateAsync(int idImage, string descripion, string length, string picture, string title);
        void Delete(int idImage);
    }
}