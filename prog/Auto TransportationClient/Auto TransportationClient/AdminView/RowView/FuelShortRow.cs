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
using Auto_TransportationClient.AdminView.AutoView;

namespace Auto_TransportationClient.AdminView.RowView;
public partial class FuelShortRow : UserControl
{
    public Fuel Fuel;

    private AutoAdd AutoAdd;

    private AutoEdit AutoEdit;

    public FuelShortRow(AutoAdd autoAdd,Fuel fuel)
    {
        Fuel = fuel;
        AutoAdd = autoAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectAutoAdd;
        label1.Click += SelectAutoAdd;
        label2.Click += SelectAutoAdd;
        label3.Click += SelectAutoAdd;
        label4.Click += SelectAutoAdd;
    }

    public FuelShortRow(AutoEdit autoEdit, Fuel fuel)
    {
        Fuel = fuel;
        AutoEdit = autoEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectAutoEdit;
        label1.Click += SelectAutoEdit;
        label2.Click += SelectAutoEdit;
        label3.Click += SelectAutoEdit;
        label4.Click += SelectAutoEdit;
    }


    private void InitData()
    {
        label2.Text = Fuel.Brand;
        label4.Text = Fuel.Type;
    }

    private void SelectAutoAdd(object sender,EventArgs e)
    {
        AutoAdd.choisedFuel = Fuel;
        AutoAdd.ShowFuel();
    }

    private void SelectAutoEdit(object sender, EventArgs e)
    {
        AutoEdit.choisedFuel = Fuel;
        AutoEdit.ShowFuel();
    }

}
