public class Problem3
{
//   Os fatores primos de 13195 são 5, 7, 13 e 29.

// Qual é o maior fator primo do número dado?

public static void FatoresPrimos(int num)
  {
    List <int> fatores = new List<int>();


    while(num % 2 == 0)
    {
      fatores.Add(2);
      num /= 2;

    }
    for (int i = 3; i * i <= num; i += 2)
        {
            while (num % i == 0)
            {
                fatores.Add(i);
                num /= i;
            }
        }

    if(num > 2) fatores.Add(num);


    System.Console.WriteLine($"Os fatores primos de {num} são: " +string.Join(",",  fatores) + $"\ne o maior fator primo do número dado é: {fatores.Max()}");

}}