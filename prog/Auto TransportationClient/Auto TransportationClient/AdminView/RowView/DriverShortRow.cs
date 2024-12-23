using Auto_TransportationClient.AdminView.TransportationView;
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

namespace Auto_TransportationClient.AdminView.RowView;
public partial class DriverShortRow : UserControl
{
    public Driver Driver;


    private TransportationAdd TransportationAdd;

    private TransportationEdit TransportationEdit;





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


    public DriverShortRow(TransportationEdit transportationEdit, Driver driver)
    {
        Driver = driver;
        TransportationEdit = transportationEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectTransportationEdit;
        groupBox2.Click += SelectTransportationEdit;
        label1.Click += SelectTransportationEdit;
        label2.Click += SelectTransportationEdit;
        label3.Click += SelectTransportationEdit;
        label4.Click += SelectTransportationEdit;
        label5.Click += SelectTransportationEdit;
        label6.Click += SelectTransportationEdit;
        label7.Click += SelectTransportationEdit;
        label8.Click += SelectTransportationEdit;
        label9.Click += SelectTransportationEdit;
        label10.Click += SelectTransportationEdit;
        label11.Click += SelectTransportationEdit;
        label12.Click += SelectTransportationEdit;
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

    private void SelectTransportationEdit(object sender, EventArgs e)
    {
        TransportationEdit.choisedDriver = Driver;
        TransportationEdit.ShowDriver();
    }
}
