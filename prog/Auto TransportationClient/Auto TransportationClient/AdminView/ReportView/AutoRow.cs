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

namespace Auto_TransportationClient.AdminView.ReportView;

public partial class AutoRow : UserControl
{
    public Auto auto;
    public Fuel fuel;

    public AutoRow(Auto auto, Fuel fuel)
    {
        this.auto = auto;
        this.fuel = fuel;

        InitializeComponent();
        InitData();
    }


    private void InitData()
    {
        label7.Text = auto.Brand;
        label8.Text = auto.Model;
        label10.Text = auto.MaxFuel.ToString("0.00");
        label11.Text = fuel.Type;
        label3.Text = auto.Drivers.Count.ToString();
    }
    
}
