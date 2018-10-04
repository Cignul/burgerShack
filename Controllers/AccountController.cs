using burgershack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
  [Route("[controller]")]

  public class AccountController : Controller
  {
    private readonly UserRepository _repo;

    [HttpPost("login")]

    public async











    public AccountController(UserRepository repo)
    {
      _repo = repo;
    }



  }
}


