
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

public partial class OrderClientControl : UserControl
{
    private ClientForm mainForm;
    /*
    public OrderController orderController;
    public CustomerController customerController;
    public ProductController productController;
    public ServicesController servicesController;
    public PurchasedProductController purchasedProductController;
    public PurchasedServicesController purchasedServicesController;
    */
    private OrderAddClient orderAdd;

    //public List<Order> orders;

    //public Order choisedOrder;



    public OrderClientControl(ClientForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuButton;

        buttonAddNew.Click += AddNew;
    }

    private void InitializeData()
    {/*
        choisedOrder = new Order();
        orderController = new OrderController(mainForm.httpClient);
        customerController = new CustomerController(mainForm.httpClient);
        productController = new ProductController(mainForm.httpClient);
        servicesController = new ServicesController(mainForm.httpClient);
        purchasedProductController = new PurchasedProductController(mainForm.httpClient);
        purchasedServicesController = new PurchasedServicesController(mainForm.httpClient);
        orderAdd = new OrderAddClient(this, mainForm.Customer);*/
    }




    public async void UpdateData()
    {/*
        flowLayoutPanel.Controls.Clear();

        var orders = await orderController.GetAllOrdersByIdCustomer(mainForm.Customer.Customer.Id);


        foreach (var order in orders)
        {
            flowLayoutPanel.Controls.Add(new OrderClientRow(this, order));
        }
        */

    }



    //можно добавить функционал
    public void HideActionGroupBox()
    {
        pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(orderAdd);
    }

}
