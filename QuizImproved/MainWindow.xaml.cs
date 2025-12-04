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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int points = 0;

            if (Q1.SelectedItem is ComboBoxItem q1 && q1.Content.ToString() == "Португальский") points = points + 1;
            if (Q2.SelectedItem is ComboBoxItem q2 && q2.Content.ToString() == "Нидерланды") points = points + 1;
            if (Q3.SelectedItem is ComboBoxItem q3 && q3.Content.ToString() == "Великобритания") points = points + 1;
            if (Q4.SelectedItem is ComboBoxItem q4 && q4.Content.ToString() == "Африка") points = points + 1;
            if (Q5.SelectedItem is ComboBoxItem q5 && q5.Content.ToString() == "Канада") points = points + 1;
            if (Q6.SelectedItem is ComboBoxItem q6 && q6.Content.ToString() == "C. Македония") points = points + 1;
            if (Q7.SelectedItem is ComboBoxItem q7 && q7.Content.ToString() == "Греция") points = points + 1;
            if (Q8.SelectedItem is ComboBoxItem q8 && q8.Content.ToString() == "США") points = points + 1;
            if (Q9.SelectedItem is ComboBoxItem q9 && q9.Content.ToString() == "Саудовская Аравия") points = points + 1;
            if (Q10.SelectedItem is ComboBoxItem q10 && q10.Content.ToString() == "Великобритания") points = points + 1;
            if (Q11.SelectedItem is ComboBoxItem q11 && q11.Content.ToString() == "Азия") points = points + 1;
            if (Q12.SelectedItem is ComboBoxItem q12 && q12.Content.ToString() == "ЮАР") points = points + 1;
            if (Q13.SelectedItem is ComboBoxItem q13 && q13.Content.ToString() == "Ирландия") points = points + 1;
            if (Q14.SelectedItem is ComboBoxItem q14 && q14.Content.ToString() == "Австралия") points = points + 1;
            if (Q15.SelectedItem is ComboBoxItem q15 && q15.Content.ToString() == "Сан-Франциско") points = points + 1;


            if (points <= 5) { MessageBox.Show($"Вы набрали {points} баллов, вы начинающий геогессер"); }
            if (points <= 10 & points > 5) { MessageBox.Show($"Вы набрали {points} баллов, вы средний геогессер"); }
            if (points <= 15 & points > 10) { MessageBox.Show($"Вы набрали {points} баллов, вы крутой геогессер"); }
        }
    }
}
