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

namespace Auto_TransportationClient.CustomerView.TransportationClientView;
public partial class TransportationControl : UserControl
{
    private ClientForm clientForm;

    public Customer Customer;

    public AutoController autoController;
    public DriverController driverController;
    public TransportationController transportationController;
    public CustomerController customerController;
    public FuelController fuelController;


    public TransportationControl(ClientForm adminPanel, Customer customer)
    {
        this.clientForm = adminPanel;
        Customer = customer;

        InitializeComponent();
        InitData();
        UpdateData();

        buttonMenu.Click += adminPanel.ShowMenuButton;

        buttonAdd.Click += Add;
        
    }



    public void InitData()
    {
        autoController = new AutoController(clientForm.httpClient);
        driverController = new DriverController(clientForm.httpClient);
        transportationController = new TransportationController(clientForm.httpClient);
        customerController = new CustomerController(clientForm.httpClient);
        fuelController = new FuelController(clientForm.httpClient);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var transportations = await transportationController.GetByIdCustomer(Customer.Id);

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
        groupBoxAction.Controls.Add(new TransportationAdd(this, Customer));
    }

}
