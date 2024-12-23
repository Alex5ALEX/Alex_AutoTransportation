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
using Auto_TransportationClient.AdminView.TransportationView;

namespace Auto_TransportationClient.AdminView.RowView;
public partial class FuelShortRow : UserControl
{
    public Fuel Fuel;

    private AutoAdd AutoAdd;

    private AutoEdit AutoEdit;

    private TransportationAdd TransportationAdd;

    private TransportationEdit TransportationEdit;  

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




    public FuelShortRow(TransportationAdd transportationAdd, Fuel fuel)
    {
        Fuel = fuel;
        TransportationAdd = transportationAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectTransportationAdd;
        label1.Click += SelectTransportationAdd;
        label2.Click += SelectTransportationAdd;
        label3.Click += SelectTransportationAdd;
        label4.Click += SelectTransportationAdd;
    }


    public FuelShortRow(TransportationEdit transportationEdit, Fuel fuel)
    {
        Fuel = fuel;
        TransportationEdit = transportationEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectTransportationEdit;
        label1.Click += SelectTransportationEdit;
        label2.Click += SelectTransportationEdit;
        label3.Click += SelectTransportationEdit;
        label4.Click += SelectTransportationEdit;
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


    private void SelectTransportationAdd(object sender, EventArgs e)
    {
        TransportationAdd.choisedFuel = Fuel;
        TransportationAdd.ShowFuel();
    }

    private void SelectTransportationEdit(object sender, EventArgs e)
    {
        TransportationEdit.choisedFuel = Fuel;
        TransportationEdit.ShowFuel();
    }

}
