/*
 *
 *  GNU GENERAL PUBLIC LICENSE
 *   Version 3, 29 June 2007
 *
*/

// Program
namespace CPFValidator {
  class Program {
    static void Main(String[] args) {
      if (args.Length <= 0) {
        CPFValidator.Ways.WithoutCLIArgs.Run();
      } else if (args.Length >= 1) {
        CPFValidator.Ways.WithCLIArgs.Run(args);
      }
    }
  }
}