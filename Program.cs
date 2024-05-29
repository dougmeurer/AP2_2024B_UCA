
public class Atv2Prog1 {
    
    private static List<int> vetor = new List<int>();

    public static void Main(string[] args) {

       while(true)
       { try {
        
        Console.WriteLine("Por favor digite o numero correspondente a ação que deseja executar: \n");
        Console.WriteLine("1 - Listar vetor");
        Console.WriteLine("2 - Adicionar número ao vetor");
        Console.WriteLine("3 - Exibir a mediana e moda do vetor");
        Console.WriteLine("6 - Excluir o último número do vetor");
        Console.WriteLine("7 - Sair");
        
        int option = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        if (option >= 8) {
                Console.WriteLine($"O Numero {option} não corresponde a uma opcao valida!");
        } else if (option < 6 && option > 3) { 
                Console.WriteLine($"O Numero {option} não corresponde a uma opcao valida!");
        } else {

            switch (option)
        {
            case 1: 
                ShowNumbers();
                 break;
            case 2: 
                CreateAndFillArray();
                break;
            case 3: 
                CalcMedian();
                CalcModa();
                break;
            case 6:
                PopLast();
                break;
            case 7: 
            Console.WriteLine("Saindo...");
            return;
        
        }

        }      

        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor digite um numero valido!");
            
        }



       } 

        

    }

    static void CreateAndFillArray() {
        Console.WriteLine("Digite quantos números você gostaria de armazenar neste vetor:");
        int vetorSize = Convert.ToInt32(Console.ReadLine());

        vetor.Clear();

        for (int i = 0; i < vetorSize; i++) {
            Console.WriteLine($"Digite um número para adicionar à posição {i}:");
            vetor.Add(Convert.ToInt32(Console.ReadLine()));
        }
    }

    static void ShowNumbers() {
        if (vetor.Count == 0) {
            Console.WriteLine("Vetor Vazio!");
        } else {
            Console.WriteLine("Os valores inseridos no Vetor são:");
            for (int i = 0; i < vetor.Count; i++) {
                Console.WriteLine($"Index {i} - Valor: {vetor[i]}");
            }
        }
    }

    static void PopLast() {
        if (vetor.Count > 0) {
            vetor.RemoveAt(vetor.Count - 1);
            Console.WriteLine("Ultimo numero excluido.");
        } else {
            Console.WriteLine("Vetor Vazio!");
        }
    }

    static void CalcMedian() {
        if (vetor.Count == 0) {
            Console.WriteLine("Vetor vazio! não é possivel calcular a mediana.");
            return;
        }

        var sortedVetor = vetor.OrderBy(n => n).ToList();
        double median;

        if (sortedVetor.Count % 2 == 0) {
            median = (sortedVetor[sortedVetor.Count / 2 - 1] + sortedVetor[sortedVetor.Count / 2]) / 2.0;
        } else {
            median = sortedVetor[sortedVetor.Count / 2];
        }

        Console.WriteLine($"A mediana do vetor é: {median}");
    }

    static void CalcModa() {
        if (vetor.Count == 0) {
            Console.WriteLine("Vetor vazio! não é possivel calcular a moda.");
            return;
        }

        var moda = vetor.GroupBy(n => n)
                        .OrderByDescending(g => g.Count())
                        .First()
                        .Key;

        Console.WriteLine($"A moda do vetor é: {moda}");
    }

}


