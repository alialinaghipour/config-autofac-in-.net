using Api.Contracts;

namespace Api.Services;

public interface IAccessService : ITransient
{
    bool Check();
}

public class AccessAppService : IAccessService
{
    public bool Check()
    {
        return true;
    }
}