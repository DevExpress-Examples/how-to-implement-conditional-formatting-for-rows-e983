﻿// Developer Express Code Central Example:
// How to implement conditional formatting for rows
// 
// The following sample demonstrates how to change the appearance of grid rows
// based on some condition. For example, in this tutorial you can see that the
// background color of grid rows is gradually changed based on the value in the
// second data column.
// This is done by binding the Background property of a style,
// assigned to a row, to a color converter. This converter is represented by the
// ColorValueConverter class that implements the IValueConverter interface and
// returns a color according to the provided numerical value.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E983

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30220.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConditionalRowFormatting.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}
