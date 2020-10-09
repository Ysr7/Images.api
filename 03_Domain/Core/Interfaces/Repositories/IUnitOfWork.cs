namespace Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}