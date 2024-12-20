
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
    public Ant(string antname,int antage){
  name = antname;
  age = antage;
  haswings = false;
  
}
}

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
class Program{

   static void  Main(){
Zoo wassupzoo = new Zoo();
    bool done = false;
    while (!done){
    Console.Clear();
    Console.WriteLine("tryck q för att exit \n tryck a för att add \n Tryck r för att remove \n tryck f för att first");
    string chooseanimal;
  switch(Console.ReadKey().KeyChar){
    case 'q':
    Console.WriteLine("tjena tjena kom gärna tillbaka king kong");
    done = true;
    break;
    case 'a':
    Console.WriteLine("tjena vilket animal vill du adda idag?(cat, parrot, penguin, ant)");
chooseanimal = Console.ReadLine();
switch(chooseanimal){
  case "cat":
  string animalname = Console.ReadLine();
  int animalage = Convert.ToInt32(Console.ReadLine());
  Cat newcat = new Cat(animalname,animalage);
   wassupzoo.addAnimal(newcat);
   break;
  case "parrot":
   animalname = Console.ReadLine();
   animalage = Convert.ToInt32(Console.ReadLine());
  Parrot newparrot = new Parrot(animalname,animalage);
   wassupzoo.addAnimal(newparrot);
   break;
   case "ant":
   animalname = Console.ReadLine();
   animalage = Convert.ToInt32(Console.ReadLine());
  Ant newant = new Ant(animalname,animalage);
   wassupzoo.addAnimal(newant);
   break;
   case "penguin":
   animalname = Console.ReadLine();
   animalage = Convert.ToInt32(Console.ReadLine());
  Penguin newpenguin = new Penguin(animalname,animalage);
   wassupzoo.addAnimal(newpenguin);
   break;
}
   
    break;
    case 'r':
    Console.WriteLine("skriv in de index du vill ta bort");
     int removeindex = Convert.ToInt32(Console.ReadLine());
     if(0<=removeindex && removeindex < wassupzoo.animals.Count()){
 wassupzoo.removeAnimal(removeindex);
     }
     else{Console.WriteLine($"index {removeindex} fanns inte g");
     }
    
    break;
    case 'f':
    wassupzoo.firstAnimal();
    break;
  }
 
  }
}
}

