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

namespace DrumMashine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<List<ChoiceElement>> ticks = new List<List<ChoiceElement>>();
            for (int i = 1; i < 7; i++)
            {
                ticks.Add(new List<ChoiceElement>());
            }
            for (int i = 1; i < 10; i++)
            {
                ticks[0].Add(new ChoiceElement(i));
                ticks[1].Add(new ChoiceElement(i));
                ticks[2].Add(new ChoiceElement(i));
                ticks[3].Add(new ChoiceElement(i));
                ticks[4].Add(new ChoiceElement(i));
                ticks[5].Add(new ChoiceElement(i));
                ticks[6].Add(new ChoiceElement(i));
            }
            Binding binding = new Binding();
            lbTick1.DataContext = ticks[1];
            binding.Source = ticks[1];
            lbTick1.SetBinding(ListBox.ItemsSourceProperty, binding);
        }
    }
}
