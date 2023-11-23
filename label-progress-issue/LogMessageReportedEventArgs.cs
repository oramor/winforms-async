namespace label_progress_issue
{
    internal class LogMessageReportedEventArgs : EventArgs
    {
        public LogMessageReportedEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; init; }
    }
}
