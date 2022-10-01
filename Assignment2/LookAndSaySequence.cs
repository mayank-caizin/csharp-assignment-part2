using System.Text;

namespace Assignment2 {
    public class LookAndSaySequence {
        // Not working
        //private static long NextTerm(long currTerm) {
        //    var list = currTerm.ToString().Select(x => int.Parse(x.ToString())).ToList();
        //    var groups = list.GroupBy(d => d);

        //    StringBuilder sb = new StringBuilder();
        //    foreach(var group in groups) {
        //        sb.Append($"{group.Count()}{group.Key}");
        //    }

        //    return long.Parse(sb.ToString());
        //}

        private static long NextTerm(long currTerm) {
            string currStr = currTerm.ToString();
            int count = 1;
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < currStr.Length; i++) {
                if (currStr[i] == currStr[i - 1]) {
                    count++;
                }
                else {
                    sb.Append($"{count}{currStr[i - 1]}");
                    count = 1;
                }
            }
            sb.Append($"{count}{currStr[currStr.Length - 1]}");

            return long.Parse(sb.ToString());
        }

        public static List<long> LookAndSay(long start, int n) {
            List<long> list = new List<long> { start };

            for (int i = 1; i < n; i++) {
                list.Add(NextTerm(list[i - 1]));
            }

            return list;
        }
    }
}
