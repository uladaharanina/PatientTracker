namespace patientTracker.Services;

using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using patientTracker.Models;
public class JWTService{

    private readonly IConfiguration _config;
    private readonly string secretKey;

    public JWTService(IConfiguration config){
        _config = config;
        secretKey = _config["JWT"];
    }


    //Create token
    public string generateToken(User user){
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        var headers = new JwtHeader(credentials);

        var payload = new JwtPayload{
            { "id", user.UserId },
            { "username", user.Username },
            { "role", user.RoleId }
        };

        var securityToken = new JwtSecurityToken(headers, payload);
        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}