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

namespace Auto_TransportationClient.AdminView.CustomerView;
public partial class CustomerRow : UserControl
{
    private CustomerControl mainController;

    public Customer Customer { get; set; }

    public CustomerRow(CustomerControl mainController, Customer customer)
    {
        this.mainController = mainController;
        Customer = customer;

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
        label7.Text = Customer.Person.Login;
        label8.Text = Customer.Person.Name;
        label9.Text = Customer.Person.Surname;
        label10.Text = Customer.Person.Phone;
        label11.Text = Customer.Person.Email;
        label12.Text = Customer.Person.Address;
    }

    private void Select(object sender, EventArgs e)
    {
        mainController.choisedCustomer = Customer;
    }

}
