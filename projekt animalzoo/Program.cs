
namespace animalzooo;

abstract class Animal{
public string name;
public int age;
public abstract void greeting();
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

