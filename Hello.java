public class Hello
{
	public static void main(String[] args)
	{
		System.out.println("Creating objects");
		Student alice = new Student("Alice");
		Student bob = new Student("Bob");
		System.out.println("alice.getName() ---> " + alice.getName());
		System.out.println("bob.getName()   ---> " + bob.getName());
		
		System.out.println();
		System.out.println("bob = alice");
		bob = alice;
		System.out.println("alice.getName() ---> " + alice.getName());
		System.out.println("bob.getName()   ---> " + bob.getName());
		
		System.out.println();
		System.out.println("alice = null");
		alice = null;
		System.out.println("alice.getName() ---> " + alice.getName()); //IT WILL CRASH!!!! Comment out this line
		System.out.println("bob.getName()   ---> " + bob.getName());
	}
}

class Student
{
	private String name;
	
	public Student(String _name)
	{
		name = _name;
	}
	
	public String getName()
	{
		return name;
	}
}