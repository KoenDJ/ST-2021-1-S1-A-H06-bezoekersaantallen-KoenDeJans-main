using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prb.VisitorsCount.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] vistorsDaily = new int[7];
        int visitorsTotal;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AddDayNameLabels();
            ShowNumberOfVisitors();
            txtVisitors.Focus();
            dtpDate.SelectedDate = DateTime.Now;
            lblToday.Content = $"Today: + {DateTime.Now.ToShortDateString()}";
        }

        private void AddDayNameLabels()
        {
            AddDayNameLabel(1);
            AddDayNameLabel(2);
            AddDayNameLabel(3);
            AddDayNameLabel(4);
            AddDayNameLabel(5);
            AddDayNameLabel(6);
            AddDayNameLabel(0);
        }

        void AddDayNameLabel(int dayNumber)
        {
            Label lblDayLabel = new Label();
            lblDayLabel.Content = (DayOfWeek)dayNumber;
            stpNamesOfDays.Children.Add(lblDayLabel);
        }

        void ShowNumberOfVisitors()
        {
            stpVisitors.Children.Clear();
            AddNumberOfVisitors(1);
            AddNumberOfVisitors(2);
            AddNumberOfVisitors(3);
            AddNumberOfVisitors(4);
            AddNumberOfVisitors(5);
            AddNumberOfVisitors(6);
            AddNumberOfVisitors(0);

        }

        void AddNumberOfVisitors(int dayNumber)
        {
            Label lblVisitors = new Label();
            int numberOfVisitors = vistorsDaily[dayNumber];

            lblVisitors.Content = numberOfVisitors;
            visitorsTotal += numberOfVisitors;

            stpVisitors.Children.Add(lblVisitors);
        }

    }
}
