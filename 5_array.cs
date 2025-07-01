/* Array 
- Array is a variable which helps us to store multiple elements of the same type.
-           |_10_||_20_||_30_||_40_||_50_|     size = 5
-  index ->    0     1     2     3    4
- The base index of array starts with 0 and ends with n-1.

Types of Array
1) 1D array    2) 2D array
*/

// 1) 1D array
// int [] a = {10,20,30,40,50}; 

// foreach(int i in a){
//     Console.Write(i+" ");
// }

// Taking user input in 1D array
//     int size;
//     Console.WriteLine("Enter the number of elements in the array : ");
//     size = Convert.ToInt32(Console.ReadLine());
    
//     int [] a = new int[size];
//     Console.WriteLine("Enter the elements : ");
//     for(int i=0;i<size;i++){
//         a[i] =  Convert.ToInt32(Console.ReadLine());
//     }

//     foreach(int i in a){
//         Console.WriteLine(i+ " ");
//     }

// 2) 2D array
/*
int [,] a = new int[2,2];
Console.WriteLine("Enter array elements : ");
for(int i=0;i<2;i++){         //Kitne "rows" mein element print hoga
    for(int j=0;j<2;j++){     //Kitne "columns" mein element print hoga
        a[i,j]=Convert.ToInt32(Console.ReadLine());   
    }
}

Console.WriteLine("Matrix Array elements : ");
for(int i=0;i<2;i++){         //Kitne "rows" mein element print hoga
    for(int j=0;j<2;j++){     //Kitne "columns" mein element print hoga
        Console.Write(a[i,j]+" ");
    }
    Console.WriteLine();
}

*/

// Taking Manual Input for 1-D Array.
// int size;
// Console.WriteLine("Enter the number of elements : ");
// size = Convert.ToInt32(Console.ReadLine());
// int [] a = new int[size];
// Console.Write("Enter the array elements : ");
// for(int i=0;i<size;i++){
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }
// foreach (int i in a){
//     Console.Write(i+" ");
// }