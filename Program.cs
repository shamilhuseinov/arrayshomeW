//1
//int[] numbers = { 100, 300, -200, 50 };
//int count = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    int j = count;
//    while (j < numbers.Length)
//    {
//        if (numbers[j] < numbers[i])
//        {
//            int x = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = x;

//        }
//        j++;
//    }
//    count++;
//    Console.WriteLine(numbers[i]);
//}

//2
//int[] numbers = { 100, 300, 250, 50 };
//int sum = 0;
//int count = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//    count++;
//}
//Console.WriteLine($"ədədi orta = {sum / count}");


//3
int[] numbers = { 1, 2, 3 };
int[] numbers2 = { 0, 0, 0 };
for (int i = 0; i < numbers.Length; i++)
{
    numbers2[i] = numbers[numbers.Length - i - 1];
}
for (int j = 0; j < numbers2.Length; j++)
{
    Console.WriteLine(numbers2[j]);
}