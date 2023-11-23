namespace label_progress_issue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            statusBarControl.SetLoggerContext(App.Logger);
            statusBarControl.RangeItems();
            App.Logger.Info("Ready");
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            await LoadAsync();
        }

        async Task LoadAsync()
        {
            var loader = new Loader();
            App.Logger.ReportProgress(loader);
            await loader.LoadAsync();
            App.Logger.Info("Finished");
        }

        void startProgressButton_Click(object sender, EventArgs e)
        {

        }
    }
}