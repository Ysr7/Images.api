namespace Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IImageRepository ImageRepository { get; set; }
        void Commit();
    }
}