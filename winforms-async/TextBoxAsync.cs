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
                if (ctx.IsDataLoaded)
                {
                    SetReady();
                }
                else
                {
                    ctx.DataLoaded += DataContext_DataLoaded;
                }
            }

            void SetReady()
            {
                Text = string.Empty;
                Enabled = true;
            }

            void DataContext_DataLoaded(object? sender, EventArgs e)
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
