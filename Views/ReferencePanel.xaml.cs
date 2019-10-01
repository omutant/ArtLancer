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
    /// Interaction logic for ReferencePanel.xaml
    /// </summary>
    public partial class ReferencePanel : UserControl
    {
        public bool showingRef = false;
        public ReferencePanel()
        {
            InitializeComponent();

        }

        private void RefPan_Toggle(object sender, RoutedEventArgs e)
        {
            if (!showingRef)
            {
                ToggleMenu("Ref_Close", RefToggler, Ref);
                showingRef = true;
            }
            else
            {
                ToggleMenu("Ref_Open", RefToggler, Ref);
                showingRef = false;
            }
            //ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        public void ToggleMenu(string Storyboard, Button toggler, Grid target)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(target);
        }
    }
}
