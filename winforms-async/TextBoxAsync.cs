namespace winforms_async
{
    public partial class TextBoxAsync : TextBox
    {
        public TextBoxAsync()
        {
            InitializeComponent();
            Enabled = false;
            Text = "Loading...";
        }

        protected override void OnDataContextChanged(EventArgs e)
        {
            base.OnDataContextChanged(e);

            if (DataContext is IAsyncViewModel ctx)
            {
                if (ctx.IsLoaded)
                {
                    SetReady();
                }
                else
                {
                    ctx.ViewModelLoaded += DataContext_Loaded;
                }
            }

            void SetReady()
            {
                Text = string.Empty;
                Enabled = true;
            }

            void DataContext_Loaded(object? sender, EventArgs e)
            {
                if (DataContext is TestFormViewModel ctx)
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(() => SetReady());
                    }
                    else
                    {
                        Text = ctx.Title;
                    }
                }
            }
        }
    }
}
