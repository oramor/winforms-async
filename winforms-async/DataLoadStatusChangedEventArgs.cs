namespace winforms_async
{
    internal class DataLoadStatusChangedEventArgs : EventArgs
    {
        public DataLoadStatusChangedEventArgs(DataLoadStatusEnum status)
        {
            Status = status;
        }

        public DataLoadStatusEnum Status { get; init; }
    }
}
