using System;
using Newtonsoft.Json;

public class Program()
{
    public struct Person
    {
        public string name;
        public int age;
        public int height;
        public string phoneNumber;
        public string ssn;
        public string address;

        public Person(string name, int age, int height, string phoneNumber, string ssn, string address)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.phoneNumber = phoneNumber;
            this.ssn = ssn;
            this.address = address;
        }
    }

    public static int init_menu()
    {
        
        return (int)Console.Read();
    }
    public static void setPersonList(List<Person> plist)
    {
        int ans = 1;
        do
        {
            Console.WriteLine("\n1- Add a Person");
            Console.WriteLine("2- Save in JSON");
            Console.WriteLine("3- Quit\n");
            Console.Write("Choose: ");
            ans = int.Parse(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    {
                        plist.Add(addPerson());
                        break;
                    }
                case 2:
                    {
                        saveInJSON(plist);
                        break;
                    }
                    
                case 3:
                    break;
                default:
                    {
                        Console.WriteLine("Enter a valid number!");
                        break;
                    }
            }
        } while (ans != 3);
    }

    public static Person addPerson()
    {
        Console.Write("\nName: ");
        string name = Console.ReadLine();
        Console.Write("\nAge: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("\nheight: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("\nPhone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("\nSSN: ");
        string ssn = Console.ReadLine(); ;
        Console.Write("\nAddress: ");
        string address = Console.ReadLine();
        return new Person(name, age, height, phoneNumber, ssn, address);
    }

    public static void viewList(List<Person> plist)
    {
        foreach (Person p in plist)
        {
            Console.WriteLine(p.name);
        }
    }

    public static void saveInJSON(List<Person> plist)
    {
        string json = JsonConvert.SerializeObject(plist, Formatting.Indented);
        Console.WriteLine(json);
        File.WriteAllText("people.json", json);
    }

    public static List<Person> getPesonList()
    {
        string json = File.ReadAllText("people.json");
        List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json);
        return people;
    }

    public static void Main(string[] args)
    {
        int ans = 1;
        List<Person> plist = new List<Person>();
        do {
            Console.WriteLine("\n1- Set Person List");
            Console.WriteLine("2- Get Person List");
            Console.WriteLine("3- View List");
            Console.WriteLine("4- Quit\n");
            Console.Write("Choose: ");
            ans = int.Parse(Console.ReadLine());
            switch (ans)
            {
                case 1: 
                    setPersonList(plist); break;
                case 2:
                    plist= getPesonList(); break;
                case 3:
                    viewList(plist); break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Enter a valid number!");
                    break;
            }
        }while (ans != 4);
        
    }
}