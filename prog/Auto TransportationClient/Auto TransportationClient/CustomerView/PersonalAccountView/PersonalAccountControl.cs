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

public partial class PersonalAccountControl : UserControl
{
    //public CustomerDTO Customer;

    private ClientForm mainForm;


    //public CustomerController customerController;

    //public Validation validation;

    public PersonalAccountControl()//ClientForm mainForm,CustomerDTO Customer)
    {
        //this.Customer = Customer;
        //this.mainForm = mainForm;

        InitializeComponent();
        InitData();

        buttonMenu.Click += mainForm.ShowMenuButton;
        buttonEdit.Click += Edit;
    }

    public void InitData()
    {/*
        validation = new Validation();

        customerController = new CustomerController(mainForm.httpClient);

        textBoxName.Text = Customer.Person.Name;
        textBoxSurname.Text = Customer.Person.Surname;
        textBoxPhone.Text = Customer.Person.Phone;
        textBoxEmail.Text = Customer.Person.Email;
        textBoxAddres.Text = Customer.Person.Address;
        textBoxLogin.Text = Customer.Person.Login;
        textBoxPassword.Text = Customer.Person.Password;*/
    }

    private async void Edit(object? sender, EventArgs e)
    {/*
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



        if (await customerController.Put(Customer))
        {
            mainForm.Customer = Customer;
            //mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }
        */
    }

}
