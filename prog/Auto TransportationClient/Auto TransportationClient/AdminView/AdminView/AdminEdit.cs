using Auto_TransportationClient.AdminView.CustomerView;
using Auto_TransportationClient.Logic;
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

namespace Auto_TransportationClient.AdminView.AdminView;
public partial class AdminEdit : UserControl
{
    public AdminControl mainController;

    private Admin Admin;

    private Validation validation;

    public AdminEdit(AdminControl mainController, Admin admin)
    {
        this.mainController = mainController;
        Admin = admin;

        validation = new Validation();

        InitializeComponent();
        InitData();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;

    }

    private void InitData()
    {
        textBoxName.Text = Admin.Person.Name;
        textBoxSurname.Text = Admin.Person.Surname;
        textBoxPhone.Text = Admin.Person.Phone;
        textBoxEmail.Text = Admin.Person.Email;
        textBoxAddres.Text = Admin.Person.Address;
        textBoxLogin.Text = Admin.Person.Login;
        textBoxPassword.Text = Admin.Person.Password;
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


        Admin.Person.Name = textBoxName.Text;
        Admin.Person.Surname = textBoxSurname.Text;
        Admin.Person.Phone = textBoxPhone.Text;
        Admin.Person.Email = textBoxEmail.Text;
        Admin.Person.Address = textBoxAddres.Text;
        Admin.Person.Login = textBoxLogin.Text;
        Admin.Person.Password = textBoxPassword.Text;



        if (await mainController.adminController.Put(Admin))
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


        if (await mainController.adminController.Del(Admin))
        {
            mainController.UpdateData();
            mainController.HideActionGroupBox();
        }
    }
}
