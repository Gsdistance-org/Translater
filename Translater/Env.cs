using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater
{
    public class Env
    {
        public static string Apikey { get; } = @"pdct.1.1.20210621T080654Z.ffed2f67d1cd4249.72f57e4243ba2ca13c16420aa636d9c21aa2b9f7";
        public static string UrlGetLangsAvivable { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/getlangs?key={0}&ui={1}";
        public static string UrlDetectSrcLang { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/detect?key={0}&text={1}";
        public static string UrlTranslateLang { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}";
    }
}
