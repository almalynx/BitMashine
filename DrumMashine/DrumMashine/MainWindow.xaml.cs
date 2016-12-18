using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
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
        private List<List<ChoiceElement>> ticks = new List<List<ChoiceElement>>();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                ticks.Add(new List<ChoiceElement>());
            }
            for (int i = 0; i < 9; i++)
            {
                ticks[0].Add(new ChoiceElement(i));
                ticks[1].Add(new ChoiceElement(i));
                ticks[2].Add(new ChoiceElement(i));
                ticks[3].Add(new ChoiceElement(i));
                ticks[4].Add(new ChoiceElement(i));
                ticks[5].Add(new ChoiceElement(i));
                ticks[6].Add(new ChoiceElement(i));
                ticks[7].Add(new ChoiceElement(i));
            }
            lbTick1.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[0] });
            lbTick2.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[1] });
            lbTick3.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[2] });
            lbTick4.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[3] });
            lbTick5.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[4] });
            lbTick6.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[5] });
            lbTick7.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[6] });
            lbTick8.SetBinding(ListBox.ItemsSourceProperty, new Binding() { Source = ticks[7] });

            String path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
            sound1.Source = new Uri(path + @"\Resources\Samples\kick-thump.wav", UriKind.RelativeOrAbsolute);
            sound2.Source = new Uri(path + @"\Resources\Samples\snare-punch.wav", UriKind.RelativeOrAbsolute);
            sound3.Source = new Uri(path + @"\Resources\Samples\openhat-analog.wav", UriKind.RelativeOrAbsolute);
            sound4.Source = new Uri(path + @"\Resources\Samples\clap-808.wav", UriKind.RelativeOrAbsolute);
            sound5.Source = new Uri(path + @"\Resources\Samples\crash-tape.wav", UriKind.RelativeOrAbsolute);
            sound6.Source = new Uri(path + @"\Resources\Samples\tom-fm.wav", UriKind.RelativeOrAbsolute);
        }

        private void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Звук не найден. Загрузите файл звука.");
        }

        private void ButtonKick_Click(object sender, RoutedEventArgs e)
        {
            sound1.Play();
            Thread.Sleep(1000);
            sound1.Stop();
        }

        private void ButtonSnare_Click(object sender, RoutedEventArgs e)
        {
            sound2.Play();
            Thread.Sleep(1000);
            sound2.Stop();
        }

        private void ButtonOpenHat_Click(object sender, RoutedEventArgs e)
        {
            sound3.Play();
            Thread.Sleep(1000);
            sound3.Stop();
        }

        private void ButtonHighHat_Click(object sender, RoutedEventArgs e)
        {
            sound4.Play();
            Thread.Sleep(1000);
            sound4.Stop();
        }

        private void ButtonCrash_Click(object sender, RoutedEventArgs e)
        {
            sound5.Play();
            Thread.Sleep(1000);
            sound5.Stop();
        }

        private void ButtonTom_Click(object sender, RoutedEventArgs e)
        {
            sound6.Play();
            Thread.Sleep(1000);
            sound6.Stop();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int tag = (int)button.Tag;
            if (ticks[0][tag].Choised)
            {
                DropShadowEffect dse = new DropShadowEffect() { Opacity = 0 };
                button.Effect = dse;
                ticks[0][(int)button.Tag].Choised = false;
            }
            else
            {
                ticks[0][(int)button.Tag].Choised = true;
                DropShadowEffect dse = new DropShadowEffect()
                {
                    Opacity = 1,
                    ShadowDepth = 0,
                    Color = Colors.Yellow
                };
                button.Effect = dse;
            }
        }
        private void ButtonP1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sound7.Source == null)
                MessageBox.Show("Звук не найден. Загрузите файл звука.");
            else
            {
                sound7.Play();
                Thread.Sleep(1000);
                sound7.Stop();
            }
        }

        private void ButtonP2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sound8.Source == null)
                MessageBox.Show("Звук не найден. Загрузите файл звука.");
            else
            {
                sound8.Play();
                Thread.Sleep(1000);
                sound8.Stop();
            }
        }
        private void ButtonP3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sound9.Source == null)
                MessageBox.Show("Звук не найден. Загрузите файл звука.");
            else
            {
                sound9.Play();
                Thread.Sleep(1000);
                sound9.Stop();
            }
        }

        private void ButtonP1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
