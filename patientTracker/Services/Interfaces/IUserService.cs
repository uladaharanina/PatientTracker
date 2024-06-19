using patientTracker.DTO;
using patientTracker.Models;
namespace patientTracker.Services;

public interface IUserService{

    Task<User> Authenticate(string username, string password);
    Task<UserDTO> CreateUser(CreateUserDTO userDTO);
    Task<IEnumerable<UserDTO>> GetAll();
}