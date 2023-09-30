using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestLib
{
    internal class TestJson
    {
        string Name { get; set; }
        JsonFields[] Fields { get; set; }
        public TestJson(string name, JsonFields[] fields) 
        {
            Name = name;
            Fields = fields;
        }
        public JsonFields GetFieldByName(string name)
        {
            return Fields.FirstOrDefault<JsonFields>(field => field.Name == name);
        }
    }
}
