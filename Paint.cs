using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;

internal class Paint
{
    static Graphics graphics; 

    
    private Paint() {
        graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);
    }

    public Graphics Graphics { get => graphics; }
    int shift = 400;
    public void DrawRectangle(Brush brush, int x, int y)
    {
        Graphics.FillRectangle(brush,
                       shift + x * 100, y * 100,
                       100, 100);
    }

    static Paint instance;
    public static Paint GetInstance()
    { 
        if (instance == null)
            instance = new Paint();
        return instance;
    }
}