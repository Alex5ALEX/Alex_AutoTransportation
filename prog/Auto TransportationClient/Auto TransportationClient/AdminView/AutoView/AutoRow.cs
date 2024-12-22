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

namespace Auto_TransportationClient.AdminView.AutoView;
public partial class AutoRow : UserControl
{
    private AutoControl mainController;

    public Auto Auto { get; set; }

    public AutoRow(AutoControl mainController, Auto auto)
    {
        this.mainController = mainController;
        Auto = auto;

        InitializeComponent();
        InitData();

        groupBox1.Click += Select;
        label1.Click += Select;
        label2.Click += Select;
        label4.Click += Select;
        label5.Click += Select;
        label7.Click += Select;
        label8.Click += Select;
        label10.Click += Select;
        label11.Click += Select;
    }

    public void InitData()
    {
        label7.Text = Auto.Brand;
        label8.Text = Auto.Model;
        label10.Text = Auto.MaxFuel.ToString("0.00");
        label11.Text = Auto.Fuel.Type;
    }

    private void Select(object sender, EventArgs e)
    {
        mainController.choisedAuto = Auto;
    }
}
