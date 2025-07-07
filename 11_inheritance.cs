/* 
Inheritance : Inheritance allows us to create new classes that reuse, extend and modify the property defined in other classes.

Types : 
1) Single Inheritance
2) Multi-level Inheritance
3) Multiple (through interface)
4) Hierarchical Inheritance


1) Single Inheritance 
Ex: class A{       |      class A{
                   |         code;    (a+b);
    }              |                  (a-b);          
                   |      }
    class B:A{     |
                   |       class B:A{
    }              |            code;
                   |             (a/b);
                   |        }
                          
                    
2) Multi-level Inheritance

class A{          |          class A{
                  |              1 property
}                 |          }
                  |
class B:A{        |          class B:A{
                  |              2 properties
                  |              Total = 2+1 = 3
}                 |          }
class C:B{        |          class C:B{        
                  |              2 properties
                  |              Total = 2+3=5
}                 |          }
 

3) Multiple inheritance is performed through interface and not through class.


interface A{

}
interface B{

}
class C:A,B{
    // creating object of class C to access the properties of interfaces A,B.
}


4) Hierarchical inheritance

class A{

}
class B:A{

}
class C:A{

}
*/

// 1) Single Inheritance
// class X{
//     protected int a=400,b=200,c;         //a,b,c are by default private members of class X.

//     public void add(){
//         c = a+b;
//         Console.WriteLine("Addition is : "+c);
//     }
//     public void sub(){
//         c = a-b;
//         Console.WriteLine("Subtraction is : "+c);
//     }
// }

// class Y:X{

//     public void multi(){
//         c = a*b;
//         Console.WriteLine("Multiplication is : "+c);
//     }

//     public void div(){
//         c = a/b;
//         Console.WriteLine("Division is : "+c);
//     }
//     static void Main(string[] args){

//         // X r = new X();

//         // r.add();
//         // r.sub();

//         // Now, since class Y has four operations, we will create object of class Y, rather than X.

//         Y r = new Y();
//         r.add();
//         r.sub();
//         r.multi();
//         r.div();
//     }
// }



// 2) Multiple Inheritance (Interface)

// We use interface, in the case when we don't know what we are going to implement.
// Don't know about implementation.
// Class provides the implementation of the interfaces.




interface A{
    void add();     //Methods in interface don't have any body, and they are by-default public.
}

interface B{
    void sub();    //Methods in interface don't have any body, and they are by-default public.
}

// Inherits class A and B
class C:A,B{

    // class C implements the methods 'add' and 'sub' of classes A and B.
    public void add(){

        int a = 100, b=20;
        Console.WriteLine(a+b);
    }
    public void sub(){

        int a = 100, b=20;
        Console.WriteLine(a-b);
    }

    static void Main(string[] args){
        C r = new C();

        r.add();
        r.sub();
    }
}








