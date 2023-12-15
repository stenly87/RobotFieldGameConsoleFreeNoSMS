// класс для ввода данных
using System.Drawing;

internal class ClearRobotCommand : IRobotCommand
{
    public void Execute()
    {
        Paint paint = Paint.GetInstance();
        Robot robot = Robot.GetInstance();

        paint.DrawRectangle(Brushes.White,
            robot.X, robot.Y);
        // затереть робота по его координатам
    }
}

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


