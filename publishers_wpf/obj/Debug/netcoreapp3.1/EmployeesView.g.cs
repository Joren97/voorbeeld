﻿#pragma checksum "..\..\..\EmployeesView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77AB9511396684A30A5A3F5A85AB9DFCE90C0308"
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
    /// EmployeesView
    /// </summary>
    public partial class EmployeesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWerknemers;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbJobs;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekEmployeesViaJob;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPublishers;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWerknemersViaPubid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWerknemersViaPubidEnJob_id;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHireDate;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWerknemersViaHireDate;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmp_id;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekWerknemerviaPK;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridEmployees;
        
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
            System.Uri resourceLocater = new System.Uri("/publishers_wpf;component/employeesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EmployeesView.xaml"
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
            this.btnZoekWerknemers = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\EmployeesView.xaml"
            this.btnZoekWerknemers.Click += new System.Windows.RoutedEventHandler(this.btnZoekWerknemers_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbJobs = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btnZoekEmployeesViaJob = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\EmployeesView.xaml"
            this.btnZoekEmployeesViaJob.Click += new System.Windows.RoutedEventHandler(this.btnZoekEmployeesViaJob_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbPublishers = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnZoekWerknemersViaPubid = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\EmployeesView.xaml"
            this.btnZoekWerknemersViaPubid.Click += new System.Windows.RoutedEventHandler(this.btnZoekWerknemersViaPubid_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnZoekWerknemersViaPubidEnJob_id = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\EmployeesView.xaml"
            this.btnZoekWerknemersViaPubidEnJob_id.Click += new System.Windows.RoutedEventHandler(this.btnZoekWerknemersViaPubidEnJob_id_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtHireDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnZoekWerknemersViaHireDate = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\EmployeesView.xaml"
            this.btnZoekWerknemersViaHireDate.Click += new System.Windows.RoutedEventHandler(this.btnZoekWerknemersViaHireDate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtEmp_id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnZoekWerknemerviaPK = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\EmployeesView.xaml"
            this.btnZoekWerknemerviaPK.Click += new System.Windows.RoutedEventHandler(this.btnZoekWerknemerviaPK_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.datagridEmployees = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

