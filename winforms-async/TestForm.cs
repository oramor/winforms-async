namespace winforms_async
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        protected override void OnDataContextChanged(EventArgs e)
        {
            base.OnDataContextChanged(e);

            if (DataContext is IAsyncViewModel ctx)
            {
                if (ctx.IsDataLoaded)
                {
                    Text = ctx.Title;
                }
                else
                {
                    ctx.DataLoaded += DataContext_DataLoaded;
                }
            }
        }

        void DataContext_DataLoaded(object? sender, EventArgs e)
        {
            if (DataContext is TestFormViewModel ctx)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(() => Text = ctx.Title);
                }
                else
                {
                    Text = ctx.Title;
                }
            }
        }
    }
}
