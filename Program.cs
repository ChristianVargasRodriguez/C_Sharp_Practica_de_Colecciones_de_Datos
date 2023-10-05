
Console.WriteLine(" ");
Console.WriteLine("------------Tres matrices básicas-----------");
// Crea una matriz para contener los valores enteros 0 a 9.​
int[] array1 = {0,1,2,3,4,5,6,7,8,9};

// Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​
string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};

// Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​

bool[] matriz = new bool[10];
for (int i = 0; i < matriz.Length; i++)
{
    matriz[i] = i % 2 == 0;
}
// Imprimir la matriz
Console.WriteLine("Matriz de booleanos:");
foreach (bool valor in matriz)
{
    Console.WriteLine(valor);
}




Console.WriteLine(" ");
Console.WriteLine("------------ Lista de Sabores -----------");
// Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​

List<string> saboresHelado = new List<string>
{
    "Chocolate",
    "Vainilla",
    "Fresa",
    "Mango",
    "Coco",
    "Menta",
    "Plátano"
};

// Imprime la longitud de esta lista después de construirla. ​
Console.WriteLine("Longitud de la lista de sabores de helado: " + saboresHelado.Count);


// Imprime el tercer sabor de la lista y luego elimina ese valor. ​
if (saboresHelado.Count >= 3)
{
    string tercerSabor = saboresHelado[2];
    Console.WriteLine("Tercer sabor de la lista se eliminará: " + tercerSabor);
    saboresHelado.RemoveAt(2);
}
else
{
    Console.WriteLine("La lista no tiene al menos tres sabores.");
}

// Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​
Console.WriteLine("Nueva longitud de la lista: " + saboresHelado.Count);




Console.WriteLine(" ");
Console.WriteLine("------------ Diccionario de Información del Usuario -----------");
// Crea un diccionario que almacene tanto claves de cadena como valores de cadena. ​
Dictionary<string, string> diccionarioSabores = new Dictionary<string, string>();


// Añade pares clave/valor a este diccionario donde:​
// cada clave sea un nombre de la matriz de nombres​
// cada valor sea un sabor seleccionado al azar de tu lista de sabores.​

string[] nombres = { "Juan", "María", "Carlos", "Luisa", "Ana" };

Random rand = new Random();
foreach (string nombre in nombres)
{
    int indiceSabor = rand.Next(saboresHelado.Count);
    string saborAsignado = saboresHelado[indiceSabor];
    diccionarioSabores[nombre] = saborAsignado;
}

// Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​

foreach (var kvp in diccionarioSabores)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}



