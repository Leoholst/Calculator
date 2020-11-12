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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_One_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                switch (button.Content)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "/":
                    case "-":
                    case "+":
                    case "*":
                        textOne.Text += button.Content;
                        break;
                    case "C":
                        textOne.Text = " ";
                        break;
                    case "Exe":
                        if (textOne.Text.Contains("+"))
                        {
                            var strAdd = textOne.Text.Split('+');
                            var sumAdd = Int32.Parse(strAdd[0]) + Int32.Parse(strAdd[1]);
                            var finalSumAdd = sumAdd.ToString();
                            textTwo.Text = finalSumAdd;
                            textOne.Text = " ";
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
