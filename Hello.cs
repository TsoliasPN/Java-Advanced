public class Hello
{
	public static void Main()
	{
		System.Console.WriteLine("Creating objects");
		Student alice = new Student("Alice");
		Student bob = new Student("Bob");
		System.Console.WriteLine("alice.getName() ---> " + alice.getName());
		System.Console.WriteLine("bob.getName()   ---> " + bob.getName());
		
		System.Console.WriteLine();
		System.Console.WriteLine("bob = alice");
		bob = alice;
		System.Console.WriteLine("alice.getName() ---> " + alice.getName());
		System.Console.WriteLine("bob.getName()   ---> " + bob.getName());
		
		System.Console.WriteLine();
		System.Console.WriteLine("alice = null");
		alice = null;
		System.Console.WriteLine("alice.getName() ---> " + alice.getName()); //IT WILL CRASH!!!! Comment out this line
		System.Console.WriteLine("bob.getName()   ---> " + bob.getName());
	}
}

class Student
{
	private string name;
	
	public Student(string _name)
	{
		name = _name;
	}
	
	public string getName()
	{
		return name;
	}
}