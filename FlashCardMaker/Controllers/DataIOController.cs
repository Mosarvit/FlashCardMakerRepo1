using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FlashCardMaker.Models;

namespace FlashCardMaker.Controllers
{
    public class DataIOController
    {
        public DataIOController()
        {

        }

        internal void addFilesContentToDatabase(string[] fileNames, MainView view)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (String str in fileNames)
            {
                stringBuilder.Append(str);
                stringBuilder.Append("\n");
            }
            view.Print(stringBuilder.ToString());

            var db = new flashCardMakerDbContext();
            var subtitle = new Subtitle { line = "line1" };
            db.Subtitles.Add(subtitle);
            db.SaveChanges();
        }
    }
}
