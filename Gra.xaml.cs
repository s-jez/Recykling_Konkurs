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
using System.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Recykling_Konkurs
{
    /// <summary>
    /// Logika interakcji dla klasy Gra.xaml
    /// </summary>
    public partial class Gra : Window
    {
        int maxSmieci = 5;
        int obecnieSmieci = 0;

        Random ran = new Random();

        int wynik = 0;
        int zycia = 3;

        DispatcherTimer ZegarGry = new DispatcherTimer();
        List<Rectangle> UsunieteElementy = new List<Rectangle>(); 
        ImageBrush PlayerIkona = new ImageBrush();
        ImageBrush TloIkona = new ImageBrush();

        public Gra()
        {
            InitializeComponent();
            ZegarGry.Tick += dropItems;
            ZegarGry.Interval = TimeSpan.FromMilliseconds(30);
            ZegarGry.Start();
            PlayerIkona.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/kosz.png"));
            TloIkona.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/bg_kosze.jpg"));
            Player.Fill = PlayerIkona;
            myCanvas.Background = TloIkona;
        }

        private void myCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point pozycja = e.GetPosition(this);
            double pX = pozycja.X;
            double pY = pozycja.Y;
            Canvas.SetLeft(Player, pX - 10);
        }

        private void dropItems(object sender, EventArgs e)
        {
            lb_Wynik.Content = "Twój wynik: " + wynik;
            lb_Zycia.Content = "Życia: " + zycia;

            if (obecnieSmieci < maxSmieci)
            {
                makePresents();
                obecnieSmieci++;
                UsunieteElementy.Clear();
            }

            if (wynik > 300) { Player.Width = 20; Player.Height = 30; }
            else if (wynik > 200) { Player.Width = 30; Player.Height = 40; }
            else if (wynik > 100) { Player.Width = 40; Player.Height = 50; }
            else if (wynik > 50) { Player.Width = 45; Player.Height = 60; }
            else if (wynik > 20) { Player.Width = 50; Player.Height = 65; }
            else if (wynik > 10) { Player.Width = 70; Player.Height = 70; }

            foreach (var x in myCanvas.Children.OfType<Rectangle>())
            {
                if ((string)x.Tag == "drops")
                {
                    int dropThis = ran.Next(5, 15);
                    Canvas.SetTop(x, Canvas.GetTop(x) + dropThis);
                    Rect items = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);
                    Rect playerObject = new Rect(Canvas.GetLeft(Player), Canvas.GetTop(Player), Player.Width, Player.Height);

                    if (playerObject.IntersectsWith(items))
                    {
                        UsunieteElementy.Add(x);
                        obecnieSmieci--;
                        wynik++;
                    }
                    else if (Canvas.GetTop(x) > 800)
                    {
                        UsunieteElementy.Add(x);
                        obecnieSmieci--;
                        zycia--;
                    }
                }

                if (zycia <= 0)
                {
                    ZegarGry.Stop();
                    lb_Zycia.Content = "Życia: 0";
                    if (wynik > 300) { MessageBox.Show("SZOOOOK !!!\nZebrałeś aż " + wynik + " śmieci\nTo fenomenalny wynik, jak to zrobiłeś???" + Environment.NewLine + Environment.NewLine + "Walczyłeś dzielnie, ale niestety to koniec... :(" + Environment.NewLine + Environment.NewLine, "KONIEC GRY", MessageBoxButton.OK, MessageBoxImage.Information); }
                    else if (wynik > 200) { MessageBox.Show("GRATULACJEEEE !!\nZebrałeś aż " + wynik + " śmieci\nTo bardzo dobry wynik, jestem z Ciebie dumny" + Environment.NewLine + Environment.NewLine + "Walczyłeś dzielnie, ale niestety to koniec... :(" + Environment.NewLine + Environment.NewLine, "KONIEC GRY", MessageBoxButton.OK, MessageBoxImage.Information); }
                    else if (wynik > 100) { MessageBox.Show("ŁADNIEEE !\nZebrałeś sporo, bo aż " + wynik + " śmieci\nDobry wynik, trzymaj tak dalej" + Environment.NewLine + Environment.NewLine + "Walczyłeś dzielnie, ale niestety to koniec... :(" + Environment.NewLine + Environment.NewLine, "KONIEC GRY", MessageBoxButton.OK, MessageBoxImage.Information); }
                    else if (wynik > 50) { MessageBox.Show("NIEŹLE \nZebrałeś " + wynik + " śmieci\nSpróbuj uzyskać lepszy wynik" + Environment.NewLine + Environment.NewLine + "Walczyłeś dzielnie, ale niestety to koniec... :(" + Environment.NewLine + Environment.NewLine, "KONIEC GRY", MessageBoxButton.OK, MessageBoxImage.Information); }
                    else { MessageBox.Show("SŁABOO...\nZebrałeś " + wynik + " śmieci\nNastępnym razem będzie lepiej" + Environment.NewLine + Environment.NewLine + "Walczyłeś dzielnie, ale niestety to koniec... :(" + Environment.NewLine + Environment.NewLine, "KONIEC GRY", MessageBoxButton.OK, MessageBoxImage.Information); }

                    resetGame();
                }
            }

            foreach (Rectangle y in UsunieteElementy)
            {
                myCanvas.Children.Remove(y);
            }
        }

        private void resetGame()
        {
            SystemSounds.Beep.Play();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
            Environment.Exit(0);
        }

        private void makePresents()
        {
            ImageBrush presents = new ImageBrush();
            int i = ran.Next(1, 5);

            switch (i)
            {
                case 1:
                    presents.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/puszka.png"));
                    break;
                case 2:
                    presents.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/butelka.png"));
                    break;
                case 3:
                    presents.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/butelka_plastik.png"));
                    break;
                case 4:
                    presents.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/kubek.png"));
                    break;
                case 5:
                    presents.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/konserwa.png"));
                    break;
            }

            Rectangle newRec = new Rectangle
            {
                Tag = "drops",
                Width = 50,
                Height = 75,
                Fill = presents,
            };

            Canvas.SetTop(newRec, ran.Next(60, 150) * -1);
            Canvas.SetLeft(newRec, ran.Next(10, 780));

            myCanvas.Children.Add(newRec);
        }
        protected override void OnClosed(EventArgs e)
        {
            resetGame();
        }
    }
}
