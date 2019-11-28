﻿namespace DatabaseCodeGenerator.Schema
{
    public static class Constants
    {
        public const string TypeInt = "int";
        public const string TypeFloat = "float";
        public const string TypeBool = "bool";
        public const string TypeEnum = "enum";
        public const string TypeString = "string";
        public const string TypeObject = "object";
        public const string TypeStruct = "struct";
        public const string TypeObjectList = "object_list";
        public const string TypeStructList = "struct_list";
        public const string TypeImage = "image";
        public const string TypeVector = "vector";
        public const string TypeColor = "color";
        public const string TypeLayout = "layout";
        public const string TypeAudioClip = "audioclip";

        public const string ItemTypeEnum = "ItemType";

        public static readonly char[] ValueSeparators = { ',','|',';',' ','\n','\r' };
    }
}
