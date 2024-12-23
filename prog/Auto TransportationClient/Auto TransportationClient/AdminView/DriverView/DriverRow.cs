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

namespace Auto_TransportationClient.AdminView.DriverView;
public partial class DriverRow : UserControl
{
    private DriverControl mainController;

    public Driver Driver { get; set; }

    public DriverRow(DriverControl mainController, Driver driver)
    {
        this.mainController = mainController;
        Driver = driver;

        InitializeComponent();
        InitData();

        groupBox1.Click += Select;
        groupBox2.Click += Select;
        label1.Click += Select;
        label2.Click += Select;
        label4.Click += Select;
        label5.Click += Select;
        label7.Click += Select;
        label8.Click += Select;
        label10.Click += Select;
        label11.Click += Select;
        label12.Click += Select;
    }

    public void InitData()
    {
        label8.Text = Driver.Name;
        label9.Text = Driver.Surname;
        label10.Text = Driver.Phone;
        label11.Text = Driver.Email;
        label7.Text = Driver.Auto.Brand;
        label12.Text = Driver.Auto.Model;

    }

    private void Select(object sender, EventArgs e)
    {
        mainController.choisedDriver = Driver;
    }
}
