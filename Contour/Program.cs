using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Contour
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        /*    Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_UI()); */
            UserSettings settings = new UserSettings("settings.json");
            List<UserData> AllUsers = settings.AllUsers;
            UserData user = AllUsers.ElementAt(0);
            user.Name = "harry";
            
            settings.Save();
            


        }
    }
}
