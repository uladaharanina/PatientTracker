
using patientTracker.Models;

namespace patientTracker.Services;

public class UserService : IUserService
{
    public Task<User> Authenticate(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAll()
    {
        throw new NotImplementedException();
    }
}