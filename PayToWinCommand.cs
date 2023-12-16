// класс для ввода данных
internal class PayToWinCommand : IRobotCommand
{
    public void Execute()
    {
        Console.WriteLine("Введите данные карты с двух сторон");
        Console.ReadLine();
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();

        robot.X = field.TargetX;
        robot.Y = field.TargetY;
    }
}


