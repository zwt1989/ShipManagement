﻿#pragma checksum "..\..\..\Ship\ShipListPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F57F87CD06DC6897B5EA71B510D84EEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ShipManagerment_MUI.Ship {
    
    
    /// <summary>
    /// ShipListPage
    /// </summary>
    public partial class ShipListPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddShip;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid shipListGrid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrePage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNextPage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPageNo;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotalPage;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPageNo;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Ship\ShipListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPageGo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShipManagerment_MUI;component/ship/shiplistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ship\ShipListPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnAddShip = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Ship\ShipListPage.xaml"
            this.btnAddShip.Click += new System.Windows.RoutedEventHandler(this.btnAddShip_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.shipListGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 40 "..\..\..\Ship\ShipListPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteShip_OnExecuted);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\..\Ship\ShipListPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Modify_OnExecuted);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPrePage = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Ship\ShipListPage.xaml"
            this.btnPrePage.Click += new System.Windows.RoutedEventHandler(this.btnPrePage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnNextPage = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Ship\ShipListPage.xaml"
            this.btnNextPage.Click += new System.Windows.RoutedEventHandler(this.btnNextPage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblPageNo = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblTotalPage = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.tbPageNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnPageGo = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Ship\ShipListPage.xaml"
            this.btnPageGo.Click += new System.Windows.RoutedEventHandler(this.btnPageGo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

