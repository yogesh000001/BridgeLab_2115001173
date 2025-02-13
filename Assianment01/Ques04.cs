using System;

class Schedular{
    public int taskId;
    public string taskName;
    public int priority;
    public string dueDate;
    public Schedular(int taskId,string taskName,int priority,string dueDate){
        this.taskId = taskId;
        this.taskName = taskName;
        this.priority = priority;
        this.dueDate = dueDate;
    }
}
class Node{
    public Node next;
    public Schedular data;
    public Node(Schedular data){
        this.data = data;
        this.next = null;
    }
}
class SchedularAlgorithm{
    private Node head;
    public static int size;
    public void addFirst(Schedular data){
        Node newNode = new Node(data);
        size++;
        if(head == null){
            head = newNode;
            head.next = head;
            return;
        }
        Node temp = head;
        while(temp.next != head){
            temp = temp.next;
        }
        temp.next = newNode;
        newNode.next = head;
        head = newNode;
    }
    public void addAtEnd(Schedular data){
        Node newNode = new Node(data);
        size++;
        if(head == null){
            head = newNode;
            head.next = head;
        }
        Node temp = head;
        while(temp.next != head){
            temp = temp.next;
        }
        temp.next = newNode;
        newNode.next = head;
    }
    public void addAtSpecificPosition(int idx,Schedular data){
        Node newNode = new Node(data);
        size++;
        if(idx == 1){
            addFirst(data);
            return;
        }
        int i = 1;
        Node temp = head;
        while(i<idx-1 && temp.next != head){
            temp = temp.next;
            i++;
        }
        if(temp.next == head){
            addAtEnd(data);
        }else{
            newNode.next = temp.next;
            temp.next = newNode;
        }
    }
    public void removeTaskId(int tid){
        Node temp = head;
        Node prev = null;
        int i = 1;
        while(temp.next != head && temp.data.taskId != tid){
            prev = temp;
            temp = temp.next;
            i++;
        }
        if(size == i){
            prev.next = head;
            return;
        }
        prev.next = prev.next.next;
    }
    public void Display(){
        Node temp = head;
        do{
            Console.WriteLine("The TaskId is : "+temp.data.taskId+", task name is : "+temp.data.taskName+", priority is : "+temp.data.priority+" and due date is : "+temp.data.dueDate);
            temp = temp.next;
        }while(temp != head);
    }
}
class Program{
    public static void Main(string []args){
        SchedularAlgorithm s = new SchedularAlgorithm();
        Schedular s1 = new Schedular(1,"abc",4,"01/01/2012");
        Schedular s2 = new Schedular(2,"adf",2,"05/08/2018");
        Schedular s3 = new Schedular(3,"gge",1,"11/03/2010");
        Schedular s4 = new Schedular(4,"rty",3,"13/02/2009");
        Schedular s5 = new Schedular(9,"arg",9,"05/05/2014");
        s.addFirst(s1);
        s.addFirst(s2);
        s.addFirst(s3);
        s.addAtEnd(s4);
        s.addAtSpecificPosition(6,s5);
        s.removeTaskId(9);
        s.Display();
    }
}