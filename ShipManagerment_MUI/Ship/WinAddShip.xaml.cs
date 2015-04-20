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
    /// Interaction logic for WinAddShip.xaml
    /// </summary>
    public partial class WinAddShip : ModernWindow
    {
        private ShipBLL _shipBLL = new ShipBLL();

        public WinAddShip()
        {
            InitializeComponent();
        }

        private void BtnSaveShip_Click(object sender, RoutedEventArgs e)
        {
            string shipName = tbShipName.Text;
            int tonnage = Convert.ToInt32(tbShipTonnage.Text);
            double price = Convert.ToDouble(tbPrice.Text);
            DateTime buyingTime = Convert.ToDateTime(dpBuyingTime.Value);
            _shipBLL.AddShip(new SM.Entities.Model.Ship()
            {
                Name = shipName,
                Tonnage = tonnage,
                Price = price,
                BuyingTime = buyingTime,
                RecordStatus = 1
            });
            this.Close();
        }
    }
}
