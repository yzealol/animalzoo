
class Zoo{
public List<Animal> animals;

public Zoo(){
animals = new List<Animal>();
}

public void greetAnimals(){
foreach (Animal x in animals){
  x.greeting();
}
}
public void addAnimal(Animal y){
animals.Add(y);
}
public void removeAnimal(int z){
  animals.RemoveAt(z);
}
public Animal firstAnimal(){
  Console.WriteLine(animals[0]);
  return animals[0];
}

}

abstract class Animal{
public string name;
public int age;
public abstract void greeting();
}

abstract class Bug :Animal{
public bool haswings;

}


class Ant :Bug{
    public override void greeting()
    {Console.WriteLine($"tjena mittbena. jag heter {name} och är {age} år gammal");
        
    }
    public Ant(string myrnamn,int myrålder){
  name = myrnamn;
  age = myrålder;
  haswings = false;
  
}
}

abstract class Mamal :Animal{
public bool isNocturnal;
public bool isAsleep;
}

class Cat :Mamal{

   public override void greeting()
    {Console.WriteLine($"tjena mittbena. jag heter {name} och är {age} år gammal");
        
    }
public Cat(string kattnamn,int kattålder){
  name = kattnamn;
  age = kattålder;
  isNocturnal = true;
}
}

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
    public Penguin(string pingvinnamn,int pingvinålder){
  name = pingvinnamn;
  age = pingvinålder;
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
public Parrot(string papegojanamn,int papegojaålder){
  name = papegojanamn;
  age = papegojaålder;
  canFly = true;
 
}

}
class Program{

   static void main(){
Zoo tjenazoo = new Zoo();
    bool klar = false;
    while (!klar){
    Console.Clear();
    Console.WriteLine("tryck q för att exit \n tryck a för att add \n Tryck r för att remove \n tryck f för att first");
    string väljdjur;
  switch(Console.ReadKey().KeyChar){
    case 'q':
    Console.WriteLine("tjena tjena kom gärna tillbaka king kong");
    klar = true;
    break;
    case 'a':
    Console.WriteLine("tjena vilket animal vill du adda idag?(cat, parrot, penguin, ant)");
väljdjur = Console.ReadLine();
switch(väljdjur){
  case "cat":
  string djurnamn = Console.ReadLine();
  int djurålder = Convert.ToInt32(Console.ReadLine());
  Cat nykatt = new Cat(djurnamn,djurålder);
   tjenazoo.addAnimal(nykatt);
   break;
  case "parrot":
   djurnamn = Console.ReadLine();
   djurålder = Convert.ToInt32(Console.ReadLine());
  Parrot nyparrot = new Parrot(djurnamn,djurålder);
   tjenazoo.addAnimal(nyparrot);
   break;
   case "ant":
   djurnamn = Console.ReadLine();
   djurålder = Convert.ToInt32(Console.ReadLine());
  Ant nyant = new Ant(djurnamn,djurålder);
   tjenazoo.addAnimal(nyant);
   break;
   case "penguin":
   djurnamn = Console.ReadLine();
   djurålder = Convert.ToInt32(Console.ReadLine());
  Penguin nypenguin = new Penguin(djurnamn,djurålder);
   tjenazoo.addAnimal(nypenguin);
   break;
}
   
    break;
    case 'r':
    Console.WriteLine("skriv in de index du vill ta bort");
     int tabortindex = Convert.ToInt32(Console.ReadLine());
     if(0<=tabortindex && tabortindex < tjenazoo.animals.Count()){
 tjenazoo.removeAnimal(tabortindex);
     }
     else{Console.WriteLine($"index {tabortindex} fanns inte g");
     }
    
    break;
    case 'f':
    tjenazoo.firstAnimal();
    break;
  }
 
  }
}
void Exit(){

}
void Add(){

}
void Remove(){

}
void First(){

}

}

