using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FlashCardMaker.Models;

namespace FlashCardMaker
{
    class flashCardMakerDbContext : DbContext
    {
        public DbSet<Subtitle> Subtitles { get; set; }
    }
}
