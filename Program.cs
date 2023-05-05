class Program { static void Main(string[] args) {

    string[] MyArray = { "123", "23", "hello", "world", "res" };

    string[] MyArray1 = new string[MyArray.Length];

    int maxLength = 3;

    void CutArray(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= maxLength)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }
    void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" {array[i]} ");
        }
        Console.WriteLine();
    }
    CutArray(MyArray, MyArray1);
    Console.Write($"Элементы массива для обработки:  ");
    PrintArray(MyArray);
    Console.Write($"Элементы массива соответствующие условиям задачи:  ");
    PrintArray(MyArray1);

}
}