namespace winforms_async
{
    internal class TestFormViewModel : IAsyncViewModel
    {
        public TestFormViewModel()
        {
            Title = "Loading...";
            Task.Run(() => RunLoaderAsync());

        }

        public bool IsDataLoaded { get; init; }
        public string Title { get; set; }
        public DataLoadStatusEnum DataLoadStatus { get; set; } = DataLoadStatusEnum.NotLoaded;

        public event EventHandler<DataLoadStatusChangedEventArgs>? DataLoadStatusChanged;
        void OnDataLoadStatusChanged(DataLoadStatusEnum status)
        {
            DataLoadStatus = status;
            DataLoadStatusChanged?.Invoke(this, new DataLoadStatusChangedEventArgs(status));
        }

        async void RunLoaderAsync()
        {
            try
            {
                OnDataLoadStatusChanged(DataLoadStatusEnum.OnLoading);
                await Task.Delay(2000);
                //throw new Exception();
                Title = "Loaded!";
                OnDataLoadStatusChanged(DataLoadStatusEnum.Loaded);
            }
            catch
            {
                OnDataLoadStatusChanged(DataLoadStatusEnum.Error);
            }
        }
    }
}
