using Core.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using Repository.Repositories;

namespace Repository
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConfiguration _configuration;
        private readonly BaseContext _context;
        private IImageRepository _ImageRepository;

        public IImageRepository ImageRepository
        {
            get
            {
                if (_ImageRepository == null)
                    _ImageRepository = new ImageRepository(_context.Images, _context);
                return _ImageRepository;
            }
            set { _ImageRepository = value; }
        }

        public UnitOfWork(BaseContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }

        public void Commit() => _context.SaveChanges();

    }

}