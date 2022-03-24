/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125  || не понял, строго до числа N или нет, поэтому сделал включительно ||
*/
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("Кубы чисел от 1 до {0}\n\n", value);
for(int i = 1; i <= value ; i++){
    Console.Write(Math.Pow(i,3) + " | ");
}
