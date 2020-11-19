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
                    case "÷":
                    case "-":
                    case "+":
                    case "x":
                        textIn.Text += button.Content;
                        break;
                    case "C":
                        textIn.Text = " ";
                        break;
                    case "Exe":
                        if (textIn.Text.Contains("+"))
                        {
                            var strAdd = textIn.Text.Split('+');
                            var sumAdd = Int32.Parse(strAdd[0]) + Int32.Parse(strAdd[1]);
                            var finalSumAdd = sumAdd.ToString();
                            textOut.Text = finalSumAdd;
                            textIn.Text = " ";
                        }
                        else if (textIn.Text.Contains("-"))
                        {
                            var strSub = textIn.Text.Split('-');
                            var sumSub = Int32.Parse(strSub[0]) - Int32.Parse(strSub[1]);
                            var finalSumSub = sumSub.ToString();
                            textOut.Text = finalSumSub;
                            textIn.Text = " ";
                        }
                        else if (textIn.Text.Contains("x"))
                        {
                            var strMult = textIn.Text.Split('x');
                            var sumMult = Int32.Parse(strMult[0]) * Int32.Parse(strMult[1]);
                            var finalSumMult = sumMult.ToString();
                            textOut.Text = finalSumMult;
                            textIn.Text = " ";
                        }
                        else if (textIn.Text.Contains("÷"))
                        {
                            var strDiv = textIn.Text.Split('÷');
                            var sumDiv = float.Parse(strDiv[0]) / float.Parse(strDiv[1]);
                            var finalSumDiv = sumDiv.ToString();
                            textOut.Text = finalSumDiv;
                            textIn.Text = " ";
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
