﻿#pragma checksum "..\..\..\Pages\HomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "430570756197D63053EBFECE3F9026EC2469DB2840AE6A03A1A92FF1E7EE706F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using User.Pages;


namespace User.Pages {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SelectedTb;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ColoreCb;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ViewCb;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvAccept;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AboutBTN;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZakazBtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DellBt;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfilBt;
        
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
            System.Uri resourceLocater = new System.Uri("/User;component/pages/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\HomePage.xaml"
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
            this.SelectedTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Pages\HomePage.xaml"
            this.SelectedTb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SelectedTb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ColoreCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Pages\HomePage.xaml"
            this.ColoreCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ViewCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Pages\HomePage.xaml"
            this.ViewCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LvAccept = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.AboutBTN = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\HomePage.xaml"
            this.AboutBTN.Click += new System.Windows.RoutedEventHandler(this.AboutBTN_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ZakazBtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\HomePage.xaml"
            this.ZakazBtn.Click += new System.Windows.RoutedEventHandler(this.ZakazBtn_OnClickAddPenBt_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DellBt = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Pages\HomePage.xaml"
            this.DellBt.Click += new System.Windows.RoutedEventHandler(this.DellBt_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ProfilBt = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\HomePage.xaml"
            this.ProfilBt.Click += new System.Windows.RoutedEventHandler(this.ProfilBt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

