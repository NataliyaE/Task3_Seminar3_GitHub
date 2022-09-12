Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

GetDashboard(num);

void GetDashboard (int num)
{
    int count = 1;
    while (count <= Math.Abs(num))
    {
        Console.WriteLine($"куб числа {count} = {count*count*count}");
        count++;
    }
}

