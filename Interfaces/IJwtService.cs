using ApplicationDomain;

namespace Interfaces
{
    public interface IJwtService
    {
        string GetJwtToken(User user);
    }
}
