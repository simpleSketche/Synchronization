using ETABSv1;

//Global variables used alot in Global class
public static class ETABS_Globals
{
    public static cSapModel mySapModel;
    public static cPluginCallback ISapPlugin;

    public static cOAPI myETABSObject;
    public static cHelper myHelper;

    public static int NumberofFrames;

    public static string[] MyName;
    public static string[] PropName;
    public static string[] StoryName;
    public static string[] PointName1;
    public static string[] PointName2;

    public static double[] Point1X;
    public static double[] Point1Y;
    public static double[] Point1Z;

    public static double[] Point2X;
    public static double[] Point2Y;
    public static double[] Point2Z;

    public static double[] Angle;

    public static double[] Offset1X;
    public static double[] Offset2X;

    public static double[] Offset1Y;
    public static double[] Offset2Y;

    public static double[] Offset1Z;
    public static double[] Offset2Z;

    public static int[] CardinalPoint;

    public static string csys;
}
