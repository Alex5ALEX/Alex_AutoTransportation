using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.AdminView.AdminView;
using Auto_TransportationClient.AdminView.FuelView;
using Auto_TransportationClient.AdminView.AutoView;
using Auto_TransportationClient.AdminView.DriverView;
using Auto_TransportationClient.AdminView.TransportationView;
using Auto_TransportationClient.AdminView.ReportView;
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
    DriverControl driverControl;
    TransportationControl transportationControl;
    ReportControl reportControl;


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
        optionDriver.Click += InitDriverControl;
        optionTransportations.Click += InitTransportationControl;
        optionReport.Click += InitReportControl;
    }

  

    private void InitializeData()
    {
        httpClient = new HttpClient();

        customerControl = new CustomerControl(this);
        adminControl = new AdminControl(this);
        fuelControl = new FuelControl(this);
        autoControl = new AutoControl(this);
        driverControl = new DriverControl(this);
        transportationControl = new TransportationControl(this);
        reportControl = new ReportControl(this);


        Controls.Add(customerControl);
        Controls.Add(adminControl);
        Controls.Add(fuelControl);
        Controls.Add(autoControl);
        Controls.Add(driverControl);
        Controls.Add(transportationControl);
        Controls.Add(reportControl);

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


    private void InitDriverControl(object sender, EventArgs e)
    {
        HideAllControls();
        driverControl.Visible = true;
    }


    private void InitTransportationControl(object sender, EventArgs e)
    {
        HideAllControls();
        transportationControl.Visible = true;
    }
    

    private void InitReportControl(object sender, EventArgs e)
    {
        HideAllControls();
        reportControl.Visible = true;
    }



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
        driverControl.Visible = false;
        transportationControl.Visible = false;
        reportControl.Visible = false;
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
