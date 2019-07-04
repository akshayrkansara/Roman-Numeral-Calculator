//Akshay Kansara, Shubham Sharma, Tyler, Anil-->
//Group 3
using System;
using System.Windows;
namespace Roman_Numeral_Converter
{
    public partial class MainWindow : Window
    {
        RomanConverter rm = new RomanConverter();
        public MainWindow()
        {
            InitializeComponent();
            //rm.LblOut = "Your Answer";
        //    DataContext = rm;
        }
        private void ConvertToRoman_Click(object sender, RoutedEventArgs e)
        {
            String r = TxtBox.Text;
                switch (r)
                {
                    case "1":
                        r = "I";
                        lblDisp.Content = r;
                        break;
                    case "2":
                        r = "II";
                        lblDisp.Content = r;
                        break;
                    case "3":
                        r = "III";
                        lblDisp.Content = r;
                        break;
                    case "4":
                        r = "IV";
                        lblDisp.Content = r;
                        break;
                    case "5":
                        r = "V";
                        lblDisp.Content = r;
                        break;
                    case "6":
                        r = "VI";
                        lblDisp.Content = r;
                        break;
                    case "7":
                        r = "VII";
                        lblDisp.Content = r;
                        break;
                    case "8":
                        r = "VIII";
                        lblDisp.Content = r;
                        break;
                    case "9":
                        r = "IX";
                        lblDisp.Content = r;
                        break;
                    case "10":
                        r = "X";
                        lblDisp.Content = r;
                        break;
                    default:
                        lblDisp.Content = "Error Number Out of Range";
                        break;
                }
        }

        
    }
}

