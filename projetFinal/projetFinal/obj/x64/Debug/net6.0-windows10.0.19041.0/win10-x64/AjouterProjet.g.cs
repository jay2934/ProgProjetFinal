﻿#pragma checksum "C:\Users\2280608\Source\Repos\ProgProjetFinal\projetFinal\projetFinal\AjouterProjet.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7303E3E66937F7CBE2666733528E83159D7802CA4DD529167A364051DE617E4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetFinal
{
    partial class AjouterProjet : 
        global::Microsoft.UI.Xaml.Controls.ContentDialog, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // AjouterProjet.xaml line 2
                {
                    global::Microsoft.UI.Xaml.Controls.ContentDialog element1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentDialog>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                }
                break;
            case 2: // AjouterProjet.xaml line 21
                {
                    this.autoSuggBoxClient = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AutoSuggestBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggBoxClient).TextChanged += this.AutoSuggestBox_TextChanged;
                    ((global::Microsoft.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggBoxClient).SuggestionChosen += this.AutoSuggestBox_SuggestionChosen;
                }
                break;
            case 3: // AjouterProjet.xaml line 32
                {
                    this.tbxTitreProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 4: // AjouterProjet.xaml line 42
                {
                    this.tbxDateProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.DatePicker>(target);
                }
                break;
            case 5: // AjouterProjet.xaml line 51
                {
                    this.tbxDescriptionProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 6: // AjouterProjet.xaml line 60
                {
                    this.nbxBudgetProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                }
                break;
            case 7: // AjouterProjet.xaml line 74
                {
                    this.nbxNbEmployeProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                }
                break;
            case 8: // AjouterProjet.xaml line 84
                {
                    this.headNbrEmployeProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 9: // AjouterProjet.xaml line 69
                {
                    this.headBudgetProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 10: // AjouterProjet.xaml line 55
                {
                    this.headDescriptionProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 11: // AjouterProjet.xaml line 46
                {
                    this.headDateProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 12: // AjouterProjet.xaml line 36
                {
                    this.headTitreProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 13: // AjouterProjet.xaml line 28
                {
                    this.headClientProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

