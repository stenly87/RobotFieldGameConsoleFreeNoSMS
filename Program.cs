using System.Diagnostics;
using System.Drawing;

for(int i = 48;i<58;i++)
    Console.WriteLine((char)i);


MainCommander mainCommander = new MainCommander();
Controller controller = new Controller(mainCommander);
while (true)
{
    controller.StartListner();
    Field.GetInstance().Cells = null;
    Field.GetInstance().TargetY = -1;

}