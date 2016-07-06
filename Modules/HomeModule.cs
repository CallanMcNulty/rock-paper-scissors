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
        string p1 = Request.Form["player1"];
        string p2 = Request.Form["player2"];
        string[] choices = {"Rock", "Paper", "Scissors"};
        Random rnd = new Random();
        if(p1=="Random")
        {
          p1 = choices[rnd.Next(0, 3)];
        }
        if(p2=="Random")
        {
          p2 = choices[rnd.Next(0, 3)];
        }
        Game g = new Game(p1,p2);
        return View["result.cshtml", g];
      };
    }
  }
}
