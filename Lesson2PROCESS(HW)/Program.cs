using System.Diagnostics;
using static System.Console;

while (true)
{
    Clear();

    WriteLine("========================================");
    WriteLine("          TORMAZ-GAME-EDITION");
    WriteLine("========================================");
    WriteLine();

    WriteLine("        ╔══════════════════╗");
    WriteLine("        ║    WAIT FOR IT   ║");
    WriteLine("        ╚══════════════════╝");
    WriteLine();

    WriteLine("             DON'T PRESS!");
    WriteLine();

    Random random = new Random();

    Thread.Sleep(random.Next(2000, 5000));

    Clear();

    WriteLine("========================================");
    WriteLine("          TORMAZ-GAME-EDITION");
    WriteLine("========================================");
    WriteLine();

    WriteLine("        ╔══════════════════╗");
    WriteLine("        ║      PRESS!      ║");
    WriteLine("        ╚══════════════════╝");
    WriteLine();

    Stopwatch stopwatch = Stopwatch.StartNew();

    ReadKey(true);

    stopwatch.Stop();

    WriteLine();
    WriteLine($"       Your reaction: {stopwatch.ElapsedMilliseconds} ms");

    WriteLine();

    WriteLine("        ╔══════════════════╗");

    if (stopwatch.ElapsedMilliseconds < 300)
    {
        WriteLine("        ║     YOU MADE IT! ║");
    }
    else
    {
        WriteLine("        ║     TOO SLOW! :(  ║");
    }

    WriteLine("        ╚══════════════════╝");

    WriteLine("Press 0 to exit or another key to play again...");
    var key = ReadKey(true);
    if (key.KeyChar == '0') break;
}