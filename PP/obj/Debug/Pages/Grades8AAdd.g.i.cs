﻿#pragma checksum "..\..\..\Pages\Grades8AAdd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F54249F49F4B5A1FA77B24710D7F69B043AAD835A6EB15374E95F88631CF291"
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
    /// Grades8AAdd
    /// </summary>
    public partial class Grades8AAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Pages\Grades8AAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIOtextb;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\Grades8AAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Адрес;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\Grades8AAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Оценка;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\Grades8AAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dobavit;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\Grades8AAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nazad;
        
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
            System.Uri resourceLocater = new System.Uri("/PP;component/pages/grades8aadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Grades8AAdd.xaml"
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
            this.Оценка = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dobavit = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\Grades8AAdd.xaml"
            this.dobavit.Click += new System.Windows.RoutedEventHandler(this.dobavit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.nazad = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\Grades8AAdd.xaml"
            this.nazad.Click += new System.Windows.RoutedEventHandler(this.nazad_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

