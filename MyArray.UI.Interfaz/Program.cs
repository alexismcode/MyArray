using MyArray.Logic;
Console.WriteLine("================================== Array ==================================");
try
{
    var array = new Arreglos(10);
    array.Fill(1, 10);
    array.Sort();
    Console.WriteLine(array);
    Console.WriteLine("============================== No Repetidos ===============================");
    var nonRepeat = array.NotRepetidos();
    nonRepeat.Sort();
    Console.WriteLine(nonRepeat);
    Console.WriteLine("================================= Primos ==================================");
    var getPrimo = array.Primos();
    Console.WriteLine(getPrimo);
    Console.WriteLine("================================== Pares ==================================");
    var getPares = array.Pares();
    Console.WriteLine(getPares);
    //array.Add(8);
    //array.Add(45);
    //array.Add(39);
    //Console.WriteLine(array);

    //array.Insert(-25, 45);
    //array.Insert(123, 16);
    //Console.WriteLine(array);
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