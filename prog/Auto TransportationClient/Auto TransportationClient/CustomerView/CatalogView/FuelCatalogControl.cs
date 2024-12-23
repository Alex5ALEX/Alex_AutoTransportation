
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_TransportationClient.Models;

namespace Auto_TransportationClient.CustomerView;

public partial class FuelCatalogControl : UserControl
{
    public Fuel Fuel;
    
    public FuelCatalogControl(Fuel Fuel)
    {
        this.Fuel = Fuel;


        InitializeComponent();
        InitData();
    }

    private async void InitData()
    {
        label7.Text = Fuel.Brand;
        label10.Text = Fuel.Type;
        label8.Text = Fuel.Price.ToString("0.00");
    }
}
