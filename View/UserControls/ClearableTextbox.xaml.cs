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

namespace CustomTextBoxControl.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextbox.xaml
    /// </summary>
    public partial class ClearableTextbox : UserControl
    {
        public ClearableTextbox()
        {
            InitializeComponent();
        }
        private string _placeholder;

        public string Placeholder
        {
            get { return _placeholder; }
            set {
                _placeholder = value;
                tbPlaceholder.Text = _placeholder;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();   
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else
                tbPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}
