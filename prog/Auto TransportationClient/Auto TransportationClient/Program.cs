using Auto_TransportationClient.AdminView;
using Auto_TransportationClient.ViewReg;
using Auto_TransportationClient.CustomerView;


namespace Auto_TransportationClient;


internal static class Program
{

    [STAThread]
    static void Main()
    {


        ApplicationConfiguration.Initialize();


        //Application.Run(new AdminPanel());


        RegistrationForm reg = new RegistrationForm();
        Application.Run(reg);


        if (reg.result == "Customer")
        {
            Application.Run(new ClientForm(reg.person));
        }
        else if (reg.result == "Admin")
        {
            Application.Run(new AdminPanel());
        }


    }
}