using System.Runtime.CompilerServices;

namespace Your.Project.Namespace;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
}