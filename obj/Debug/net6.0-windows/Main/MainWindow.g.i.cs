﻿#pragma checksum "..\..\..\..\Main\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894B8E52905FB1A1CADA84B4F3E7EB241157F265"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GroupPrject;
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


namespace GroupPrject {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InvoiceDateBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InvoiceNumberBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InvoiceCostBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ItemsDropdown;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddItemButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedItemCostLabel;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveItemButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ItemsGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GroupPrject;V1.0.0.0;component/main/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Main\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Main\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenSearch);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\..\Main\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenItems);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\..\..\Main\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateInvoice);
            
            #line default
            #line hidden
            return;
            case 4:
            this.InvoiceDateBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.InvoiceNumberBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.InvoiceCostBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ItemsDropdown = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\..\Main\MainWindow.xaml"
            this.ItemsDropdown.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemsDropdownSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddItemButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.SelectedItemCostLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.RemoveItemButton = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.ItemsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

