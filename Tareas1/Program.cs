//inicio del ejecicios
//primer ejercicio 
/*
int numero = 1;
do
{
    Console.WriteLine(numero);
    numero++;
}while (numero <= 5);
*/
//ejercicio 2
/*
 int numero = 1;
do
{
    Console.WriteLine(numero);
    numero++;
}while (numero <= 10);
*/
//3 ejercicio
/*
int numero = 10;
do
{
    Console.WriteLine(numero);
    numero--;
} while (numero >= 1);
*/
//4 ejercicio 
/*
int numero = 2;
do
{
    Console.WriteLine(numero);
    numero+= 2;
} while (numero <= 20);
*/
//ejercicio5
/*
int numero = 1;
do
{
    Console.WriteLine(numero);
    numero += 2;
} while (numero <= 15);
*/
//ejercicio6
/*
int numero = 1;
do
{
    Console.WriteLine($"{numero} el cuadrado es:{numero * numero}");
    numero++;
   
} while (numero <= 10);
*/
//ejercicio7
/*
int numero = 1;
int sumad =0;
do
{
    Console.WriteLine(numero);
    sumad += numero;
    numero++;
    
} while (numero <= 10);
Console.WriteLine($"la suma es {sumad}");
*/
//ejercicio8
/*
int numero = 1;
do
{
    Console.WriteLine($"5x{numero}={numero*5}");
    numero++;
} while (numero <= 10);
*/
//ejercio9
/*
int numero = 1;
do
{ 
    if (numero % 2== 0)
    Console.WriteLine($"el numero es par {numero}");
    else
        Console.WriteLine($"el numero es impar {numero }");
    numero++;
} while (numero <= 20);
*/
//ejercicio10
/*
int numero = 1;
do
{
    Console.WriteLine(numero);
    numero+=1;
} while (numero <= 50);
Console.WriteLine($"total de numero {numero-1}");
*/
//ejercicio11
/*
int suma = 0;
int numero = 0;
int i = 1;
do
{
    i++;
    Console.WriteLine("Ingrese numero");
    numero = int.Parse(Console.ReadLine());
    suma += numero;
  
}while (i <=5);
Console.WriteLine($"suma total es:{suma}");
*/
//ejercicio12
/*
int suma = 0;
int numero = 2;
int i = 1;
do
{
    Console.WriteLine("Ingrese numero");
    numero = int.Parse(Console.ReadLine());
    suma += numero;

} while (numero != 0);
Console.WriteLine($"suma total es:{suma}");
*/
//ejercicio13
/*
int suma = 0;
int numero = 2;
int i = 0;
do
{
    Console.WriteLine("Ingrese numero");
    numero = int.Parse(Console.ReadLine());
    suma += numero;
    i++;

} while (numero != 0);
Console.WriteLine($"suma total es:{suma}, los numeros ingresados fueron {i}");
*/
//ejercicio14
/*
int mayor = 0;
int numero = 0;
do
{
    Console.WriteLine("Ingrese numero");
    numero = int.Parse(Console.ReadLine());
    if (numero>mayor)
    {
        mayor = numero;
    }
    
} while (numero != 0);
Console.WriteLine($"el numero mayor es:{mayor}");
*/
//ejercicio15
/*
int mayor = 0;
int numero = 0;
do
{
    Console.WriteLine("Ingrese numero postivo");
    numero = int.Parse(Console.ReadLine());


} while (numero <= 0);
Console.WriteLine("Ingreso un numero positivo xd");
*/
//ejercicio16
/*
string clave = "";
do
{
    Console.WriteLine("Ingrese la contraseña");
    clave =(Console.ReadLine());


} while (clave != "123");
Console.WriteLine("contraseña correcta");
*/
//ejercicio17

int numero = 0;
int contador = 0;
do
{
    Console.WriteLine("Ingrese numero");
    numero = int.Parse(Console.ReadLine());
    if (numero  %2 == 0 && numero != 0)
    {
        contador++; 
    }
}while (numero != 0);
Console.WriteLine($"la cantidad de numeros pares fueron:{contador}");