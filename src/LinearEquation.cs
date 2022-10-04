using System.Text.RegularExpressions;

namespace CSharp.Assignment.Part2 {
    public class LinearEquation {
        private static int GetCoeffSum(string exp) {
            Regex coeffRegex = new Regex(@"(-)?(\d+)?x");
            int sum = 0;

            foreach (Match match in coeffRegex.Matches(exp)) {
                int curr = 1;
                if (match.Groups[1].Value != "") curr = -1;
                if (match.Groups[2].Value != "") curr *= int.Parse(match.Groups[2].Value);

                sum += curr;
            }

            return sum;
        }

        private static int GetConstSum(string exp) {
            Regex constRegex = new Regex(@"(?>-?[\d]*)(?!x)");
            int sum = 0;

            foreach(Match match in constRegex.Matches(exp)) {
                if(match.Value != "")
                    sum += int.Parse(match.Value);
            }

            return sum;
        }

        public static string FindX(string equation) {
            string[] split = equation.Split('=');
            string lhs = split[0], rhs = split[1];

            int coeffSum = GetCoeffSum(lhs) - GetCoeffSum(rhs);
            int constSum = GetConstSum(rhs) - GetConstSum(lhs);

            if (coeffSum == 0 && constSum == 0) return "Infinite solutions";

            if (coeffSum == 0) return "No solution";

            double x = Math.Round((double) constSum / coeffSum, 2);

            return $"x={x}";
        }
    }
}
