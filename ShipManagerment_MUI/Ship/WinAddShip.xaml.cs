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
        private SM.Entities.Model.Ship modifyShip = null;

        //父页面对象
        public ShipListPage parentWin = null;

        public WinAddShip()
        {
            InitializeComponent();
        }

        public WinAddShip(int id)
        {
            modifyShip = _shipBLL.GetShipById(id);
            InitializeComponent();
            if (modifyShip != null)
            {
                lblShipId.Content = modifyShip.Id;
                tbShipName.Text = modifyShip.Name;
                tbShipTonnage.Text = modifyShip.Tonnage.ToString();
                tbPrice.Text = modifyShip.Price.ToString("0.00");
                dpBuyingTime.Value = modifyShip.BuyingTime;
            }
        }

        private void BtnSaveShip_Click(object sender, RoutedEventArgs e)
        {
            string shipName = tbShipName.Text;
            int tonnage = Convert.ToInt32(tbShipTonnage.Text);
            double price = Convert.ToDouble(tbPrice.Text);
            DateTime buyingTime = Convert.ToDateTime(dpBuyingTime.Value);
            var item = new SM.Entities.Model.Ship()
            {
                Name = shipName,
                Tonnage = tonnage,
                Price = price,
                BuyingTime = buyingTime
            };

            //根据隐藏域是否有Id值，判断是新增还是更新
            if (string.IsNullOrEmpty(lblShipId.Content.ToString()))
            {
                item.RecordStatus = 1;
                _shipBLL.AddShip(item);
            }
            else
            {
                item.Id = Convert.ToInt32(lblShipId.Content.ToString());
                _shipBLL.UpdateShip(item);
            }

            //调用父页面刷新方法
            if (parentWin != null)
            {
                parentWin.ShipListDataBind(1);
            }
            this.Close();
        }
    }
}
