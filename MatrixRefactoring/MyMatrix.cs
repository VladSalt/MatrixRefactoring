using MatrixRefactoring.Interfaces;

namespace MatrixRefactoring
{
    class MyMatrix<T>
    {
        protected int RowCount { get { return InnerMatrix.GetLength(0); } }
        public int ColCount { get { return InnerMatrix.GetLength(1); } }

        private T[,] InnerMatrix;

        private IMyMatrixElementOperation<T> myMatrixElementOperation;
        public MyMatrix(IMyMatrixElementOperation<T> myMatrixElementOperation, T[,] matrix)
        {
            this.myMatrixElementOperation = myMatrixElementOperation;
            this.InnerMatrix = matrix;
        }

        public MyMatrix(int row, int col, IMyMatrixElementOperation<T> myMatrixElementOperation)
        {
            InnerMatrix = new T[row, col];
            this.myMatrixElementOperation = myMatrixElementOperation;
        }

        public MyMatrix<T> Multiply(MyMatrix<T> matrix)
        {
            var result = new MyMatrix<T>(RowCount, ColCount, myMatrixElementOperation);

            for (int i = 0; i < RowCount; i++)
                for (int j = 0; j < matrix.ColCount; j++)
                    for (int k = 0; k < matrix.RowCount; k++)
                    {
                        var value = result.InnerMatrix[i, j];
                        myMatrixElementOperation.Operation(InnerMatrix[i, k], matrix.InnerMatrix[k, j], value);
                        result.InnerMatrix[i, j] = value;
                    }
            return result;
        }
    }
}