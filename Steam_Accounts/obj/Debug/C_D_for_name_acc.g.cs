﻿#pragma checksum "..\..\C_D_for_name_acc.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1AB10CC6A10AB9D3D41648CB92353BE109850B692D6398C644116A4FF380292A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Steam_Accounts;
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


namespace Steam_Accounts {
    
    
    /// <summary>
    /// C_D_for_name_acc
    /// </summary>
    public partial class C_D_for_name_acc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\C_D_for_name_acc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_win_d;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\C_D_for_name_acc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Name_win_d;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\C_D_for_name_acc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Text_for_enter;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\C_D_for_name_acc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image b_exit;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\C_D_for_name_acc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_box_name_acc;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\C_D_for_name_acc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_add_acc;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\C_D_for_name_acc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_not;
        
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
            System.Uri resourceLocater = new System.Uri("/Steam_Accounts;component/c_d_for_name_acc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\C_D_for_name_acc.xaml"
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
            this.border_win_d = ((System.Windows.Controls.Border)(target));
            
            #line 18 "..\..\C_D_for_name_acc.xaml"
            this.border_win_d.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.border_win_d_MLBD);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Name_win_d = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Text_for_enter = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.b_exit = ((System.Windows.Controls.Image)(target));
            
            #line 32 "..\..\C_D_for_name_acc.xaml"
            this.b_exit.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.b_exit_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.text_box_name_acc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.b_add_acc = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\C_D_for_name_acc.xaml"
            this.b_add_acc.Click += new System.Windows.RoutedEventHandler(this.b_add_acc_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.b_not = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\C_D_for_name_acc.xaml"
            this.b_not.Click += new System.Windows.RoutedEventHandler(this.b_not_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
