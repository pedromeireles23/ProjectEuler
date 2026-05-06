class Problem4
{
//   Um número palíndromo é lido da mesma forma de trás para frente. O maior palíndromo formado pelo produto de dois números de dois dígitos é 9009 = 91 × 99.

// Encontre o maior palíndromo formado pelo produto de dois números de n dígitos.

public static int MaiorPalindromo(int n)
  {
    int max = (int)Math.Pow(10,n ) -1;
    int min = (int)Math.Pow(10,n-1);

    int maior = 0;

    for(int i = max; i >= min; i--)
    {
      for (int j = i; i >= min; j--)
      {
        int produto = i *j;
        if(produto <= maior )break;
        if (EhPalindromo(produto))
        {
          maior = produto;
        }
      }
      
    }
    return maior;

    // char[] charArray = mult.ToString().ToCharArray();
    // int tamanhoArray = charArray.Length;
    // List <int> listaPalindromo = new List<int>();

    // if (charArray[0] != charArray[tamanhoArray - 1] && charArray[1] != charArray[tamanhoArray - 2])
    // {
    //   System.Console.WriteLine("O número é um palindromo");
    // }

  //   while(charArray[0] != charArray[tamanhoArray - 1] && charArray[1] != charArray[tamanhoArray - 2])
  //   {
      
  //   }

  //   System.Console.WriteLine(string.Join(", ", charArray));
  // }
}
  static bool EhPalindromo(int numero)
  {
    string s = numero.ToString();
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return s == new string(arr);
  }

}