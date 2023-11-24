namespace label_progress_issue
{
    internal class ProgressNotifier : Progress<ProgressInfo>
    {
        internal void ReportMessage(string message)
        {
            if (message == "Step 3")
            {
                Console.WriteLine("Step 3");
            }

            OnReport(new ProgressInfo(message));
        }
    }
}
