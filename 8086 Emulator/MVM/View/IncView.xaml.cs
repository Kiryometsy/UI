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

namespace _8086_Emulator.MVM.View
{
    /// <summary>
    /// Interaction logic for IncView.xaml
    /// </summary>
    public partial class IncView : UserControl
    {
        public string toNazwa;
        public int[] tab = new int[4] { 1, 2, 3, 4 };
        public string[] nazwy = new string[4] { "ax", "bx", "cx", "dx" };
        public IncView()
        {
            InitializeComponent();
        }

        //Load
        private void UserControl_Loaded(object sender, EventArgs e)
        {
            ax_value_box.Text = tab[0].ToString();
            bx_value_box.Text = tab[1].ToString();
            cx_value_box.Text = tab[2].ToString();
            dx_value_box.Text = tab[3].ToString();
        }
        //Index
        private void AX1_btn_Checked(object sender, EventArgs e)
        {
            toNazwa = "ax";
        }
        private void BX1_btn_Checked(object sender, EventArgs e)
        {
            toNazwa = "bx";
        }

        private void CX1_btn_Checked(object sender, EventArgs e)
        {
            toNazwa = "cx";
        }
        private void DX1_btn_Checked(object sender, EventArgs e)
        {
            toNazwa = "dx";
        }

        private void ax_value_box_LostFocus(object sender, RoutedEventArgs e)
        {

            tab[0] = int.Parse(ax_value_box.Text);
        }

        private void bx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {

            tab[1] = int.Parse(bx_value_box.Text);
        }
        private void cx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {

            tab[2] = int.Parse(cx_value_box.Text);
        }
        private void dx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {

            tab[3] = int.Parse(dx_value_box.Text);
        }

        private void exec_btn_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (toNazwa == nazwy[i])
                {
                    tab[i]++;
                    break;
                }
            }
            ax_value_box.Text = tab[0].ToString();
            bx_value_box.Text = tab[1].ToString();
            cx_value_box.Text = tab[2].ToString();
            dx_value_box.Text = tab[3].ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 3;
            tab[3] = 4;

            ax_value_box.Text = tab[0].ToString();
            bx_value_box.Text = tab[1].ToString();
            cx_value_box.Text = tab[2].ToString();
            dx_value_box.Text = tab[3].ToString();

        }






    }
}
