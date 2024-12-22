using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.AdminView.AdminView;
using Auto_TransportationClient.AdminView.FuelView;
using Auto_TransportationClient.AdminView.AutoView;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_TransportationClient.AdminView;
public partial class AdminPanel : Form
{

    public HttpClient httpClient { get; set; }


    CustomerControl customerControl;
    AdminControl adminControl;
    FuelControl fuelControl;
    AutoControl autoControl;
    /*ServicesControl servicesControl;
    ProviderControl providerControl;
    ManufactureControl manufactureControl;
    ProductControl productControl;
    OrderControl orderControl;
    ReportControl reportControl;
    AdminControl adminControl;*/



    public AdminPanel()
    {
            
        InitializeComponent();
        InitializeData();

        this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        buttonMenu.Click += ShowMenu;
        groupBoxMenu.Click += HideMenu;
        labelMenu.Click += HideMenu;


        optionCustomer.Click += InitCustomerControl;
        optionAdmin.Click += InitAdminControl;
        optionFuel.Click += InitFuelControl;
        optionAuto.Click += InitAutoControl;
        /*
        customerOption.Click += InitCustomerControl;
        servicesOption.Click += InitServicesControl;
        providerOption.Click += InitProviderControl;
        manufactureOption.Click += InitManufactureControl;
        productOption.Click += InitProductControl;
        orderOption.Click += InitOrderControl;
        ReportOption.Click += InitReportControl;
        adminOprion.Click += InitAdminControl;*/
    }



    private void InitializeData()
    {
        httpClient = new HttpClient();

        customerControl = new CustomerControl(this);
        adminControl = new AdminControl(this);
        fuelControl = new FuelControl(this);
        autoControl = new AutoControl(this);
        /*
        servicesControl = new ServicesControl(this);
        providerControl = new ProviderControl(this);
        manufactureControl = new ManufactureControl(this);
        productControl = new ProductControl(this);
        orderControl = new OrderControl(this);
        reportControl = new ReportControl(this);
        adminControl = new AdminControl(this);*/

        Controls.Add(customerControl);
        Controls.Add(adminControl);
        Controls.Add(fuelControl);
        Controls.Add(autoControl);
        /*
        Controls.Add(servicesControl);
        Controls.Add(providerControl);
        Controls.Add(manufactureControl);
        Controls.Add(productControl);
        Controls.Add(orderControl);
        Controls.Add(reportControl);
        Controls.Add(adminControl);*/

        HideMainControls();
        HideMenuControl();
    }


    //menu options
    private void InitCustomerControl(object sender, EventArgs e)
    {
        HideAllControls();
        customerControl.Visible = true;
    }

    private void InitAdminControl(object sender, EventArgs e)
    {
        HideAllControls();
        adminControl.Visible = true;
    }

    private void InitFuelControl(object sender, EventArgs e)
    {
        HideAllControls();
        fuelControl.Visible = true;
    }

    private void InitAutoControl(object sender, EventArgs e)
    {
        HideAllControls();
        autoControl.Visible = true;
    }

    /*
    private void InitServicesControl(object sender, EventArgs e)
    {
        HideAllControls();
        servicesControl.Visible = true;
    }

    private void InitProviderControl(object sender, EventArgs e)
    {
        HideAllControls();
        providerControl.Visible = true;
    }

    private void InitManufactureControl(object sender, EventArgs e)
    {
        HideAllControls();
        manufactureControl.Visible = true;
    }

    private void InitProductControl(object sender, EventArgs e)
    {
        HideAllControls();
        productControl.Visible = true;
    }

    private void InitOrderControl(object sender, EventArgs e)
    {
        HideAllControls();
        orderControl.Visible = true;
    }

    private void InitReportControl(object sender, EventArgs e)
    {
        HideAllControls();
        reportControl.Visible = true;
    }

    private void InitAdminControl(object sender, EventArgs e)
    {
        HideAllControls();
        adminControl.Visible = true;
    }*/

    //controls



    private void HideAllControls()
    {
        HideMenuControl();
        buttonMenu.Visible = false;
        pictureBox1.Visible = false;
        labelHello.Visible = false;

        HideMainControls();
    }


    private void HideMainControls()
    {
        customerControl.Visible = false;
        adminControl.Visible = false;
        fuelControl.Visible = false;
        autoControl.Visible = false;
        /*
        servicesControl.Visible = false;
        providerControl.Visible = false;
        manufactureControl.Visible = false;
        productControl.Visible = false;
        orderControl.Visible = false;
        reportControl.Visible = false;
        adminControl.Visible = false;*/
    }



    //menu
    public void ShowMenu(object sender, EventArgs e)
    {
        ShowMenuControl();
    }

    public void HideMenu(object sender, EventArgs e)
    {
        HideMenuControl();
    }

    public void ShowMenuControl()
    {
        groupBoxMenu.BringToFront();
        groupBoxMenu.Visible = true;
    }

    public void HideMenuControl()
    {
        groupBoxMenu.Visible = false;
    }


    //exit
    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
    
}
