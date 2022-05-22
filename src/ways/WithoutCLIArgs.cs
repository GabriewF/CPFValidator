/*
 *
 *  GNU GENERAL PUBLIC LICENSE
 *   Version 3, 29 June 2007
 *
*/

///
using System.Text.RegularExpressions;

// Program
namespace CPFValidator.Ways
{
  class WithoutCLIArgs
  {
    public static void Run()
    {
      // What's is the CPF?
      Console.Clear();
      Console.WriteLine();

      // Title
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("  BEM VINDO");
      Console.ResetColor();
      Console.Write(" - Ao verificador de CPF");
      Console.WriteLine();

      // Message of the ERROR
      Console.WriteLine();
      Console.WriteLine("  Digite seu CPF para verifica-lo");
      Console.WriteLine();
      Console.Write("  >>> ");

      var CPFInput = Console.ReadLine();

      // Verify if has only numbers
      if (!Regex.IsMatch($"{CPFInput}", @"^\d+$"))
      {
        // Bep Bop
        Console.Beep();
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
      int[] CPFArray = $"{CPFInput}".ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

      // CPF Length verify
      if (CPFArray.Length != 11)
      {
        // Bep Bop
        Console.Beep();
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
      Int32 CPFResult01 = 0;
      CPFResult01 += CPFArray[0] * 10;
      CPFResult01 += CPFArray[1] * 09;
      CPFResult01 += CPFArray[2] * 08;
      CPFResult01 += CPFArray[3] * 07;
      CPFResult01 += CPFArray[4] * 06;
      CPFResult01 += CPFArray[5] * 05;
      CPFResult01 += CPFArray[6] * 04;
      CPFResult01 += CPFArray[7] * 03;
      CPFResult01 += CPFArray[8] * 02;

      // Secondary digit, calculations
      Int32 CPFResult02 = 0;
      CPFResult02 += CPFArray[0] * 11;
      CPFResult02 += CPFArray[1] * 10;
      CPFResult02 += CPFArray[2] * 09;
      CPFResult02 += CPFArray[3] * 08;
      CPFResult02 += CPFArray[4] * 07;
      CPFResult02 += CPFArray[5] * 06;
      CPFResult02 += CPFArray[6] * 05;
      CPFResult02 += CPFArray[7] * 04;
      CPFResult02 += CPFArray[8] * 03;
      CPFResult02 += CPFArray[9] * 02;

      // More calculations...
      Int32 Digit01 = (CPFResult01 * 10) % 11;
      Int32 Digit02 = (CPFResult02 * 10) % 11;

      // More verifications...
      if (Digit01.Equals(10) || Digit01.Equals(11)) Digit01 = 0;
      if (Digit02.Equals(10) || Digit02.Equals(11)) Digit02 = 0;

      // Error if the CPF is invalid
      if (Digit02 != CPFArray[10] && Digit01 != CPFArray[9])
      {
        /// Print Invalid CPF ERROR
        Console.Clear();
        Console.WriteLine();

        // Title
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