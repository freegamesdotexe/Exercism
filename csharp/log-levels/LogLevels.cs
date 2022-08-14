using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        logLine = logLine.Replace("[INFO]: ", "");
        logLine = logLine.Replace("[WARNING]: ", "");
        logLine = logLine.Replace("[ERROR]: ", "");
        logLine = logLine.TrimStart();
        logLine = logLine.TrimEnd();

        return logLine;
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains("[INFO]: "))
        {
            return "info";
        }
        else if (logLine.Contains("[WARNING]: "))
        {
            return "warning";
        }
        else if (logLine.Contains("[ERROR]: "))
        {
            return "error";
        }

        return "";
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + $" ({LogLevel(logLine)})";
    }
}
