﻿namespace winforms_async
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

            if (DataContext is TestFormViewModel ctx)
            {
                if (ctx.IsLoaded)
                {
                    Text = ctx.Title;
                }
                else
                {
                    ctx.ViewModelLoaded += DataContext_Loaded;
                }
            }
        }

        void DataContext_Loaded(object? sender, EventArgs e)
        {
            if (DataContext is TestFormViewModel ctx)
            {
                Text = ctx.Title;
            }
        }
    }
}
