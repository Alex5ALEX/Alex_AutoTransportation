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

namespace Auto_TransportationClient.AdminView.FuelView;
public partial class FuelControl : UserControl
{
    private AdminPanel adminPanel;

    public FuelController fuelController;

    public Fuel choisedFuel;

    public FuelControl(AdminPanel adminPanel)
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
        choisedFuel = new Fuel();

        fuelController = new FuelController(adminPanel.httpClient);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var customer = await fuelController.GetAll();

        foreach (var item in customer)
        {
            flowLayoutPanel1.Controls.Add(new FuelRow(this, item));
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
        groupBoxAction.Controls.Add(new FuelAdd(this));
    }


    public void Edit(object sender, EventArgs e)
    {
        if(choisedFuel.Id == Guid.Empty) { return; }
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new FuelEdit(this, choisedFuel));
    }
}
