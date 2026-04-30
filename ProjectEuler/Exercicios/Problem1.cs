public class Problem1
{
//Se listarmos todos os números naturais menores que 10 que são múltiplos de 3 ou 5, obtemos 3, 5, 6 e 9. A soma desses múltiplos é 23.
//Encontre a soma de todos os múltiplos de 3 ou 5 menores que o valor do parâmetro fornecido.


public static int MultiploDe3Ou5(int num)
  {
    List <int> numeros = new List<int>();

    for(int i = 0; i < num; i++)
    {
      if(i % 3 == 0 || i % 5 == 0 )
      {
        numeros.Add(i);
      }
    }
    int resultado = numeros.Sum();
    return resultado;
  }


}