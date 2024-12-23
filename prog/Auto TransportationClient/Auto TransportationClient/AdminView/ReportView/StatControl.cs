using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_TransportationClient.AdminView.ReportView;

public partial class StatControl : UserControl
{
    private ReportControl mainController;

    public StatControl(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();
    }

    private void InitData()
    {
        InitLabel();
        InitBox();
    }

    private async void InitBox()
    {
        var auto = await mainController.autoController.GetAll();
        
        foreach (var item in auto)
        {
            var fuel = await mainController.fuelController.GetById(item.FuelId);

            flowLayoutPanel1.Controls.Add(new AutoRow(item,fuel));
        }
    }


    private async void InitLabel()
    {
        var drivers = await mainController.driverController.GetAll();
        var auto = await mainController.autoController.GetAll();
        var transport = await mainController.transportationController.GetAll();
        var fuels = await mainController.fuelController.GetAll();
        var customers = await mainController.customerController.GetAll();
        var admins = await mainController.adminController.GetAll();

        label3.Text = drivers.Count.ToString();
        label5.Text = auto.Count.ToString();
        label7.Text = transport.Count.ToString();
        label9.Text = fuels.Count.ToString();
        label11.Text = customers.Count.ToString();
        label13.Text = admins.Count.ToString();
    }

}
