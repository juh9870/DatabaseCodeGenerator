//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;
using EditorDatabase.Enums;

namespace EditorDatabase.Serializable
{
    [Serializable]
    public class SerializableItem
    {
        [JsonIgnore]
	    public string FileName { get; set; }

        public ItemType ItemType;
        public int Id;
        public bool Disabled;
    }
}
