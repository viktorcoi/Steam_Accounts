﻿#pragma checksum "..\..\Window_S_A.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD5B24BFA147F373FD72F16E9CAD36B82440A3729A5F0EDEAA6D55A968F3601C"
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
    /// Window_S_A
    /// </summary>
    public partial class Window_S_A : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image b_steam;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image b_acc;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image b_change;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_win_S_A;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Name_win_S_A;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image b_exit;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image b_roll;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Window_S_A.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView List_for_acc;
        
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
            System.Uri resourceLocater = new System.Uri("/Steam_Accounts;component/window_s_a.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window_S_A.xaml"
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
            this.b_steam = ((System.Windows.Controls.Image)(target));
            
            #line 18 "..\..\Window_S_A.xaml"
            this.b_steam.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.b_steam_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.b_acc = ((System.Windows.Controls.Image)(target));
            
            #line 37 "..\..\Window_S_A.xaml"
            this.b_acc.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.b_acc_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.b_change = ((System.Windows.Controls.Image)(target));
            
            #line 56 "..\..\Window_S_A.xaml"
            this.b_change.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.b_change_MouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.border_win_S_A = ((System.Windows.Controls.Border)(target));
            
            #line 75 "..\..\Window_S_A.xaml"
            this.border_win_S_A.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.border_win_d_MLBD);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Name_win_S_A = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.b_exit = ((System.Windows.Controls.Image)(target));
            
            #line 83 "..\..\Window_S_A.xaml"
            this.b_exit.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.b_exit_MouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.b_roll = ((System.Windows.Controls.Image)(target));
            
            #line 97 "..\..\Window_S_A.xaml"
            this.b_roll.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.b_roll_MouseUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.List_for_acc = ((System.Windows.Controls.ListView)(target));
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
            case 9:
            
            #line 158 "..\..\Window_S_A.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_delete);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 282 "..\..\Window_S_A.xaml"
            ((System.Windows.Controls.WrapPanel)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.WrapPanel_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 282 "..\..\Window_S_A.xaml"
            ((System.Windows.Controls.WrapPanel)(target)).MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.WrapPanel_MouseRightButtonUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

