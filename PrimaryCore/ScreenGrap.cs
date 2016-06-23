using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaryCore
{
    public class ScreenGrap
    {
        private static string pathSaveLocation;
        private static int uniqueNumberId;
        private static Screen screenInFocus;
        private static string fileName = "grap";


        public static string GetPrimary(string name)
        {
            fileName = name;

            screenInFocus = Screen.PrimaryScreen;

            getTempLocation();

            getUniqueName(name);

            getScreenGrap();

            return pathSaveLocation;

        }

        public static void CleanUp()
        {
            getTempLocation();
            if(Directory.Exists(pathSaveLocation))
            {
                Directory.Delete(pathSaveLocation, true);
            }
        }

        private static void getTempLocation()
        {
          
            try
            {
                string location = PrimaryCore.ApplicationFolderLocation.Location();
                pathSaveLocation = Path.Combine(location, "ScreenGrab");

                if (!Directory.Exists(pathSaveLocation))
                    Directory.CreateDirectory(pathSaveLocation);

            }
            catch (Exception e)
            {
                LoggingExceptions.Log("Getting temp folder location for Screen grab", e);
            }
        }

        private static void getScreenGrap()
        {
            try
            {
                Bitmap printscreen = new Bitmap(screenInFocus.Bounds.Width, screenInFocus.Bounds.Height);
                Graphics graphics = Graphics.FromImage(printscreen as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
                printscreen.Save(pathSaveLocation, ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                LoggingExceptions.Log("Grabbing screen shot", e);
            }
       
        }
        
        private static void getUniqueName(string name)
        {          
           

            try
            {
                string path = Path.Combine(pathSaveLocation, String.Format("{0}.jpg", name));
                if (File.Exists(path))
                {
                    uniqueNumberId++;
                    getUniqueName(String.Format("{0}-{1}", fileName, uniqueNumberId.ToString()));
                }
                else
                    pathSaveLocation = path;

            }
            catch(Exception e)
            {
                LoggingExceptions.Log("Creating Unique Name for Screen grab", e);
            }
        }
    }
}
