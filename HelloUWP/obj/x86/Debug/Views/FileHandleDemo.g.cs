﻿#pragma checksum "C:\Users\Hp\Desktop\New folder\HelloUWP\HelloUWP\Views\FileHandleDemo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D1391AF05707BC0384BCD619469F7A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloUWP.Views
{
    partial class FileHandleDemo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\FileHandleDemo.xaml line 12
                {
                    this.FileConten = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Views\FileHandleDemo.xaml line 13
                {
                    this.FileName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Views\FileHandleDemo.xaml line 14
                {
                    this.BtnSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnSave).Click += this.BtnSave_Click;
                }
                break;
            case 5: // Views\FileHandleDemo.xaml line 15
                {
                    this.BtnLoad = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnLoad).Click += this.BtnLoad_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

