/*
 *
 *  GNU GENERAL PUBLIC LICENSE
 *   Version 3, 29 June 2007
 *
*/

///
using System.Text.RegularExpressions;

// With CLI Args Way
namespace CPFValidator.Ways
{
  class WithCLIArgs
  {
    public static void Run(String[] args)
    {
      // Verify if has only numbers
      if (!Regex.IsMatch(args[0], @"^\d+$"))
      {
        // Clear's the console
        Console.Clear();
        Console.WriteLine();

        // Error Title
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  ERRO");
        Console.ResetColor();
        Console.Write(" - Argumentos inválidos");
        Console.WriteLine();

        // Message of the ERROR
        Console.WriteLine();
        Console.WriteLine($"  Esperado argumento numéricos, mais o Formato não foi aceito...");
        Console.WriteLine("  Exemplo: 12345678900");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("  Saindo em 003 segundos...");
        Console.ResetColor();
        Thread.Sleep(3000);
        Console.Clear();

        // Quit
        Environment.Exit(0);
      }

      // Get the CPF
      int[] CPFArray = args[0].ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

      // Verify the CPF Length
      if (CPFArray.Length != 11)
      {
        // Clear's the console
        Console.Clear();
        Console.WriteLine();

        // Title
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  ERRO");
        Console.ResetColor();
        Console.Write(" - Argumentos inválidos");
        Console.WriteLine();

        // Message of the ERROR
        Console.WriteLine();
        Console.WriteLine($"  Esperado argumento numéricos, com 11 de comprimento, mais {CPFArray.Length} foi recebido.");
        Console.WriteLine("  Exemplo: 12345678900");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("  Saindo em 003 segundos...");
        Console.ResetColor();
        Thread.Sleep(3000);
        Console.Clear();

        // Quit
        Environment.Exit(0);
      }

      // Primary digit, calculations
      Int32 CPFDigit01 = 0;
      CPFDigit01 =+ CPFArray[0] * 10;
      CPFDigit01 =+ CPFArray[1] * 09;
      CPFDigit01 =+ CPFArray[2] * 08;
      CPFDigit01 =+ CPFArray[3] * 07;
      CPFDigit01 =+ CPFArray[4] * 06;
      CPFDigit01 =+ CPFArray[5] * 05;
      CPFDigit01 =+ CPFArray[6] * 04;
      CPFDigit01 =+ CPFArray[7] * 03;
      CPFDigit01 =+ CPFArray[8] * 02;

      // Secondary digit, calculations
      Int32 CPFDigit02 = 0;
      CPFDigit02 =+ CPFArray[0] * 11;
      CPFDigit02 =+ CPFArray[1] * 10;
      CPFDigit02 =+ CPFArray[2] * 09;
      CPFDigit02 =+ CPFArray[3] * 08;
      CPFDigit02 =+ CPFArray[4] * 07;
      CPFDigit02 =+ CPFArray[5] * 06;
      CPFDigit02 =+ CPFArray[6] * 05;
      CPFDigit02 =+ CPFArray[7] * 04;
      CPFDigit02 =+ CPFArray[8] * 03;
      CPFDigit02 =+ CPFArray[9] * 02;

      // More calculations...
      Int32 Digit01 = (CPFDigit01 * 10) % 11;
      Int32 Digit02 = (CPFDigit02 * 10) % 11;

      // More verifications...
      if (Digit01.Equals(10) || Digit01.Equals(11)) Digit01 = 0;
      if (Digit02.Equals(10) || Digit02.Equals(11)) Digit02 = 0;

      // Error if the CPF is invalid
      if (Digit02 != CPFArray[10] && Digit01 != CPFArray[9])
      {
        /// Print Invalid CPF ERROR
        Console.Clear();
        Console.WriteLine();

        // Title of the ERROR
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  ERRO");
        Console.ResetColor();
        Console.Write(" - CPF inválido");
        Console.WriteLine();

        // Message of the ERROR
        Console.WriteLine();
        Console.WriteLine("  O seu CPF não passou no algorítimo de verificação!");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("  Saindo em 003 segundos...");
        Console.ResetColor();
        Thread.Sleep(3000);
        Console.Clear();

        // Quit
        Environment.Exit(0);
      }

      // Print Successfully Checked CPF
      Console.Clear();
      Console.WriteLine();

      // Title
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("  SUCESSO");
      Console.ResetColor();
      Console.Write(" - CPF válido");
      Console.WriteLine();

      // Message of the ERROR
      Console.WriteLine();
      Console.WriteLine("  O seu CPF passou no algorítimo de verificação!");
      Console.WriteLine();

      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.Write("  Saindo em 003 segundos...");
      Console.ResetColor();
      Thread.Sleep(3000);
      Console.Clear();

      // Quit
      Environment.Exit(0);
    }
  }
}