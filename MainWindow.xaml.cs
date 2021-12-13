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
using System.Media;

namespace Recykling_Konkurs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer soundPlayer = new SoundPlayer();
        public MainWindow()
        {
            InitializeComponent();
            soundPlayer.SoundLocation = @"..\..\sounds\music.wav";
            soundPlayer.PlayLooping();
        }

        private void btn_Gra_Click(object sender, RoutedEventArgs e)
        {
            // Zagraj w grę - okno modalne
            Gra gra = new Gra();
            gra.ShowDialog();
        }

        private void btn_Nauka_Click(object sender, RoutedEventArgs e)
        {
            // Nauka - okno modalne
            Nauka nauka = new Nauka();
            nauka.ShowDialog();
        }

        private void btn_Quiz_Click(object sender, RoutedEventArgs e)
        {
            // Quiz - okno modalne
            Quiz quiz = new Quiz();
            quiz.ShowDialog();
        }

        private void btn_Ustawienia_Click(object sender, RoutedEventArgs e)
        {
            // Ustawienia - okno modalne
            Ustawienia ustawienia = new Ustawienia();
            ustawienia.ShowDialog();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            // Zamkniecie okienka
            Close();
        }

        private void btn_Autorzy_Click(object sender, RoutedEventArgs e)
        {
            // Autorzy - okno modalne
            Autorzy autorzy = new Autorzy();
            autorzy.ShowDialog();
        }
    }
}
