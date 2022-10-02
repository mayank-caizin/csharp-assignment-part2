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

        static void FareySequenceTest() {
            int[] inputs = { 1, 4, 5 };

            foreach(int input in inputs) {
                List<string> output = FareySequence.Farey(input);
                foreach(string item in output) {
                    Console.Write(item + ' ');
                }
                Console.WriteLine();
            }
        }

        static void LinearEquationTest() {
            string[] inputs = {
                "99x=99",
                "4x-7=x+11",
                "3x=2x+x",
                "3x=3x+2",
                "-1-2x=15+x"
            };

            foreach(string input in inputs) {
                Console.WriteLine(LinearEquation.FindX(input));
            }
        }

        static void NicoCipherTest() {
            string[][] inputs = {
                new string[] { "mubashirhassan", "crazy" },
                new string[] { "edabitisamazing", "matt" },
                new string[] { "iloveher", "612345" },
            };

            foreach(var input in inputs) {
                Console.WriteLine(NicoCipher.EncryptNico(input[0], input[1]));
            }
        }

        static void Main(string[] args) {
            // LookAndSaySequenceTest();
            // PilishStringsTest();
            // FareySequenceTest();
            // LinearEquationTest();
            NicoCipherTest();
        }
    }
}