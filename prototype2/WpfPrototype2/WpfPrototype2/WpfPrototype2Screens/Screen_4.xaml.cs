using System;
using System.Collections.Generic;
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

namespace WpfPrototype2Screens
{
	/// <summary>
	/// Interaction logic for Screen_4.xaml
	/// </summary>
	public partial class Screen_4 : UserControl
	{
		public Screen_4()
		{
			this.InitializeComponent();
		}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 | comboBox2.SelectedIndex == -1 | comboBox3.SelectedIndex == -1 | comboBox4.SelectedIndex == -1 | comboBox5.SelectedIndex == -1 | comboBox6.SelectedIndex == -1 | comboBox7.SelectedIndex == -1)
            {
                MessageBox.Show(@" Ошибка: Выберите критерии.");

            }
            else
            {
                Microsoft.Expression.Prototyping.Services.PlayerContext.Instance.ActiveNavigationViewModel.NavigateToScreen("WpfPrototype2Screens.Screen_5", true);
            }
            }


        }
	}
