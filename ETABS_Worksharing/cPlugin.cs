// This is the entry point of any ETABS/SAP2000 Plugin
// Lower bound of all arrays is 0 for ETABS
// Avoid delcaring static array
using CSiAPIv1;                  //to Access ETABS/SAP2000 API
using System;
using static Globals;

namespace ETABS_Worksharing
{
    // cPlugin has to be implemented in ETABS Plugins, it has to contain two functions Main() and Info()
    public class cPlugin
    {

        //Entry point of plugin - has to exist with this exact signature
        // must call Finish() when plugin is closed!
        public void Main(ref cSapModel _SapModel, ref cPluginCallback _ISapPlugin)
        {
            ParentPluginObject = this;
            SapModel = _SapModel;
            ISapPlugin = _ISapPlugin;

            try
            {
                MainView mv = new MainView();
                mv.Show();
            }
            catch (Exception ex)
            {
                try
                {
                    ISapPlugin.Finish(1);
                    Console.WriteLine(ex);
                }
                catch (Exception ex1)
                {
                    Console.WriteLine(ex1);
                    throw;
                }
            }
        }

        // return value should be 0 if successful
        public int Info(ref string txt)
        {
            try
            {
                txt = "Plugin is written...";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return 0;
        }

        //Deconstructor to clean up
        ~cPlugin()
        {
            Console.WriteLine(GC.GetGeneration(0));
        }
    }
}
