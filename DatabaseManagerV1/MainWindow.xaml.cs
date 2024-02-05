using DatabaseManagerV1.Managers;
using DatabaseManagerV1.Templates;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace DatabaseManagerV1
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

		#region form ui actions
		Point pxy;
		private void TopBar_MouseDown(object sender, MouseButtonEventArgs e)
		{
			pxy = e.GetPosition(this);
		}

		private void TopBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				this.Left += e.GetPosition(this).X - pxy.X;
				this.Top += e.GetPosition(this).Y - pxy.Y;
			}
		}
		private void exitButton_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				Application.Current.Shutdown();
			}
		}
		private void minimizeButton_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		#endregion

		private void runQuery_Click(object sender, RoutedEventArgs e)
		{
			RunQueryBySelection();
		}


		List<ManagersTemplate> managersList = new List<ManagersTemplate>()
		{
			new CoreHotel(),
			new CoreCodeSharingApp(),
		};

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (var manager in managersList)
			{
				targetDbBox.Items.Add(manager);
			}
		}

		private void RunQueryBySelection()
		{
			if (queryentry.Text.Replace(" ", "").Length > 0)
			{
				if (executedQueriesList.Items.Count > 0)
				{
					executedQueriesList.Items.Add(new Separator());
				}
				ListBoxItem queryItem = new ListBoxItem();
				queryItem.Content = queryentry.Text;
				queryItem.Selected += QueryItem_Selected;
				executedQueriesList.Items.Add(queryItem);

				DataTable? dbt = null;
				dbt = managersList[targetDbBox.SelectedIndex].RequestQuery(queryentry.Text) as DataTable;
				dg1.ItemsSource = dbt?.AsDataView();
			}
			else
			{
				MessageBox.Show("Empty query");
			}
		}

		private void QueryItem_Selected(object sender, RoutedEventArgs e)
		{
			HideEqp();
			if (MessageBox.Show("Load Query", "Executed Queries", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
			{
				queryentry.Text = ((ListBoxItem)sender).Content.ToString();
			}
		}

		private void CheckSelectedDbServiceRunning()
		{
			managersList[targetDbBox.SelectedIndex].CheckService(true);
		}

		private void startService_Click(object sender, RoutedEventArgs e)
		{
			CheckSelectedDbServiceRunning();
		}
		void HideEqp()
		{
			DoubleAnimation h = new DoubleAnimation(eqPanel.Width, 0, new Duration(TimeSpan.FromMilliseconds(100)));
			eqPanel.BeginAnimation(Border.HeightProperty, h);
		}
		void ShowEqp()
		{
			DoubleAnimation h = new DoubleAnimation(0, eqPanel.Width, new Duration(TimeSpan.FromMilliseconds(100)));
			eqPanel.BeginAnimation(Border.HeightProperty, h);
		}
		private void eqpgrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			HideEqp();
		}

		private void eQueriesBtn_Click(object sender, RoutedEventArgs e)
		{
			ShowEqp();
		}
	}
}
