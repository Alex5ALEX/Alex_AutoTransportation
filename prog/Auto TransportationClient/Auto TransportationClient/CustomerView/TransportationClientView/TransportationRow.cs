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

namespace Auto_TransportationClient.CustomerView.TransportationClientView;
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


}
