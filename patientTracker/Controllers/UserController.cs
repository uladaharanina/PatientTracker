
using Microsoft.AspNetCore.Mvc;
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
        IEnumerable<User> allUsers =  await _userService.GetAll();
        return Ok(allUsers);
    }

    /*
        UPDATE USER PASSWORD
    */

    /*
        CREATE A USER
    */

    /*
        DELETE USER
    */


    /*AUTHENTICATION AND AUTHROZATION*/
}