namespace CPFValidator.Error {
  class NoArgs {
    public static void Message(int length) {
      if (length <= 0) {
        // Bep Bop
        Console.Beep();
        Console.Clear();
        Console.WriteLine();
        
        // Title
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  ERRO");
        Console.ResetColor();
        Console.Write(" - Argumentos inesperados");
        Console.WriteLine();

        // Message of the ERROR
        Console.WriteLine();
        Console.WriteLine($"  Esperado um argumento, mais {Convert.ToString(length)} foram recebido.");
        Console.WriteLine("  Exemplo: 123.456.789-00");
        Console.WriteLine();

        // Quit
        Environment.Exit(0);
      }
    }
  }
}