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

            var loader = new Loader();
            App.Logger.ReportProgress(loader);
            await loader.LoadAsync();
            App.Logger.Info("Finished");
        }

        async void startProgressButton_Click(object sender, EventArgs e)
        {
            progressLabel.Text = "Step 1";
            await Task.Delay(200);

            progressLabel.Text = "Step 2";
            await Task.Delay(200);

            progressLabel.Text = "Step 3";
            //await Task.Delay(200);

            progressLabel.Text = "Finished";
        }
    }
}