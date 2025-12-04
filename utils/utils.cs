using System;
using System.Threading;

namespace utils{
public static class ConsoleUtils
{
    public static void Refresh()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }

    public static void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public static void ClearLines(int linesToClear)
{
    int startLine = Console.CursorTop - linesToClear;
    if (startLine < 0) startLine = 0;

    // Move cursor to the first line to clear
    Console.SetCursorPosition(0, startLine);

    // Clear each line
    for (int i = 0; i < linesToClear; i++)
    {
        Console.Write(new string(' ', Console.WindowWidth));
    }

    // Move cursor back to the top cleared line
    Console.SetCursorPosition(0, startLine);
}

    
}
}