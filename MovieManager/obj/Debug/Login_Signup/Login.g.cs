﻿#pragma checksum "..\..\..\Login_Signup\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D901299F6604985B538D3525D1A1CB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MovieManager.Showtimes;
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


namespace MovieManager.Login_Signup {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUserName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbWatermarkUser;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbPassword;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbWatermarkPass;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbWarningMessage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Login_Signup\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblSignup;
        
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
            System.Uri resourceLocater = new System.Uri("/MovieManager;component/login_signup/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Login_Signup\Login.xaml"
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
            
            #line 7 "..\..\..\Login_Signup\Login.xaml"
            ((MovieManager.Login_Signup.Login)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.UserControl_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbUserName = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Login_Signup\Login.xaml"
            this.tbUserName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbUserName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbWatermarkUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.pbPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 22 "..\..\..\Login_Signup\Login.xaml"
            this.pbPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.pbPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbWatermarkPass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Login_Signup\Login.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Login_Signup\Login.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbWarningMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.tblSignup = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

