// Constructor
/*
- Constructor is a special type of method whose name is same as 'class' name, it is innvoked automatically at the time of object creation.
- Note:- The main purpose of constructor is to initialize the data member of new object.

- Types of Constructors
1) Default constructor
   Syntax:-
   class A{
      A(){
      
      }
   }
2) Parametric constructor
   class A{
      A(int a){
      
      }
   }
*/

class X{
   // int num;

   /*
   A()    //default constructor
   {
      num=100;
   }

   public void show(){
      Console.Write(num);
   }

   */

   X(int num,string name)    //parameterized constructor
   {
      Console.Write(num+" "+name);
   }


   static void Main(string[] args){
      X r = new X(50,"Akhilesh");
   }
}