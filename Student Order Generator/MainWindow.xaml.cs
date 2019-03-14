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
using System.IO;

namespace Student_Order_Generator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public List<string> Students;
		public int StudentNumber;
		List<int> student_order;
		Random student_r;

		public MainWindow()
		{
			InitializeComponent();
			Students = new List<string>();
			student_r = new Random();
			student_order = new List<int>();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			string student_name;
			int index = student_r.Next(0, Students.Count);
			student_name = Students[index];
			lblStudent.Content = student_name;
			Students.Remove(student_name);

		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			Random order_r = order_r = new Random();
			int order;
			do
			{
				order = order_r.Next(1, StudentNumber+1);
			}
			while (student_order.Contains(order));
			lblOrder.Content = order;
			lstStudentOrder.Items.Add(order + "\t" + lblStudent.Content);
			student_order.Add(order);
			if (Students.Count == 0)
			{
				btnChooseStudent.IsEnabled = false;
				btnGenerateNumber.IsEnabled = false;
				using (StreamWriter writer = new StreamWriter("important.txt"))
				{
					foreach( string item in lstStudentOrder.Items )
						writer.WriteLine(item);
					
				}
			}
		}
	}
}
