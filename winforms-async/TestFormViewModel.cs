namespace winforms_async
{
    internal class TestFormViewModel
    {
        public TestFormViewModel()
        {
            Title = "Loading...";
            Task.Run(() => RunLoaderAsync());
        }

        public bool IsLoaded { get; init; }
        public string Title { get; set; }

        public event EventHandler? ViewModelLoaded;
        void OnViewModelLoaded()
        {
            ViewModelLoaded?.Invoke(this, EventArgs.Empty);
        }

        async void RunLoaderAsync()
        {
            await Task.Delay(2000);
            Title = "Loaded!";
            OnViewModelLoaded();
        }
    }
}
