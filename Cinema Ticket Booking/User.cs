using System;
using System.Collections.Generic;
using System.Text;

namespace UTS_460552
{
    abstract class User
    {
        public string username;
        public abstract void Welcome();
        public abstract string Exit();
    }
}
