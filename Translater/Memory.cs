using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater
{
    class Memory
    {
        public static string trformattype = File.ReadAllText(@".\TranslaterLangs\" + File.ReadAllText(@".\pacageselector.mem") + @".translatepacage");
        public static string pacageselector = File.ReadAllText(@".\pacageselector.mem");
    }
}
