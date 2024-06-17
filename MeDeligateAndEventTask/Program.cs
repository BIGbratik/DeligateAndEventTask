// 1) Написать метод-расширение, принимающий на вход делегат в виде функции, приводящей тип в число, и возвращающий максимальный элемент кооллекции
// 2) Написать класс, обходящий каталог файлов и выдающий собятие при нахождении каждого файла с применением public event EvendHandler и аргумент FileArgs : EventArgs
// 3) Для 2) предусмотреть возможность остановки сканирования
// 4) Выводить в консоль результаты возникновения событий и работы метода расширений


using MeDeligateAndEventTask;

//Тестирование с поиском по массиву int
var testInt = new List<int> { -10, 11, 4, -3, 100, -99 };
var myIntConverter = MyConverters.ConvertIntToDouble;
var myIntMax = testInt.GetMax(myIntConverter);
Console.WriteLine(myIntMax.ToString());

//Тестирование с поиском по массиву string
var testStr = new List<string> { "1", "-2", "3", "100,1" };
var myStrConverter = MyConverters.ConvertStringToDouble;
var myStrMax = testStr.GetMax(myStrConverter);
Console.WriteLine(myStrMax.ToString());

//Работа с событиями

var publisher = new MyEventClassPublisher();
var subscriber = new MyEventClassSubscriber();
publisher.MyEvent += subscriber.DisplayMessage;

Console.Write("Введите директорию для поиска - ");
var directory = Console.ReadLine();

Console.Write("Введите патерн поиска файла или его полное имя - ");
var pattern = Console.ReadLine();

publisher.ScanDirecory(directory, pattern);


