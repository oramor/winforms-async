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
                    SetLoaded();
                }

                ctx.DataLoadStatusChanged += DataContext_DataLoadStatusChanged;
            }

            void SetLoaded()
            {
                if (InvokeRequired)
                {
                    Invoke(() => {
                        Text = string.Empty;
                        Enabled = true;
                    });
                }
            }

            void SetError()
            {
                if (InvokeRequired)
                {
                    Invoke(() => {
                        Text = "<Error>";
                        Enabled = false;
                    });
                }
            }

            void SetLoading()
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(() => {
                        Text = "Loading...";
                        Enabled = false;
                    });
                }
            }

            void DataContext_DataLoadStatusChanged(object? sender, DataLoadStatusChangedEventArgs e)
            {
                if (DataContext is TestFormViewModel ctx)
                {
                    switch (e.Status)
                    {
                        case DataLoadStatusEnum.OnLoading:
                            {
                                SetLoading();
                                break;
                            }
                        case DataLoadStatusEnum.Loaded:
                            {
                                SetLoaded();
                                break;
                            }
                        case DataLoadStatusEnum.Error:
                            {
                                SetError();
                                break;
                            }
                    }
                }
            }
        }
    }
}
