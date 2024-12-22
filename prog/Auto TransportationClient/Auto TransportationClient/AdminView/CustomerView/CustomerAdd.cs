using Auto_TransportationClient.Models;
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


namespace Auto_TransportationClient.AdminView.CustomerView;
public partial class CustomerAdd : UserControl
{
    public CustomerControl mainController;

    private Validation validation;

    public CustomerAdd(CustomerControl mainController)
    {
        this.mainController = mainController;

        validation = new Validation();

        InitializeComponent();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonAdd.Click += Add;
    }

    private async void Add(object sender, EventArgs e ) 
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


        Customer customer = new Customer()
        { Person = new Person()
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddres.Text,
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text
            } 
        };





        if (await mainController.customerController.Post(customer))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }

        textBoxSurname.Text = "";
        textBoxName.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";
        textBoxLogin.Text = "";
        textBoxPassword.Text = "";


    }


}
