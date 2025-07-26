using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using summa_backend.Models;
using summa_backend.Services;
using summa_backend.DTOs;

namespace summa_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] AuthRequest request)
    {
        var token = _authService.Authenticate(request.Username, request.Password);
        if (string.IsNullOrEmpty(token))
        {
            return Unauthorized("Invalid credentials");
        }

        return Ok(new { token });
    }

    [Authorize]
    [HttpGet("me")]
    public IActionResult Me()
    {
        var username = User.Identity?.Name;
        return Ok(new { message = $"Authenticated as {username}" });
    }
}