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

namespace Wpf.Colspan
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainVIewModel _viewModel = new MainVIewModel();
            _viewModel.InitUi();
            DataContext = _viewModel;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            try
            {
                ScrollViewer sv = e.OriginalSource as ScrollViewer;
                if (sv != null)
                {
                    scrView.ScrollToHorizontalOffset(sv.HorizontalOffset);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
