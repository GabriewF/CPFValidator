/*
 *
 *  GNU GENERAL PUBLIC LICENSE
 *   Version 3, 29 June 2007
 *
*/

using System;
using System.Text.RegularExpressions;

// Program
namespace CPFValidator.Ways
{
  class WithCLIArgs
  {
    public static void Run(String[] args)
    {
      // Verify if has only numbers
      if (!Regex.IsMatch(args[0], @"^\d+$"))
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
      int[] CPFArray = args[0].ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

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
      int CPFNum01 = CPFArray[0] * 10;
      int CPFNum02 = CPFArray[1] * 9;
      int CPFNum03 = CPFArray[2] * 8;
      int CPFNum04 = CPFArray[3] * 7;
      int CPFNum05 = CPFArray[4] * 6;
      int CPFNum06 = CPFArray[5] * 5;
      int CPFNum07 = CPFArray[6] * 4;
      int CPFNum08 = CPFArray[7] * 3;
      int CPFNum09 = CPFArray[8] * 2;

      // Secondary digit, calculations
      int CPF2Calc01 = CPFArray[0] * 11;
      int CPF2Calc02 = CPFArray[1] * 10;
      int CPF2Calc03 = CPFArray[2] * 9;
      int CPF2Calc04 = CPFArray[3] * 8;
      int CPF2Calc05 = CPFArray[4] * 7;
      int CPF2Calc06 = CPFArray[5] * 6;
      int CPF2Calc07 = CPFArray[6] * 5;
      int CPF2Calc08 = CPFArray[7] * 4;
      int CPF2Calc09 = CPFArray[8] * 3;
      int CPF2Calc10 = CPFArray[9] * 2;

      // Calculations
      int CPFResult = CPFNum01 + CPFNum02 + CPFNum03 + CPFNum04 + CPFNum05 + CPFNum06 + CPFNum07 + CPFNum08 + CPFNum09;
      int CPFResult2 = CPF2Calc01 + CPF2Calc02 + CPF2Calc03 + CPF2Calc04 + CPF2Calc05 + CPF2Calc06 + CPF2Calc07 + CPF2Calc08 + CPF2Calc09 + CPF2Calc10;

      // More calculations...
      int CPFRest = (CPFResult * 10) % 11;
      int CPFRest2 = (CPFResult2 * 10) % 11;

      // More verifications...
      if (CPFRest.Equals(10) || CPFRest.Equals(11)) CPFRest = 0;
      if (CPFRest2.Equals(10) || CPFRest2.Equals(11)) CPFRest2 = 0;

      // Error if the CPF is invalid
      if (CPFRest2 != CPFArray[10] && CPFRest != CPFArray[9])
      {
        // Bep Bop
        Console.Beep();
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

      // Bep Bop
      Console.Beep();
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