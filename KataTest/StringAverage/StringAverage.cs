using System.Linq;

namespace KataTest.StringAverage
{
    public class StringAverage
    {
        public string[] NumberString = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public string AverageString(string input)
        {
            if (input == "")
            {
                return "n/a";
            }
            var numbers = input.Split(' ');
            var total = numbers.Sum(number => ConvertToInt(number));

            var average = total / numbers.Length;

            return NumberString[average];
        }

        private int ConvertToInt(string input)
        {
            switch (input)
            {
                case "zero":
                    return 0;
                    break;
                case "one":
                    return 1;
                    break;
                case "two":
                    return 2;
                    break;
                case "three":
                    return 3;
                    break;
                case "four":
                    return 4;
                    break;
                case "five":
                    return 5;
                    break;
                case "six":
                    return 6;
                    break;
                case "seven":
                    return 7;
                    break;
                case "eight":
                    return 8;
                    break;
                case "nine":
                    return 9;
                    break;
                default:
                    return 0;
                    break;
            }

            return 0;
        }
    }
}
//1.
//英文跟數字的轉換, 可以改用Dictionary或Enum
//目前你的寫法, 如果需要異動轉換表, 在NumberString array及switch裡都會需要改動
//而且有可能因為兩邊不一致造成錯誤, Dictionary跟Enum則不會有這樣的問題
//另外用index去取array裡面的值通常是比較難理解跟維護的
//也容易因為順序改變而取到錯誤的值

//2.
//對照表之外的測試案例
//需求描述中有提到 If the string is empty or includes a number greater than 9, return "n/a"
//另外我記得在Codewars要submit的時候也會有在對照表之外的input test case
//"one vpmibk two seven seven" 但沒有看到你的Test case有加入
//建議可以稍微加一些邊際測試, 確保程式在錯誤的輸入時也能正常運作