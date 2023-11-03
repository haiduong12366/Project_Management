using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FullScreenAppDemo.View.UC;
namespace FullScreenAppDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),      //First Point of First Line
                        new ObservablePoint(4,7),       //2nd POint
                        new ObservablePoint(5,3),     //------
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),      //First Point of 2nd Line
                        new ObservablePoint(2,5),       //2nd POint
                        new ObservablePoint(3,6),     //------
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,4),      //First Point of 3rd Line
                        new ObservablePoint(5,5),       //2nd POint
                        new ObservablePoint(7,7),     //------
                        new ObservablePoint(9,10),
                        new ObservablePoint(10,9)
                    },
                    PointGeometrySize = 15
                }
            };
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UCUser u = new UCUser();
            u.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UCProjects P = new UCProjects();
            P.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UCTask T = new UCTask();
            T.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UCTimeKeeping Ti = new UCTimeKeeping();
            Ti.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            UCTeam Te = new UCTeam();
            Te.Show();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            UCSalary S = new UCSalary();
            S.Show();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            UCLeaveRequest L = new UCLeaveRequest();
            L.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UCHome H = new UCHome();
            H.Show();
        }
    }
}
