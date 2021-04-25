using System;
using System.Linq.Expressions;

namespace Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParameterExpression number = Expression.Parameter(typeof(double), "num");
            ConstantExpression one = Expression.Constant((double)1, typeof(double));
            BinaryExpression add = Expression.Add(number, one);
            Expression<Func<double, double>> lambda1 = Expression.Lambda<Func<double, double>>(add, new ParameterExpression[] { number });
            Func<double, double> func = lambda1.Compile();

            Console.ReadKey();
        }
    }
}
