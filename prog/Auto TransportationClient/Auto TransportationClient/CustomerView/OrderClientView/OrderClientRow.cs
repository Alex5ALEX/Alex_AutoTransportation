
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_TransportationClient.CustomerView;

public partial class OrderClientRow : UserControl
{
    private OrderClientControl mainController;

    //public Order order;

    public OrderClientRow()//OrderClientControl mainController, Order order)
    {
        this.mainController = mainController;
        //this.order = order;

        InitializeComponent();
        InitData();

        /*
        groupBox1.Click += select_order;
        groupBox2.Click += select_order;
        label1.Click += select_order;
        label2.Click += select_order;
        label3.Click += select_order;
        label4.Click += select_order;
        label5.Click += select_order;
        label6.Click += select_order;
        label7.Click += select_order;
        label8.Click += select_order;*/
    }

    private async void InitData()
    {/*
        label8.Text = order.Date.ToString("dd MM yyyy");

        CustomerDTO customer = await mainController.customerController.GetById(order.Id_Customer);

        label2.Text = customer.Person.Name;
        label4.Text = customer.Person.Surname;
        label6.Text = customer.Person.Phone;*/
    }


    /*
    private void select_order(object sender, EventArgs e)
    {
        mainController.choisedOrder = order;
    }*/

}
