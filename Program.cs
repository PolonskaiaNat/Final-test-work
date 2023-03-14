// написать программу, которая из имеющихся массива строк формирует массив из строк, длина которого меньше, либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string [] array = new string [3];
int max = 3;
string [] result = new string [3];
int j = 0;

Console.WriteLine("Введите первый элемент");
array [0] = Console.ReadLine();
Console.WriteLine("Введите первый элемент");
array [1] = Console.ReadLine();
Console.WriteLine("Введите первый элемент");
array [2] = Console.ReadLine();

for (int i=0; i < max; i++)
    {
        string a=array[i];
       if(a.Length<=max)
       {
        result[j]= array[i];
        j++;
       }
    }
Console.WriteLine($"Элементы больше не больше 3-х");
for (int i=0; i< result.Length; i++)
    {
                Console.WriteLine($"{result[i]} ");
    } 

