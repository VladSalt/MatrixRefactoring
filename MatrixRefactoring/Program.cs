using MatrixRefactoring.Models;
using System;

namespace MatrixRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeInt = new MyIntOperator();
            var myIntMatrix23 = new MyMatrix<int>(2, 3, typeInt);
            var myIntMatrix32 = new MyMatrix<int>(3, 2, typeInt);
            var myIntMultiplyMatrix = myIntMatrix23.Multiply(myIntMatrix32);

            var typeVector = new MyVectorOperator();
            var myVectorMatrix23 = new MyMatrix<MyVector>(2, 3, typeVector);
            var myVectorMatrix32 = new MyMatrix<MyVector>(3, 2, typeVector);
            var myVectorMultiplyMatrix = myVectorMatrix23.Multiply(myVectorMatrix32);

            var typeComplex = new MyComplexOperator();
            var myComlexMatrix23 = new MyMatrix<MyComplex>(2, 3, typeComplex);
            var myComlexMatrix32 = new MyMatrix<MyComplex>(3, 2, typeComplex);
            var myComplexMultiplyMatrix = myComlexMatrix23.Multiply(myComlexMatrix32);

            Console.ReadKey();
        }
    }
}
