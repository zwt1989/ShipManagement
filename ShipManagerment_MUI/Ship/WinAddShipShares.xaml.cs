using FirstFloor.ModernUI.Windows.Controls;
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
using SM.BLL;

namespace ShipManagerment_MUI.Ship
{
    /// <summary>
    /// Interaction logic for WinAddShipShares.xaml
    /// </summary>
    public partial class WinAddShipShares : ModernWindow
    {
        private ShipSharesBLL _sharesBll = new ShipSharesBLL();
        private SM.Entities.Model.ShipShares modifyShares = null;

        //父页面对象
        public ShipSharesListPage parentWin = null;

        public WinAddShipShares()
        {
            InitializeComponent();
        }

        public WinAddShipShares(int id)
        {
            modifyShares = _sharesBll.GetShipSharesById(id);
            InitializeComponent();

            //初始化下拉

            if (modifyShares != null)
            {
                cbShipList.SelectedValue=modifyShares.ShipId;
                cbSharesHolderList.SelectedValue = modifyShares.ShareHolderId;

            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
