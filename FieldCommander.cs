// класс для рисования поля
using System.Drawing;

internal class FieldCommander : ICommander
{
    public FieldCommander()
    {
    }

    public void Execute(int[] value)
    {
        // получение ссылки на Graphics для рисования
        Paint paint = Paint.GetInstance();
        int[,] array = new int[5,5];
        for (int i = 0, q = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                array[j, i] = value[q++];

        Field.GetInstance().Cells = array;

        
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Brush brush = null;
                switch (array[i, j])
                {
                    case 1: brush = Brushes.White; break;
                    case 2: brush = Brushes.Brown; break;
                    case 3: brush = Brushes.Blue;
                        Robot.GetInstance().X = i;
                        Robot.GetInstance().Y = j;
                        break;
                    case 4: brush = Brushes.Red;
                        Field.GetInstance().TargetX = i;
                        Field.GetInstance().TargetY = j;
                        break;
                }
                paint.DrawRectangle(brush, i, j);
            }

        // происходит рисование поля, цифры заносятся
        // в объект Field заносятся цифры (одномерный массив
        // в 25 ячеек преобразовываем в двумерный массив 5х5)
        // в объект Robot заносятся координаты
    }
}
