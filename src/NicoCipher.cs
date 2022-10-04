using System.Text;

namespace CSharp.Assignment.Part2 {
    public class NicoCipher {
        public static string EncryptNico(string message, string key) {
            int l = key.Length;
            List<List<char>> matrix = new List<List<char>>();

            for(int i = 0; i < l; i++) {
                matrix.Add(new List<char> { key[i] });
            }

            for(int i = 0; i < message.Length; i++) {
                matrix[i % l].Add(message[i]);
            }

            // Filling the last col with spaces
            int row_size = matrix[0].Count;
            for(int i = 0; i < l; i++) {
                if (matrix[i].Count < row_size) {
                    matrix[i].Add(' ');
                }
            }

            // Sorting the matrix based on the characters of the key
            matrix.Sort((a, b) => {
                if (a[0] < b[0]) return -1;
                else if (a[0] > b[0]) return 1;
                return 0;
            });

            // The final result
            StringBuilder sb = new StringBuilder();
            for(int j = 1; j < row_size; j++) {
                for(int i = 0; i < l; i++) {
                    sb.Append(matrix[i][j]);
                }
            }

            return sb.ToString();
        }
    }
}
