using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.Controller;
using Auto_TransportationClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_TransportationClient.AdminView.TransportationView;
public partial class TransportationControl : UserControl
{
    private AdminPanel adminPanel;

    public AutoController autoController;
    public DriverController driverController;
    public TransportationController transportationController;
    public CustomerController customerController;
    public FuelController fuelController;

    public Transportation choisedTransportation;

    public TransportationControl(AdminPanel adminPanel)
    {
        this.adminPanel = adminPanel;

        InitializeComponent();
        InitData();
        UpdateData();

        buttonMenu.Click += adminPanel.ShowMenu;

        buttonAdd.Click += Add;
        buttonEdit.Click += Edit;
    }



    public void InitData()
    {
        choisedTransportation = new Transportation();

        autoController = new AutoController(adminPanel.httpClient);
        driverController = new DriverController(adminPanel.httpClient);
        transportationController = new TransportationController(adminPanel.httpClient);
        customerController = new CustomerController(adminPanel.httpClient);
        fuelController = new FuelController(adminPanel.httpClient);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var transportations = await transportationController.GetAll();

        foreach (var item in transportations)
        {
            flowLayoutPanel1.Controls.Add(new TransportationRow(this, item));
        }
    }

    //можно добавить функционал
    public void HideActionGroupBox(object sender, EventArgs e)
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }


    public void Add(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new TransportationAdd(this));
    }


    public void Edit(object sender, EventArgs e)
    {
        if (choisedTransportation.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new TransportationEdit(this, choisedTransportation));
    }
}
