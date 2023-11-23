namespace label_progress_issue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void startProgressButton_Click(object sender, EventArgs e)
        {
            var loader = new Loader();
            loader.ProgressChanged += Loader_ProgressChanged;
            await loader.LoadAsync();
            progressLabel.Text = "Finished";
        }

        void Loader_ProgressChanged(object? sender, ProgressInfo info)
        {
            progressLabel.Text = info.Message;
        }
    }
}