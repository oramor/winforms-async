namespace label_progress_issue
{
    internal class LogInfo
    {
        public LogInfo(int percentage)
        {

        }

        public int? Percentage { get; private set; }

        public bool IsProgress => Percentage >= 0;
    }
}
