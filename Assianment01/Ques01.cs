using System;

class Student
{
    public int rollNumber;
    public int age;
    public string name;
    public string grade;
    public int RollNumber
    {
        get { return rollNumber; }
        set { rollNumber = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Grade
    {
        get { return grade; }
        set { grade = value; }
    }
    public Student(int rollNumber, int age, string name, string grade)
    {
        this.rollNumber = rollNumber;
        this.age = age;
        this.name = name;
        this.grade = grade;
    }
}
class Node
{
    public Student data;
    public Node next;
    public Node(Student data)
    {
        this.data = data;
        next = null;
    }
}
class ManageStudentSystem
{
    private Node head;
    public void AddStudentAtFirst(Student data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        newNode.next = head;
        head = newNode;
    }
    public void AddStudentAtEnd(Student data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }
    public void AddStudentAtSpecificPosition(Student data, int position)
    {
        Node newNode = new Node(data);
        if (position == 0)
        {
            newNode.next = head;
            head = newNode;
            return;
        }
        int i = 0;
        Node temp = head;
        while (i < position - 1)
        {
            temp = temp.next;
            i++;
        }
        newNode.next = temp.next;
        temp.next = newNode;
    }
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No student details entered");
            return;
        }
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine("The rollnumber of student is : " + temp.data.rollNumber + ", age : " + temp.data.age + " , name is : " + temp.data.name + " and grade is : " + temp.data.grade);
            temp = temp.next;
        }
    }
    public void DeleteByRollNumber(int num)
    {
        Node temp = head;
        Node prev = null;
        if(temp != null && temp.data.rollNumber == num)
        {
            head = temp.next;
            return;
        }
        while (temp != null && temp.data.rollNumber != num)
        {
            prev = temp;
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("Enter roll number is not present in data");
            return;
        }
        prev.next = prev.next.next;
    }
    public void SearchForStudent(int num){
        if(head == null){
            return;
        }
        Node temp = head;
        while (temp!=null  && temp.data.rollNumber != num)
        {
            temp = temp.next;
        }
        if(temp == null){
            Console.WriteLine("No the searched student is not present in the data");
            return;
        }
        Console.WriteLine("Yes, the entered roll number "+temp.data.rollNumber+" is present!");
    }
    public void UpdateGrade(int num,string gr){
        Node temp = head;
        while(temp != null){
            if(temp.data.rollNumber == num){
                temp.data.grade = gr;
                Console.WriteLine("Grade update successfully");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found!");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Student st1 = new Student(1, 19, "Yash", "A+");
        Student st2 = new Student(2, 20, "Rahul", "A");
        Student st3 = new Student(3, 21, "Shivam", "B+");
        Student st4 = new Student(4, 19, "Aryan", "C+");
        ManageStudentSystem m = new ManageStudentSystem();
        m.AddStudentAtFirst(st2);
        m.AddStudentAtFirst(st1);
        m.AddStudentAtEnd(st3);
        m.AddStudentAtSpecificPosition(st4, 1);
        m.DeleteByRollNumber(100);
        m.SearchForStudent(10);
        m.UpdateGrade(1,"abc");
        m.Display();
    }
}