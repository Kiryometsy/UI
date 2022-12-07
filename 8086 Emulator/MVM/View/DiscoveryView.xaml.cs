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
    /// Interaction logic for DiscoveryView.xaml
    /// </summary>
    public partial class DiscoveryView : UserControl
    {
        /*public int AX = 1;
        public int BX = 2;
        public int CX = 3;
        public int DX = 4;*/

        public int from;
        public int to;

        public string fromNazwa;
        public string toNazwa;
        public int[] tab = new int[4] { 1, 2, 3, 4 };
        public string[] nazwy = new string[4] { "ax", "bx", "cx", "dx" };
        public DiscoveryView()
        {
            InitializeComponent();
        }
        //Load
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //ax_value_box.Text = AX.ToString();
            //bx_value_box.Text = BX.ToString();
            //cx_value_box.Text = CX.ToString();
            //dx_value_box.Text = DX.ToString();
            ax_value_box.Text = tab[0].ToString();
            bx_value_box.Text = tab[1].ToString();
            cx_value_box.Text = tab[2].ToString();
            dx_value_box.Text = tab[3].ToString();

        }
        //From
        private void AX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            //from = AX;
            from = tab[0];
            fromNazwa = nazwy[0];
        }
        private void BX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            //from = BX;
            from = tab[1];
            fromNazwa = nazwy[1];
        }
        private void CX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            //from = CX;
            from = tab[2];
            fromNazwa = nazwy[2];
        }
        private void DX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            //from = DX;
            from = tab[3];
            fromNazwa = nazwy[3];
        }
        //TO
        private void AX1_btn_Checked(object sender, RoutedEventArgs e)
        {
            //to = AX;
            to = tab[0];
            toNazwa= nazwy[0];
        }
        private void BX1_btn_Checked(object sender, RoutedEventArgs e)
        {
            //to = BX;
            to = tab[1];
            toNazwa = nazwy[1];
        }
        private void CX1_btn_Checked(object sender, RoutedEventArgs e)
        {
           //to = CX;
            to = tab[2];
            toNazwa = nazwy[2];
        }
        private void DX1_btn_Checked(object sender, RoutedEventArgs e)
        {
            //to = DX;
            to = tab[3];
            toNazwa = nazwy[3];
        }
        //User Change
        private void ax_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
           // AX = int.Parse(ax_value_box.Text);
            tab[0] = int.Parse(ax_value_box.Text);
        }
        private void bx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
            //BX = int.Parse(bx_value_box.Text);
            tab[1] = int.Parse(bx_value_box.Text);
        }
        private void cx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
            //CX = int.Parse(cx_value_box.Text);
            tab[2] = int.Parse(cx_value_box.Text);
        }
        private void dx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
            //DX = int.Parse(dx_value_box.Text);
            tab[3]=int.Parse(dx_value_box.Text);
        }
        //Execute
        private void exec_btn_Click_1(object sender, RoutedEventArgs e)
        {
            //? ważne ////////////////////////////////////////
            /*if (to == AX)
            {
                AX = from;

            }
            else if (to == BX)
            {
                BX = from;

            }
            else if (to == CX)
            {
                CX = from;

            }
            else if (to == DX)
            {
                DX = from;
            }*/

            for (int i = 0; i < 4; i++)
            {
                if (fromNazwa == nazwy[i])
                {
                    from = tab[i];
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (toNazwa == nazwy[i])
                {
                    tab[i] = from;
                    break;
                }
            }
            //? ważne  ////////////////////////////////////////
            /*ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();*/

            ax_value_box.Text = tab[0].ToString();
            bx_value_box.Text = tab[1].ToString();
            cx_value_box.Text = tab[2].ToString();
            dx_value_box.Text = tab[3].ToString();

            AX1_btn.IsChecked = false;
            BX1_btn.IsChecked = false;
            CX1_btn.IsChecked = false;
            DX1_btn.IsChecked = false;
            AX2_btn.IsChecked = false;
            BX2_btn.IsChecked = false;
            CX2_btn.IsChecked = false;
            DX2_btn.IsChecked = false;
        }
        //Reset
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            /* AX = 1;
             BX = 2;
             CX = 3;
             DX = 4;
             ax_value_box.Text = AX.ToString();
             bx_value_box.Text = BX.ToString();
             cx_value_box.Text = CX.ToString();
             dx_value_box.Text = DX.ToString();*/
            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 3;
            tab[3] = 4;

            ax_value_box.Text = tab[0].ToString();
            bx_value_box.Text = tab[1].ToString();
            cx_value_box.Text = tab[2].ToString();
            dx_value_box.Text = tab[3].ToString();

            AX1_btn.IsChecked = false;
            BX1_btn.IsChecked = false;
            CX1_btn.IsChecked = false;
            DX1_btn.IsChecked = false;
            AX2_btn.IsChecked = false;
            BX2_btn.IsChecked = false;
            CX2_btn.IsChecked = false;
            DX2_btn.IsChecked = false;
        }
    }
}
