using Auto_TransportationClient.AdminView.CustomerView;
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

namespace Auto_TransportationClient.AdminView.AdminView;
public partial class AdminRow : UserControl
{
    private AdminControl mainController;

    public Admin Admin { get; set; }

    public AdminRow(AdminControl mainController, Admin admin)
    {
        this.mainController = mainController;
        Admin = admin;

        InitializeComponent();
        InitData();

        groupBox1.Click += Select;
        label1.Click += Select;
        label2.Click += Select;
        label3.Click += Select;
        label4.Click += Select;
        label5.Click += Select;
        label6.Click += Select;
        label7.Click += Select;
        label8.Click += Select;
        label9.Click += Select;
        label10.Click += Select;
        label11.Click += Select;
        label12.Click += Select;
    }

    public void InitData()
    {
        label7.Text = Admin.Person.Login;
        label8.Text = Admin.Person.Name;
        label9.Text = Admin.Person.Surname;
        label10.Text = Admin.Person.Phone;
        label11.Text = Admin.Person.Email;
        label12.Text = Admin.Person.Address;
    }

    private void Select(object sender, EventArgs e)
    {
        mainController.choisedAdmin = Admin;
    }

}
