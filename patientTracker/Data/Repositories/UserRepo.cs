namespace patientTracker.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using  patientTracker.Models;

public class UserRepo : IUserRepo{

    public readonly PatientTrackerContext _context;

 //Get all users
    public async Task<List<User>> GetAllUsers(){
        return await _context.Users.ToListAsync();
    }

    //Create a user
    public async Task<User> CreateUser(User user){
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    //Get user by id
    public async Task<User> GetUserById(int id){
        return await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
    }

    //Authenticate user
    public async Task<bool> AuthenticateUser(string username, string password){

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password ==  password);
        if(user!= null){
            return true;
        }
            return false;
    }

    //Update user password
    public async Task<User> UpdateUserPassword(int userId, string newPassword){
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
        if(user != null ){
            user.Password =  newPassword;
            await _context.SaveChangesAsync();
            return user;

        }
        return null;
    }

    //Delete user
    public async void DeleteUser(User user){
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }


}