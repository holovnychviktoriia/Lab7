namespace Lab7;

public static class Task1
{
    public static void Run()
    {
        Console.WriteLine("Завдання 1");

        var actions = new List<Action>();
        for (int i = 1; i <= 5; i++)
        {
            actions.Add(() => Console.WriteLine(i));
        }
        foreach (var action in actions) action();

        var fixedActions = new List<Action>();
        for (int i = 1; i <= 5; i++)
        {
            int copy = i;
            fixedActions.Add(() => Console.WriteLine(copy));
        }
        foreach (var action in fixedActions) action();
    }
}