using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.Extended
{
    public class MessageDisplay
    {
        private static MessageForm form;

        public static  void ShowMessageAsync(string msg)
        {

            try
            {
                form = new MessageForm();

                getMainMenu();

                form.Message = msg;
                form.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                form.ShowDialog(getMainMenu());

            }
            catch (Exception e)
            {

            }
            
        }

        private static MainMenuForm getMainMenu()
        {
            try
            {
               var frm = (MainMenuForm)Application.OpenForms["MainMenuForm"];
                return frm;
            }
            catch(Exception e)
            {

            }
            return null;
            
        }

    }
}
