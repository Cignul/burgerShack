using System;
using System.ComponentModel.DataAnnotations;

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


  }
}