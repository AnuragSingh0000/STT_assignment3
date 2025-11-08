using System;
using System.Threading;

class Program
{
    private int data;
    private static int activeObjects = 0;

    public Program()
    {
        activeObjects++;
        Console.WriteLine("Constructor Called. Active objects: " + activeObjects);
    }

    ~Program()
    {
        activeObjects--;
        Console.WriteLine("Object Destroyed. Active objects: " + activeObjects);
    }

    public void set_data(int x)
    {
        data = x;
    }

    public void show_data()
    {
        Console.WriteLine("Data = " + data);
    }

    static void Main(string[] args)
    {
        Program? p1 = new Program();
        Program? p2 = new Program();
        Program? p3 = new Program();

        p1.set_data(10);
        p2.set_data(20);
        p3.set_data(30);

        p1.show_data();
        p2.show_data();
        p3.show_data();

        Console.WriteLine("\n--- End of Program objects section ---");

        p1 = null;
        p2 = null;
        p3 = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();
        // Thread.Sleep(5000); // Give GC time

        Console.WriteLine("--- Program End ---");
    }
}
