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

namespace VypisPrvocisel
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

        private void FirstOpBut_Click(object sender, RoutedEventArgs e)
        {
            int Res;
            int t;
            async Task<int> FirstAsync()
            {
                int i = 0;
                await Task.Run(() =>
                {
                    for (int i = 2; i < 10; i++)
                    {
                        if (Convert.ToChar(FirstOpFirst.Text) != i) if (Convert.ToChar(FirstOpFirst.Text) % i == 0) return;
                    }
                    string s = Convert.ToString(FirstOpResult);
                    t = Convert.ToInt16(FirstOpSecond.Text);
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == Convert.ToChar(FirstOpFirst.Text))
                        {
                            for (int ii = 0; ii < Res; ii++)
                            {
                                if (i + Res >= s.Length) return;
                                else if (s[i + ii] != Convert.ToChar(FirstOpFirst.Text)) return;

                            }
                            FirstOpResult.Text = Convert.ToString(Res);
                        }
                    }
                });
                return i;
            }
        }

        private void SecondOpBut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThirdtOpBut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
