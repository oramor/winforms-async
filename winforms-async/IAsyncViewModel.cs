namespace winforms_async
{
    internal interface IAsyncViewModel
    {
        string Title { get; }
        event EventHandler? DataLoaded;
        bool IsDataLoaded { get; }
    }
}
