﻿#pragma checksum "..\..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088DE624879DDFD7F98501A3FFF136FFC6B71345"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DatabaseManagerV1;
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


namespace DatabaseManagerV1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border TopBar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border exitButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border minimizeButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border maximizeButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox targetDbBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox queryentry;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startService;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button runQuery;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eQueriesBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border eqPanel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox executedQueriesList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DatabaseManagerV1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\MainWindow.xaml"
            ((DatabaseManagerV1.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TopBar = ((System.Windows.Controls.Border)(target));
            
            #line 12 "..\..\..\..\MainWindow.xaml"
            this.TopBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TopBar_MouseDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\MainWindow.xaml"
            this.TopBar.MouseMove += new System.Windows.Input.MouseEventHandler(this.TopBar_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.exitButton = ((System.Windows.Controls.Border)(target));
            
            #line 14 "..\..\..\..\MainWindow.xaml"
            this.exitButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.exitButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.minimizeButton = ((System.Windows.Controls.Border)(target));
            
            #line 15 "..\..\..\..\MainWindow.xaml"
            this.minimizeButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.minimizeButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.maximizeButton = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.dg1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.targetDbBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.queryentry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.startService = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\MainWindow.xaml"
            this.startService.Click += new System.Windows.RoutedEventHandler(this.startService_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.runQuery = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\MainWindow.xaml"
            this.runQuery.Click += new System.Windows.RoutedEventHandler(this.runQuery_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.eQueriesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\MainWindow.xaml"
            this.eQueriesBtn.Click += new System.Windows.RoutedEventHandler(this.eQueriesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.eqPanel = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            
            #line 44 "..\..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.eqpgrid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.executedQueriesList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

