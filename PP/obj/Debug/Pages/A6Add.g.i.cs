﻿#pragma checksum "..\..\..\Pages\A6Add.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "439703D8FC67FDB97853253AEC69FE40E2192FD9D526DF29029A843579C5F58C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PP.Pages;
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


namespace PP.Pages {
    
    
    /// <summary>
    /// A6Add
    /// </summary>
    public partial class A6Add : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\A6Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIOtextb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\A6Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Адрес;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\A6Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dobavit;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\A6Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nazad;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\A6Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phonenumber;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\A6Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Адрес_Copy1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\A6Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phonenumber1;
        
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
            System.Uri resourceLocater = new System.Uri("/PP;component/pages/a6add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\A6Add.xaml"
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
            this.FIOtextb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Адрес = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dobavit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\A6Add.xaml"
            this.dobavit.Click += new System.Windows.RoutedEventHandler(this.dobavit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.nazad = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\A6Add.xaml"
            this.nazad.Click += new System.Windows.RoutedEventHandler(this.nazad_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.phonenumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Адрес_Copy1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.phonenumber1 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

