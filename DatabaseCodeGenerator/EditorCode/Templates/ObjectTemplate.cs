﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace DatabaseCodeGenerator.EditorCode.Templates
{
    using Schema;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ObjectTemplate : ObjectTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 1 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//-------------------------------------------------------------------------------"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 2 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//                                                                               "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 3 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    This code was automatically generated.                                     "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 4 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    Changes to this file may cause incorrect behavior and will be lost if      "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 5 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    the code is regenerated.                                                   "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 6 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//                                                                               "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 7 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//-------------------------------------------------------------------------------"));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System.Linq;\r\nusing ");
            
            #line 6 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 6 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.EnumsNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 7 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 7 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 8 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 8 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.TypesNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nnamespace ");
            
            #line 10 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 10 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ClassesNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic partial class ");
            
            #line 12 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DataClassName(ObjectData)));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\tpartial void OnDataDeserialized(");
            
            #line 14 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(ObjectData.name)));
            
            #line default
            #line hidden
            this.Write(" serializable, ");
            
            #line 14 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseClassName));
            
            #line default
            #line hidden
            this.Write(" database);\r\n\r\n");
            
            #line 16 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

		if (ObjectType == ObjectType.Struct)
        {

            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 20 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DataClassName(ObjectData)));
            
            #line default
            #line hidden
            this.Write("() {}\r\n");
            
            #line 21 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 25 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DataClassName(ObjectData)));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 25 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(ObjectData.name)));
            
            #line default
            #line hidden
            this.Write(" serializable, ");
            
            #line 25 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseClassName));
            
            #line default
            #line hidden
            this.Write(" database)\r\n\t\t{\r\n");
            
            #line 27 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

			if (ObjectType == ObjectType.Class)
            {

            
            #line default
            #line hidden
            this.Write("\t\t\tId = new ItemId<");
            
            #line 31 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DataClassName(ObjectData)));
            
            #line default
            #line hidden
            this.Write(">(serializable.Id, serializable.FileName);\r\n");
            
            #line 32 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

			}

			PushIndent("\t\t\t");

			foreach (var item in ObjectData.members)
				WriteDeserializationCode(item, Schema);

			PopIndent();

            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tOnDataDeserialized(serializable, database);\r\n\t\t}\r\n\r\n");
            
            #line 46 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

		if (ObjectType == ObjectType.Struct)
        {

            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 50 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(ObjectData.name) + " " + Utils.StructSerializationMethodName));
            
            #line default
            #line hidden
            this.Write("()\r\n\t\t{\r\n\t\t\tvar serializable = new ");
            
            #line 52 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(ObjectData.name)));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 53 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

		}
		else
        {

            
            #line default
            #line hidden
            this.Write("\t\tpublic void ");
            
            #line 58 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializationMethodName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 58 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(ObjectData.name)));
            
            #line default
            #line hidden
            this.Write(" serializable)\r\n\t\t{\r\n");
            
            #line 60 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

			}

			PushIndent("\t\t\t");

			foreach (var item in ObjectData.members)
				WriteSerializationCode(item, Schema);

			PopIndent();

			if (ObjectType == ObjectType.Struct)
            {

            
            #line default
            #line hidden
            this.Write("\t\t\treturn serializable;\r\n");
            
            #line 74 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

			}

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 79 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

		if (ObjectType == ObjectType.Class)
        {

            
            #line default
            #line hidden
            this.Write("\t\tpublic readonly ItemId<");
            
            #line 83 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DataClassName(ObjectData)));
            
            #line default
            #line hidden
            this.Write("> Id;\r\n\r\n");
            
            #line 85 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

		}

            
            #line default
            #line hidden
            
            #line 88 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"

		PushIndent("\t\t");

		foreach (var item in ObjectData.members) 
			WriteDataClassMember(item, Schema);

		PopIndent();

            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic static ");
            
            #line 97 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\ObjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DataClassName(ObjectData)));
            
            #line default
            #line hidden
            this.Write(" DefaultValue { get; private set; }\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 2 "D:\Projects\Database\DatabaseCodeGenerator\DatabaseCodeGenerator\EditorCode\Templates\Serialization.tt"

		private void WriteSerializableClassMember(XmlClassMember member, DatabaseSchema schema)
		{
			if (member.type == Constants.TypeInt)
			{
				WriteLine("public int " + member.name + ";");
			}
			else if (member.type == Constants.TypeFloat)
			{
				WriteLine("public float " + member.name + ";");
			}
			else if (member.type == Constants.TypeBool)
			{
				WriteLine("public bool " + member.name + ";");
			}
			else if (member.type == Constants.TypeString)
			{
				WriteLine("[DefaultValue(\"\")]");
				WriteLine("public string " + member.name + ";");
			}
			else if (member.type == Constants.TypeColor)
			{
				WriteLine("[DefaultValue(\"\")]");
				WriteLine("public string " + member.name + ";");
			}
			else if (member.type == Constants.TypeImage)
			{
				WriteLine("[DefaultValue(\"\")]");
				WriteLine("public string " + member.name + ";");
			}
			else if (member.type == Constants.TypeAudioClip)
			{
				WriteLine("[DefaultValue(\"\")]");
				WriteLine("public string " + member.name + ";");
			}
			else if (member.type == Constants.TypePrefab)
			{
				WriteLine("[DefaultValue(\"\")]");
				WriteLine("public string " + member.name + ";");
			}
			else if (member.type == Constants.TypeLayout)
			{
				WriteLine("[DefaultValue(\"\")]");
				WriteLine("public string " + member.name + ";");
			}
			else if (member.type == Constants.TypeVector)
			{
				WriteLine("public Vector2 " + member.name + ";");
			}
			else if (member.type == Constants.TypeEnum)
			{
				if (!schema.HasEnum(member.typeid))
					throw new InvalidSchemaException("Unknown enum type in class member " + member.name);

				WriteLine("public " + member.typeid + " " + member.name + ";");
			}
			else if (member.type == Constants.TypeObject)
			{
				if (!schema.HasObject(member.typeid))
					throw new InvalidSchemaException("Unknown object type in class member " + member.name);

				WriteLine("public int " + member.name + ";");
			}
			else if (member.type == Constants.TypeObjectList)
			{
				if (!schema.HasObject(member.typeid))
					throw new InvalidSchemaException("Unknown object type in class member " + member.name);

				WriteLine("public int[] " + member.name + ";");
			}
			else if (member.type == Constants.TypeStruct)
			{
				if (!schema.HasStruct(member.typeid))
					throw new InvalidSchemaException("Unknown struct type in class member " + member.name);

				WriteLine("public " + Utils.SerializableClassName(member.typeid) + " " + member.name + ";");
			}
			else if (member.type == Constants.TypeStructList)
			{
				if (!schema.HasStruct(member.typeid))
					throw new InvalidSchemaException("Unknown struct type in class member " + member.name);

				WriteLine("public " + Utils.SerializableClassName(member.typeid) + "[] " + member.name + ";");
			}
			else if (member.type == Constants.TypeEnumFlags)
			{
				if (!schema.HasEnum(member.typeid))
					throw new InvalidSchemaException("Unknown enum type in class member " + member.name);

				WriteLine("public " + member.typeid + "[] " + member.name + ";");
			}
			else
			{
				throw new InvalidSchemaException("Invalid class member type - " + member.type);
			}
		}

		private void WriteDataClassMember(XmlClassMember member, DatabaseSchema schema)
		{
			//var obsolete = member.options.Contains(Constants.OptionObsolete);
			var memberName = !string.IsNullOrEmpty(member.alias) ? member.alias : member.name;
			//if (obsolete) memberName = PrivateMemberName(memberName);
			var prefix = "public "; //obsolete ? "private readonly " : "public ";
			var suffix = ";"; //obsolete ? ";" : " { get; private set; }";

			if (member.type == Constants.TypeInt)
			{
	            member.MinMaxInt(out var minvalue, out var maxvalue);
		        WriteLine(prefix + "NumericValue<int> " + memberName + " = new NumericValue<int>(0, " + minvalue + ", " + maxvalue + ");");
			}
			else if (member.type == Constants.TypeFloat)
			{
	            member.MinMaxFloat(out var minvalue, out var maxvalue);
		        WriteLine(prefix + "NumericValue<float> " + memberName + " = new NumericValue<float>(0, " + minvalue + "f, " + maxvalue + "f);");
			}
			else if (member.type == Constants.TypeBool)
			{
				WriteLine(prefix + "bool " + memberName + suffix);
			}
			else if (member.type == Constants.TypeString)
			{
				WriteLine(prefix + "string " + memberName + suffix);
			}
			else if (member.type == Constants.TypeColor)
			{
				WriteLine(prefix + "System.Drawing.Color " + memberName + suffix);
			}
			else if (member.type == Constants.TypeImage)
			{
				WriteLine(prefix + "string " + memberName + suffix);
			}
			else if (member.type == Constants.TypeAudioClip)
			{
				WriteLine(prefix + "string " + memberName + suffix);
			}
			else if (member.type == Constants.TypePrefab)
			{
				WriteLine(prefix + "string " + memberName + suffix);
			}
			else if (member.type == Constants.TypeLayout)
			{
				WriteLine(prefix + "Layout " + memberName + suffix);
			}
			else if (member.type == Constants.TypeVector)
			{
				WriteLine(prefix + "Vector2 " + memberName + suffix);
			}
			else if (member.type == Constants.TypeEnum)
			{
				if (!schema.HasEnum(member.typeid))
					throw new InvalidSchemaException("Unknown enum type in class member " + member.name);

				WriteLine(prefix + member.typeid + " " + memberName + suffix);
			}
			else if (member.type == Constants.TypeObject)
			{
				if (!schema.HasObject(member.typeid))
					throw new InvalidSchemaException("Unknown object type in class member " + member.name);

				var dataClass = schema.GetObject(member.typeid);
				WriteLine(prefix + "ItemId<" + Utils.DataClassName(dataClass) + "> " + memberName + " = ItemId<" + Utils.DataClassName(dataClass) + ">.Empty" + suffix);
			}
			else if (member.type == Constants.TypeObjectList)
			{
				if (!schema.HasObject(member.typeid))
					throw new InvalidSchemaException("Unknown object type in class member " + member.name);

				var dataClass = schema.GetObject(member.typeid);
				
				WriteLine(prefix + "Wrapper<" + Utils.DataClassName(dataClass) + ">[] " + memberName + suffix);
			}
			else if (member.type == Constants.TypeStruct)
			{
				if (!schema.HasStruct(member.typeid))
					throw new InvalidSchemaException("Unknown struct type in class member " + member.name);

				var dataClass = schema.GetStruct(member.typeid);
				WriteLine(prefix + Utils.DataClassName(dataClass) + " " + memberName + " = new " + Utils.DataClassName(dataClass) + "()" + suffix);
			}
			else if (member.type == Constants.TypeStructList)
			{
				if (!schema.HasStruct(member.typeid))
					throw new InvalidSchemaException("Unknown struct type in class member " + member.name);

				var dataClass = schema.GetStruct(member.typeid);

				WriteLine(prefix + Utils.DataClassName(dataClass) + "[] " + memberName + suffix);
			}
			else if (member.type == Constants.TypeEnumFlags)
			{
				if (!schema.HasEnum(member.typeid))
					throw new InvalidSchemaException("Unknown enum type in class member " + member.name);

				WriteLine(prefix + member.typeid + "[] " + memberName + suffix);
			}
			else
			{
				throw new InvalidSchemaException("Invalid class member type - " + member.type);
			}
		}

		private string GetSerializableDefaultValue(XmlClassMember member, DatabaseSchema schema)
        {
			switch (member.type)
			{
				case Constants.TypeInt:
				case Constants.TypeEnum:
				case Constants.TypeObject:
					return "0";
				case Constants.TypeFloat:
					return "0f";
				case Constants.TypeBool:
					return "false";
				case Constants.TypeString:
				case Constants.TypeColor:
				case Constants.TypeImage:
				case Constants.TypeAudioClip:
				case Constants.TypePrefab:
				case Constants.TypeLayout:
					return "string.Empty";
				case Constants.TypeVector:
					return "Vector2.Zero";
				case Constants.TypeObjectList:
				case Constants.TypeStructList:
				case Constants.TypeEnumFlags:
					return "null";
				case Constants.TypeStruct:
					return "new " + Utils.SerializableClassName(member.typeid) + "()";
				default:
					throw new InvalidSchemaException("Invalid class member type - " + member.type);
			}
        }

		private void WriteSerializationCode(XmlClassMember member, DatabaseSchema schema)
        {
			var memberName = !string.IsNullOrEmpty(member.alias) ? member.alias : member.name;
			//if (member.options.Contains(Constants.OptionObsolete)) memberName = PrivateMemberName(memberName);
			var notnull = member.options.Contains(Constants.OptionNotNull);

            if (member.type == Constants.TypeObject)
            {
				var dataClass = schema.GetObject(member.typeid);
                WriteLine("serializable." + member.name + " = " + memberName + ".Value;");
				//TODO: if (notnull)
            }
            else if (member.type == Constants.TypeObjectList)
            {
				var dataClass = schema.GetObject(member.typeid);
                WriteLine("if (" + memberName + " == null || " + memberName + ".Length == 0)");
                WriteLine("    serializable." + member.name + " = null;");
                WriteLine("else");
                WriteLine("    serializable." + member.name + " = " + memberName + ".Select(wrapper => wrapper.Item.Value).ToArray();");
            }
            else if (member.type == Constants.TypeStruct)
            {
				var dataClass = schema.GetStruct(member.typeid);
                WriteLine("serializable." + member.name + " = " + memberName + "." + Utils.StructSerializationMethodName + "();");
            }
            else if (member.type == Constants.TypeStructList)
            {
				var dataClass = schema.GetStruct(member.typeid);
                WriteLine("if (" + memberName + " == null || " + memberName + ".Length == 0)");
                WriteLine("    serializable." + member.name + " = null;");
                WriteLine("else");
                WriteLine("    serializable." + member.name + " = " + memberName + ".Select(item => item." +
					Utils.StructSerializationMethodName + "()).ToArray();");
            }
			else if (member.type == Constants.TypeEnumFlags)
			{
                WriteLine("if (" + memberName + " == null || " + memberName + ".Length == 0)");
                WriteLine("    serializable." + member.name + " = null;");
                WriteLine("else");
                WriteLine("    serializable." + member.name + " = (" + member.typeid + "[])" + memberName + ".Clone();");
			}
            else if (member.type == Constants.TypeInt)
            {
                WriteLine("serializable." + member.name + " = " + memberName + ".Value;");
            }
            else if (member.type == Constants.TypeFloat)
            {
                WriteLine("serializable." + member.name + " = " + memberName + ".Value;");
            }
            else if (member.type == Constants.TypeColor)
            {
                WriteLine("serializable." + member.name + " = Helpers.ColorToString(" + memberName + ");");
            }
            else if (member.type == Constants.TypeLayout)
            {
                WriteLine("serializable." + member.name + " = " + memberName + ".Data;");
            }
            else
            {
                WriteLine("serializable." + member.name + " = " + memberName + ";");
            }
        }

        private void WriteDeserializationCode(XmlClassMember member, DatabaseSchema schema)
        {
			var memberName = !string.IsNullOrEmpty(member.alias) ? member.alias : member.name;
			//if (member.options.Contains(Constants.OptionObsolete)) memberName = PrivateMemberName(memberName);
			var notnull = member.options.Contains(Constants.OptionNotNull);

            if (member.type == Constants.TypeObject)
            {
				var dataClass = schema.GetObject(member.typeid);
                WriteLine(memberName + " = database." + Utils.ObjectIdGetterName(member.typeid) + "(serializable." + member.name + ");");
				if (notnull)
				{
					WriteLine("if (" + memberName + ".IsNull)");
					WriteLine("    throw new DatabaseException(this.GetType().Name + \"." + memberName + " cannot be null\");");
                }
            }
            else if (member.type == Constants.TypeObjectList)
            {
				var dataClass = schema.GetObject(member.typeid);
                WriteLine(memberName + " = serializable." + member.name + "?.Select(id => new Wrapper<" + 
					Utils.DataClassName(dataClass) + "> { Item = database." + Utils.ObjectIdGetterName(member.typeid) + "(id) }).ToArray();");
            }
            else if (member.type == Constants.TypeStruct)
            {
				var dataClass = schema.GetStruct(member.typeid);
                WriteLine(memberName + " = new " + Utils.DataClassName(dataClass) + "(serializable." + member.name + ", database);");
            }
            else if (member.type == Constants.TypeStructList)
            {
				var dataClass = schema.GetStruct(member.typeid);
                WriteLine(memberName + " = serializable." + member.name + "?.Select(item => new " + 
					Utils.DataClassName(dataClass) + "(item, database)).ToArray();");
            }
			else if (member.type == Constants.TypeEnumFlags)
			{
                WriteLine(memberName + " = (" + member.typeid + "[])serializable." + member.name + "?.Clone();");
			}
            else if (member.type == Constants.TypeInt)
            {
                member.MinMaxInt(out var minvalue, out var maxvalue);
                WriteLine(memberName + " = new NumericValue<int>(serializable." + member.name + ", " + minvalue + ", " + maxvalue + ");");
            }
            else if (member.type == Constants.TypeFloat)
            {
                member.MinMaxFloat(out var minvalue, out var maxvalue);
                WriteLine(memberName + " = new NumericValue<float>(serializable." + member.name + ", " + minvalue + "f, " + maxvalue + "f);");
            }
            else if (member.type == Constants.TypeColor)
            {
                WriteLine(memberName + " = Helpers.ColorFromString(serializable." + member.name + ");");
            }
            else if (member.type == Constants.TypeLayout)
            {
                WriteLine(memberName + " = new Layout(serializable." + member.name + ");");
            }
            else
            {
                WriteLine(memberName + " = serializable." + member.name + ";");
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
    public class ObjectTemplateBase
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
