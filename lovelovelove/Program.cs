// using ExOne;
// using ExpTwo; 
// using ExThree;
using Ex4;

// class Program{
//     static void Main(string[] args) {
//         List<B> userpr = new List<B>();
//         userpr.Add(new B(228, "SuperUser", "qQqQ"));
//         userpr.Add(new B(22823, "SuperUser 2.0", "zZzZ")); 
//         foreach (var i in userpr){
//             Console.WriteLine($"Added new User, {i.Id}, {i.NickName}, {i.Description}");
//         }
        
//         Ivan lox = new Ivan();
//         lox.name = "Vanek";
//         lox.age = "34";
//         lox.heigh = "167";
//         lox.print();
        
//         B Danek = new B();
//         Danek.Id = 6644;
//         Danek.Description = "< blank >";
//         Danek.NickName = "Men4ik";
        
//         Player Anton = new Player();
//         Anton.Number = 7;
//         Anton.Height = 184;
//         Anton.Name = "Anton";
//         Anton.HaveSkill = false;
//         Console.WriteLine(Anton.ToString());
        
//         Team Ft = new Team();
//         Ft.Name = "BB";
//         Ft.Coach = "Samiy Krutoy trener";

//         Ft.Players.Add(new Player(17, 184, "Alex", true));
//         Ft.Players.Add(new Player(5, 187, "Kostik", false));
//         Ft.Players.Add(new Player(10, 165, "Maxik", true));
//         Ft.Players.Add(new Player(1, 175, "Iluwa", true));
//         Ft.Players.Add(new Player(13, 189, "Anton", false));
//         Console.WriteLine($"Team {Ft.Name}, {Ft.Coach}, ");
//         foreach(var i in Ft.Players){
//             Console.WriteLine($"{i.Number}, {i.Height}, {i.Name}, {i.HaveSkill}");
            
//         }

//         // !!!Console.WriteLine(Ft.ToString()); // ??? как выводить данные со списка, используя ToString



//         Console.WriteLine($"New user {Danek.NickName}, his description {Danek.Description}, his Id {Danek.Id}");
//         Console.WriteLine($"Человек {lox.name}, рост {lox.heigh}, возраст {lox.age}");
//         Console.ReadKey();
//     }
// }





// class Program{
//     static void Main(string[] args) {
//         List<B> alist = new List<B>();
//         alist.Add(new B(228, "SuperUser", "qQqQ"));
//         alist.Add(new B(22823, "SuperUser 2.0", "zZzZ")); 
//         foreach (var i in alist){
//             Console.WriteLine($"Added new User, {i.Id}, {i.NickName}, {i.Description}");
//         }
        
//         B Danek = new B();
//         Danek.Id = 6644;
//         Danek.Description = "< blank >";
//         Danek.NickName = "Men4ik";
//         Console.WriteLine($"New user {Danek.NickName}, his description {Danek.Description}, his Id {Danek.Id}");
//         Console.ReadKey();
//     }
// }




// Эксперимент два!


// class Program{
//     static void Main(string[] args) {
//         Player Anton = new Player();
//         Anton.Number = 7;
//         Anton.Height = 184;
//         Anton.Name = "Anton";
//         Anton.HaveSkill = false;
//         Console.WriteLine(Anton.ToString());
        
//         Team Ft = new Team();
//         Ft.Name = "BB";
//         Ft.Coach = "Samiy Krutoy trener";

//         Ft.Players.Add(new Player(17, 184, "Alex", true));
//         Console.WriteLine($"Team {Ft.Name}, {Ft.Coach}, ");
//         foreach(var i in Ft.Players){
//             Console.WriteLine($"{i.Number}, {i.Height}, {i.Name}, {i.HaveSkill}");
            
//         }
//     }
// }



// ex 4

class Program{
    static void Main() {
        Team Zenith = new Team();
        Zenith.Name = "Zenith";
        Zenith.Coach = "Gvardiola))";
        for (int i = 0; i < 3; i++) {
            Zenith.NewPlayers(new Player());
            Zenith.Players[i].Number = $"Игроки команды {i + 1}"; // игнорит эту часть кода
        }
        Console.WriteLine($"{Zenith.Players}"); //
        Console.WriteLine(Zenith.ToString());
        Console.ReadKey();
    }
}