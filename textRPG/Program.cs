using System;

namespace textRPG {
  class Program {
    static void Main(string[] args) {
      Player player = new Knight(100, 10);
      Console.WriteLine(player.GetType());
    }
  }
}