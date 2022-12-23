/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*Примеры*:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] Change(string[] a)
{
    int k=0;
    string[] b=new string[a.Length]; 
    for(int i=0;i<a.Length;i++)
        {
            if (a[i].Length<=3)
                {
                    b[k]=a[i];
                    k++;
                }
        }
    return b;
}

void Print(string[] b)
{
    for(int i=0;i<b.Length;i++)
        System.Console.Write($"{b[i],5}");
}
string[] a={"1234","How are you","hi","-22","gb"};
string[] b=Change(a);
Print(b);
