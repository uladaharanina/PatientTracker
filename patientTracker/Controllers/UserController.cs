
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using patientTracker.DTO;
using patientTracker.Models;
using patientTracker.Services;


[ApiController]
[Route("api/[controller]")]
public class UserController : Controller{

    public IUserService _userService;

    public UserController(IUserService userService){
        _userService = userService;
    }
    /*
        GET ALL USERS
    */
    [HttpGet]
    public async Task<IActionResult>  GetAllUsers(){
        IEnumerable<UserDTO> allUsers =  await _userService.GetAll();
        return Ok(allUsers);
    }

    /*
        CREATE A USER
    */
    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO createdUserDTO){
        UserDTO user = await _userService.CreateUser(createdUserDTO);
        return Ok("Created User: " + user.Username);
    }


    /*
        UPDATE USER PASSWORD
    */
    [HttpPatch]
    [Route("UpdatePassword")]
    public async Task<IActionResult> UpdateUserPassword(int userId, string newPassword){

        try{
              UserDTO user = await _userService.UpdateUserPassword(userId, newPassword);
            if(user != null){
                return Ok("Password updated for: " + user.Username);
            }
            else{
                return NotFound("User does not exist");
            }
        }
        catch(Exception ex){
            return BadRequest(ex.Message);
        }
      
    }


    /*
        DELETE USER
    */


    /*AUTHENTICATION AND AUTHROZATION*/
}