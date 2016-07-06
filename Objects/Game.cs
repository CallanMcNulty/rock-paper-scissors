using System;

namespace RockPaperScissorsObjects
{
  public class Game
  {
    private string[] _choices = new string[2];
    public Game(string p1, string p2)
    {
      _choices[0] = p1;
      _choices[1] = p2;
    }
    public string Play()
    {
      int workingIndex = Array.IndexOf(_choices, "Rock");
      int otherIndex = Math.Abs(workingIndex-1);
      if(workingIndex>-1)
      {
        if(_choices[otherIndex] == "Paper")
        {
          return "Player " + (otherIndex+1).ToString();
        }
        else if(_choices[otherIndex] == "Scissors")
        {
          return "Player " + (workingIndex+1).ToString();
        }
      }
      workingIndex = Array.IndexOf(_choices, "Paper");
      otherIndex = Math.Abs(workingIndex-1);
      if(workingIndex>-1)
      {
        if(_choices[otherIndex] == "Scissors")
        {
          return "Player " + (otherIndex+1).ToString();
        }
      }
      return "Draw";
    }
    public void SetChoices(string p1, string p2)
    {
      _choices[0] = p1;
      _choices[1] = p2;
    }
  }
}
