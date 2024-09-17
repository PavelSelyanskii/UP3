//Задание 19: Поиск в строках
//Написать программу, которая ищет подстроку в строке и выводит ее индекс или
//сообщение, что подстрока не найдена.

//List<string> stroka = new List<string>();

//stroka.Add("Эта строка написана для теста");
//Console.WriteLine(stroka[0]);

//string postroka = Console.ReadLine();
//postroka = postroka.ToLower();

//if (stroka[0].IndexOf(postroka) == -1)
//{
//    Console.WriteLine($"Начальный индекс: 0 \nКонечный индекс: {stroka[0].IndexOf(postroka) + postroka.Length}");
//}
//else
//{
//    Console.WriteLine($"Начальный индекс: {stroka[0].IndexOf(postroka)} \nКонечный индекс: {stroka[0].IndexOf(postroka) + postroka.Length-1}");
//}

//Задание 20: Удаление пробелов
//Создать программу, которая удаляет все лишние пробелы из строки, оставляя
//по одному между словами.

//string stroka = "   Эта строка   написана   для   теста";
//string strokaSum = "";
//string[] arr = stroka.Split(' ');

//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = arr[i].Trim();
//    if (arr[i].Length!=0)
//    {
//       strokaSum += arr[i];
//        strokaSum += " ";
//    }
//}
//Console.WriteLine(strokaSum);


//Задание 21: Калькулятор даты
//Написать программу, которая вычисляет количество дней между двумя датами,
//введенными пользователем

//int day = int.Parse(Console.ReadLine());
//int month = int.Parse(Console.ReadLine());  
//int year = int.Parse(Console.ReadLine());

//DateTime time1 = new DateTime(year,month,day);
//int day2 = int.Parse(Console.ReadLine());
//int month2 = int.Parse(Console.ReadLine());
//int year2 = int.Parse(Console.ReadLine());

//DateTime time2 = new DateTime(year2,month2,day2);

//Console.WriteLine(time1-time2);


//Задание 22: Валидация данных
//Разработать программу, которая проверяет корректность ввода данных
//(например, номер телефона, e-mail и т.д.).
//Console.Write("Введите номер телефона: ");
//string number = Console.ReadLine();
//Console.Write("Введите почту: ");
//string email = Console.ReadLine();
//if (number[0] == '+' && number.Length == 12)
//{
//    if (number[1] == '7' || number[1] == '8')
//    {
//        Console.WriteLine("Номер ведён верно");
//    }
//}
//else
//{
//    Console.WriteLine("Номер ведён не верно");
//}

//if (email.Split('@').Length > 2)
//{
//    Console.WriteLine("соси");
//    Environment.Exit(0);
//}

//if (email.Contains("@")&& email.Contains("gmail.com")|| email.Contains("@") && email.Contains("mail.ru"))
//{
//    Console.WriteLine("Почта ведена верно");
//}
//else
//{
//    Console.WriteLine("Почта ведена не верно");
//}

//23: Генерация паролей
//Создать приложение, которое генерирует случайный пароль заданной длины, с учетом использования 
//букв, цифр и специальных символов.
//char[] array = { '!', '@', '#', '$', '%', '^', '&', '*' };
//char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
//Random rand = new Random();
//Console.Write("Введите длинну пароля: ");
//int lenght = int.Parse(Console.ReadLine());
//string password = "";
//for (int i = 0; i < lenght; i++)
//{
//    int number = rand.Next(1,4);
//    if(number==1)
//    {
//        password += rand.Next(1, 10);
//    }
//    if (number == 2)
//    {
//        password += alpha[rand.Next(0,alpha.Length)];
//    }
//    if (number == 3)
//    {
//        password += array[rand.Next(0,array.Length)];
//    }
//}
//Console.WriteLine(password);

//Задание 24: Чек на покупки
//Написать программу, которая принимает список покупок и их стоимость, а затем
//выводит чек с общей суммой и НДС
//double sum = 0;
//string[] arr = new string[0];
//while (true)
//{
//    Console.WriteLine("В вашей корзине: ");
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write($"|{arr[i]}|");
//    }
//    Console.WriteLine();
//    Console.Write("Введите товар: ");
//    string tovar = Console.ReadLine();
//    Array.Resize(ref arr, arr.Length + 1);
//    arr[arr.Length - 1] = tovar;
//    Console.Write("Введите цену товара: ");
//    double sell = int.Parse(Console.ReadLine());
//    arr[arr.Length - 1] += " "+$"{sell.ToString()}руб.";
//    sum += sell;
//    Console.Clear();
//    while (true)
//    {
//        Console.WriteLine("Продукты закончились?\n1.Да\n2.Нет");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.Clear ();
//            Console.WriteLine("Сумма для оплаты: " + (sum + ((sum / 100) * 20)));
//            Environment.Exit(0);
//        }
//        else
//        {
//            Console.Clear();
//            break;
//        }
//    }
//}

//Задание 25: Анализ текста
//Разработать приложение, которое анализирует текст, введенный
//пользователем, и выводит статистику по частоте использования каждого слова
//int count = 0;
//char a = ' ';
//Console.Write("Введите текст: ");
//string patch = Console.ReadLine();
//string str1 = "";
//patch.Replace('.', a);
//string[] arr = patch.Split(' ');
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i]==str1)
//    {
//        count++;
//    }
//    else
//    {
//        Console.WriteLine("Таких слов нету");
//    }

//}
//Console.ReadLine();

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите текст:");
//        string inputText = Console.ReadLine();

//        // Разделение текста на слова
//        string[] words = inputText.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

//        // Приведение слов к нижнему регистру
//        words = words.Select(w => w.ToLower()).ToArray();

//        // Подсчет количества упоминаний каждого слова
//        Dictionary<string, int> wordCount = new Dictionary<string, int>();
//        foreach (string word in words)
//        {
//            if (wordCount.ContainsKey(word))
//            {
//                wordCount[word]++;
//            }
//            else
//            {
//                wordCount[word] = 1;
//            }
//        }

//        // Сортировка слов по количеству упоминаний
//        var sortedWords = wordCount.OrderByDescending(w => w.Value);

//        // Вывод статистики по словам
//        Console.WriteLine("Статистика по словам:");
//        foreach (var word in sortedWords)
//        {
//            Console.WriteLine("{0}: {1}", word.Key, word.Value);
//        }

//        Console.ReadKey();
//    }
//}

