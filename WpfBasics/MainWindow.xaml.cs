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

namespace WpfBasics
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropDown_SelectionChanged(this.FinishDropdown, null);
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Description is: {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = false;
            this.AssemblyCheckbox.IsChecked = false;
            this.PlasmaCheckbox.IsChecked = false;
            this.LaserCheckbox.IsChecked = false;
            this.PurchaseCheckbox.IsChecked = false;
            this.LatheCheckbox.IsChecked = false;
            this.DrillCheckbox.IsChecked = false;
            this.FoldCheckbox.IsChecked = false;
            this.RollCheckbox.IsChecked = false;
            this.SawCheckbox.IsChecked = false;
            this.LengthText.Text = string.Empty;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) 
        {
            // sender : checkbox itself
            this.LengthText.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.NoteText.Text = (string)value.Content;
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = this.SupplierNameText.Text;
        }
    }
}