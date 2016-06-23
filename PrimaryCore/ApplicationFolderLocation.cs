using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryCore
{
    public class ApplicationFolderLocation
    {
        private static string location;
        private static bool located;

        public static string Location()
        {

            userFolder();
            runningLocation();

            return location;
        }

        private static void runningLocation()
        {
            if(!located)
            {
                try
                {
                    location = System.Windows.Forms.Application.StartupPath;

                    located = true;

                }
                catch (Exception e)
                {

                }

            }


        }


        private static void userFolder()
        {
            if (!located)
            {
                try
                {

                    location = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                    location = Path.Combine(location, "Bug");

                    if (!Directory.Exists(location))
                        Directory.CreateDirectory(location);

                    located = true;
                }
                catch (Exception e)
                {
                 
                }
            }
            


        }

    }
}
