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

namespace Mi_IncomeTaxCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {   
            // get text intput from user
            var text = (TextBox)sender;
            // split it to get just the user input.
            string[] inputText = text.ToString().Split(':');
            // if else statement to make sure deleting text doesn't crash the program
            if (inputText.Length > 1)
            {
                // numbers is a test to manually alter info put into the text box.
                var numbers = Convert.ToInt32(inputText[1])/2;
                testInput.Text = inputText[1];
                testInput2.Text = numbers.ToString();
            }
            else
            {
                testInput.Text = "";
                testInput2.Text = "";
            }
        }
    }
}
