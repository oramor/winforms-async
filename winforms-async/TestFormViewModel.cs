namespace winforms_async
{
    internal class TestFormViewModel
    {
        public TestFormViewModel()
        {
            Title = "Loading...";
            Task.Run(() => RunLoader());
        }

        public bool IsLoaded { get; init; }
        public string Title { get; set; }

        public event EventHandler? ViewModelLoaded;

        void RunLoader()
        {
            Task.Delay(2000).Wait();
            Title = "Loaded!";
            ViewModelLoaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
