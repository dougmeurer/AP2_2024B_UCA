public class Atv2Prog1 {

    public static void Main(string[] args) {

        int vetorSize;

        try {
                Console.Clear();
                Console.WriteLine("Digite quantos numeros voce gostaria de armazenar neste vetor:");
                vetorSize = Convert.ToInt32(Console.ReadLine());

                int [] vetor = new int[vetorSize];

                    for (int i = 0; i < vetor.Length; i++){
                        Console.WriteLine($"Digite um numero para adicionar a posicao {i}:");
                        vetor[i] = Convert.ToInt32(Console.ReadLine());
                    }

                        Console.WriteLine("Os valores inseridos no Vetor sao:");
                            for (int i = 0; i < vetor.Length; i++) {
                                Console.WriteLine($"Index {i} - Valor: {vetor[i]}");
                            }

        } catch (FormatException) {

            Console.WriteLine("Opa! Digite um Numero Valido Por Favor.");

        }

        

    }

    // public static int AddNumbers(int[] args) {

    // }

    // public static double CalcMedian(int[] sortedArray) {


    // }

}


