# <a name="using"></a> How to use?

#### The Library has 3 built-in event handlers.

 - Logging
 - Exceptions

```c# 
static void Main()
{
    MusicBrainz.Events.Logging.Instance.Call += LoggingOnCall;
    MusicBrainz.Events.Exceptions.Instance.Call += ExceptionOnCall;
}

private static void LoggingOnCall(object sender, LogEntry e)
{
    Console.WriteLine(e.ToString());
}

private static void ExceptionOnCall(object sender, EventArg e)
{
    Console.WriteLine(e.Message);
    throw e.Exception;
}
```




