﻿#pragma checksum "..\..\MainWindow - Copy 1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C7E0789BBC31578DF1858BDE53FBEBCC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace POEStashSorter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 1 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal POEStashSorter.MainWindow PoE_Stash_Sorter;
        
        #line default
        #line hidden
        
        
        #line 5 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid btnStartSorting;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl StashTabs;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLeftStash;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgRightStash;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlLeague;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlSortMode;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartSorting;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlSpeed;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas stashPanel;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow - Copy 1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlSortOption;
        
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
            System.Uri resourceLocater = new System.Uri("/POEStashSorter;component/mainwindow%20-%20copy%201.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow - Copy 1.xaml"
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
            this.PoE_Stash_Sorter = ((POEStashSorter.MainWindow)(target));
            return;
            case 2:
            this.btnStartSorting = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.StashTabs = ((System.Windows.Controls.TabControl)(target));
            
            #line 6 "..\..\MainWindow - Copy 1.xaml"
            this.StashTabs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StashTabs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgLeftStash = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.imgRightStash = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            
            #line 69 "..\..\MainWindow - Copy 1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ReloadAlgorithms);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ddlLeague = ((System.Windows.Controls.ComboBox)(target));
            
            #line 76 "..\..\MainWindow - Copy 1.xaml"
            this.ddlLeague.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ddlLeague_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ddlSortMode = ((System.Windows.Controls.ComboBox)(target));
            
            #line 79 "..\..\MainWindow - Copy 1.xaml"
            this.ddlSortMode.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ddlSortMode_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.StartSorting = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\MainWindow - Copy 1.xaml"
            this.StartSorting.Click += new System.Windows.RoutedEventHandler(this.StartSorting_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ddlSpeed = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.stashPanel = ((System.Windows.Controls.Canvas)(target));
            return;
            case 13:
            this.ddlSortOption = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\MainWindow - Copy 1.xaml"
            this.ddlSortOption.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ddlSortOption_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 10 "..\..\MainWindow - Copy 1.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ListViewScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
