namespace Application.RepositoryInterfaces;

public interface IUnitOfWork
{
    Task SaveChanges(CancellationToken cancellationToken);
}
