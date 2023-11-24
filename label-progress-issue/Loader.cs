namespace label_progress_issue
{
    internal class Loader : ProgressNotifier
    {
        internal async Task LoadAsync()
        {
            ReportMessage("Step 1");
            await Task.Delay(300);

            ReportMessage("Step 2");
            await Task.Delay(300);

            ReportMessage("Step 3");
            //await Task.Delay(50);
        }
    }
}
