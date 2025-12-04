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

    
}
}