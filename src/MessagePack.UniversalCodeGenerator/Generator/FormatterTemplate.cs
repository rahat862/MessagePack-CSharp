﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MessagePack.CodeGenerator.Generator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class FormatterTemplate : FormatterTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("#pragma warning disable 618\r\n#pragma warning disable 612\r\n#pragma warning disable" +
                    " 414\r\n#pragma warning disable 168\r\n\r\nnamespace ");
            
            #line 11 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using System;\r\n    using MessagePack;\r\n\r\n");
            
            #line 16 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 foreach(var objInfo in objectSerializationInfos) { 
            
            #line default
            #line hidden
            this.Write("\r\n    public sealed class ");
            
            #line 18 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.Name));
            
            #line default
            #line hidden
            this.Write("Formatter : global::MessagePack.Formatters.IMessagePackFormatter<");
            
            #line 18 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.FullName));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n");
            
            #line 20 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if( objInfo.IsStringKey) { 
            
            #line default
            #line hidden
            this.Write("\r\n        readonly global::MessagePack.Internal.AutomataDictionary ____keyMapping" +
                    ";\r\n        readonly byte[][] ____stringByteKeys;\r\n\r\n        public ");
            
            #line 25 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.Name));
            
            #line default
            #line hidden
            this.Write("Formatter()\r\n        {\r\n            this.____keyMapping = new global::MessagePack" +
                    ".Internal.AutomataDictionary()\r\n            {\r\n");
            
            #line 29 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 foreach(var x in objInfo.Members) { 
            
            #line default
            #line hidden
            this.Write("                { \"");
            
            #line 30 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.StringKey));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 30 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.IntKey));
            
            #line default
            #line hidden
            this.Write("},\r\n");
            
            #line 31 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            };\r\n\r\n            this.____stringByteKeys = new byte[][]\r\n           " +
                    " {\r\n");
            
            #line 36 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 foreach(var x in objInfo.Members.Where(x => x.IsReadable)) { 
            
            #line default
            #line hidden
            this.Write("                global::MessagePack.MessagePackBinary.GetEncodedStringBytes(\"");
            
            #line 37 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.StringKey));
            
            #line default
            #line hidden
            this.Write("\"),\r\n");
            
            #line 38 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                \r\n            };\r\n        }\r\n\r\n");
            
            #line 42 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n        public int Serialize(ref byte[] bytes, int offset, ");
            
            #line 44 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.FullName));
            
            #line default
            #line hidden
            this.Write(" value, global::MessagePack.IFormatterResolver formatterResolver)\r\n        {\r\n");
            
            #line 46 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if( objInfo.IsClass) { 
            
            #line default
            #line hidden
            this.Write("            if (value == null)\r\n            {\r\n                return global::Mes" +
                    "sagePack.MessagePackBinary.WriteNil(ref bytes, offset);\r\n            }\r\n");
            
            #line 51 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            \r\n");
            
            #line 52 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
