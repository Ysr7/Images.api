using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories {
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {

        public ImageRepository (DbSet<Image> entity, BaseContext context)
            : base (context, entity) 
            { 
            }
    }
}