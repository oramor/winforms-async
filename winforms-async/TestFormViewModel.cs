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

        public event EventHandler? DataLoaded;
        void OnViewModelLoaded()
        {
            DataLoaded?.Invoke(this, EventArgs.Empty);
        }

        async void RunLoaderAsync()
        {
            await Task.Delay(2000);
            Title = "Loaded!";
            OnViewModelLoaded();
        }
    }
}
