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
using System.Windows.Media.Animation;

namespace ArtLancer.Views
{
    /// <summary>
    /// Interaction logic for EconomyPanel.xaml
    /// </summary>
    public partial class EconomyPanel : UserControl
    {
        public bool showingEcon = true;
        public EconomyPanel()
        {
            InitializeComponent();
        }

        private void EconPan_Toggle(object sender, RoutedEventArgs e)
        {
            if (!showingEcon)
            {
                ToggleMenu("Econ_Close", Econ);
                showingEcon = true;
            }
            else
            {
                ToggleMenu("Econ_Open", Econ);
                showingEcon = false;
            }
            //ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        public void ToggleMenu(string Storyboard, Grid target)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(target);
        }
    }
}
