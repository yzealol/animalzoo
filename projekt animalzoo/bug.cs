namespace animalzooo;
abstract class Bug :Animal{
public bool haswings;

}
class Ant :Bug{
    public override void greeting()
    {Console.WriteLine($"tjena mittbena. jag heter {name} och är {age} år gammal");
        
    }
    public Ant(string antname,int antage){
  name = antname;
  age = antage;
  haswings = false;
  
}
}