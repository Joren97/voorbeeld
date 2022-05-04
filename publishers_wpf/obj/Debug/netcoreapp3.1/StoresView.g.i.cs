﻿#pragma checksum "..\..\..\StoresView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C9DBCBB565A1F46A6FCF2A1B877568CD331D3C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace publishers_wpf {
    
    
    /// <summary>
    /// StoresView
    /// </summary>
    public partial class StoresView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNaam;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWinkelsViaStor_name;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtState;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWinkelsViaState;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWinkelsViaNaamEnState;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWinkelsViaPK;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\StoresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridStores;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/publishers_wpf;V1.0.0.0;component/storesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StoresView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnZoekWinkelsViaStor_name = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\StoresView.xaml"
            this.btnZoekWinkelsViaStor_name.Click += new System.Windows.RoutedEventHandler(this.btnZoekWinkels_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtState = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnZoekWinkelsViaState = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\StoresView.xaml"
            this.btnZoekWinkelsViaState.Click += new System.Windows.RoutedEventHandler(this.btnZoekWinkelsViaState_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnZoekWinkelsViaNaamEnState = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\StoresView.xaml"
            this.btnZoekWinkelsViaNaamEnState.Click += new System.Windows.RoutedEventHandler(this.btnZoekWinkelsViaNaamEnState_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnZoekWinkelsViaPK = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\StoresView.xaml"
            this.btnZoekWinkelsViaPK.Click += new System.Windows.RoutedEventHandler(this.btnZoekWinkelsViaPK_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.datagridStores = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

