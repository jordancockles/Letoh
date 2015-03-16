using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetohHMSTests
{
    class LoadFileUnsuccessful : ILoadFile
    {
        public bool success()
        {
            return false;
        }
    }
}
