namespace DIKUArcade.Utilities;

public static class Globals{

    private static bool isGraphicsEnabled = true;

    public static bool IsGraphicsEnabled {
        get => isGraphicsEnabled;
        set => isGraphicsEnabled = value;
    }
}