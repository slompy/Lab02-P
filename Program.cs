Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;


// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);
// Console.WriteLine($"255 + 1 для byte = {overflowed}");

// Console.WriteLine();
// Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter;

// Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// Console.WriteLine($"Код символа: '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\tпосле таба");
// Console.WriteLine($"Перенос:\nпосле переноса");

// System.Console.WriteLine();
// System.Console.WriteLine("decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

// Console.WriteLine();
// Console.WriteLine("var");

// var studentAge = 20;
// studentAge = "двадцать";
// var gpa = 4.75;
// var fullName = "Смирнова А.С.";

// Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

// Console.WriteLine();
// Console.WriteLine("Ввод текста");

// Console.Write("Введите ваше имя: ");
// string enteredName = Console.ReadLine();

// Console.Write("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();

// Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");

// Console.WriteLine("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse:       {birthYearParse}");
// Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: TryParse");

// Console.WriteLine("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

// Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// Console.WriteLine($"Значение переменной booksCount: {booksCount}");





Console.Write($"Введите ваше имя и фамилию: ");
string enteredName = Console.ReadLine();
Console.Write($"Введите вашу группу: ");
string enteredGroupName = Console.ReadLine();
Console.Write($"Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();
int enteredBirthYear = Convert.ToInt32(birthYearInput);
Console.Write($"Введите ваш средний балл: ");
string AverageScore = Console.ReadLine();
double enteredAverageScore = Convert.ToDouble(AverageScore);
Console.Write($"Введите вашу любимую букву: ");
string LoveSymbol = Console.ReadLine();
char enteredSymbol = Convert.ToChar(LoveSymbol);

Console.WriteLine($"имя: {enteredName}, группа: {enteredGroupName}, год: {enteredBirthYear}, балл: {enteredAverageScore}, буква: {enteredSymbol} ");

const double scholarshipthreshold = 4.0;
bool isScholarshipEligible = enteredAverageScore >= scholarshipthreshold;

Console.WriteLine("===Визитная карточка студента===");
Console.WriteLine($"ФИО:                            {enteredName}");
Console.WriteLine($"Группа:                         {enteredGroupName}");
Console.WriteLine($"Год рождения:                   {enteredBirthYear}, в 2030 году вам будет: {2030 - enteredBirthYear} лет");
Console.WriteLine($"Средний балл:                   {enteredAverageScore}");
Console.WriteLine($"Стипендия положена (>= 4.0):    {isScholarshipEligible}");
Console.WriteLine($"Любимая буква:                  {enteredSymbol}");
