// класс поля
using System.Text;

internal class Field
{
    // тут организовать синглтон и хранение ячеек в свойстве Cells

    static Field instance;
    public static Field GetInstance()
    {
        if (instance == null)
            instance = new Field();
        return instance;
    }

    public int[,] Cells { get; set; }

    public int TargetX { get; set; }
    public int TargetY { get; set; }

    internal bool CheckRobotEndGame(Robot robot)
    {
        return robot.X == TargetX && robot.Y == TargetY;
        // сравнение координат робота с координатами
        // финишной точки
    }

    internal string Generate()
    {
        StringBuilder result = new StringBuilder();
        result.Append(new string('1', 25));
        Random random = new Random();
        for (int i = 0; i < 10; i++)
            result[random.Next(0, 25)] = '2';

        int target = 0, robot = random.Next(0, 25);
        result[robot] = '3';
        do 
        {
            target = random.Next(0, 25);
        }
        while (target == robot);
            result[target] = '4';
        return result.ToString();
    }
}

