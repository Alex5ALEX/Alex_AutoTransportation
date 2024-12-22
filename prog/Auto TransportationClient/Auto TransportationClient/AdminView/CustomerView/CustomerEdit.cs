using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_TransportationClient.Logic;

using Auto_TransportationClient.Models;

namespace Auto_TransportationClient.AdminView.CustomerView;
public partial class CustomerEdit : UserControl
{
    public CustomerControl mainController;

    private Customer Customer;

    private Validation validation;

    public CustomerEdit(CustomerControl mainController, Customer customer)
    {
        this.mainController = mainController;
        Customer = customer;

        validation = new Validation();

        InitializeComponent();
        InitData();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;

    }

    private void InitData()
    {
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



        if (await mainController.customerController.Put(Customer))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }

    }


    private async void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        if (await mainController.customerController.Del(Customer))
        {
            mainController.UpdateData();
            mainController.HideActionGroupBox();
        }
    }

}
