// класс для ввода данных
internal class RobotCommander : ICommander
{
    Queue<IRobotCommand> robotCommands = new Queue<IRobotCommand>();

    public RobotCommander()
    {
        robotCommands.Enqueue(new DrawRobotCommand());
        Thread thread = new Thread(RunCommand);
        thread.Start();
    }

    public void Execute(int[] value)
    {
        for(int i  = 0; i < value.Length; i++)
        {
            robotCommands.Enqueue(new ClearRobotCommand());
            switch (value[i])
            {
                case 1: robotCommands.Enqueue(new MoveRobotUpCommand()); break;
                case 2: robotCommands.Enqueue(new MoveRobotDownCommand()); break;
                case 3: robotCommands.Enqueue(new MoveRobotLeftCommand()); break;
                case 4: robotCommands.Enqueue(new MoveRobotRightCommand()); break;
            }
            robotCommands.Enqueue(new DrawRobotCommand());
        }

        // массив value перебирается сначала до конца
        // на каждую цифру создается соответствующая команда
        // и передается в очередь выполнения команд
        // здесь какой-нибудь switch, который по номеру создается команду
        // можно чередовать команды движения и рисования
    }

    void RunCommand(object obj)
    {
        while (!Field.GetInstance().CheckRobotEndGame(Robot.GetInstance())) 
        {
            Thread.Sleep(200);
            if (robotCommands.Count > 0)
            {
                var command = robotCommands.Dequeue();
                command.Execute();
            }
        }
    }
}

