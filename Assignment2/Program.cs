namespace Assignment2 {
    internal class Program {
        static void LookAndSaySequenceTest() {
            int[][] inputs = {
                new int[] { 1, 7 },
                new int[] { 123, 4 },
                new int[] { 70, 5 },
            };

            foreach (var input in inputs) {
                List<long> output = LookAndSaySequence.LookAndSay(input[0], input[1]);
                foreach(long item in output) {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        static void PilishStringsTest() {
            string[] inputs = {
                "", "33314444", "TOP", "X",
                "HOWINEEDADRINKALCOHOLICINNATUREAFTERTHEHEAVYLECTURESINVOLVINGQUANTUMMECHANICSANDALLTHESECRETSOFTHEUNIVERSE",
                "CANIMAKEAGUESSNOW", "FORALOOP"
            };
            foreach(string input in inputs) {
                Console.WriteLine(PilishStrings.PilishString(input));
            }
        }

        static void Main(string[] args) {
            // LookAndSaySequenceTest();
            PilishStringsTest();
        }
    }
}