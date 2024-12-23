using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto_TransportationClient.Controller;


namespace Auto_TransportationClient.AdminView.ReportView;

public partial class ReportControl : UserControl
{
    private AdminPanel adminPanel;

    public CustomerController customerController;
    public AdminController adminController;
    public AutoController autoController;
    public DriverController driverController;
    public FuelController fuelController;
    public PersonController personController;
    public TransportationController transportationController;

    public ReportControl(AdminPanel adminPanel)
    {
        this.adminPanel = adminPanel;

        InitializeComponent();
        InitData();

        buttonMenu.Click += adminPanel.ShowMenu;
        button1.Click += InitFinanceReport;
        button2.Click += InitStatisticReport;
        button3.Click += HideActionGroupBox;
    }



    private void InitData()
    {
        customerController = new CustomerController(adminPanel.httpClient);
        adminController = new AdminController(adminPanel.httpClient);
        autoController = new AutoController(adminPanel.httpClient);
        driverController = new DriverController(adminPanel.httpClient);
        fuelController = new FuelController(adminPanel.httpClient);
        personController = new PersonController(adminPanel.httpClient);
        transportationController = new TransportationController(adminPanel.httpClient);
    }


    public void HideActionGroupBox(object sender, EventArgs e)
    {
        HideActionGroupBox();
    }


    public void HideActionGroupBox()
    {
        groupBox1.Controls.Clear();
       pictureBox1.Visible = true;
    }


    private void InitFinanceReport(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new FinanceControl(this));
    }


    private void InitStatisticReport(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new StatControl(this));
    }


}
