using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace burgershack.Models
{

  //Helper method
  public class UserLogin
  {
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
  }
  public class UserRegistration //helper model
  {
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

  }
  public class User
  {

    public String Id { get; set; }

    public bool Active { get; set; }
    [Required]
    public string Username { get; set; }

    [Required]

    internal string Hash { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; }
    public ClaimsPrincipal _principal { get; private set; }

    internal void SetClaims()
    {
      var claims = new List<Claim>{
        new Claim(ClaimTypes.Email, Email),
        new Claim(ClaimTypes.Name,Id) //req.session.uid = id
      };
      var userIdentity = new ClaimsIdentity(claims, "login");
      _principal = new ClaimsPrincipal(userIdentity);
    }
  }
}