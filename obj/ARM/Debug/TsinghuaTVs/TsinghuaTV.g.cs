﻿#pragma checksum "D:\我的文档\Programming\TsinghuaUWP\InsTsinghua\InsTsinghua\TsinghuaTVs\TsinghuaTV.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ADAE8AA0B57257573B1701C1F1F9EC95"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsTsinghua.TsinghuaTVs
{
    partial class TsinghuaTV : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class TsinghuaTV_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITsinghuaTV_Bindings
        {
            private global::InsTsinghua.TsinghuaTVs.TsinghuaTV dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj8;

            public TsinghuaTV_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // ITsinghuaTV_Bindings

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

            // TsinghuaTV_obj1_Bindings

            public void SetDataRoot(global::InsTsinghua.TsinghuaTVs.TsinghuaTV newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::InsTsinghua.TsinghuaTVs.TsinghuaTV obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_TV1(obj.TV1, phase);
                    }
                }
            }
            private void Update_TV1(global::System.Collections.ObjectModel.ObservableCollection<global::InsTsinghua.TsinghuaTVs.TV1> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                }
            }
        }
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\TsinghuaTVs\TsinghuaTV.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.REFRESH_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.NarrowLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.InOut = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 5:
                {
                    this.TVList = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 6:
                {
                    this.TVPlayer = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.MyMedias = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    #line 80 "..\..\..\TsinghuaTVs\TsinghuaTV.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.MyMedias).CurrentStateChanged += this.MyMedias_CurrentStateChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.TVGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 66 "..\..\..\TsinghuaTVs\TsinghuaTV.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.TVGrid).SelectionChanged += this.TVGrid_SelectionChanged;
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TsinghuaTV_obj1_Bindings bindings = new TsinghuaTV_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

