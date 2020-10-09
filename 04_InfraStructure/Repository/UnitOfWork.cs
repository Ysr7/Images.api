using Core.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace Repository {

    public class UnitOfWork : IUnitOfWork {
        private readonly IConfiguration _configuration;
        private readonly BaseContext _context;
        public UnitOfWork(BaseContext context, IConfiguration configuration) 
        {
            _configuration = configuration;
            _context = context;
        }

         public void Commit() => _context.SaveChanges();

    }

}