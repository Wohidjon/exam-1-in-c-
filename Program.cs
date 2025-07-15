// Task 1
// int n = int.Parse(Console.ReadLine());
//         string[] parts = Console.ReadLine().Split();
//         int[] arr = new int[n];
//         for (int i = 0; i < n; i++)
//             arr[i] = int.Parse(parts[i]);

//         int count = 1; 
//         for (int i = 1; i < n; i++)
//         {
//             if (arr[i] != arr[i - 1])
//                 count++;
//         }

//         Console.WriteLine(count);

// Task 2
// int n = int.Parse(Console.ReadLine());
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int k = int.Parse(Console.ReadLine());

// for (int i = 0; i < n; i++)
// {
//     if (i != k)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


// Task 3

// int n = int.Parse(Console.ReadLine());
//         string[] input = Console.ReadLine().Split();
//         int[] arr = Array.ConvertAll(input, int.Parse);
//         int min = arr[0], max = arr[0];
//         int minIndex = 0, maxIndex = 0;

//         for (int i = 1; i < n; i++)
//         {
//             if (arr[i] < min)
//             {
//                 min = arr[i];
//                 minIndex = i;
//             }
//             if (arr[i] > max)
//             {
//                 max = arr[i];
//                 maxIndex = i;
//             }
//         }
//         int start = Math.Min(minIndex, maxIndex);
//         int end = Math.Max(minIndex, maxIndex);

//         for (int i = start; i <= end; i++)
//         {
//             Console.Write(arr[i] + " ");
//         }



// Task 4
    // int n = int.Parse(Console.ReadLine());
    //         string[] parts = Console.ReadLine().Split();
    //         int[] arr = new int[n];
    //         for (int i = 0; i < n; i++)
    //             arr[i] = int.Parse(parts[i]);
    // for (int i = 1; i < n; i++)
    // {
    //     if (arr[i] > 0) { arr[i] = 0; }  
    //             Console.WriteLine(arr[i]);    
    //         }


    // Task 5

//     int n = int.Parse(Console.ReadLine());
//         string[] parts = Console.ReadLine().Split();
//         int[] arr = new int[n];
//         for (int i = 0; i < n; i++)
//     arr[i] = int.Parse(parts[i]);
// for (int i = 1; i < n; i++)
// {
//     int cnt = 0;
//     if (arr[i] == arr[i + 1])
//     {
//         h++;
//     } 
//         }
// Console.WriteLine(h);

// Task 6


// Task 7
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int SumOfDigits(int n)
// {
//     for (int i = n; i > 0; i /= 10)
//     {
//         sum += i;
//     }
//     return sum;
// }


// Task 8
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// void Swap(ref int a, ref int b)
// {
//     Swap(a, b);
// }

// Task 9
// void IncrementArrayElements(ref int[] arr, ref int n)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] += n;
//     }
// }

// Task 10


