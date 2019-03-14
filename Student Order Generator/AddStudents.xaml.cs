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

namespace Student_Order_Generator
{
	/// <summary>
	/// Interaction logic for AddStudents.xaml
	/// </summary>
	public partial class AddStudents : Window
	{
		MainWindow main;

		public AddStudents()
		{
			InitializeComponent();
			main = new MainWindow();
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			string name = txtName.Text;
			lstStudents.Items.Add(name);
			main.Students.Add(name);
			txtName.Clear();
			txtName.Focus();
		}

		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf(lstStudents.SelectedItem));
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			main.StudentNumber = main.Students.Count;
			main.Show();
			this.Close();
		}
	}
}
