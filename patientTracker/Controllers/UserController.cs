
using Microsoft.AspNetCore.Mvc;

[Controller]
[Route("/api/[controllerName]")]
public class UserController : Controller{
    /*
        GET ALL USERS
    */
    [HttpGet]
    public Task<IActionResult> GetAllUsers(){

        //Check authorization

        //Return all users
        UserService userService = new UserService();
    }

    /*
        UPDATE USER PASSWORD
    */

    /*
        DELETE USER
    */


    /*AUTHENTICATION AND AUTHROZATION*/
}