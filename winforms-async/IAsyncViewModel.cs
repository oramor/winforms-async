namespace winforms_async
{
    internal interface IAsyncViewModel
    {
        string Title { get; }
        event EventHandler<DataLoadStatusChangedEventArgs> DataLoadStatusChanged;
        DataLoadStatusEnum DataLoadStatus { get; }
        bool IsDataLoaded { get; }
    }
}
