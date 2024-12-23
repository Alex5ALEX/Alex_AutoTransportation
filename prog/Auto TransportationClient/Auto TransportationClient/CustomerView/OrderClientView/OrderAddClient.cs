
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

public partial class OrderAddClient : UserControl
{/*
    private OrderClientControl mainController;

    private List<ProductShortRow> productRow = [];
    private List<ServicesShortRow> servicesRow = [];

    public CustomerDTO customer;

    */
    public OrderAddClient()//OrderClientControl mainController, CustomerDTO customer)
    {
        //this.mainController = mainController;
        //this.customer = customer;


        InitializeComponent();
        InitData();
        ShowCustomer();


        buttonBack.Click += Back;
        buttonAdd.Click += Add;
    }

    private void Back(object? sender, EventArgs e)
    {
        //mainController.HideActionGroupBox();
    }


    public void InitData()
    {
        InitProducts();
        InitServices();
    }




    private async void InitProducts()
    {/*
        flowLayoutPanelProduct.Controls.Clear();

        List<Product> products = await mainController.productController.GetAllProductsAsync();

        foreach (Product product in products)
        {
            ProductShortRow productShortRow = new ProductShortRow(product);
            productRow.Add(productShortRow);
            flowLayoutPanelProduct.Controls.Add(productShortRow);
        }*/
    }


    private async void InitServices()
    {/*
        flowLayoutPanelServices.Controls.Clear();

        List<Services> services = await mainController.servicesController.GetAllServicesAsync();

        foreach (Services services1 in services)
        {
            ServicesShortRow servicesShortRow = new ServicesShortRow(services1);
            servicesRow.Add(servicesShortRow);
            flowLayoutPanelServices.Controls.Add(servicesShortRow);
        }*/

    }



    public void ShowCustomer()
    {/*
        label2.Text = customer.Person.Name;
        label4.Text = customer.Person.Surname;
        label6.Text = customer.Person.Phone;
        label8.Text = customer.Person.Email;
        label10.Text = customer.Person.Address;*/
    }



    private async void Add(object? sender, EventArgs e)
    {/*
        if (customer.Customer.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите покупателя.");
            return;
        }

        Order order = new Order()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker1.Value,
            Id_Customer = customer.Customer.Id
        };


        var response = await mainController.orderController.PostOrder(order);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var product in productRow)
        {
            if (product.getQuantity() > 0)
            {
                PurchasedProduct purchasedProduct = new PurchasedProduct()
                {
                    Id_Order = order.Id,
                    Id_Product = product.product.Id,
                    Quantity = product.getQuantity()
                };

                mainController.purchasedProductController.PostPurchasedProduct(purchasedProduct);
            }
        }


        foreach (var services in servicesRow)
        {
            if (services.getQuantity() > 0)
            {
                PurchasedServices purchasedServices = new PurchasedServices()
                {
                    Id_Order = order.Id,
                    Id_Services = services.services.Id,
                    Quantity = services.getQuantity()
                };

                mainController.purchasedServicesController.PostPurchasedServices(purchasedServices);
            }
        }


        dateTimePicker1.Value = DateTime.Now;
        ShowCustomer();
        mainController.UpdateData();*/
    }


}
