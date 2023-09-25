using System;

public interface IRadio
{
    bool IsOn { get; }
    string Station { get; set; }
    void TurnOn();
    void TurnOff();
    void ChangeStation(string station);
}

public interface ISeats
{
    string Position { get; set; }
    bool IsHeatingOn { get; }
    void AdjustPosition(string position);
    void HeatOn();
    void HeatOff();
}

public abstract class Avto : IRadio, ISeats
{
    public int Shvudkist { get; protected set; }
    public bool IsOn { get; private set; } = false;
    public string Station { get; set; } = "Station 1";
    public string Position { get; set; } = "Normal";
    public bool IsHeatingOn { get; private set; } = false;

    public abstract void Gazui();
    public abstract void Tormozi();
    public void TurnOn() => IsOn = true;
    public void TurnOff() => IsOn = false;
    public void ChangeStation(string station)
    {
        if (IsOn) Station = station;
    }
    public void AdjustPosition(string position) => Position = position;
    public void HeatOn() => IsHeatingOn = true;
    public void HeatOff() => IsHeatingOn = false;
}

public class BMW : Avto
{
    public override void Gazui()
    {
        Shvudkist += 23;
    }

    public override void Tormozi()
    {
        Shvudkist -= 7;
    }
}

public class Toyota : Avto
{
    public override void Gazui()
    {
        Shvudkist += 13;
    }

    public override void Tormozi()
    {
        Shvudkist -= 7;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Avto bmw = new BMW();
        Avto toyota = new Toyota();

        while (true)
        {
            Console.WriteLine("1: Газувати BMW");
            Console.WriteLine("2: Тормозити BMW");
            Console.WriteLine("3: Газувати Toyota");
            Console.WriteLine("4: Тормозити Toyota");
            Console.WriteLine("5: Газувати обидва автомобiлi");
            Console.WriteLine("6: Тормозити обидва автомобiлi");
            Console.WriteLine("7: Показати швидкiсть BMW");
            Console.WriteLine("8: Показати швидкiсть Toyota");
            Console.WriteLine("9: Показати швидкiсть обох автомобiлiв");
            Console.WriteLine("10: Переглянути стан BMW");
            Console.WriteLine("11: Переглянути стан Toyota");
            Console.WriteLine("12: Включити радіо в BMW");
            Console.WriteLine("13: Вимкнути радіо в BMW");
            Console.WriteLine("14: Змінити станцію в BMW");
            Console.WriteLine("15: Змінити положення сидіння в BMW");
            Console.WriteLine("16: Включити підігрів сидіння в BMW");
            Console.WriteLine("17: Вимкнути підігрів сидіння в BMW");
            Console.WriteLine("18: Включити радіо в Toyota");
            Console.WriteLine("19: Вимкнути радіо в Toyota");
            Console.WriteLine("20: Змінити станцію в Toyota");
            Console.WriteLine("21: Змінити положення сидіння в Toyota");
            Console.WriteLine("22: Включити підігрів сидіння в Toyota");
            Console.WriteLine("23: Вимкнути підігрів сидіння в Toyota");
            Console.WriteLine("0: Вийти");

            Console.Write("Введiть команду: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    bmw.Gazui();
                    Console.WriteLine("Ви натиснули на газ BMW!");
                    break;
                case "2":
                    bmw.Tormozi();
                    Console.WriteLine("Ви натиснули на гальма BMW!");
                    break;
                case "3":
                    toyota.Gazui();
                    Console.WriteLine("Ви натиснули на газ Toyota!");
                    break;
                case "4":
                    toyota.Tormozi();
                    Console.WriteLine("Ви натиснули на гальма Toyota!");
                    break;
                case "5":
                    bmw.Gazui();
                    toyota.Gazui();
                    Console.WriteLine("Ви натиснули на газ обох автомобiлiв!");
                    break;
                case "6":
                    bmw.Tormozi();
                    toyota.Tormozi();
                    Console.WriteLine("Ви натиснули на гальма обох автомобiлiв!");
                    break;
                case "7":
                    Console.WriteLine($"Швидкiсть BMW: {bmw.Shvudkist}");
                    break;
                case "8":
                    Console.WriteLine($"Швидкiсть Toyota: {toyota.Shvudkist}");
                    break;
                case "9":
                    Console.WriteLine($"Швидкiсть BMW: {bmw.Shvudkist}");
                    Console.WriteLine($"Швидкiсть Toyota: {toyota.Shvudkist}");
                    break;
                case "10":
                    DisplayCarStatus(bmw);
                    break;
                case "11":
                    DisplayCarStatus(toyota);
                    break;
                case "12":
                    bmw.TurnOn();
                    Console.WriteLine("Радiо в BMW увiмкнено!");
                    break;
                case "13":
                    bmw.TurnOff();
                    Console.WriteLine("Радiо в BMW вимкнено!");
                    break;
                case "14":
                    Console.WriteLine("Введiть назву станцiї:");
                    string bmwStation = Console.ReadLine();
                    bmw.ChangeStation(bmwStation);
                    Console.WriteLine($"Станцiю в BMW змiнено на {bmwStation}!");
                    break;
                case "15":
                    Console.WriteLine("Введiть положення сидiння:");
                    string bmwPosition = Console.ReadLine();
                    bmw.AdjustPosition(bmwPosition);
                    Console.WriteLine($"Положення сидiння в BMW змiнено на {bmwPosition}!");
                    break;
                case "16":
                    bmw.HeatOn();
                    Console.WriteLine("Пiдiгрiв сидiнь в BMW увiмкнено!");
                    break;
                case "17":
                    bmw.HeatOff();
                    Console.WriteLine("Пiдiгрiв сидiнь в BMW вимкнено!");
                    break;
                case "18":
                    toyota.TurnOn();
                    Console.WriteLine("Радiо в Toyota увiмкнено!");
                    break;
                case "19":
                    toyota.TurnOff();
                    Console.WriteLine("Радiо в Toyota вимкнено!");
                    break;
                case "20":
                    Console.WriteLine("Введiть назву станцiї:");
                    string toyotaStation = Console.ReadLine();
                    toyota.ChangeStation(toyotaStation);
                    Console.WriteLine($"Станцiю в Toyota змiнено на {toyotaStation}!");
                    break;
                case "21":
                    Console.WriteLine("Введiть положення сидiння:");
                    string toyotaPosition = Console.ReadLine();
                    toyota.AdjustPosition(toyotaPosition);
                    Console.WriteLine($"Положення сидiння в Toyota змiнено на {toyotaPosition}!");
                    break;
                case "22":
                    toyota.HeatOn();
                    Console.WriteLine("Пiдiгрiв сидiнь в Toyota увiмкнено!");
                    break;
                case "23":
                    toyota.HeatOff();
                    Console.WriteLine("Пiдiгрiв сидiнь в Toyota вимкнено!");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Невiрна команда!");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayCarStatus(Avto car)
    {
        Console.WriteLine($"Стан автомобіля {car.GetType().Name}:");
        Console.WriteLine($"Швидкість: {car.Shvudkist}");
        Console.WriteLine($"Радіо: {(car.IsOn ? "Увiмкнено" : "Вимкнено")}");
        if (car.IsOn) Console.WriteLine($"Станцiя: {car.Station}");
        Console.WriteLine($"Положення сидiння: {car.Position}");
        Console.WriteLine($"Пiдiгрiв сидiнь: {(car.IsHeatingOn ? "Увiмкнено" : "Вимкнено")}");
    }
}
