using System;
using System.Windows;

//Jiwant Singh
//Nihal Ahmed Gesudraz
//Apoorva Solanki
//Kiranpreet Kaur
//Harkirat Kaur

namespace RockPaperScissor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		RPSVM vm = new RPSVM();
		const int rock = 1;
		const int paper = 2;
		const int scissor = 3;

		public MainWindow()
		{
			InitializeComponent();
			DataContext = vm;
			vm.ComputerMakesSelection();
		}

		private void Replay(object sender, EventArgs e)
		{
			vm.Replay();
		}

		private void Rock(object sender, EventArgs e)
		{
			vm.GamePlay(rock);
		}

		private void Paper(object sender, EventArgs e)
		{
			vm.GamePlay(paper);
		}

		private void Scissor(object sender, EventArgs e)
		{
			vm.GamePlay(scissor);
		}
	}
}
