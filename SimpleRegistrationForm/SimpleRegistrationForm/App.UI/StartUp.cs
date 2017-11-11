namespace UI
{
    using System;
    using System.Threading.Tasks;
    using Zebble;

    public partial class StartUp : Zebble.StartUp
    {
        public override async Task Run()
        {
            ApplicationName = "SimpleRegistrationForm";

            await InstallIfNeeded();

            CssStyles.LoadAll();

            Device.App.ReceivedMemoryWarning += CleanUpMemory;

            LoadFirstPage().RunInParallel();
        }

        void CleanUpMemory()
        {
            // Note: Before raising this event, Zebble will have already done the following:            
            //         - Display an output log message
            //         - Dispose navigation cache
            //         - Force Garbage collection

            // TODO: If applicable, you can also remove any custom data that you have cached in memory.
            // Tip: You can detect potential memory leaks by using a tool such as DotMemory from Jet Brains.
        }

        public static Task LoadFirstPage() => Nav.Go(new Pages.Page1());
    }
}