using System;
using System.Linq;//Для методів класу myArray(створеного мною)

namespace Shpora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] myArray = {2, 8, 15, 4, 2, 15, 9, 11, 2, 13, 98, 64, 65, 88, 96 };
            int result;

            result = myArray.Min();//Повертає найменший елемент масиву
            result = myArray.Max();//Повертає найбільший елемент масиву
            result = myArray.First();//Повертає перший елемент масиву (FirstOrDefault() - повертає дефолтне знач. якщо умова не виконується)
            result = myArray.Last();//Повертає останній елемент масиву
            result = myArray.Sum();//Повертає суму елементів
            result = myArray.Where(i => i % 2 == 0).Sum();//Повертає суму елементів з умовою (тут умова - сума парних) myArray.Where(i => i % 2 == 0).Min() - найменше парне...
            int[] resultArray = myArray.OrderBy(i => i).ToArray();//Повертає масив посортованих за зростанням елементів myArray
            resultArray = myArray.OrderByDescending(i => i).ToArray();//Повертає масив посортованих за спаданням елементів myArray
            resultArray = myArray.Distinct().ToArray();//Повертає масив унікальних елементів myArray (ті, які повторюються залишаються тільки в 1 екземплярі)
            Array.Sort(myArray);//Сортує елементи myArray за зростанням
            Array.Reverse(myArray);//Елементи в myArray пересортовуються в обернений порядок (1 і останній міняються місцями)
            result = Array.Find(myArray, i => i < 60);//Повертає перше число, яке задовільняє умову
            result = Array.FindLast(myArray, i => i < 60);//Повертає останнє число, яке задовільняє умову (починає пошук з кінця)
            resultArray = Array.FindAll(myArray, i => i < 60);//Повертає всі числа, які задовільняють умову
            result = Array.FindIndex(myArray, i => i == 88);//Повертає перший індекс елементу який задовільняє умову (немає такого елементу - повертає -1)
            result = Array.FindLastIndex(myArray, i => i == 88);//Повертає останній індекс елементу який задовільняє умову (немає такого елементу - повертає -1, пошук з кінця)
            


        }
    }
}
