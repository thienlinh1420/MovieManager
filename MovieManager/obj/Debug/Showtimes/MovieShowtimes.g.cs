﻿#pragma checksum "..\..\..\Showtimes\MovieShowtimes.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5FBD791A419CA4FFCBFBF756B2DEB21"
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


namespace MovieManager.Showtimes {
    
    
    /// <summary>
    /// MovieShowtimes
    /// </summary>
    public partial class MovieShowtimes : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Showtimes\MovieShowtimes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel wpnCineplex;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Showtimes\MovieShowtimes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel wpnCinema;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Showtimes\MovieShowtimes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnShowtimesInfo;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Showtimes\MovieShowtimes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnCinemaInfo;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Showtimes\MovieShowtimes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblCinemaName;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Showtimes\MovieShowtimes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnCalendar;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Showtimes\MovieShowtimes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnFilmInfoInShowtimes;
        
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
            System.Uri resourceLocater = new System.Uri("/MovieManager;component/showtimes/movieshowtimes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Showtimes\MovieShowtimes.xaml"
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
            
            #line 7 "..\..\..\Showtimes\MovieShowtimes.xaml"
            ((MovieManager.Showtimes.MovieShowtimes)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.wpnCineplex = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 3:
            this.wpnCinema = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 4:
            this.pnShowtimesInfo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.pnCinemaInfo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.tblCinemaName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.pnCalendar = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.pnFilmInfoInShowtimes = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

