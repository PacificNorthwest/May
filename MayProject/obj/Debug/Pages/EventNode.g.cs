﻿#pragma checksum "..\..\..\Pages\EventNode.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7AF0A9B340525FF0D2785CE6D27CE614"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MayProject;
using MayProject.Pages;
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


namespace MayProject.Pages {
    
    
    /// <summary>
    /// EventNode
    /// </summary>
    public partial class EventNode : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Pages\EventNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Plate;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\EventNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventTitle;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\EventNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DescriptionPlate;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\EventNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventDescription;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Pages\EventNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventCharacters;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\EventNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventLocation;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\EventNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventTime;
        
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
            System.Uri resourceLocater = new System.Uri("/MayProject;component/pages/eventnode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EventNode.xaml"
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
            this.Plate = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.EventTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DescriptionPlate = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.EventDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.EventCharacters = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.EventLocation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EventTime = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
