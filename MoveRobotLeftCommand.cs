// класс для ввода данных
internal class MoveRobotLeftCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться влево, если да, меняем ему координаты
        Robot robot = Robot.GetInstance();
        int[,] field = Field.GetInstance().Cells;

        int x = robot.X - 1;
        if (x < 0)
            return;

        if (field[x, robot.Y] == 2)
            return;

        robot.X = x;
    }
}