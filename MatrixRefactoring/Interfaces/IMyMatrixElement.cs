using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRefactoring.Interfaces
{
    interface IMyMatrixElementOperation<T>
    {
        void Operation(T element0, T element1, T result);
    }
}
