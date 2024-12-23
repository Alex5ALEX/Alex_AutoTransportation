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

namespace Auto_TransportationClient.AdminView.TransportationView;
public partial class TransportationRow : UserControl
{
    private TransportationControl mainController;

    public Transportation Transportation { get; set; }

    public TransportationRow(TransportationControl mainController, Transportation transportation)
    {
        this.mainController = mainController;
        Transportation = transportation;

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
        label12.Click += Select;
        label13.Click += Select;
        label14.Click += Select;
    }

    public async void InitData()
    {
        label8.Text = Transportation.Date.ToString("dd MM yyyy");
        label9.Text = Transportation.From;
        label1.Text = Transportation.To;
        label11.Text = Transportation.Distance.ToString();
        label4.Text = Transportation.Fuel.Type;
        label10.Text = Transportation.FuelVolume.ToString("0.00");

        Auto auto = await mainController.autoController.GetById(Transportation.Driver.AutoId);

        label15.Text = auto.Brand;
        label13.Text = auto.Model;
    }

    private void Select(object sender, EventArgs e)
    {
        mainController.choisedTransportation = Transportation;
    }
}
