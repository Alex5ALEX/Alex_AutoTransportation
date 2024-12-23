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
using Auto_TransportationClient.Logic;
using Auto_TransportationClient.Controller;
using System.DirectoryServices.ActiveDirectory;

namespace Auto_TransportationClient.CustomerView;

public partial class PersonalAccountControl : UserControl
{
    public Customer Customer;

    private ClientForm clientForm;

    public PersonController personController;

    public CustomerController customerController;

    public Validation validation;

    public PersonalAccountControl(ClientForm clientForm, Customer Customer)
    {
        this.clientForm = clientForm;
        this.Customer = Customer;
        

        InitializeComponent();
        InitData();

        buttonMenu.Click += clientForm.ShowMenuButton;
        buttonEdit.Click += Edit;
    }

    public void InitData()
    {
        validation = new Validation();

        customerController = new CustomerController(clientForm.httpClient);
        personController = new PersonController(clientForm.httpClient);

        textBoxName.Text = Customer.Person.Name;
        textBoxSurname.Text = Customer.Person.Surname;
        textBoxPhone.Text = Customer.Person.Phone;
        textBoxEmail.Text = Customer.Person.Email;
        textBoxAddres.Text = Customer.Person.Address;
        textBoxLogin.Text = Customer.Person.Login;
        textBoxPassword.Text = Customer.Person.Password;
    }

    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text) ||
        string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
        string.IsNullOrWhiteSpace(textBoxPassword.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        Customer.Person.Name = textBoxName.Text;
        Customer.Person.Surname = textBoxSurname.Text;
        Customer.Person.Phone = textBoxPhone.Text;
        Customer.Person.Email = textBoxEmail.Text;
        Customer.Person.Address = textBoxAddres.Text;
        Customer.Person.Login = textBoxLogin.Text;
        Customer.Person.Password = textBoxPassword.Text;



        if (await personController.Put(Customer.Person))
        {
            clientForm.Customer = Customer;
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }


    }

}
