using Auto_TransportationClient.CustomerView.TransportationClientView;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Auto_TransportationClient.CustomerView.TransportationClientView.RowView;
public partial class DriverShortRow : UserControl
{
    public Driver Driver;


    private TransportationAdd TransportationAdd;


    public DriverShortRow(TransportationAdd transportationAdd, Driver driver)
    {
        Driver = driver;
        TransportationAdd = transportationAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectTransportationAdd;
        groupBox2.Click += SelectTransportationAdd;
        label1.Click += SelectTransportationAdd;
        label2.Click += SelectTransportationAdd;
        label3.Click += SelectTransportationAdd;
        label4.Click += SelectTransportationAdd;
        label5.Click += SelectTransportationAdd;
        label6.Click += SelectTransportationAdd;
        label7.Click += SelectTransportationAdd;
        label8.Click += SelectTransportationAdd;
        label9.Click += SelectTransportationAdd;
        label10.Click += SelectTransportationAdd;
        label11.Click += SelectTransportationAdd;
        label12.Click += SelectTransportationAdd;
    }


    private void InitData()
    {
        label2.Text = Driver.Name;
        label4.Text = Driver.Surname;
        label5.Text = Driver.Phone;

        label11.Text = Driver.Auto.Brand;
        label9.Text = Driver.Auto.Model;
        label7.Text = Driver.Auto.MaxFuel.ToString("0.00");
    }


    private void SelectTransportationAdd(object sender, EventArgs e)
    {
        TransportationAdd.choisedDriver = Driver;
        TransportationAdd.ShowDriver();
    }


}
