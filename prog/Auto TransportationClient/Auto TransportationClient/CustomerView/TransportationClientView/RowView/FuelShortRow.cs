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
using Auto_TransportationClient.CustomerView.TransportationClientView;

namespace Auto_TransportationClient.CustomerView.TransportationClientView.RowView;
public partial class FuelShortRow : UserControl
{
    public Fuel Fuel;

    private TransportationAdd TransportationAdd;


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

    private void InitData()
    {
        label2.Text = Fuel.Brand;
        label4.Text = Fuel.Type;
    }


    private void SelectTransportationAdd(object sender, EventArgs e)
    {
        TransportationAdd.choisedFuel = Fuel;
        TransportationAdd.ShowFuel();
    }


}
