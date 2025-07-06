/*
Encapsulation : Encapsulation is a mechanism in which 'data member' and 'method' is wrapped in a single unit inside a class,
                so that the data can't be accessed by other class.

Condition : Data should be 'private'.
Ex: class is the best example of encapsulation.

      class A{
            private data

                  + 
  
            public methods      
      }
*/

class S{
    private int atmPIN;

    public int getReturn(){
        return atmPIN;
    }
    public void setValue(int pin){
        atmPIN = pin;
    }
}
class T{
    public static void Main(string[] args){
        S r = new S();
        r.setValue(3456);
        Console.Write("ATM pin is : "+r.getReturn());
    }

}