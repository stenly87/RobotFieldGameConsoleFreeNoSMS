// класс для ввода данных
internal class PayToWinCommand : IRobotCommand
{
    public void Execute()
    {
        Console.WriteLine("Введите данные карты с двух сторон");
        Console.ReadLine();
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                if (field.Cells[i, j] == 4)
                {
                    robot.X = i;
                    robot.Y = j;
                    break;
                }
            }
    }
}


