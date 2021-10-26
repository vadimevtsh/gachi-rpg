using System;
using Entities;

// TODO: Implement main methods
namespace Game
{
  class GameManager
  {
    private static Player _player;
    private static void Init() {
      // _player = new Player(Console.ReadLine(), 1, 1, 1);
    }
    private static void Update() {

    }
    private static void Main() {
      Init();
      while (true)
      {
        Update();
      }
    }
  }
}
