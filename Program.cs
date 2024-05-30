
public class Atv2Prog1 {
    
    private static List<int> vetor = new List<int>();

    public static void Main(string[] args) {

       while(true)
       { try {
        
        Console.WriteLine("Please insert a number corresponding to the action you wish you perform: \n");
        Console.WriteLine("1 - List Vector");
        Console.WriteLine("2 - Add a Number to the Vector");
        Console.WriteLine("3 - Show Vector's Mean & Median");
        Console.WriteLine("6 - Delete the Last Number of the Vector");
        Console.WriteLine("7 - Exit");
        
        int option = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        if (option >= 8) {
                Console.WriteLine($"The number {option} does not correspond to a valid option!");
        } else if (option < 6 && option > 3) { 
                Console.WriteLine($"The number {option} does not correspond to a valid option!");
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
            Console.WriteLine("Exiting...");
            return;
        
        }

        }      

        }
        catch (FormatException)
        {
            Console.WriteLine("Please insert a valid number.");
            
        }



       } 

        

    }

    static void CreateAndFillArray() {
        Console.WriteLine("Enter how many numbers you would like to store in the vector:");
        int vetorSize = Convert.ToInt32(Console.ReadLine());

        vetor.Clear();

        for (int i = 0; i < vetorSize; i++) {
            Console.WriteLine($"Enter a number to add to the {i} position:");
            vetor.Add(Convert.ToInt32(Console.ReadLine()));
        }
    }

    static void ShowNumbers() {
        if (vetor.Count == 0) {
            Console.WriteLine("Vector is Empty!");
        } else {
            Console.WriteLine("The Numbers inserted in the Vector are:");
            for (int i = 0; i < vetor.Count; i++) {
                Console.WriteLine($"Index {i} - Number: {vetor[i]}");
            }
        }
    }

    static void PopLast() {
        if (vetor.Count > 0) {
            vetor.RemoveAt(vetor.Count - 1);
            Console.WriteLine("Last Number Deleted.");
        } else {
            Console.WriteLine("Vector is Empty!");
        }
    }

    static void CalcMedian() {
        if (vetor.Count == 0) {
            Console.WriteLine("It's not possible to calculate the Median, Vector is Empty!");
            return;
        }

        var sortedVetor = vetor.OrderBy(n => n).ToList();
        double median;

        if (sortedVetor.Count % 2 == 0) {
            median = (sortedVetor[sortedVetor.Count / 2 - 1] + sortedVetor[sortedVetor.Count / 2]) / 2.0;
        } else {
            median = sortedVetor[sortedVetor.Count / 2];
        }

        Console.WriteLine($"The Vector's Median is: {median}");
    }

    static void CalcModa() {
        if (vetor.Count == 0) {
            Console.WriteLine("It's not possible to calculate the Mean, Vector is Empty!");
            return;
        }

        var moda = vetor.GroupBy(n => n)
                        .OrderByDescending(g => g.Count())
                        .First()
                        .Key;

        Console.WriteLine($"The Vector's Mean is: {moda}");
    }

}


