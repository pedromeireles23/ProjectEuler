public class Problem2
{
//   Cada novo termo na sequência de Fibonacci é gerado pela soma dos dois termos anteriores. Começando com 1 e 2, os primeiros 10 termos serão:

// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
// Considerando os termos na sequência de Fibonacci cujos valores não excedem n, encontre a soma dos termos de valor par.

public static void SequenciaFibonacci(int n)
  {
    if(n <= 1 ) System.Console.WriteLine(n);
    // List <int> valores= new List<int>();
    int[] valores = new int[n];
    valores[0] = 0;
    if(n > 1)
    {
      valores[1] = 1;
    }
    
    

    for (int i = 2; i < n; i++)
    {
      valores[i] = valores [i-1] + valores [i-2];
      System.Console.WriteLine(valores[i]);
      
    }
    int resultado = 0;
    for (int i = 0; i <valores.Length; i++)
    {
      if (valores[i] % 2 == 0)
      {
        resultado += valores[i];
      }
    }
    System.Console.WriteLine($"O resultado da soma dos termos pares: " + resultado);
  
  }
}