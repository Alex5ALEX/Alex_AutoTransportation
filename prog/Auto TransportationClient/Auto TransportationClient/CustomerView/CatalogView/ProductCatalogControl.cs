
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

public partial class ProductCatalogControl : UserControl
{/*
    private CatalogControl mainController;
    private Product product;
    */
    public ProductCatalogControl()//CatalogControl mainController, Product product)
    {
        //this.mainController = mainController;
        //this.product = product;

        InitializeComponent();
        InitData();
    }

    private async void InitData()
    {/*
        labelNameText.Text = product.Name;
        labelPriceText.Text = product.Price.ToString();
        labelTypeText.Text = product.Type.ToString();
       
        Provider provider = await mainController.providerController.GetProviderById(product.Id_Provider);
        Manufacture manufacture = await mainController.manufactureController.GetManufactureById(product.Id_Manufacture);

        label2.Text = provider.Company;
        label3.Text = provider.ContactPerson;
        label5.Text = provider.Phone;
        label7.Text = provider.Email;

        label9.Text = manufacture.Company;*/
    }
}
