﻿// класс для ввода данных
using System.Drawing;

internal class DrawRobotCommand : IRobotCommand
{
    public void Execute()
    {
        Paint paint = Paint.GetInstance();
        Robot robot = Robot.GetInstance();

        paint.DrawRectangle(Brushes.Blue, 
            robot.X, robot.Y);
        // нарисовать робота по его координатам
    }
}


