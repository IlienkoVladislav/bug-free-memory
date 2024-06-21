using System;
using System.Collections.Generic;
using System.Text;

public class Logger
{
    private static Logger instance;
    private List<string> log;
    private Encoding encoding = Encoding.UTF8;

    private Logger()
    {
        log = new List<string>();
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    public void Log(string message)
    {
        string logEntry = $"{DateTime.Now:s}: {message}";
        log.Add(logEntry);
        Console.WriteLine(logEntry); // Вивід в консоль для демонстрації
    }

    public void PrintLog()
    {
        foreach (string entry in log)
        {
            byte[] bytes = encoding.GetBytes(entry);
            Console.WriteLine(encoding.GetString(bytes));
        }
    }
}
