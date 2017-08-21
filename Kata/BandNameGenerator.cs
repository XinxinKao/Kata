using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class BandNameGenerator
    {
        public string Generator(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return null;

            var lowerInputString = inputString.Trim().ToLower();
            var head = lowerInputString.Substring(0, 1).ToUpper();
            var body = lowerInputString.Substring(1);
            var text = head + body;
            if (lowerInputString.Substring(0, 1) == lowerInputString.Substring(lowerInputString.Length - 1))
            {
                return text + body;
            }

            return "The " + text;
        }
    }
}

//1.字首跟字尾可以用linq的First()跟Last(), 比較簡潔

//2.可以補一下Test Case Name, 比較可以清楚看出那一條的測試意圖

//3.雖然是Kata, 建議比照真實開發的情況, 把Production code跟Test code拆成不同專案, 
//讓Test Code build failed不會影響到Production code, 也不會一起被release上去