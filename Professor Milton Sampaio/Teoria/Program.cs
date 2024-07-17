using Teoria;

//  Parei aula 05


//Array
/*
 
int[] numeros = { 8, 4, 5, 6, 9, 7 };
numeros.Imprimir(mensagem: "Array inicial");

Console.WriteLine(numeros.Length);

Array.Resize(ref numeros, 20);
Console.WriteLine($"Novo Tamanho:{numeros.Length}");

Array.Sort(numeros);
numeros.Imprimir(mensagem: "Array ordenado");

Array.Reverse(numeros);
numeros.Imprimir("Array invertido");

*/

// Listas - diferente do array a list é dinamica

var numeros = new List<int>() { 8, 5, 1 , 3 , 4 };

Console.WriteLine(value:"Imprimir List");
numeros.ForEach((item) => Console.WriteLine(item));

var outrosNumeros = new List<int>();

outrosNumeros.Add(2);
outrosNumeros.Add(5);



