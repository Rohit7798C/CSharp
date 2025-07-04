// Classes & Objects in C#

/*
A) Class
- Class is a prototype defined by user in which we define the properties & behaviour of objects.
- Class is a logical entity and it does not exist in real.
- It contains the properties and behaviour of objects.
- Memory is not created for a class.

B) Object
- Object is an instance of a class that represents the class and an object is a real entity that has state and behaviour.
- Memory is created for object.


class mobile{
   **Properties**
   name; 
   cost;
   design;
   storage;

   **Behaviour**
   calling();
   chatting();
   music();   

}

 */

/*
class Mobile{

    int price;
    string storage;
    string color;

    public void calling(){
        Console.WriteLine("Voice Message!!");
    }

    public void chatting(){
        Console.WriteLine("Text Message!");
    }
    public void music(){
        Console.WriteLine("Song...");
    }
    static void Main(string[] args){
        Mobile m = new Mobile();
        m.price = 10000;
        m.storage = "8GB Ram";
        m.color = "Black";

        Console.WriteLine(m.price);
        Console.WriteLine(m.storage);
        Console.WriteLine(m.color);

        m.calling();
        m.chatting();
        m.music();
    }
}

*/