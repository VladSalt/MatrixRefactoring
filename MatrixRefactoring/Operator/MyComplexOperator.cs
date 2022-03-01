using MatrixRefactoring.Interfaces;
using MatrixRefactoring.Models;

namespace MatrixRefactoring
{
    class MyComplexOperator : IMyMatrixElementOperation<MyComplex>
    {
        public void Operation(MyComplex element0, MyComplex element1, MyComplex result)
        {
            if (result == null)
                result = new MyComplex(0, 0);

            double r1 = element0?.re ?? 0;
            double r2 = element1?.re ?? 0;
            double i1 = element0?.im ?? 0;
            double i2 = element1?.im ?? 0;

            result.re = result?.re ?? 0 + r1 * r2;
            result.im = result?.im ?? 0 + i1 * i2;
        }
    }
}