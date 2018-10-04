using System.Threading.Tasks;
using burgershack.Models;
using burgershack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
  [Route("[controller]")]

  public class AccountController : Controller
  {
    private readonly UserRepository _repo;

    [HttpPost("login")]

    public async Task<User> Login([FromBody]UserLogin creds)
    {
      if (!ModelState.IsValid) { return null; }
      User user = _repo.Login(creds);
      if (user == null) { return null; }

    }


  }










  public AccountController(UserRepository repo)
  {
    _repo = repo;
  }



}
}


