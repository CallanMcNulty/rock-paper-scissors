using RockPaperScissorsObjects;
using Xunit;

namespace RockPaperScissors
{
  public class GameTests
  {
    [Fact]
    public void Play_RockRock_Draw()
    {
      Game g = new Game("Rock", "Rock");
      Assert.Equal("Draw", g.Play());
    }
    [Fact]
    public void Play_RockPaper_P2()
    {
      Game g = new Game("Rock", "Paper");
      Assert.Equal("Player 2", g.Play());
    }
    [Fact]
    public void Play_PaperRock_P1()
    {
      Game g = new Game("Paper", "Rock");
      Assert.Equal("Player 1", g.Play());
    }
    [Fact]
    public void Play_PaperScissors_P2()
    {
      Game g = new Game("Paper", "Scissors");
      Assert.Equal("Player 2", g.Play());
    }
    [Fact]
    public void Play_ScissorsPaper_P1()
    {
      Game g = new Game("Scissors", "Paper");
      Assert.Equal("Player 1", g.Play());
    }
    [Fact]
    public void Play_RockScissors_P1()
    {
      Game g = new Game("Rock", "Scissors");
      Assert.Equal("Player 1", g.Play());
    }
    [Fact]
    public void Play_ScissorsRock_P2()
    {
      Game g = new Game("Scissors", "Rock");
      Assert.Equal("Player 2", g.Play());
    }
  }
}
