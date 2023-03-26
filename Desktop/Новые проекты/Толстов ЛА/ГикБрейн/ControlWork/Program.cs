// Вывод массива строк с элементами до 3-х символов:

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] textArray = new string [n];
void array(string [] textArray)
{
  for (int i = 0; i<textArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1}-й элемент массива");
     textArray[i] = Console.ReadLine();
  }
}
string [] mas(string [] textArray)
{
  int count = 0;
  for (int i = 0; i<textArray.Length; i++)
  {
    if(textArray[i].Length <=3)
    count++;
  }
  string [] rezult = new string [count];
  int k = 0;
  for (int i = 0; i<textArray.Length; i++)
  {
    if(textArray[i].Length <=3)
    {
        rezult[k] = textArray[i];
        k++;
    }
  }
  return rezult;
}
void print(string [] textArray)
{
    Console.Write("[");
    for (int i = 0; i<textArray.Length; i++)
    {
    Console.Write($"{textArray[i]}, ");
    }
    Console.Write("]");
}
array(textArray);
print(mas(textArray));
