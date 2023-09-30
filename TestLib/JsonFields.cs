using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestLib
{
    internal class JsonFields
    {
        string type;
        public string Type 
        {
            get { return type; } 
            set { type = value; }
        }
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string value;
        public string Value 
        {
            get { return value; }
            set { this.value = value; }
        } 
        public JsonFields(string type, string name, string value)
        {
            Type = type; 
            Name = name; 
            Value = value;
        }
    }
}
