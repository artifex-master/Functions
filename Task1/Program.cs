

while (true)
{
    // Введите число
    Console.Write("Введите число: ");
    // Присваиваем значение в переменную convertedVal
    string convertedVal = Console.ReadLine();
    if (convertedVal == "q")
    {
        break;
    }

    // convertedVal - число?
    int num;
    // Проверяем является ли ввод целочисленным числом
    if (int.TryParse(convertedVal, out num))
    {
        int sum = 0;
        while(num > 0) {
            sum += num % 10;
            num /= 10;
        }

        if(sum % 2 == 0){
            break;
        }
    }
    else
    {
        Console.WriteLine("Введенное значение не является числом. Введите другое значение:");
    }
}



