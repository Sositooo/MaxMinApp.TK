using System.Windows;

namespace MaxMinApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки "Вычислить"
        private void btnVychislit_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2, num3;

            // Проверяем корректность ввода всех трёх полей
            if (!double.TryParse(txtNum1.Text, out num1) ||
                !double.TryParse(txtNum2.Text, out num2) ||
                !double.TryParse(txtNum3.Text, out num3))
            {
                MessageBox.Show("Введите корректные числа!");
                return;
            }

            // Вызываем логику из класса Calculator
            double result;
            if (rbMax.IsChecked == true)
                result = Calculator.GetMax(num1, num2, num3);
            else
                result = Calculator.GetMin(num1, num2, num3);

            txtResult.Text = result.ToString();
        }
    }
}
