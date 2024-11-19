using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_11___Arrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] numbers = new int[6] { 100, 50, 20, 60, 90, 80 };
        int maximum = 0;
        int minimum = int.MaxValue;
        int[] smallestAndBiggestNumber = new int[2];
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            int[] resultaat = ReturnSmallestAndBiggest(numbers);
            outputTextBox.Text = $"resultaat: {resultaat[0]}, {resultaat[1]}";
        }
        private int[] ReturnSmallestAndBiggest(int[] number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            int[] smallestAndBiggestNumber = new int[2] { minimum, maximum };
            return smallestAndBiggestNumber;
        }
    }
}