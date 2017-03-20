using JsonTemplating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTemplateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = string.Join("", File.ReadAllLines("template.txt"));
            var test = new Test
            {
                Key = "keyValue",
                Name = "nameValue",
                Code = "codeValue",
                Related = new Test
                {
                    Key = "childKeyValue",
                    Name = "childNameValue",
                    Code = "childCodeValue"
                }
            };

            var result = JsonTemplateVisitor.Serialize(test, template);
        }
    }

    class Test
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Test Related { get; set; }
    }
}
