using System;
namespace First{
    class Program
    {
        public static void Main(string[] args){
            // Console.WriteLine("Learn Coding");
            // int a = 10;
            // a=20;
            // Console.WriteLine("The value of num is : "+a);

            // double num=45.7;
            // Console.WriteLine("The value of num is : "+num);


            // string str = "Rohit";
            // Console.WriteLine("Value of str is : "+str);

            // bool b=true;
            // Console.WriteLine("The value of b is : "+b);


            // C# input-output

            // String value --> ReadLine()
            // Integer value --> ToInt16() / ToInt32() / ToInt64()--> (It also converts string value to integer value).

            // Taking String as Input
            // string name;
            // Console.Write("Enter Your Name : ");
            // name = Console.ReadLine();
            // Console.Write("My name is : "+name);

            //Console.Read(): Reads a single character from the input stream. It returns the integer representation of that character (its ASCII/Unicode value).
            //Console.ReadLine(): Reads an entire line of characters (until the user presses Enter) from the input stream. It returns this line as a string.

            // Taking Integer as Input
            // This method is used to convert 'String' to 'Integer'
            // string name;
            // Console.Write("Enter any number : ");
            // name = Console.ReadLine();
            // int num = Convert.ToInt32(name);
            // Console.Write("The number is "+num);

            // If we want to directly use integer as input, we can use the below method.
            // int num;
            // Console.Write("Enter the number : ");
            // num = Convert.ToInt16(Console.ReadLine());
            // Console.Write("The entered number is : "+num);

            // Taking 'double' number as input
            // double num;
            // Console.Write("Enter the number : ");
            // num = Convert.ToDouble(Console.ReadLine());
            // Console.Write("The Entered number is : "+num);

            
            // A) Conditional Statements
            // 1) if-statement
            // int PIN = 5633;
            // Console.WriteLine("rohit");
            // if(PIN==5333){
            //     Console.WriteLine("ABCD EFGH");
            // }
            // Console.WriteLine("1234567890");


            // 2) if-else statement
            // int age = 34;
            // int age;
            // Console.WriteLine("Enter your age : ");
            // age = Convert.ToInt32(Console.ReadLine());
            // if(age>=18){
            //     Console.Write("Eligible for voting");
            // }
            // else{
            //     Console.Write("Not eligible for voting");
            // }
             
            
            // 3) if-else-if ladder
            // int marks = 98;
            // int marks;
            // Console.Write("Enter your Marks : ");
            // marks = Convert.ToInt16(Console.ReadLine());
            // if(marks>=80 && marks<=100){
            //     Console.WriteLine("Topper!");
            // }
            // else if(marks>=60 && marks<80){
            //     Console.Write("First!");
            // }
            // else if(marks>=33 && marks<60){
            //     Console.Write("Pass!");
            // }
            // else{
            //     Console.Write("Fail");
            // }


            // 4)nested-if statement
            // int a=10,b=20,c=30;
            // if(a>b){
            //     if(a>c){
            //         Console.WriteLine("The greatest value is 10");
            //     }
            // }
            // else if(b>c){
            //     Console.WriteLine("The greatest value is 20");
            // }
            // else{
            //     Console.WriteLine("The greatest value is 30");
            // }



            // 5)switch statement
            // int choice;
            // Console.Write("Enter your Choice : ");
            // choice = Convert.ToInt32(Console.ReadLine());
            // switch(choice){
            //     case 1: Console.Write("Rohit");
            //     break;
            //     case 2: Console.Write("Rohan");
            //     break;
            //     default: Console.Write("Invalid Choice!!");
            //     break;
            // }


            // B) Looping Statement
            
            // While-loop is called 'entry controlled' loop, because it checks the entry condition.
            // 1) while loop
            // Ascending Order
            // int i=1;
            // while(i<=10){
            //     Console.Write(i + " ");
            //     i++;
            // }

            // Descending (reverse) order
            // int i=20;
            // while(i>=1){
            //     Console.Write(i + " ");
            //     i--;
            // }


            // 2)do-while loop
            // do-while-loop is called 'exit controlled' loop, because it checks the exit condition.

            // int i=1;
            // do{
            //     Console.Write(i + " ");
            //     ++i;
            // }
            // while(i<=10);


            // 3)for-loop

            // for(int i=1;i<=50;++i){
            //     Console.Write(i+" ");
            // }


            // 4) for-each loop
            
            // int [] a = {1,2,3,4,5};
            // foreach(int i in a){
            //     Console.WriteLine(i);
            // }


            // C) Jumping Statement

            // 1) break 

            // for(int i=1;i<=10;i++){
            //     if(i==5){
            //         break;    //Output 1 2 3 4 
            //     }
            //     Console.Write(i + " ");
            // }


            // 2) continue 
                
            // for(int i=1;i<=10;i++){
            // if(i==6 || i==9){
            //     continue;        // Output 1 2 3 4 5 7 8 9 10 
            // }
            // Console.Write(i + " ");
            // }

            // int result = add(10,20);                    //Method calling
            // Console.Write(result);


            // 3) goto-statement
            // Can be used for repeating tasks like that of loops
            // int i=1;
            // go:
            // if(i<=100){
            //     Console.Write(i+" ");
            //     i++;
            //     goto go;            // Prints the natural numbers 1 to 100.
            // }



            // Can be used for skipping some part of the code.
            // int i=1;
            // if(i==1){
            //     Console.WriteLine("Learn Coding...");
            //     goto down;
            // }
            // Console.WriteLine("Ankush...");         //Here Ankush is skipped
            // down:
            // Console.WriteLine("Aniket...");
            
        }

        // static int add(int x,int y){      // Method defining
        //     return x+y;
        // }
    }
}

