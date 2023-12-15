// класс для ввода данных
internal class Controller
{
    private MainCommander mainCommander;

    public Controller(MainCommander mainCommander)
    {
        this.mainCommander = mainCommander;
    }

    // цикл по запросу команды
    internal void StartListner()
    {
        mainCommander.SetInterpretator(new FieldCommander());
        Console.WriteLine("Введите 25 символов для рисования поля");
        GetIntArrayFromUser(Field.GetInstance().Generate());
        mainCommander.SetInterpretator(new RobotCommander());
        while (!Field.GetInstance().CheckRobotEndGame(Robot.GetInstance()))
        {
            Console.WriteLine("Введите последовательность шагов для робота");
            GetIntArrayFromUser();
        }
        // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute
        // смена интерпретатора у mainCommander на RobotCommander
        // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
    }

    private void GetIntArrayFromUser(string defaultString = null)
    {
        Console.SetCursorPosition(0, 0);
        string askString = defaultString ?? Console.ReadLine();
        int[] array = askString.Select(s => (int)s - 48).ToArray();
        mainCommander.Execute(array);
    }
}
