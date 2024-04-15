using System;

namespace BT2._1.Controllers
{
    internal class YourDbContext : IDisposable
    {
        public object Songs { get; internal set; }
    }
}