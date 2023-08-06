using MyArray.Logic;
Console.WriteLine("================================== Array ==================================");
try
{
    var array = new Arreglos(5);
    array.Add(8);
    array.Add(45);
    array.Add(39);
    Console.WriteLine(array);

    array.Insert(-25, 45);
    array.Insert(123, 16);
    Console.WriteLine(array);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


//int[] numbers;
//numbers = new int[10];
//numbers[0] = 1;
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//var array = new Arreglos(10);
//array.Fill(200, 300);
//Console.WriteLine(array);

//Console.WriteLine("============================= Sort Ascendente =============================");

//array.Sort();
//Console.WriteLine(array);

//Console.WriteLine("============================= Sort Descendente ============================");

//array.Sort(true);
//Console.WriteLine(array);