class Program
{
	static void Main()
	{
		Student<string> studentName = new Student<string>();
		Student<int> studentId = new Student<int>();
	}
	
}

class Student<T>
{
	public T data;
	
	public Student(T data)
	{
		
	}
}

