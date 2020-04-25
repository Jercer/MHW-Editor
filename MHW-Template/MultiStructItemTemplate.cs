﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MHW_Template
{
    using Microsoft.CSharp;
    using System.CodeDom;
    using System.Text.RegularExpressions;
    using MHW_Template;
    using MHW_Template.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "R:\Games\Monster Hunter World\MHW-Editor\MHW-Template\MultiStructItemTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class MultiStructItemTemplate : MultiStructItemTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace ");
            
            #line 24 "R:\Games\Monster Hunter World\MHW-Editor\MHW-Template\MultiStructItemTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n    public partial class ");
            
            #line 25 "R:\Games\Monster Hunter World\MHW-Editor\MHW-Template\MultiStructItemTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(" {\r\n        public override string EncryptionKey => ");
            
            #line 26 "R:\Games\Monster Hunter World\MHW-Editor\MHW-Template\MultiStructItemTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(structData.encryptionKey == null ? "null" : $"\"{structData.encryptionKey}\""));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 27 "R:\Games\Monster Hunter World\MHW-Editor\MHW-Template\MultiStructItemTemplate.tt"

    var compiler = new CSharpCodeProvider();

    foreach (var @struct in structData.structs) {
        var sortIndex = 50;
        var name = Regex.Replace(@struct.name, @"[^\w\d]+", "_");

        WriteLine("");
        //WriteLine("        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode, Pack = 1)]");
        WriteLine($"        public partial class {name} : MhwStructItem{(@struct.showVertically ? ", IHasCustomView<MultiStructItemCustomView>" : "")} {{");
        WriteLine($"            public const ulong FixedSizeCount = {@struct.fixedSizeCount};");
        WriteLine($"            public const string GridName = \"{@struct.name}\";");

        if (@struct.hidden) {
            WriteLine($"            public const bool IsHidden = {@struct.hidden.ToString().ToLower()};");
        }

        if (@struct.canAddRows) {
            WriteLine($"            public const bool IsAddingAllowed = {@struct.canAddRows.ToString().ToLower()};");
        }

        foreach (var entry in @struct.entries) {
            var accessLevel = entry.accessLevel;
            if (entry.displayName == "Index") accessLevel += " override";
            else if (accessLevel != "private") accessLevel += " virtual";

            var propName = Regex.Replace(entry.displayName, @"[^\w\d]+", "_");
            if (entry.forceUnique) propName += $"_{sortIndex}";
            var entryName = $"{propName}_raw";

            var typeString = compiler.GetTypeOutput(new CodeTypeReference(entry.type));
            if (entry.arrayCount > -1) typeString += "[]";

            string returnString;
            var setCast = "";
            var getCast = "";

            if (entry.enumReturn == null) {
                returnString = typeString;
            } else {
                returnString = compiler.GetTypeOutput(new CodeTypeReference(entry.enumReturn));
                getCast = $"({returnString}) ";
                setCast = $"({typeString}) ";
            }

            if (entry.displayName == "Index") {
                getCast = "(ulong) ";
                setCast = $"({returnString}) ";
                returnString = "ulong";
            }

            // Main property.
            WriteLine("");
            WriteLine($"            protected {typeString} {entryName};");
            WriteLine($"            public const string {propName}_displayName = \"{entry.displayName}\";");
            WriteLine($"            public const int {propName}_sortIndex = {sortIndex};");
            WriteLine($"            [SortOrder({propName}_sortIndex)]");
            WriteLine($"            [DisplayName({propName}_displayName)]");

            if (entry.dataSourceType != null) {
                WriteLine($"            [DataSource(DataSourceType.{entry.dataSourceType})]");
            }

            if (entry.readOnly) {
                WriteLine("            [IsReadOnly]");
            }

            WriteLine($"            {accessLevel} {returnString} {propName} {{");

            if (returnString == "bool") {
                WriteLine($"                get => {getCast}Convert.ToBoolean({entryName});");
            } else if (typeString == "char[]") {
                WriteLine($"                get => {getCast}new string({entryName});");
            } else {
                WriteLine($"                get => {getCast}{entryName};");
            }

            // Always include a setter, even for readOnly. This enables us to bypass readOnly via command line switch.
            WriteLine("                set {");

            if (returnString == "bool") {
                WriteLine($"                    if (Convert.ToBoolean({entryName}) == {entry.valueString}) return;"); // Do nothing if the value is the same.
                WriteLine($"                    {entryName} = Convert.ToByte({entry.valueString});");
            } else if (typeString == "char[]") {
                WriteLine($"                    if ({getCast}new string({entryName}) == {entry.valueString}) return;"); // Do nothing if the value is the same.
                WriteLine($"                    {entryName} = {setCast}{entry.valueString}.ToCharArray(0, {entry.arrayCount - 1});");
            } else {
                WriteLine($"                    if ({getCast}{entryName} == {entry.valueString}) return;"); // Do nothing if the value is the same.
                WriteLine($"                    {entryName} = {setCast}{entry.valueString};");
            }

            WriteLine($"                    OnPropertyChanged(nameof({propName}));");

            if (entry.dataSourceType != null) {
                WriteLine($"                    OnPropertyChanged(nameof({propName}_button));");
            }

            if (entry.extraOnPropertyChanged != null) {
                foreach (var propertyToChange in entry.extraOnPropertyChanged) {
                    var propertyToChangeName = Regex.Replace(propertyToChange, @"[^\w\d]+", "_");

                    WriteLine($"                    OnPropertyChanged(nameof({propertyToChangeName}));");
                }
            }

            WriteLine("                }");
            WriteLine("            }");

            if (entry.dataSourceType != null) {
                var dataSourceLookup = GenerationHelper.GetDataSourceType(entry.dataSourceType ?? throw new Exception());

                WriteLine("");
                WriteLine($"            [SortOrder({propName}_sortIndex)]");
                WriteLine($"            [DisplayName({propName}_displayName)]");
                WriteLine($"            [CustomSorter(typeof({entry.dataSourceCustomSorter}))]");
                WriteLine($"            public string {propName}_button => {dataSourceLookup}.TryGet({propName}).ToStringWithId({propName});");
            }

            if (entry.createPercentField) {
                WriteLine("");
                WriteLine($"            private float _{propName}Percent;");
                WriteLine($"            [SortOrder({propName}_sortIndex + 1)]");
                WriteLine($"            [DisplayName({propName}_displayName + \"%\")]");
                WriteLine($"            public float {propName}_percent {{");
                WriteLine($"                get => _{propName}Percent;");
                WriteLine("                set {");
                WriteLine($"                    _{propName}Percent = value.Clamp(0f, 100f);");
                WriteLine($"                    OnPropertyChanged(nameof({propName}_percent));");
                WriteLine("                }");
                WriteLine("            }");
            }

            sortIndex += 50;
        }

        // Individual LoadData.
        WriteLine("");
        WriteLine($"            public static {name} LoadData(BinaryReader reader) {{");
        WriteLine($"                var data = new {name}();");
        foreach (var entry in @struct.entries) {
            var propName = Regex.Replace(entry.displayName, @"[^\w\d]+", "_");
            if (entry.forceUnique) propName += $"_{sortIndex}";
            var entryName = $"{propName}_raw";

            var condition = "";
            if (entry.condition != null) {
                condition = $"{entry.condition} ".Replace("|ref|", "data.");
            }

            if (entry.arrayCount > -1) {
                WriteLine($"                {condition}data.{entryName} = reader.Read{GetReadType(entry.type)}s({entry.arrayCount});");
            } else if (entry.isNullTerminatedString) {
                WriteLine($"                {condition}data.{entryName} = reader.ReadNullTermString();");
            } else {
                WriteLine($"                {condition}data.{entryName} = reader.Read{GetReadType(entry.type)}();");
            }
        }
        WriteLine("                return data;");
        WriteLine("            }");

        // Individual WriteData.
        WriteLine("");
        WriteLine("            public override void WriteData(BinaryWriter writer) {");
        foreach (var entry in @struct.entries) {
            var propName = Regex.Replace(entry.displayName, @"[^\w\d]+", "_");
            if (entry.forceUnique) propName += $"_{sortIndex}";
            var entryName = $"{propName}_raw";

            var condition = "";
            if (entry.condition != null) {
                condition = $"{entry.condition} ".Replace("|ref|", "");
            }

            if (entry.type == typeof(string)) {
                WriteLine($"                {condition}writer.Write({entryName}.ToNullTermCharArray());");
            } else {
                WriteLine($"                {condition}writer.Write({entryName});");
            }
        }
        WriteLine("            }");

        // GetCustomView (if needed).
        if (@struct.showVertically) {
            WriteLine("");
            WriteLine("            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {");
            WriteLine("                return new ObservableCollection<MultiStructItemCustomView> {");
            foreach (var entry in @struct.entries) {
                var propName = Regex.Replace(entry.displayName, @"[^\w\d]+", "_");
                if (entry.forceUnique) propName += $"_{sortIndex}";

                WriteLine($"                    new MultiStructItemCustomView(this, \"{entry.displayName}\", \"{propName}\"),");
            }
            WriteLine("                };");
            WriteLine("            }");
        }

        WriteLine("        }"); // Inner Class
    }

    // Master LoadData.
    WriteLine("");
    WriteLine("        public override void LoadFile(string targetFile) {");
    WriteLine("            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));");
    WriteLine("            data = new List<MhwStructDataContainer>();");
    WriteLine("            dataByType = new Dictionary<Type, MhwStructDataContainer>();");
    foreach (var @struct in structData.structs) {
        var name = Regex.Replace(@struct.name, @"[^\w\d]+", "_");

        WriteLine("");
        WriteLine($"            var {name}_list = new ObservableCollection<object>();");
        WriteLine($"            for (ulong i = 0; i < GetEntryCount(typeof({name})); i++) {{");
        WriteLine($"                var item = {name}.LoadData(reader);");
        WriteLine("                item.Index = i;");
        WriteLine($"                {name}_list.Add(item);");
        WriteLine("            }");
        WriteLine($"            var {name}_container = new MhwStructDataContainer({name}_list, typeof({name}));");
        WriteLine($"            data.Add({name}_container);");
        WriteLine($"            dataByType[typeof({name})] = {name}_container;");
    }
    WriteLine("        }");

    string GetReadType(Type type) {
        return Type.GetTypeCode(type).ToString();
    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "R:\Games\Monster Hunter World\MHW-Editor\MHW-Template\MultiStructItemTemplate.tt"

private string @__namespaceField;

/// <summary>
/// Access the _namespace parameter of the template.
/// </summary>
private string _namespace
{
    get
    {
        return this.@__namespaceField;
    }
}

private string _classNameField;

/// <summary>
/// Access the className parameter of the template.
/// </summary>
private string className
{
    get
    {
        return this._classNameField;
    }
}

private global::MHW_Template.MhwMultiStructData _structDataField;

/// <summary>
/// Access the structData parameter of the template.
/// </summary>
private global::MHW_Template.MhwMultiStructData structData
{
    get
    {
        return this._structDataField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool _namespaceValueAcquired = false;
if (this.Session.ContainsKey("_namespace"))
{
    this.@__namespaceField = ((string)(this.Session["_namespace"]));
    _namespaceValueAcquired = true;
}
if ((_namespaceValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("_namespace");
    if ((data != null))
    {
        this.@__namespaceField = ((string)(data));
    }
}
bool classNameValueAcquired = false;
if (this.Session.ContainsKey("className"))
{
    this._classNameField = ((string)(this.Session["className"]));
    classNameValueAcquired = true;
}
if ((classNameValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("className");
    if ((data != null))
    {
        this._classNameField = ((string)(data));
    }
}
bool structDataValueAcquired = false;
if (this.Session.ContainsKey("structData"))
{
    this._structDataField = ((global::MHW_Template.MhwMultiStructData)(this.Session["structData"]));
    structDataValueAcquired = true;
}
if ((structDataValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("structData");
    if ((data != null))
    {
        this._structDataField = ((global::MHW_Template.MhwMultiStructData)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class MultiStructItemTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
