﻿#pragma checksum "C:\Users\2280608\source\repos\ProgProjetFinal\projetFinal\projetFinal\Projets.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "800881E0ACA9C259DF1DD6311E22EFF2568357822133383BC977D9D4D217AE7A"
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
    partial class Projets : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Projets_obj5_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IProjets_Bindings
        {
            private global::projetFinal.Projet dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj5;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj6;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj7;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj8;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj9;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj10;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj11;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj12;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj13;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj14;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10TextDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12TextDisabled = false;
            private static bool isobj13TextDisabled = false;
            private static bool isobj14TextDisabled = false;

            public Projets_obj5_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 58 && columnNumber == 48)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 55 && columnNumber == 52)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 52)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 52)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 44 && columnNumber == 52)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 45 && columnNumber == 52)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 52)
                {
                    isobj12TextDisabled = true;
                }
                else if (lineNumber == 41 && columnNumber == 56)
                {
                    isobj13TextDisabled = true;
                }
                else if (lineNumber == 42 && columnNumber == 56)
                {
                    isobj14TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Projets.xaml line 29
                        this.obj5 = new global::System.WeakReference(global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target));
                        break;
                    case 6: // Projets.xaml line 58
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 7: // Projets.xaml line 55
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 8: // Projets.xaml line 52
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 9: // Projets.xaml line 39
                        this.obj9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 10: // Projets.xaml line 44
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 11: // Projets.xaml line 45
                        this.obj11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 12: // Projets.xaml line 46
                        this.obj12 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 13: // Projets.xaml line 41
                        this.obj13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 14: // Projets.xaml line 42
                        this.obj14 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj5.Target as global::Microsoft.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_(global::WinRT.CastExtensions.As<global::projetFinal.Projet>(item), 1 << phase);
            }

            public void Recycle()
            {
            }

            // IProjets_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::projetFinal.Projet>(newDataRoot);
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::projetFinal.Projet obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Statut(obj.Statut, phase);
                        this.Update_Client(obj.Client, phase);
                        this.Update_Total_salaire(obj.Total_salaire, phase);
                        this.Update_No_projet(obj.No_projet, phase);
                        this.Update_Description(obj.Description, phase);
                        this.Update_Budget(obj.Budget, phase);
                        this.Update_Nb_employe(obj.Nb_employe, phase);
                        this.Update_Titre(obj.Titre, phase);
                        this.Update_Date_debut(obj.Date_debut, phase);
                    }
                }
            }
            private void Update_Statut(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 58
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_Client(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 55
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj.ToString(), null);
                    }
                }
            }
            private void Update_Total_salaire(global::System.Decimal obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 52
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                    }
                }
            }
            private void Update_No_projet(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 39
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                    }
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 44
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                    }
                }
            }
            private void Update_Budget(global::System.Decimal obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 45
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj.ToString(), null);
                    }
                }
            }
            private void Update_Nb_employe(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 46
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj.ToString(), null);
                    }
                }
            }
            private void Update_Titre(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 41
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj, null);
                    }
                }
            }
            private void Update_Date_debut(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Projets.xaml line 42
                    if (!isobj14TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj, null);
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Projets.xaml line 12
                {
                    this.GridProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // Projets.xaml line 26
                {
                    this.gridViewProjets = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.GridView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.GridView)this.gridViewProjets).SelectionChanged += this.gridViewProjets_SelectionChanged;
                }
                break;
            case 15: // Projets.xaml line 22
                {
                    this.btnAjouterProjet = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.btnAjouterProjet).Click += this.btnAjouterProjet_Click;
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
            switch(connectionId)
            {
            case 5: // Projets.xaml line 29
                {                    
                    global::Microsoft.UI.Xaml.Controls.StackPanel element5 = (global::Microsoft.UI.Xaml.Controls.StackPanel)target;
                    Projets_obj5_Bindings bindings = new Projets_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element5.DataContext);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element5, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

