using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthController(TokenService ts) => _tokenService = ts;

    [HttpPost("login")]
    public IActionResult Login(LoginRequest login)
    {
        if (login.Usuario != "admin" || login.Senha != "123456")
            return Unauthorized();

        var token = _tokenService.GerarToken(login.Usuario);
        return Ok(new { token });
    }
}