// класс робота
internal class Robot
{
    public int X { get; set; }
    public int Y { get; set; }

    static Robot instance;
    public static Robot GetInstance()
    {
        if (instance == null)
            instance = new Robot();
        return instance;
    }
    // организовать синглтон и хранение текущих координат
}