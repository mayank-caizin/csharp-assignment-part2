namespace Assignment2 {
    public class FareySequence {
        public static List<string> Farey(int n) {
            List<string> list = new List<string>();

            double x1 = 0, y1 = 1, x2 = 1, y2 = n;
            list.Add($"{x1}/{y1}");
            list.Add($"{x2}/{y2}");

            double x, y = 0;
            while(y2 != 1.0) {
                x = Math.Floor((y1 + n) / y2) * x2 - x1;
                y = Math.Floor((y1 + n) / y2) * y2 - y1;

                list.Add($"{x}/{y}");

                x1 = x2;
                x2 = x;
                y1 = y2;
                y2 = y;
            }

            return list;
        }
    }
}
