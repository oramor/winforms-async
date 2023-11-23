namespace label_progress_issue
{
    internal class GuiLogger
    {
        internal void Info(string message)
        {
            LogMessageReported?.Invoke(this, new LogMessageReportedEventArgs(message));
        }

        internal virtual void ReportProgress(ProgressNotifier notifier)
        {
            OnLogProgressReported(new LogProgressReportedEventArgs(notifier));
        }

        internal event EventHandler<LogMessageReportedEventArgs>? LogMessageReported;

        public event EventHandler<LogProgressReportedEventArgs>? LogProgressReported;
        protected void OnLogProgressReported(LogProgressReportedEventArgs e)
        {
            LogProgressReported?.Invoke(this, e);
        }
    }
}
