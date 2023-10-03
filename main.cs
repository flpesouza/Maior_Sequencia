using System;

class Exercicio2
  {
  static void Main(string[] args)
  {
    int cont = 1;
    int numero = 0;
    int aux = 0;
    int contAux = 0;
    while (numero != -1)
    {
      Console.Write("Digite um valor: ");
      numero = int.Parse(Console.ReadLine());
    if(numero > aux)
    {
      cont++;
    if (cont > contAux)
    {
      contAux = cont;
    }
    }
    else
    {
      cont = 1;
    }
    aux = numero;
    }
    Console.WriteLine("Resposta correta: "+contAux);
  }
}
