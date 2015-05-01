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
using SM.Entities.SearchModel;

namespace ShipManagerment_MUI.Ship
{
    /// <summary>
    /// Interaction logic for ShipSharesListPage.xaml
    /// </summary>
    public partial class ShipSharesListPage : UserControl
    {
        private ShipSharesBLL _sharesBll = new ShipSharesBLL();

        public ShipSharesListPage()
        {
            InitializeComponent();
        }

        #region 分页

        /// <summary>
        /// 每页条数
        /// </summary>
        private int pageSize = 10;

        /// <summary>
        /// 绑定列表
        /// </summary>
        /// <param name="pageIndex">页码</param>
        public void ShipSharesListDataBind(int pageIndex)
        {
            int recordCount = 0;
            IList<SM.Entities.Model.ShipShares> shipSharesList = _sharesBll.GetListByPager(pageIndex, pageSize, new SearchShipShares(), null, out recordCount);
            shipSharesListGrid.DataContext = shipSharesList;

            //设置翻页控件
            int pageSum = 0;
            lblPageNo.Content = pageIndex;
            tbPageNo.Text = Convert.ToString(pageIndex);
            if (recordCount % pageSize == 0)
            {
                pageSum = recordCount / pageSize;
            }
            else
            {
                pageSum = recordCount / pageSize + 1;
            }
            lblTotalPage.Content = pageSum;
        }

        /// <summary>
        /// 上一页方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrePage_Click(object sender, RoutedEventArgs e)
        {
            int curPageNo = Convert.ToInt32(lblPageNo.Content);
            if (curPageNo > 1)
            {
                ShipSharesListDataBind(curPageNo - 1);
            }
        }

        /// <summary>
        /// 下一页方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            int curPageNo = Convert.ToInt32(lblPageNo.Content);
            if (curPageNo < Convert.ToInt32(lblTotalPage.Content))
            {
                ShipSharesListDataBind(curPageNo + 1);
            }
        }

        /// <summary>
        /// 跳转页方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageGo_Click(object sender, RoutedEventArgs e)
        {
            int pageGoNum = Convert.ToInt32(tbPageNo.Text);
            if (pageGoNum >= 1 && pageGoNum <= Convert.ToInt32(lblTotalPage.Content))
            {
                ShipSharesListDataBind(pageGoNum);
            }
        }

        #endregion

        private void btnAddShipShares_OnClick(object sender, RoutedEventArgs e)
        {
            WinAddShipShares addShipSharesWindow = new WinAddShipShares();
            //将当前页面对象赋给弹出窗,用于反向调用
            addShipSharesWindow.parentWin = this;
            addShipSharesWindow.Show();
        }

        private void DeleteShipShares_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _sharesBll.DeleteShip((int)e.Parameter);
            ShipSharesListDataBind(1);
        }

        private void Modify_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            WinAddShipShares addShipSharesWindow = new WinAddShipShares((int)e.Parameter);
            //将当前页面对象赋给弹出窗,用于反向调用
            addShipSharesWindow.parentWin = this;
            addShipSharesWindow.Show();
        }
    }
}
