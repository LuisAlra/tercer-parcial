#pragma checksum "C:\Users\lange\Downloads\ingenieria-de-software\tercer-parcial\WUimagenes\WUimagenes\BlankPage1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CA40AADB5CB1DF83A86CF0B1B1E2B2AAE8B123044257F20024D26A2C9F3E2C87"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WUimagenes
{
    partial class BlankPage1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Button element1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 12 "..\..\..\BlankPage1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element1).Click += this.Button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btn_saludo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\BlankPage1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_saludo).Click += this.btn_saludo_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

