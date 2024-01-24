namespace MahalCoffee.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        IBaristaRepository Barista { get; }
        IReviewRepository Review { get; }
        Task SaveAsync();
    }
}