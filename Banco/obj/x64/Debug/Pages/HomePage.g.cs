﻿#pragma checksum "D:\ESTAGIO\TotalCross\C#\Banco\Banco\Pages\HomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "04E3ECE18FA0182D5E61EB47D6D8CB9DDEEBE113D3D0B42CC86398B32BFFDF9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1.Pages
{
    partial class HomePage : 
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
            case 2: // Pages\HomePage.xaml line 26
                {
                    this.notification = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3: // Pages\HomePage.xaml line 27
                {
                    this.goout = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Pages\HomePage.xaml line 15
                {
                    this.service = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5: // Pages\HomePage.xaml line 16
                {
                    this.pou = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.pou).Click += this.OpenPou;
                }
                break;
            case 6: // Pages\HomePage.xaml line 17
                {
                    this.cor = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Pages\HomePage.xaml line 18
                {
                    this.extract = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8: // Pages\HomePage.xaml line 19
                {
                    this.pix = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9: // Pages\HomePage.xaml line 20
                {
                    this.comp = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 10: // Pages\HomePage.xaml line 21
                {
                    this.recarg = (global::Windows.UI.Xaml.Controls.Button)(target);
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

