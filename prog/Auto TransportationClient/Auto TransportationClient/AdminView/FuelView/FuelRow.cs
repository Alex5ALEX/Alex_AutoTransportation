using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_TransportationClient.AdminView.FuelView;
public partial class FuelRow : UserControl
{
    private FuelControl mainController;

    public Fuel Fuel { get; set; }

    public FuelRow(FuelControl mainController, Fuel fuel)
    {
        this.mainController = mainController;
        Fuel = fuel;

        InitializeComponent();
        InitData();

        groupBox1.Click += Select;
        label1.Click += Select;
        label2.Click += Select;
        label4.Click += Select;
        label7.Click += Select;
        label8.Click += Select;
        label10.Click += Select;
    }

    public void InitData()
    {
        label7.Text = Fuel.Brand;
        label10.Text = Fuel.Type;
        label8.Text = Fuel.Price.ToString("0.00");
    }

    private void Select(object sender, EventArgs e)
    {
        mainController.choisedFuel = Fuel;
    }
}
