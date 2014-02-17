using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01
{
    enum Status
    {
        Sent = 1,
        Received = 2,
        Replied = 4
    }

    class S02
    {
        public static void MainX()
        {
            var sentAndReceived = Status.Sent | Status.Received;
            var sentOnly = sentAndReceived & ~Status.Received;
            var isSent = (sentOnly & Status.Sent) == 0;
        }
    }
}
