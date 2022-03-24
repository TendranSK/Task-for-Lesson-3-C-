// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом


int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Palyndrome(num));


static bool Palyndrome (int n)
        {
            int r = 0;
            int m = n;
            while (m != 0)
            {
                r = r * 10 + m % 10;
                m = m / 10;
            }
            return (r == n);
        }
