
using patientTracker.Models;
using patientTracker.Data.Repositories;
using patientTracker.DTO;

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

     public async Task<UserDTO> CreateUser(CreateUserDTO userDTO){
        //Validate Password and username
        var user = new User{
            Username = userDTO.Username,
            Password =  userDTO.Password,
            RoleId = userDTO.RoleId,
             DateCreated = DateTime.UtcNow
        };
        User newUser = await _userRepo.CreateUser(user);
        return new UserDTO{
            Username = newUser.Username,
            RoleId = newUser.RoleId
        }; 
     }


    public async Task<IEnumerable<UserDTO>> GetAll()
    {   
        IEnumerable<User> users = await _userRepo.GetAllUsers();
        return users.Select(u => new UserDTO{
            Username = u.Username,
            RoleId = u.RoleId
        });
    }

    
}