using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_TransportationClient.AdminView.TransportationView;
using Auto_TransportationClient.Models;

namespace Auto_TransportationClient.AdminView.RowView;
public partial class CustomerShortRow : UserControl
{
    public Customer Customer;


    private TransportationAdd TransportationAdd;

    private TransportationEdit TransportationEdit;





    public CustomerShortRow(TransportationAdd transportationAdd, Customer customer)
    {
        Customer = customer;
        TransportationAdd = transportationAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectTransportationAdd;
        label1.Click += SelectTransportationAdd;
        label2.Click += SelectTransportationAdd;
        label3.Click += SelectTransportationAdd;
        label4.Click += SelectTransportationAdd;
        label5.Click += SelectTransportationAdd;
        label6.Click += SelectTransportationAdd;
    }


    public CustomerShortRow(TransportationEdit transportationEdit, Customer customer)
    {
        Customer = customer;
        TransportationEdit = transportationEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += SelectTransportationEdit;
        label1.Click += SelectTransportationEdit;
        label2.Click += SelectTransportationEdit;
        label3.Click += SelectTransportationEdit;
        label4.Click += SelectTransportationEdit;
        label5.Click += SelectTransportationEdit;
        label6.Click += SelectTransportationEdit;
    }




    private void InitData()
    {
        label2.Text = Customer.Person.Name;
        label4.Text = Customer.Person.Surname;
        label5.Text = Customer.Person.Phone;
    }




    private void SelectTransportationAdd(object sender, EventArgs e)
    {
        TransportationAdd.choisedCustomer = Customer;
        TransportationAdd.ShowCustomer();
    }

    private void SelectTransportationEdit(object sender, EventArgs e)
    {
        TransportationEdit.choisedCustomer =Customer;
        TransportationEdit.ShowCustomer();
    }
}
