using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IImageService
    {
        Image Consult(int idImage);
        IEnumerable<Image> GetAll();
        Task<int> RegisterAsync(string descripion, int? length, string picture);
        Task UpdateAsync(int idImage, string descripion, int? length, string picture);
        void Delete(int idImage);
    }
}