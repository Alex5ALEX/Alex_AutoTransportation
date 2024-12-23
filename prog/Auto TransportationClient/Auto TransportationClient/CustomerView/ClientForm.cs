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
using Auto_TransportationClient.CustomerView.TransportationClientView;

namespace Auto_TransportationClient.CustomerView;


public partial class ClientForm : Form
{

    public Customer Customer;
    public Person Person;

    public HttpClient httpClient;

    public CustomerController customerController;

    public PersonController personController;


    public PersonalAccountControl personalAccountControl;


    public CatalogControl catalogControl;
    public TransportationControl transportatioControl;


    public ClientForm(Person Person)
    {
        this.Person = Person;

        InitializeComponent();
        InitData();

        this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        buttonMenu.Click += ShowMenuButton;
        groupBoxMenu.Click += HideMenuButton;
        labelMenu.Click += HideMenuButton;

        personOption.Click += InitPersonalControl;
        orderOption.Click += InitOrderControl;
        catalogOption.Click += InitCatalogControl;
    }


    public async void InitData()
    {
        httpClient = new HttpClient();

        Customer = new Customer();

        customerController = new CustomerController(httpClient);
        personController = new PersonController(httpClient);


        InitCustomer();
    }

    public  async void InitCustomer()
    {
        Person = await personController.GetByLogin(Person.Login, Person.Password);
        Customer = await  customerController.GetByIdPerson(Person.Id);

        InitControls();
    }

    public async void InitControls()
    {
        personalAccountControl = new PersonalAccountControl(this, Customer);
        catalogControl = new CatalogControl(this);
        transportatioControl = new TransportationControl(this, Customer);

        Controls.Add(personalAccountControl);
        Controls.Add(catalogControl);
        Controls.Add(transportatioControl);

        HideMainControls();
        HideMenuControl();
    }

    //menu options
    private void InitPersonalControl(object sender, EventArgs e)
    {
        HideAllControls();
        personalAccountControl.Visible = true;
    }
    private void InitOrderControl(object sender, EventArgs e)
    {
        HideAllControls();
        transportatioControl.Visible = true;
    }

    private void InitCatalogControl(object sender, EventArgs e)
    {
        HideAllControls();
        catalogControl.Visible = true;
    }


    //controls



    private void HideAllControls()
    {
        HideMenuControl();
        buttonMenu.Visible = false;
        pictureBox1.Visible = false;

        HideMainControls();
    }


    private void HideMainControls()
    {
        personalAccountControl.Visible = false;
        catalogControl.Visible = false;
        transportatioControl.Visible = false;
    }



    //menu
    public void ShowMenuButton(object sender, EventArgs e)
    {
        ShowMenuControl();
    }

    public void HideMenuButton(object sender, EventArgs e)
    {
        HideMenuControl();
    }

    public void ShowMenuControl()
    {
        groupBoxMenu.BringToFront();
        groupBoxMenu.Visible = true;
    }

    public void HideMenuControl()
    {
        groupBoxMenu.Visible = false;
    }

    //exit
    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

}
