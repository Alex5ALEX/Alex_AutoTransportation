using Auto_TransportationClient.AdminView;


namespace Auto_TransportationClient;


internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        //var customer = new CustomerController(new HttpClient()).GetAll();

        ApplicationConfiguration.Initialize();
        Application.Run(new AdminPanel());
    }
}