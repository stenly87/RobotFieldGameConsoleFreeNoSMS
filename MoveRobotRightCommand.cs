// класс для ввода данных
internal class MoveRobotRightCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вправо, если да, меняем ему координаты
        Robot robot = Robot.GetInstance();
        int[,] field = Field.GetInstance().Cells;

        int x = robot.X + 1;
        if (x >= 5)
            return;

        if (field[x, robot.Y] == 2)
            return;

        robot.X = x;
    }
}