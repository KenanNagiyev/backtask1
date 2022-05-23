using backtask1.DAL;
using System;

namespace backtask1.Controllers
{
    internal class AppdbContext
    {
        public object Sliders { get; internal set; }

        public static implicit operator AppdbContext(AppDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}