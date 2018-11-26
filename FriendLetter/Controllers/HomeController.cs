using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public  class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello()
    {
      return "Hello Friend!";
    }

    [Route("/goodbye")]
    public string Goodbye()
    {
      return "Goodbye friend.";
    }

    [Route("/letter")]
    public string Goodbye()
    {
      return "Our virtual postcard will go here soon!";
    }
  }
}
