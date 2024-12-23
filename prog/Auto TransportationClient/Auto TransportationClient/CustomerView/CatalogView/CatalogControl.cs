using Auto_TransportationClient.Controller;

namespace Auto_TransportationClient.CustomerView;

public partial class CatalogControl : UserControl
{
    private ClientForm mainForm;
    /*
    public ProductController productController;
    public ServicesController servicesController;
    public ProviderController providerController;
    public ManufactureController manufactureController;
    */
    public CatalogControl(ClientForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuButton;
    }

    public void InitData()
    {/*
        productController = new ProductController(mainForm.httpClient);
        servicesController = new ServicesController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
        manufactureController = new ManufactureController(mainForm.httpClient);*/
    }

    public void UpdateData()
    {
        UpdateProductRow();
        UpdateServicesRow();
    }
    public async void UpdateProductRow()
    {/*
        flowLayoutPanelProduct.Controls.Clear();

        List<Product> products = await productController.GetAllProductsAsync();

        foreach(var product in products)
        {
            flowLayoutPanelProduct.Controls.Add(new ProductCatalogControl(this, product));
        }*/
     }

    public async void UpdateServicesRow() 
    {/*
        flowLayoutPanelServices.Controls.Clear();

        List<Services> services = await servicesController.GetAllServicesAsync();

        foreach (var serv in services)
        {
            flowLayoutPanelServices.Controls.Add(new ServicesCatalogControl(serv));
        }*/
    }   

}
