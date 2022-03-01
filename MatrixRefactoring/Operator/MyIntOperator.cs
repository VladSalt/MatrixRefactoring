using MatrixRefactoring.Interfaces;

namespace MatrixRefactoring
{
    class MyIntOperator : IMyMatrixElementOperation<int>
    {
        public void Operation(int element0, int element1, int result)
        {
            result = element0 * element1;
        }
    }
}