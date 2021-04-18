using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLink.Lib
{
    public interface ILogger
    {
        void Log(OperationModel operation);
    }
}
