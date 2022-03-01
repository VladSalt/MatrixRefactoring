using MatrixRefactoring.Interfaces;
using MatrixRefactoring.Models;

namespace MatrixRefactoring
{
    class MyVectorOperator : IMyMatrixElementOperation<MyVector>
    {
        public void Operation(MyVector element0, MyVector element1, MyVector result)
        {
            if (result == null)
                result = new MyVector(0, 0);

            int x1 = element0?.X ?? 0;
            int x2 = element1?.X ?? 0;
            int y1 = element0?.Y ?? 0;
            int y2 = element1?.Y ?? 0;

            result.X = x1 * x2;
            result.Y = y1 * y2;
        }
    }
}