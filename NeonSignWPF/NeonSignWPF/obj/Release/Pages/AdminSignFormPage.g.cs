﻿#pragma checksum "..\..\..\Pages\AdminSignFormPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2CBB4C347E90684528B32102E6C4D864280383DB0A885866EA073B338A2E6B48"
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
    /// AdminSignFormPage
    /// </summary>
    public partial class AdminSignFormPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\AdminSignFormPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSignForm;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\AdminSignFormPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image_photo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\AdminSignFormPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectPlacePhoto;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\AdminSignFormPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\AdminSignFormPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_button;
        
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
            System.Uri resourceLocater = new System.Uri("/NeonSignWPF;component/pages/adminsignformpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AdminSignFormPage.xaml"
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
            this.TextSignForm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Image_photo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.SelectPlacePhoto = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Pages\AdminSignFormPage.xaml"
            this.SelectPlacePhoto.Click += new System.Windows.RoutedEventHandler(this.SelectImage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ConfButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\AdminSignFormPage.xaml"
            this.ConfButton.Click += new System.Windows.RoutedEventHandler(this.ConfButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.back_button = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\AdminSignFormPage.xaml"
            this.back_button.Click += new System.Windows.RoutedEventHandler(this.Back_button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

