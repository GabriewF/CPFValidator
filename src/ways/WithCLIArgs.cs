/*
 *
 *  GNU GENERAL PUBLIC LICENSE
 *   Version 3, 29 June 2007
 *
*/

using System;
using System.Text.RegularExpressions;

// Program
namespace CPFValidator.Ways {
  class WithCLIArgs {
    public static void Run(String[] args) {
      if (!Regex.IsMatch(args[0], @"^\d+$")) {
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
    }
  }
}