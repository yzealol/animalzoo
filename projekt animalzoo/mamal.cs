namespace animalzooo;
abstract class Mamal :Animal{
public bool isNocturnal;

}
class Cat :Mamal{

   public override void greeting()
    {Console.WriteLine($"tjena mittbena. jag heter {name} och är {age} år gammal");
        
    }
public Cat(string catname,int catage){
  name = catname;
  age = catage;
  isNocturnal = true;
}
public bool isAsleep(){
return true;
}
}