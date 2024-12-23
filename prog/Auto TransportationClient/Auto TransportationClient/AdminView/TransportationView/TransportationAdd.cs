using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.Logic;
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

using Auto_TransportationClient.Logic;

using Auto_TransportationClient.AdminView.RowView;

namespace Auto_TransportationClient.AdminView.TransportationView;
public partial class TransportationAdd : UserControl
{
    public TransportationControl mainController;

    public Customer choisedCustomer;
    public Driver choisedDriver;
    public Fuel choisedFuel;


    public TransportationAdd(TransportationControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();


        buttonBack.Click += mainController.HideActionGroupBox;
        buttonAdd.Click += Add;
    }

    private void InitData()
    {
        choisedCustomer = new Customer();
        choisedDriver = new Driver();
        choisedFuel = new Fuel();


        InitCustomer();
        InitDriver();
        InitFuel();
    }

    private async void InitCustomer()
    {
        var customer = await mainController.customerController.GetAll();

        foreach(var item in customer)
        {
            flowLayoutPanelCustomer.Controls.Add(new CustomerShortRow(this, item));
        }
    }
    
    private async void InitFuel()
    {
        var fuel = await mainController.fuelController.GetAll();

        foreach (var item in fuel)
        {
            flowLayoutPanelFuel.Controls.Add(new FuelShortRow(this, item));
        }
    }

    private async void InitDriver()
    {
        var driver = await mainController.driverController.GetAll();

        foreach (var item in driver)
        {
            flowLayoutPanelDriver.Controls.Add(new DriverShortRow(this, item));
        }
    }


    public void ShowCustomer()
    {
        label8.Text = choisedCustomer.Person.Name;
        label5.Text = choisedCustomer.Person.Surname;
    }
    public void ShowFuel()
    {
        label12.Text = choisedFuel.Brand;
        label10.Text = choisedFuel.Type;
    }

    public void ShowDriver() 
    {
        label2.Text = choisedDriver.Name;
        label4.Text = choisedDriver.Surname;
    }





    private async void Add(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxFrom.Text) ||
            string.IsNullOrWhiteSpace(textBoxTo.Text) )
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        if (choisedCustomer.Id == Guid.Empty)
        {
            MessageBox.Show("Выберите клиента.");
            return;
        }

        if (choisedDriver.Id == Guid.Empty)
        {
            MessageBox.Show("Выберите водителя.");
            return;
        }

        if (choisedFuel.Id == Guid.Empty)
        {
            MessageBox.Show("Выберите топливо.");
            return;
        }

        Transportation transportation = new Transportation() 
        {
            Date = dateTimePicker1.Value,
            From = textBoxFrom.Text,
            To = textBoxTo.Text,
            Distance = (int)numericUpDown1.Value,
            FuelVolume = (double)numericUpDown2.Value,
            CustomerId = choisedCustomer.Id,
            DriverId = choisedDriver.Id,
            FuelId = choisedFuel.Id
        };


        if (await mainController.transportationController.Post(transportation))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Что то пошло не так");
            return;
        }

        dateTimePicker1.Value = DateTime.Now;
        textBoxFrom.Text = "";
        textBoxTo.Text = "";
        numericUpDown1.Value = 0;
        numericUpDown2.Value = 0;
        choisedCustomer = new Customer() { Person = new Person() };
        choisedDriver = new Driver();
        choisedFuel = new Fuel();

        ShowCustomer();
        ShowDriver();
        ShowFuel();
    }

}
