﻿#pragma checksum "..\..\..\Pages\AddUserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A94A0BC0A2384F0979E1CCE0C30DBFE6835CA2BCCD26180F1CD0DDC8D5D3FB5B"
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
    /// AddUserPage
    /// </summary>
    public partial class AddUserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Pages\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextLogin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextPassword;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextFirstName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextLastName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextEmail;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Conf_Button;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/NeonSignWPF;component/pages/adduserpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddUserPage.xaml"
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
            this.TextLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Conf_Button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\AddUserPage.xaml"
            this.Conf_Button.Click += new System.Windows.RoutedEventHandler(this.Conf_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\AddUserPage.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

