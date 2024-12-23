using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Auto_TransportationClient.AdminView.ReportView;

public partial class FinanceControl : UserControl
{
    private ReportControl mainController;

    public FinanceControl(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();
    
    }

    private void InitData()
    {
        InitLabels();
        InitChart();
    }

    private async void InitChart()
    {
        chart1.Series.Clear();

        Series seriesProd = new Series()
        {
            Name = "ProfitFromProducts",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Column 
        };




        var transport = await mainController.transportationController.GetAll();

        Dictionary<int, double> transportProf = new Dictionary<int, double>();


        foreach (var item in transport)
        {

            if (transportProf.ContainsKey(item.Date.Year))
            {
                transportProf[item.Date.Year] += (double)item.Fuel.Price * item.FuelVolume;
            }
            else
            {
                transportProf.Add(item.Date.Year, (double)item.Fuel.Price * item.FuelVolume);
            }

        }
        

        foreach (var item in transportProf)
        {
            seriesProd.Points.AddXY(item.Key, item.Value);
        }

        
        chart1.Series.Add(seriesProd);

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Years";
        chart1.ChartAreas[0].AxisY.Title = "Profit";

        // Заголовок диаграммы
        chart1.Titles.Add("Profit in Year");

    } 




    private async void InitLabels() 
    {
        var transport = await mainController.transportationController.GetAll();

        label5.Text = transport.Count.ToString();

        double price = 0;

        foreach (var item in transport) 
        {
            price += (double)item.Fuel.Price * item.FuelVolume;
        
        }
        label3.Text = price.ToString("0.00");

    }

}
