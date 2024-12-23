using Auto_TransportationClient.AdminView.RowView;
using Auto_TransportationClient.Logic;
using Auto_TransportationClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_TransportationClient.Logic;
using Auto_TransportationClient.AdminView.AutoView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Auto_TransportationClient.AdminView.DriverView;
public partial class DriverEdit : UserControl
{
    private DriverControl mainController;

    public Driver Driver;

    public Auto choisedAuto;

    private Validation validation;

    public DriverEdit(DriverControl mainController, Driver Driver)
    {
        this.mainController = mainController;
        this.Driver = Driver;

        InitializeComponent();
        InitData();

        buttonBack.Click += mainController.HideActionGroupBox;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private void InitData()
    {
        validation = new Validation();

        textBoxName.Text = Driver.Name;
        textBoxSurname.Text = Driver.Surname;
        textBoxPhone.Text = Driver.Phone;
        textBoxEmail.Text = Driver.Email;
        textBoxAddres.Text = Driver.Address;

        choisedAuto = Driver.Auto;
        ShowAuto();

        InitAuto();
    }


    private async void InitAuto()
    {
        var auto = await mainController.autoController.GetAll();

        foreach (var item in auto)
        {
            flowLayoutPanel1.Controls.Add(new AutoShortRow(this, item));
        }
    }


    public void ShowAuto()
    {
        label2.Text = choisedAuto.Brand;
        label4.Text = choisedAuto.Model;
        label5.Text = choisedAuto.MaxFuel.ToString("0.00");
    }


    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
            string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
            string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
            string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        Driver.Name = textBoxName.Text;
        Driver.Surname = textBoxSurname.Text;
        Driver.Phone = textBoxPhone.Text;
        Driver.Email = textBoxEmail.Text;
        Driver.Address = textBoxAddres.Text;
        Driver.AutoId = choisedAuto.Id;




        if (await mainController.driverController.Put(Driver))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("что-то пошло не так");
            return;
        }
        
    }


    private async void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        if (await mainController.driverController.Del(Driver))
        {
            mainController.UpdateData();
            mainController.HideActionGroupBox();
        }
    }


}
