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
public partial class FuelAdd : UserControl
{
    public FuelControl mainController;

    public FuelAdd(FuelControl mainController)
    {
        this.mainController = mainController;


        InitializeComponent();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonAdd.Click += Add;
    }

    private async void Add(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxBrand.Text) ||
       string.IsNullOrWhiteSpace(textBoxType.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        Fuel fuel = new Fuel()
        {
            Brand = textBoxBrand.Text,
            Type = textBoxType.Text,
            Price = numericUpDown1.Value
        };





        if (await mainController.fuelController.Post(fuel))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }

        textBoxBrand.Text = "";
        textBoxType.Text = "";
        numericUpDown1.Value = 0;
    }
}
