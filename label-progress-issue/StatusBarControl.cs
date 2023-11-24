namespace label_progress_issue
{
    internal partial class StatusBarControl : StatusStrip
    {
        const int LOGGER_AREA_WIDTH = 300;

        ToolStripControlHost? _loggerWidgetHost;
        GuiLogger? _logger;

        internal StatusBarControl()
        {
            InitializeComponent();
        }

        internal void SetLoggerContext(GuiLogger logger)
        {
            /// Логгер можно назначить только один раз
            if (_logger != null)
                return;

            _logger = logger;

            LoggerWidget widget = new(_logger, "Ready");

            _loggerWidgetHost ??= new ToolStripControlHost(widget);
        }

        public void RangeItems()
        {
            Items.Clear();

            if (_loggerWidgetHost != null)
            {
                _loggerWidgetHost.Size = new Size(LOGGER_AREA_WIDTH, Height);

                Items.Add(_loggerWidgetHost);
            }
        }

        private sealed class LoggerWidget : FlowLayoutPanel
        {
            const int TEXT_OFFSET_Y = 3;
            const int TEXT_WIDTH = 400;

            ProgressNotifier? _currentNotifier;
            Label _label = new() { AutoSize = false, Size = new Size(TEXT_WIDTH, 20), AutoEllipsis = true, Padding = new Padding(0, TEXT_OFFSET_Y, 0, 0) };

            internal LoggerWidget(GuiLogger logger, string defaultMessage)
            {
                FlowDirection = FlowDirection.LeftToRight;

                Controls.Add(_label);

                logger.LogProgressReported += Logger_LogProgressReported;
                logger.LogMessageReported += Logger_LogMessageReported;

                SetMessage(defaultMessage);
            }

            void SetNotifier(ProgressNotifier notifier)
            {
                if (notifier.Equals(_currentNotifier))
                    return;

                if (_currentNotifier != null)
                {
                    _currentNotifier.ProgressChanged -= Notifier_ProgressChanged;
                }

                _currentNotifier = notifier;
                _currentNotifier.ProgressChanged += Notifier_ProgressChanged;
            }

            void SetMessage(string message)
            {
                _label.Text = message;
            }

            void Logger_LogMessageReported(object? sender, LogMessageReportedEventArgs e)
            {
                SetMessage(e.Message);
            }

            void Logger_LogProgressReported(object? sender, LogProgressReportedEventArgs e)
            {
                SetNotifier(e.Notifier);
            }

            void Notifier_ProgressChanged(object? sender, ProgressInfo info)
            {
                if (info.Message is string s)
                {
                    SetMessage(s);
                }
            }
        }
    }
}
