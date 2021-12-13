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
using System.Windows.Shapes;
using System.Media;

namespace Recykling_Konkurs
{
    /// <summary>
    /// Logika interakcji dla klasy Ustawienia.xaml
    /// </summary>
    public partial class Ustawienia : Window
    {
        SoundPlayer soundPlayer = new SoundPlayer();
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void btn_Main(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            soundPlayer.Stop();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            soundPlayer.SoundLocation = @"..\..\sounds\music.wav";
            soundPlayer.PlayLooping();
        }
    }
}
