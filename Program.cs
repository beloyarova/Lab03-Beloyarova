using System.Diagnostics;
using System.IO.Compression;

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

Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
Console.WriteLine($"После этого weekNumber = {weekNumber}");

Console.WriteLine();
Console.WriteLine("Практическая ловушка");

int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");

Console.WriteLine();
Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");

Console.WriteLine();
Console.WriteLine("Логические операторы");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;

bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;
Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
Console.WriteLine($"Нет долгов: {isDebtFree}");

Console.WriteLine();
Console.WriteLine("Короткое замыкание");

bool CheckAndPrint(string label, bool value)
{
    Console.WriteLine($"  Вычисляется: {label}");
    return value;
}

Console.WriteLine("Проверяем && (первый операнд false);");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

Console.WriteLine();
Console.WriteLine("Проверяем || (первый операнд true):");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Результат: {resultOr}");

Console.WriteLine();
Console.WriteLine("Приоритет операций");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4    = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4  = {resultWithParens}");
bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5>3 && 2<4 || false    = {logicResult}");
Console.WriteLine($"(5>3 && 2<4) || false  = {logicResultParens}");

Console.WriteLine();
Console.WriteLine("Приемная комиссия");

Console.Write("Введите средний балл аттестата: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Введите баллы за экзамен (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.Write("Есть льгота? (1 - да, 0 - нет): ");
int benefitInput = int.Parse(Console.ReadLine());
bool hasBenefit = (benefitInput == 1);

bool hasGoodCertificate = averageGrade >= 4.0;
bool hasGoodExam = examScore >= 60;
bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

double totalScore = averageGrade * 10;
totalScore += examScore;

Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
Console.WriteLine($"Льгота: {hasBenefit}");
Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
Console.WriteLine($"Итоговый балл: {totalScore}");

Console.WriteLine();
Console.WriteLine("Чётное или нечётное — без if");
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

bool isEven = number % 2 == 0;

Console.WriteLine($"Число четное: {isEven}");

Console.WriteLine();
Console.WriteLine("Инкремент в выражении");

int x = 7;

int result1 = x++; // используется старое значение 7
Console.WriteLine($"result1 = {result1}, x = {x}"); // x увеличивается до 8 

int result2 = ++x; // x увеличивается до 9
Console.WriteLine($"result2 = {result2}, x = {x}"); // используется новое значение 9

int result3 = x++ + 10; // используется 9, затем x увеличивается до 10
Console.WriteLine($"result3 = {result3}, x = {x}");

Console.WriteLine();
Console.WriteLine("Калькулятор скидки с несколькими условиями");

Console.WriteLine();
Console.Write("Введите сумму покупки: ");
double summa = double.Parse(Console.ReadLine());

Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
int card = int.Parse(Console.ReadLine());
bool hasCard = (card == 1);

Console.Write("Введите количество товаров: ");
int quantity = int.Parse(Console.ReadLine());

bool summaBuy = summa >= 3000;
bool product = quantity >= 3;
bool eligibleForDiscount = (summaBuy && product) || hasCard;

Console.WriteLine();
Console.WriteLine($"Сумма >= 3000: {summaBuy}");
Console.WriteLine($"Товаров >= 3: {product}");
Console.WriteLine($"Есть карта: {hasCard}");
Console.WriteLine($"Скидка: {eligibleForDiscount}");