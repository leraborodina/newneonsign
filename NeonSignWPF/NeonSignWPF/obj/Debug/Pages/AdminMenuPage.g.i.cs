﻿#pragma checksum "..\..\..\Pages\AdminMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D07C8ECFA133664E249CD48669DCFA04BF6F8D3D3328DE9FED8C540D6E2B3DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NeonSignWPF.Pages;
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


namespace NeonSignWPF.Pages {
    
    
    /// <summary>
    /// AdminMenuPage
    /// </summary>
    public partial class AdminMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Pages\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MainPanel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Orders;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Roles;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Users;
        
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
            System.Uri resourceLocater = new System.Uri("/NeonSignWPF;component/pages/adminmenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AdminMenuPage.xaml"
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
            this.MainPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Orders = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\AdminMenuPage.xaml"
            this.Orders.Click += new System.Windows.RoutedEventHandler(this.Orders_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Roles = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\AdminMenuPage.xaml"
            this.Roles.Click += new System.Windows.RoutedEventHandler(this.Roles_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Users = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\AdminMenuPage.xaml"
            this.Users.Click += new System.Windows.RoutedEventHandler(this.Users_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

