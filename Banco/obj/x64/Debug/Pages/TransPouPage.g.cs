#pragma checksum "D:\ESTAGIO\TotalCross\C#\Banco\Banco\Pages\TransPouPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21421169B460CB5FE879C796351DB57925DA811F22DCEEEA776FF56E2695F4A8"
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
    partial class TransPouPage : 
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
            case 2: // Pages\TransPouPage.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.OpenConfTransPou;
                }
                break;
            case 3: // Pages\TransPouPage.xaml line 28
                {
                    this.textBox_Copy1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Pages\TransPouPage.xaml line 20
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\TransPouPage.xaml line 21
                {
                    this.textBox_Copy = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

