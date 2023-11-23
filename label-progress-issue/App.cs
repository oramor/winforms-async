namespace label_progress_issue
{
    internal class App
    {
        static App()
        {
            Logger = new GuiLogger();
        }

        internal static GuiLogger Logger { get; }
    }
}
