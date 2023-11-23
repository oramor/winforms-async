namespace label_progress_issue
{
    internal static class Logger
    {
        internal static void Info(string message)
        {
            LogMessageReported?.Invoke(null, new LogMessageReportedEventArgs(message));
        }

        static event EventHandler<LogMessageReportedEventArgs>? LogMessageReported;
    }
}
