namespace label_progress_issue
{
    internal class ProgressNotifier : Progress<ProgressInfo>
    {
        internal void ReportMessage(string message)
        {
            OnReport(new ProgressInfo(message));
        }
    }
}
