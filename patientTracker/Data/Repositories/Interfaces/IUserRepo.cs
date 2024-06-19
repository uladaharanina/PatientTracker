namespace patientTracker.Data.Repositories;

using System.Runtime.CompilerServices;
using patientTracker.Models;

public interface IUserRepo{

    //Get all users
    public Task<List<User>> GetAllUsers();

    //Create a user
    public Task<User> CreateUser(User user);

    //Get user by id
    public Task<User> GetUserById(int id);

    //Authenticate user
    public Task<User> AuthenticateUser(string username, string password);

    //Update user password
    public Task<User> UpdateUserPassword(int userId, string newPassword);

    //Delete user
    public void DeleteUser(User user);


}