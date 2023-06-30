namespace winforms_async
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            showFormButton.Click += ShowFormButton_Click;
        }

        void ShowFormButton_Click(object? sender, EventArgs e)
        {
            var viewModel = new TestFormViewModel();
            var form = new TestForm() {
                DataContext = viewModel
            };
            form.ShowDialog();
        }
    }
}