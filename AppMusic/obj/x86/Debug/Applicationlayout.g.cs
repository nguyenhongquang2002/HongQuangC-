﻿#pragma checksum "D:\sem 3\AppMusic\AppMusic\Applicationlayout.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89036CC8D2E6301EEF8DFD9C74C5F6EADBDB2D68C5B2B954133C21BABB93D632"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMusic
{
    partial class Applicationlayout : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Applicationlayout.xaml line 11
                {
                    this.MyNavView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.MyNavView).Loaded += this.MyNavView_Loaded;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.MyNavView).BackRequested += this.MyNavView_BackRequested;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.MyNavView).ItemInvoked += this.MyNavView_ItemInvoked;
                }
                break;
            case 3: // Applicationlayout.xaml line 27
                {
                    this.ContentPage = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
