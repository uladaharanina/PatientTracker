
using Microsoft.AspNetCore.Mvc;
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


    /*
        DELETE USER
    */


    /*AUTHENTICATION AND AUTHROZATION*/
}