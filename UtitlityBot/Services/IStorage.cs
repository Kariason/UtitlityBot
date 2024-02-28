using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtitlityBot.Models;

namespace UtitlityBot.Services
{
    public interface IStorage
    {
        Session GetSession(long chatId);
    }
}
