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
        public int AX = 1;
        public int BX = 2;
        public int CX = 3;
        public int DX = 4;

        public int from;
        public int to;
        public DiscoveryView()
        {
            InitializeComponent();
        }
        //Load
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();
        }
        //From
        private void AX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            from = AX;
        }
        private void BX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            from = BX;
        }
        private void CX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            from = CX;
        }
        private void DX2_btn_Checked(object sender, RoutedEventArgs e)
        {
            from = DX;
        }
        //TO
        private void AX1_btn_Checked(object sender, RoutedEventArgs e)
        {
            to = AX;
        }
        private void BX1_btn_Checked(object sender, RoutedEventArgs e)
        {
            to = BX;
        }
        private void CX1_btn_Checked(object sender, RoutedEventArgs e)
        {
            to = CX;
        }
        private void DX1_btn_Checked(object sender, RoutedEventArgs e)
        {
            to = DX;
        }
        //User Change
        private void ax_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
            AX = int.Parse(ax_value_box.Text);
        }
        private void bx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
            BX = int.Parse(bx_value_box.Text);
        }
        private void cx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
            CX = int.Parse(cx_value_box.Text);
        }
        private void dx_value_box_LostFocus(object sender, RoutedEventArgs e)
        {
            DX = int.Parse(dx_value_box.Text);
        }
        //Execute
        private void exec_btn_Click_1(object sender, RoutedEventArgs e)
        {
            //? ważne ////////////////////////////////////////
            if (to == AX)
            {
                AX = from;

            }
            if (to == BX)
            {
                BX = from;
                BX = 50;

            }
            if (to == CX)
            {
                CX = from;
                CX = 10;

            }
            if (to == DX)
            {
                DX = from;
                DX = 30;

            }
            //? ważne  ////////////////////////////////////////
            ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();
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
            AX = 1;
            BX = 2;
            CX = 3;
            DX = 4;
            ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();
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
