﻿#pragma checksum "..\..\..\..\Search\SearchWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A1E0DE11F3F2865A514FC300B0F332DF9C6B0396"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GroupPrject.Search;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GroupPrject.Search {
    
    
    /// <summary>
    /// SearchWindow
    /// </summary>
    public partial class SearchWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboInvNum;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboInvDate;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboInvCharge;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgResults;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelect;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvNum;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvDate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotalCharge;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSelectStatus;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GroupPrject;component/search/searchwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Search\SearchWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cboInvNum = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\..\Search\SearchWindow.xaml"
            this.cboInvNum.DropDownClosed += new System.EventHandler(this.InvNumPass);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboInvDate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cboInvCharge = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\..\..\Search\SearchWindow.xaml"
            this.cboInvCharge.DropDownClosed += new System.EventHandler(this.InvChargePass);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgResults = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnSelect = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Search\SearchWindow.xaml"
            this.btnSelect.Click += new System.Windows.RoutedEventHandler(this.SelectInvoice);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Search\SearchWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.CancelSearch);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblInvNum = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblInvDate = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblTotalCharge = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lblSelectStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

