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

namespace Auto_TransportationClient.AdminView.AutoView;
public partial class AutoControl : UserControl
{
    private AdminPanel adminPanel;

    public AutoController autoController;
    public FuelController fuelController;

    public Auto choisedAuto;

    public AutoControl(AdminPanel adminPanel)
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
        choisedAuto = new Auto();

        autoController = new AutoController(adminPanel.httpClient);
        fuelController = new FuelController(adminPanel.httpClient);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var auto = await autoController.GetAll();

        foreach (var item in auto)
        {
            flowLayoutPanel1.Controls.Add(new AutoRow(this, item));
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
        groupBoxAction.Controls.Add(new AutoAdd(this));
    }


    public void Edit(object sender, EventArgs e)
    {
        if (choisedAuto.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new AutoEdit(this, choisedAuto));
    }
}
