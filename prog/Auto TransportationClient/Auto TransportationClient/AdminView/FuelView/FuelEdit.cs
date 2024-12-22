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

namespace Auto_TransportationClient.AdminView.FuelView;
public partial class FuelEdit : UserControl
{
    public FuelControl mainController;

    private Fuel Fuel;


    public FuelEdit(FuelControl mainController, Fuel fuel)
    {
        this.mainController = mainController;
        Fuel = fuel;


        InitializeComponent();
        InitData();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;

    }

    private void InitData()
    {
        textBoxBrand.Text = Fuel.Brand;
        textBoxType.Text = Fuel.Type;
        numericUpDown1.Value = Fuel.Price;
    }

    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxBrand.Text) ||
        string.IsNullOrWhiteSpace(textBoxType.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        Fuel.Brand = textBoxBrand.Text;
        Fuel.Type = textBoxType.Text;
        Fuel.Price = numericUpDown1.Value;



        if (await mainController.fuelController.Put(Fuel))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }

    }


    private async void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        if (await mainController.fuelController.Del(Fuel))
        {
            mainController.UpdateData();
            mainController.HideActionGroupBox();
        }
    }
}
