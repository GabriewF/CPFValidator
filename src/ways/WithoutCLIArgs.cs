/*
 *
 *  GNU GENERAL PUBLIC LICENSE
 *   Version 3, 29 June 2007
 *
*/

// Program
namespace CPFValidator.Ways {
  class WithoutCLIArgs {
    public static void Run() {
      // Log
      Console.WriteLine();
      Console.WriteLine("  Sem argumentos CLI!");
      Console.WriteLine();

      // Exit
      Environment.Exit(0);
    }
  }
}