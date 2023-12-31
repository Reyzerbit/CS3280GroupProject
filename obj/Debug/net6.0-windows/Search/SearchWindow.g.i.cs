﻿#pragma checksum "..\..\..\..\Search\SearchWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85673636F33E28EC58D98F9224F148EB05492C7C"
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
using Microsoft.Windows.Themes;
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
        
        
        #line 326 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboInvNum;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboInvDate;
        
        #line default
        #line hidden
        
        
        #line 328 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboInvCharge;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgResults;
        
        #line default
        #line hidden
        
        
        #line 330 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectInvoice;
        
        #line default
        #line hidden
        
        
        #line 331 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 332 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvNum;
        
        #line default
        #line hidden
        
        
        #line 333 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvDate;
        
        #line default
        #line hidden
        
        
        #line 334 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotalCharge;
        
        #line default
        #line hidden
        
        
        #line 335 "..\..\..\..\Search\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSelectStatus;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\Search\SearchWindow.xaml"
            ((GroupPrject.Search.SearchWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.WindowClosing);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\Search\SearchWindow.xaml"
            ((GroupPrject.Search.SearchWindow)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboInvNum = ((System.Windows.Controls.ComboBox)(target));
            
            #line 326 "..\..\..\..\Search\SearchWindow.xaml"
            this.cboInvNum.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.InvNumPass);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboInvDate = ((System.Windows.Controls.ComboBox)(target));
            
            #line 327 "..\..\..\..\Search\SearchWindow.xaml"
            this.cboInvDate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.InvDatePass);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cboInvCharge = ((System.Windows.Controls.ComboBox)(target));
            
            #line 328 "..\..\..\..\Search\SearchWindow.xaml"
            this.cboInvCharge.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.InvChargePass);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgResults = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.btnSelectInvoice = ((System.Windows.Controls.Button)(target));
            
            #line 330 "..\..\..\..\Search\SearchWindow.xaml"
            this.btnSelectInvoice.Click += new System.Windows.RoutedEventHandler(this.SelectInvoice);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 331 "..\..\..\..\Search\SearchWindow.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.ClearSearch);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblInvNum = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblInvDate = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lblTotalCharge = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lblSelectStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

