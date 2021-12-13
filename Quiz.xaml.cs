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

namespace Recykling_Konkurs
{
    /// <summary>
    /// Interaction logic for Quiz.xaml
    /// </summary>
    public partial class Quiz : Window
    {
        public Quiz()
        {
            InitializeComponent();
            StartGame();
            Nextq();
        }

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int questionNumber = 0;
        int i;
        int score = 0;
        int nq = 1;

        private void Nextq()
        {
            if (questionNumber < questionNumbers.Count)
            {
                i = questionNumbers[questionNumber];
            }
            else
            {
                RestartGame();
            }
            numberq.Content = "Pytanie " + nq + "/15";
            nq++;
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }

            switch (i)
            {
                case 1:
                    txtQuestion.Text = "Co wrzucamy do zielonego pojemnika?";
                    ansQuestion.Text = "";
                    ans1.Content = "Szkło";
                    ans2.Content = "Papier";
                    ans3.Content = "Metal";
                    ans4.Content = "BIO";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q1.png"));
                    break;
                case 2:
                    txtQuestion.Text = "Co to jest recykling?";
                    ansQuestion.Text = "\n A - Naprawiania zepsutych przedmiotów \n B - Segregacja śmieci \n C - Niszczenie odpadów w sposób bezpieczny dla środowiska \n D - Powtórne wykorzystanie materiałow lub substancji";
                    ans1.Content = "A";
                    ans2.Content = "B";
                    ans3.Content = "C";
                    ans4.Content = "D";
                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q2.png"));
                    break;
                case 3:
                    txtQuestion.Text = "Co oznacza ten symbol?";
                    ansQuestion.Text = "\n A - Opakowanie nadaje się do recyklingu \n B - Opakowanie nadaj się do spożycia\n C - Opakowanie nadaje się do ponownego użytku\n D - Opakowanie jest biodegradowalne";
                    ans1.Content = "A";
                    ans2.Content = "B";
                    ans3.Content = "C";
                    ans4.Content = "D";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q3.png"));
                    break;
                case 4:
                    txtQuestion.Text = "Co to jest warstwa ozonowa?";
                    ansQuestion.Text = "\n A - Wierzchnia warstwa ziemi\n B - Jedna z warstw oceanicznych\n C - Warstwa ochronna atmosfery Ziemi\n D - Inna nazwa zorzy polarnej";
                    ans1.Content = "A";
                    ans2.Content = "B";
                    ans3.Content = "C";
                    ans4.Content = "D";
                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q4.png"));
                    break;
                case 5:
                    txtQuestion.Text = "Czego nie można wrzucać do kompostownika?";
                    ansQuestion.Text = "";
                    ans1.Content = "Liści";
                    ans2.Content = "Owoców";
                    ans3.Content = "Trawy";
                    ans4.Content = "Szkła";
                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q5.png"));
                    break;
                case 6:
                    txtQuestion.Text = "Gdzie wyrzuca się zużyte baterie?";
                    ansQuestion.Text = "\n A - Do specjalnego pojemnika \n B - Do kosza na śmieci\n C - Do pojemnika na plastik \n D - Do pojemnika na metale";
                    ans1.Content = "A";
                    ans2.Content = "B";
                    ans3.Content = "C";
                    ans4.Content = "D";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q6.png"));
                    break;
                case 7:
                    txtQuestion.Text = "Energią odnawialną nie jest:";
                    ansQuestion.Text = "";
                    ans1.Content = "Słońce";
                    ans2.Content = "Wodór";
                    ans3.Content = "Woda";
                    ans4.Content = "Wiatr";
                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q7.png"));
                    break;
                case 8:
                    txtQuestion.Text = "Ile rozkłada się plastkiowa butelka?";
                    ansQuestion.Text = "";
                    ans1.Content = "1 rok";
                    ans2.Content = "10 lat";
                    ans3.Content = "50 lat";
                    ans4.Content = ">100 lat";
                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q8.png"));
                    break;
                case 9:
                    txtQuestion.Text = "Ile rozkłada się szkło?";
                    ansQuestion.Text = "";
                    ans1.Content = "10 lat";
                    ans2.Content = "Nigdy";
                    ans3.Content = "100-500 lat";
                    ans4.Content = "2000 lat";
                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q9.png"));
                    break;
                case 10:
                    txtQuestion.Text = "Ile potrzeba drzew do \nwyprodukowania 1 tony papieru?";
                    ansQuestion.Text = "";
                    ans1.Content = "4";
                    ans2.Content = "12";
                    ans3.Content = "17";
                    ans4.Content = "40";
                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q10.png"));
                    break;
                case 11:
                    txtQuestion.Text = "Jak długo rozkłada się guma do żucia?";
                    ansQuestion.Text = "";
                    ans1.Content = "10 lat";
                    ans2.Content = "5 lat";
                    ans3.Content = "2 lata";
                    ans4.Content = "3 miesiące";
                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q11.png"));
                    break;
                case 12:
                    txtQuestion.Text = "Jak długo rozkłada się torebka foliowa?";
                    ansQuestion.Text = "";
                    ans1.Content = "300 lat";
                    ans2.Content = "1000 lat";
                    ans3.Content = "250 lat";
                    ans4.Content = "400 lat";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q12.png"));
                    break;
                case 13:
                    txtQuestion.Text = "Ile kilogramów odpadów produkuje przeciętny Polak?";
                    ansQuestion.Text = "";
                    ans1.Content = "400 kg";
                    ans2.Content = "500 kg";
                    ans3.Content = "90 kg";
                    ans4.Content = "300 kg";
                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q13.png"));
                    break;
                case 14:
                    txtQuestion.Text = "Gdzie można znaleźć napis PET?";
                    ansQuestion.Text = "\n A - Na butelkach plastikowych \n B - Na puszkach po napojach\n C - Na szklanych butelkach \n D - Na pudełkach tekturowych";
                    ans1.Content = "A";
                    ans2.Content = "B";
                    ans3.Content = "C";
                    ans4.Content = "D";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q14.png"));
                    break;
                case 15:
                    txtQuestion.Text = "Co to jest utylizacja?";
                    ansQuestion.Text = "\n A - Proces rozkładu odpadków \n B - Składowanie odpadów na wysypisku\n C - Wykorzystywanie surowców odpadowych do powtórnego użycia \n D - Dziura w ziemi gdzie wrzuca się odpady";
                    ans1.Content = "A";
                    ans2.Content = "B";
                    ans3.Content = "C";
                    ans4.Content = "D";
                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/q15.png"));
                    break;
            }
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            ans1.Tag = "0";
            ans2.Tag = "0";
            ans3.Tag = "0";
            ans4.Tag = "0";

            if (questionNumber < 0) { questionNumber = 0; }
            else { questionNumber++; }

            if (questionNumber == 15)
            {
                if (score > 13) { MessageBox.Show($"Liczba punktów: {score}/15\n\nWiesz już wszystko na temat recyklingu...\nTylko pozazdrościć takiej wiedzy ;)", "Twój wynik", MessageBoxButton.OK, MessageBoxImage.Information); }
                else if (score > 8) { MessageBox.Show($"Liczba punktów: {score}/15\n\nCałkiem dobry wynik\nW zakładce 'Czas na naukę' dowiesz się wielu ciekawych rzeczy ;)", "Twój wynik", MessageBoxButton.OK, MessageBoxImage.Information); }
                else if (score <= 8) { MessageBox.Show($"Liczba punktów: {score}/15\n\nNie poszło ci najlepiej...\nPolacam przeczytać zakładkę 'Czas na naukę' ;)", "Twój wynik", MessageBoxButton.OK, MessageBoxImage.Information); }
                score = 0;
                this.Close();
            }
            Nextq();
        }

        private void RestartGame()
        {
            score = 0;
            questionNumber = -1;
            i = 0;
            StartGame();
        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumbers = randomList;
        }
    }
}
