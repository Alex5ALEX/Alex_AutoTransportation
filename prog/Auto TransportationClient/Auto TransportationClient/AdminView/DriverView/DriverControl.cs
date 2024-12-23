using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.Controller;
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

namespace Auto_TransportationClient.AdminView.DriverView;
public partial class DriverControl : UserControl
{
    private AdminPanel adminPanel;

    public AutoController autoController;
    public DriverController driverController;

    public Driver choisedDriver;

    public DriverControl(AdminPanel adminPanel)
    {
        this.adminPanel = adminPanel;

        InitializeComponent();
        InitData();
        UpdateData();

        buttonMenu.Click += adminPanel.ShowMenu;

        buttonAdd.Click += Add;
        buttonEdit.Click += Edit;
    }



    public void InitData()
    {
        choisedDriver = new Driver();

        autoController = new AutoController(adminPanel.httpClient);
        driverController = new DriverController(adminPanel.httpClient);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var driver = await driverController.GetAll();

        foreach (var item in driver)
        {
            flowLayoutPanel1.Controls.Add(new DriverRow(this, item));
        }
    }

    //можно добавить функционал
    public void HideActionGroupBox(object sender, EventArgs e)
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }


    public void Add(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new DriverAdd(this));
    }


    public void Edit(object sender, EventArgs e)
    {
        if (choisedDriver.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new DriverEdit(this, choisedDriver));
    }
}
