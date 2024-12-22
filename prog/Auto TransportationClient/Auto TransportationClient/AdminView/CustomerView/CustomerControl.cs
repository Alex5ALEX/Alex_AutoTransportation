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

using Auto_TransportationClient.Controller;

namespace Auto_TransportationClient.AdminView.CustomerView;
public partial class CustomerControl : UserControl
{
    private AdminPanel adminPanel;

    public CustomerController customerController;

    public Customer choisedCustomer;

    public CustomerControl(AdminPanel adminPanel)
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
        choisedCustomer = new Customer();

        customerController = new CustomerController(adminPanel.httpClient);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var customer = await customerController.GetAll();

        foreach (var item in customer) 
        {
            flowLayoutPanel1.Controls.Add(new CustomerRow(this, item));
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
        groupBoxAction.Controls.Add(new CustomerAdd(this));
    }


    public void Edit(object sender, EventArgs e) 
    {
        if (choisedCustomer.Id == Guid.Empty) { return; }
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new CustomerEdit(this, choisedCustomer));
    }
}
