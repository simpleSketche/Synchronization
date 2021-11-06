using CSiAPIv1;
using ETABS_Worksharing;

//Global variables used alot in Global class
public static class Globals
{
    public static cPlugin ParentPluginObject;
    public static cSapModel SapModel;
    public static cPluginCallback ISapPlugin;

    public static int NumberNames;
    public static int ret = -1;
    public static string[] MyName;
    public static string Name;
    public static int NumberItems;
    public static eCNameType[] CNameType;
    public static string[] Cname;
    public static double[] SF;
    public static int ComboType;
    public static eLoadCaseType CaseType;
    public static int SubType;

}

