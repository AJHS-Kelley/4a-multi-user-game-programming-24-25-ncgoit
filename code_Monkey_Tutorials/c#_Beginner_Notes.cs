using System;
class Template {
  static void Main() {

        Console.WriteLine("Hello, World!");
        // If statments

        // string name == "Code Monkey";
        // if (name == "Code Monkey") {
        //     Console.WriteLine("Hello Code Monkey!");
        // }
        // if (name == "Iron Man") {
        //     Conso.WriteLine("Iron Man!")
        // }
        // if (name == "Black Widow") {
        //     Conso.WriteLine("Hello Black Widow!")
        // }

        // Switch code
        //   string name = "Code Monkey";
        // switch (name) {
        //     case "Code Monkey":
        //         Console.WriteLine("Hello Code Monkey!");
        //         break;
        //     case "Iron Man":
        //         Console.WriteLine("Hello Iron Man!");
        //         break;
        // 	case "Black Widow":
        //         Console.WriteLine("Hello Black Widow!");
        //         break;
        }
  
    // Scope code
    namespace CodeMonkey_CSharpCourse {
        internal class program {


            static void Main(string[] args) {
                int age = 35;

                bool isPlayer = false;
                SayHello("Code Monkey", age);
            }

            static void SayHello(string playerName, int age) {
                Console.WriteLine($"Hello {playerName} you are {age} years old!");
            }
        }
    }


    // Class code
    namespace CodeMonkey_CSharpCourse {

        internal class Program {

            static void Main(string[] args) {
                l
                int age = 56;
                Player codeMonkeyPlayer = new Player();
                codeMonkeyPlayer.name = "Code Monkey";
                codeMonkeyPlayer.SayHello();
                Player ironManPlayer = new Player();
                ironManPlayer.name = "Iron Man";
                ironManPlayer.SayHello();

                Console.WriteLine(codeMonkeyPlayer.getHashCode() + " " + ironManPlayer.getHashCode);
            }

            class Player {
                
                string name = "Code Monkey";
                public Player() {
                    Console.WriteLine("Creating Player!");
                }

                public void SayHello() {
                    Console.WriteLine($"Hello {name}!");
                }
            }
        }
    }
}