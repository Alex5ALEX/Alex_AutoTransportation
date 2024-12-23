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

using Auto_TransportationClient.Logic;

using Auto_TransportationClient.AdminView.RowView;

namespace Auto_TransportationClient.AdminView.DriverView;
public partial class DriverAdd : UserControl
{
    public DriverControl mainController;

    public Auto choisedAuto;

    private Validation validation;

    public DriverAdd(DriverControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();


        buttonBack.Click += mainController.HideActionGroupBox;
        buttonAdd.Click += Add;
    }

    private void InitData()
    {
        choisedAuto = new Auto();
        validation = new Validation();

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




    private async void Add(object sender, EventArgs e)
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


        if (choisedAuto.Id == Guid.Empty)
        {
            MessageBox.Show("Выберите авто.");
            return;
        }

        Driver driver = new Driver()
        {
            Name = textBoxName.Text,
            Surname = textBoxSurname.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Address = textBoxAddres.Text,
            AutoId = choisedAuto.Id,
            //Auto = choisedAuto
        };

        if (await mainController.driverController.Post(driver))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Что то пошло не так");
            return;
        }

        textBoxName.Text = "";
        textBoxSurname.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";
        choisedAuto = new Auto();
        ShowAuto();
    }

}
