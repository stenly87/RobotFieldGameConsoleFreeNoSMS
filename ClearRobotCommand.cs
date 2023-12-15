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


