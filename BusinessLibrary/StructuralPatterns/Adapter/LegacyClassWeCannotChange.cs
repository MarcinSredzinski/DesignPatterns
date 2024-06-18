namespace BusinessLibrary.StructuralPatterns.Adapter;

/// <summary>
/// This is a legacy class that contains a very useful methods, but we are not able to change it due to some reasons.
/// We still want to use it in our current codebase.
/// </summary>
public class LegacyClassWeCannotChange(string someObscureDependency, int someOtherDependency)
{
    public int DoSomething(int x, int y)
    {
        return x + y;
    }

    public int DoSomethingElse(int x, int y)
    {
        return x - y;
    }
}