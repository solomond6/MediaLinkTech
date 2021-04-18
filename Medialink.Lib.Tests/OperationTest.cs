using MediaLink.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medialink.Lib.Tests
{
    public class OperationTest
    {
        public List<OperationModel> AllOperations()
        {
            List<OperationModel> li = new List<OperationModel>();
            li.Add(new OperationModel
            {
                OperationName = "Sum",
                A = 2,
                B = 3,
                Result = "5",
            });
            li.Add(new OperationModel
            {
                OperationName = "Multiply",
                A = 2,
                B = 3,
                Result = "5",
            });
            li.Add(new OperationModel
            {
                OperationName = "Divide",
                A = 2,
                B = 3,
                Result = "5",
            });
            return li;
        }
    }
}
