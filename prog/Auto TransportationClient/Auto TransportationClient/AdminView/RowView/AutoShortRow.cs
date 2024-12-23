using Auto_TransportationClient.AdminView.AutoView;
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

using Auto_TransportationClient.AdminView.DriverView;

namespace Auto_TransportationClient.AdminView.RowView;
public partial class AutoShortRow : UserControl
{
    public Auto Auto;

    private DriverAdd DriverAdd;

    private DriverEdit DriverEdit;

    public AutoShortRow(DriverAdd driverAdd, Auto auto)
    {
        Auto = auto;
        DriverAdd = driverAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectDriverAdd;
        label1.Click += SelectDriverAdd;
        label2.Click += SelectDriverAdd;
        label3.Click += SelectDriverAdd;
        label4.Click += SelectDriverAdd;
        label5.Click += SelectDriverAdd;
        label6.Click += SelectDriverAdd;
        label7.Click += SelectDriverAdd;
        label8.Click += SelectDriverAdd;
    }

    public AutoShortRow(DriverEdit driverEdit, Auto auto)
    {
        Auto = auto;
        DriverEdit = driverEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectDriverEdit;
        label1.Click += SelectDriverEdit;
        label2.Click += SelectDriverEdit;
        label3.Click += SelectDriverEdit;
        label4.Click += SelectDriverEdit;
    }


    private void InitData()
    {
        label2.Text = Auto.Brand;
        label4.Text = Auto.Model;
        label7.Text = Auto.MaxFuel.ToString("0.00");
        label5.Text = Auto.Fuel.Type;
    }

    private void SelectDriverAdd(object sender, EventArgs e)
    {
        DriverAdd.choisedAuto = Auto;
        DriverAdd.ShowAuto();
    }

    private void SelectDriverEdit(object sender, EventArgs e)
    {
        DriverEdit.choisedAuto = Auto;
        DriverEdit.ShowAuto();
    }
}
