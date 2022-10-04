using System.Text;

namespace CSharp.Assignment.Part2 {
    public class PilishStrings {
        public static string PilishString(string str) {
            if (str.Length == 0) return "";

            const string PI = "314159265358979";
            StringBuilder res = new StringBuilder();

            int i = 0, p = 0, length = 0;
            for(i = 0; i < PI.Length; i++) {
                length = PI[i] - '0';
                if (p + length >= str.Length) break;

                res.Append(str.Substring(p, length));

                if (i < PI.Length - 1)
                    res.Append(' ');

                p += length;
            }

            if(i < PI.Length)
                res.Append(str.Substring(p).PadRight(length, str[str.Length - 1]));

            return res.ToString();
        }
    }
}