if(objInfo.HasIMessagePackSerializationCallbackReceiver && objInfo.NeedsCastOnBefore) { 
            
            #line default
            #line hidden
            this.Write("            ((IMessagePackSerializationCallbackReceiver)value).OnBeforeSerialize(" +
                    ");\r\n");
            
            #line 54 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else if(objInfo.HasIMessagePackSerializationCallbackReceiver) { 
            
            #line default
            #line hidden
            this.Write("            value.OnBeforeSerialize();\r\n");
            
            #line 56 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            var startOffset = offset;\r\n");
            
            #line 58 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if( objInfo.IsIntKey) { if( (objInfo.MaxKey + 1) <= 15) { 
            
            #line default
            #line hidden
            this.Write("            offset += global::MessagePack.MessagePackBinary.WriteFixedArrayHeader" +
                    "Unsafe(ref bytes, offset, ");
            
            #line 59 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.MaxKey + 1));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 60 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            offset += global::MessagePack.MessagePackBinary.WriteArrayHeader(ref " +
                    "bytes, offset, ");
            
            #line 61 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.MaxKey + 1));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 62 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } } else if( objInfo.WriteCount <= 15) { 
            
            #line default
            #line hidden
            this.Write("            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUn" +
                    "safe(ref bytes, offset, ");
            
            #line 63 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.WriteCount));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 64 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            offset += global::MessagePack.MessagePackBinary.WriteMapHeader(ref by" +
                    "tes, offset, ");
            
            #line 65 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.WriteCount));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 66 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 67 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if(objInfo.IsIntKey) { 
            
            #line default
            #line hidden
            
            #line 68 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 for(var i =0; i<= objInfo.MaxKey; i++) { var member = objInfo.GetMember(i); 
            
            #line default
            #line hidden
            
            #line 69 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if( member == null) { 
            
            #line default
            #line hidden
            this.Write("            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, o" +
                    "ffset);\r\n");
            
            #line 71 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            offset += ");
            
            #line 72 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.GetSerializeMethodString()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 73 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } } } else { 
            
            #line default
            #line hidden
            
            #line 74 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 var index = 0; foreach(var x in objInfo.Members) { 
            
            #line default
            #line hidden
            this.Write("            offset += global::MessagePack.MessagePackBinary.WriteRaw(ref bytes, o" +
                    "ffset, this.____stringByteKeys[");
            
            #line 75 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(index++));
            
            #line default
            #line hidden
            this.Write("]);\r\n            offset += ");
            
            #line 76 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.GetSerializeMethodString()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 77 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("            return offset - startOffset;\r\n        }\r\n\r\n        public ");
            
            #line 81 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.FullName));
            
            #line default
            #line hidden
            this.Write(" Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver for" +
                    "matterResolver, out int readSize)\r\n        {\r\n            if (global::MessagePac" +
                    "k.MessagePackBinary.IsNil(bytes, offset))\r\n            {\r\n");
            
            #line 85 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if( objInfo.IsClass) { 
            
            #line default
            #line hidden
            this.Write("                readSize = 1;\r\n                return null;\r\n");
            
            #line 88 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("                throw new InvalidOperationException(\"typecode is null, struct not" +
                    " supported\");\r\n");
            
            #line 90 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            }\r\n\r\n            var startOffset = offset;\r\n");
            
            #line 94 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if(objInfo.IsStringKey) { 
            
            #line default
            #line hidden
            this.Write("            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(byte" +
                    "s, offset, out readSize);\r\n");
            
            #line 96 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            var length = global::MessagePack.MessagePackBinary.ReadArrayHeader(by" +
                    "tes, offset, out readSize);\r\n");
            
            #line 98 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            offset += readSize;\r\n\r\n");
            
            #line 101 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 foreach(var x in objInfo.Members) { 
            
            #line default
            #line hidden
            this.Write("            var __");
            
            #line 102 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.Name));
            
            #line default
            #line hidden
            this.Write("__ = default(");
            
            #line 102 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.Type));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 103 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n            for (int i = 0; i < length; i++)\r\n            {\r\n");
            
            #line 107 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if(objInfo.IsStringKey) { 
            
            #line default
            #line hidden
            this.Write(@"                var stringKey = global::MessagePack.MessagePackBinary.ReadStringSegment(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }
");
            
            #line 116 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("                var key = i;\r\n");
            
            #line 118 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n                switch (key)\r\n                {\r\n");
            
            #line 122 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 foreach(var x in objInfo.Members) { 
            
            #line default
            #line hidden
            this.Write("                    case ");
            
            #line 123 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.IntKey));
            
            #line default
            #line hidden
            this.Write(":\r\n                        __");
            
            #line 124 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.Name));
            
            #line default
            #line hidden
            this.Write("__ = ");
            
            #line 124 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.GetDeserializeMethodString()));
            
            #line default
            #line hidden
            this.Write(";\r\n                        break;\r\n");
            
            #line 126 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                    default:\r\n                        readSize = global::MessageP" +
                    "ack.MessagePackBinary.ReadNextBlock(bytes, offset);\r\n                        bre" +
                    "ak;\r\n                }\r\n");
            
            #line 131 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 if(objInfo.IsStringKey) { 
            
            #line default
            #line hidden
            this.Write("                \r\n                NEXT_LOOP:\r\n");
            
            #line 133 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                offset += readSize;\r\n            }\r\n\r\n            readSize = offs" +
                    "et - startOffset;\r\n\r\n            var ____result = new ");
            
            #line 139 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(objInfo.GetConstructorString()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 140 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 foreach(var x in objInfo.Members.Where(x => x.IsWritable)) { 
            
            #line default
            #line hidden
            this.Write("            ____result.");
            
            #line 141 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.Name));
            
            #line default
            #line hidden
            this.Write(" = __");
            
            #line 141 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x.Name));
            
            #line default
            #line hidden
            this.Write("__;\r\n");
            
            #line 142 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 143 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
if(objInfo.HasIMessagePackSerializationCallbackReceiver && objInfo.NeedsCastOnAfter) { 
            
            #line default
            #line hidden
            this.Write("            ((IMessagePackSerializationCallbackReceiver)____result).OnAfterDeseri" +
                    "alize();\r\n");
            
            #line 145 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } else if(objInfo.HasIMessagePackSerializationCallbackReceiver) { 
            
            #line default
            #line hidden
            this.Write("            ____result.OnAfterDeserialize();\r\n");
            
            #line 147 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            return ____result;\r\n        }\r\n    }\r\n\r\n");
            
            #line 152 "D:\git\MessagePack-CSharp\src\MessagePack.UniversalCodeGenerator\Generator\FormatterTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}\r\n\r\n#pragma warning restore 168\r\n#pragma warning restore 414\r\n#pragma warning re" +
                    "store 618\r\n#pragma warning restore 612");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class FormatterTemplateBase
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
