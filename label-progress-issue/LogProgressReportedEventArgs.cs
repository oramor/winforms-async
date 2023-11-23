namespace label_progress_issue
{
    internal class LogProgressReportedEventArgs : EventArgs
    {
        internal LogProgressReportedEventArgs(ProgressNotifier notifier)
        {
            Notifier = notifier;
        }

        internal ProgressNotifier Notifier { get; init; }
    }
}
