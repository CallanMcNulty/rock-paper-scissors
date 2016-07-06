using Nancy;
using System;
using RockPaperScissorsObjects;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/game"] = _ => {
        Game g = new Game(Request.Form["player1"],Request.Form["player2"]);
        return View["result.cshtml", g.Play()];
      };
    }
  }
}
