// класс для ввода данных
internal class MoveRobotDownCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вниз, если да, меняем ему координаты
        Robot robot = Robot.GetInstance();
        int[,] field = Field.GetInstance().Cells;

        int y = robot.Y + 1;
        if (y >= 5) 
            return;

        if (field[robot.X, y] == 2)
            return;

        robot.Y = y;
    }
}