namespace Net8SDKWithNet48Added;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
#if NET48
        MainNet48();
#else
        MainNet8();
#endif
    }


#if NET48

    private static void MainNet48()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new XtraForm1());
    }

#else

    private static void MainNet8()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new XtraForm1());
    }

#endif
}