// класс для ввода данных
internal class MoveRobotUpCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вверх, если да, меняем ему координаты
        Robot robot = Robot.GetInstance();
        int[,] field = Field.GetInstance().Cells;

        int y = robot.Y - 1;
        if (y < 0)
            return;

        if (field[robot.X, y] == 2)
            return;

        robot.Y = y;
    }
}