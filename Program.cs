using System.Diagnostics;
using System.Drawing;

MainCommander mainCommander = new MainCommander();
Controller controller = new Controller(mainCommander);
while (true)
{
    controller.StartListner();
    Field.GetInstance().Cells = null;
    Field.GetInstance().TargetY = -1;

}