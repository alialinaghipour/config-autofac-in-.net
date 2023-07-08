using Api.Contracts;

namespace Api.Services;

public interface IUnitOfWork : IScope
{
    void Save();
}

public class UnitOfWork : IUnitOfWork
{
    public void Save()
    {
        throw new NotImplementedException();
    }
}