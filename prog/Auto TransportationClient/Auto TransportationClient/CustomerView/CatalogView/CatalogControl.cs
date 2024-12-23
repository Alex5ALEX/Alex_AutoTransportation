using Auto_TransportationClient.Controller;
using Auto_TransportationClient.Models;


namespace Auto_TransportationClient.CustomerView;

public partial class CatalogControl : UserControl
{
    private ClientForm mainForm;

    public FuelController fuelController;

    
    public CatalogControl(ClientForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuButton;
    }

    public void InitData()
    {
        fuelController = new FuelController(mainForm.httpClient);
    }

    public async void UpdateData()
    {
        flowLayoutPanelFuel.Controls.Clear();

        var fuel = await fuelController.GetAll();

        foreach (var item in fuel) 
        {
            flowLayoutPanelFuel.Controls.Add(new FuelCatalogControl(item));
        }

    }
     

}
