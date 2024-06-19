
using patientTracker.Models;
using patientTracker.Data.Repositories;

namespace patientTracker.Services;

public class UserService : IUserService
{
    public IUserRepo _userRepo;

    public UserService(IUserRepo userRepo)
    {
        _userRepo = userRepo;
    }
    public async Task<User> Authenticate(string username, string password)
    {
       return await _userRepo.AuthenticateUser(username, password);
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        return await _userRepo.GetAllUsers();
    }
}