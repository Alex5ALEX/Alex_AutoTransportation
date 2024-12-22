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

namespace Auto_TransportationClient.AdminView.AutoView;
public partial class AutoEdit : UserControl
{
    private AutoControl mainController;

    public Auto Auto;

    public Fuel choisedFuel;


    public AutoEdit(AutoControl mainController, Auto Auto)
    {
        this.mainController = mainController;
        this.Auto = Auto;

        InitializeComponent();
        InitData();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private void InitData()
    {
        textBoxBrand.Text = Auto.Brand;
        textBoxModel.Text = Auto.Model;
        numericUpDown1.Value = (decimal) Auto.MaxFuel;

        choisedFuel = Auto.Fuel;
        ShowFuel();

        InitFuel();
    }


    private async void InitFuel()
    {
        var fuels = await mainController.fuelController.GetAll();

        foreach (var fuel in fuels)
        {
            flowLayoutPanel1.Controls.Add(new FuelShortRow(this, fuel));
        }
    }


    public void ShowFuel()
    {
        label2.Text = choisedFuel.Brand;
        label4.Text = choisedFuel.Type;
    }


    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxBrand.Text) ||
        string.IsNullOrWhiteSpace(textBoxModel.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        Auto.Brand = textBoxBrand.Text;
        Auto.Model = textBoxModel.Text;
        Auto.MaxFuel = (double)numericUpDown1.Value;
        Auto.FuelId = choisedFuel.Id;
        Auto.Fuel = choisedFuel;




        if (await mainController.autoController.Put(Auto))
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


        if (await mainController.autoController.Del(Auto))
        {
            mainController.UpdateData();
            mainController.HideActionGroupBox();
        }
    }


}
