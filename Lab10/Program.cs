//Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
//Реализовать класс, в котором указанные значения представлены в виде свойств.
//Для свойств предусмотреть проверку корректности данных. Класс должен содержать
//конструктор для установки начальных значений, а также метод ToRadians для перевода
//угла в радианы. Создать объект на основе разработанного класса.
//Осуществить использование объекта в программе.


int gradus, min, sec;
Console.WriteLine("Введите градусы:");
try
{
    gradus = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadKey();
    return;
}
Console.WriteLine("Введите минуты:");
try
{
    min = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadKey();
    return;
}
Console.WriteLine("Введите секунды:");
try
{
    sec = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadKey();
    return;
}

Angle angle = new Angle(gradus, min, sec);

double radiansAngle = angle.ToRadians();

Console.WriteLine("Угол {0}.{1}'{2}\" равен {3:f5} радиан", angle.Gradus, angle.Minute, angle.Second, radiansAngle);
Console.ReadKey();
return;

class Angle
{
    private int gradus, min, sec;

    public int Gradus
    {
        set
        {
            if (value < -360 || value > 360) { Console.WriteLine("Угол должен быть в диапазоне от -360 до 360!"); value = 0; }
            gradus = value;
        }
        get
        {
            return gradus;
        }
    }
    public int Minute
    {
        set
        {
            if (value < 0 || value > 59) { Console.WriteLine("Минуты должны быть в диапазоне от 0 до 59!"); value = 0; }
            min = value;
        }
        get { return min; }
    }
    public int Second
    {
        set
        {
            if (value < 0 || value > 59) { Console.WriteLine("Секунды должны быть в диапазоне от 0 до 59!"); value = 0; }
            sec = value;
        }
        get
        {
            return sec;
        }
    }

    public Angle(int gradus = 0, int min = 0, int sec = 0)
    {
        this.Gradus = gradus;
        this.Minute = min;
        this.Second = sec;
    }

    public double ToRadians()
    {
        return (gradus + min / (double)60 + sec / (double)3600) / (double)180 * Math.PI;
    }
}


