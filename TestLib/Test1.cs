using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestLib
{
    public class Test1
    {
        TestJson TestJson { get; set; }
        public void GetItemsFromJson(string jsonPath)
        {
            string jsonText = File.ReadAllText(jsonPath);
            jsonText = jsonText;
            TestJson testJson = JsonConvert.DeserializeObject<TestJson>(jsonText);
            TestJson = testJson;
        }
        public int Process()
        {
            var hex = TestJson.GetFieldByName("data1").Value; 
            var a = Enumerable.Range(0, hex.Length)
                     .Where(k => k % 2 == 0)
                     .Select(k => Convert.ToByte(hex.Substring(k, 2), 16))
                     .ToArray();
            var b = int.Parse(TestJson.GetFieldByName("offset").Value);
            var c = int.Parse(TestJson.GetFieldByName("shift").Value);
            var x = a[b] >> c;
            return x;
        }
    }
}
