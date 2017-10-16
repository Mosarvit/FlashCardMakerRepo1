using FlashCardMaker.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardMaker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainView mainForm = new MainView();
            DataIOController dataIOController = new DataIOController();
            mainForm.setDataIOController(dataIOController);
            Application.Run(mainForm);
        }
    }
}
