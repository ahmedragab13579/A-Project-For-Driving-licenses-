using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.OperationResults
{
    public class OperationResult<T>
    {
        public bool Success { get; init; }
        public Exception Exception { get; init; }

        public string Message { get; init; }
        public T Result { get; init; }
    }
}

