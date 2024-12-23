using Auto_TransportationClient.AdminView.RowView;
using Auto_TransportationClient.Logic;
using Auto_TransportationClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_TransportationClient.Logic;
using Auto_TransportationClient.AdminView.AutoView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.AdminView.DriverView;
using Auto_TransportationClient.AdminView.FuelView;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Auto_TransportationClient.AdminView.TransportationView;
public partial class TransportationEdit : UserControl
{
    private TransportationControl mainController;

    public Transportation Transportation;

    public Customer choisedCustomer;
    public Driver choisedDriver;
    public Fuel choisedFuel;

    public TransportationEdit(TransportationControl mainController, Transportation Transportation)
    {
        this.mainController = mainController;
        this.Transportation = Transportation;

        InitializeComponent();
        InitData();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private async void InitData()
    {
        choisedFuel = await mainController.fuelController.GetById(Transportation.FuelId);
        choisedDriver = await mainController.driverController.GetById(Transportation.DriverId);
        choisedCustomer = await mainController.customerController.GetById(Transportation.CustomerId);

        dateTimePicker1.Value = Transportation.Date;
        textBoxFrom.Text = Transportation.From;
        textBoxTo.Text = Transportation.To;
        numericUpDown1.Value = (decimal)Transportation.Distance;
        numericUpDown2.Value = (decimal)Transportation.FuelVolume;

        ShowCustomer();
        ShowDriver();
        ShowFuel();


        InitCustomer();
        InitDriver();
        InitFuel();
    }


    private async void InitCustomer()
    {
        var customer = await mainController.customerController.GetAll();

        foreach (var item in customer)
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


    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxFrom.Text) ||
            string.IsNullOrWhiteSpace(textBoxTo.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        Transportation.Date = dateTimePicker1.Value;
        Transportation.From = textBoxFrom.Text;
        Transportation.To = textBoxTo.Text;
        Transportation.Distance = (int)numericUpDown1.Value;
        Transportation.FuelVolume = (double)numericUpDown2.Value;
        Transportation.CustomerId = choisedCustomer.Id;
        Transportation.DriverId = choisedDriver.Id;
        Transportation.FuelId = choisedFuel.Id;
        Transportation.Fuel = null;
        Transportation.Customer = null;
        Transportation.Driver = null;


        if (await mainController.transportationController.Put(Transportation))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("что-то пошло не так");
            return;
        }
        
    }


    private async void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        if (await mainController.transportationController.Del(Transportation))
        {
            mainController.UpdateData();
            mainController.HideActionGroupBox();
        }
    }


}
