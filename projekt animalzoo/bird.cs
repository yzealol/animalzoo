namespace animalzooo;
abstract class Bird : Animal{
public bool canFly;
public void fly(int meter){
  Console.WriteLine(meter);
}
}
class Penguin :Bird{
 public override void greeting()
    {Console.WriteLine($"tjena mittbena. jag heter {name} och är {age} år gammal");
        
    }
    public Penguin(string penguinname,int penguinage){
  name = penguinname;
  age = penguinage;
canFly = false;

}
}

class Parrot : Bird{
   public override void greeting()
    {Console.WriteLine($"tjena mittbena. jag heter {name} och är {age} år gammal");
        
    }
public void Speak(string parrotspeak){

Console.WriteLine(parrotspeak);

}
public Parrot(string parrotname,int parrotage){
  name = parrotname;
  age = parrotage;
  canFly = true;
 
}

}