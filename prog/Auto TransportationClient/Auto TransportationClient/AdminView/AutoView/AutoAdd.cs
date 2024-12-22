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

using Auto_TransportationClient.AdminView.RowView;

namespace Auto_TransportationClient.AdminView.AutoView;
public partial class AutoAdd : UserControl
{
    public AutoControl mainController;

    public Fuel choisedFuel;

    public AutoAdd(AutoControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();


        buttonBack.Click += mainController.HideActionGroupBox;
        buttonAdd.Click += Add;
    }

    private void InitData()
    {
        choisedFuel = new Fuel();


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




    private async void Add(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxBrand.Text) ||
            string.IsNullOrWhiteSpace(textBoxModel.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        if (choisedFuel.Id == Guid.Empty)
        {
            MessageBox.Show("Выберите топливо.");
            return;
        }

        Auto auto = new Auto()
        {
            Brand = textBoxBrand.Text,
            Model = textBoxModel.Text,
            MaxFuel = (double)numericUpDown1.Value,
            FuelId = choisedFuel.Id
        };






        if (await mainController.autoController.Post(auto))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Что то пошло не так");
            return;
        }

        textBoxBrand.Text = "";
        textBoxModel.Text = "";
        choisedFuel = new Fuel();
        ShowFuel();
        numericUpDown1.Value = 0;
    }

}
