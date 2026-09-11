Console.WriteLine("Банковский счёТ");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500; // пополнение
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200; // покупка
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05; // начисление 5% процентов
Console.WriteLine($"После начисления 5%: {balance}");

balance /= 2;
Console.WriteLine($"После деления пополам: {balance}");
