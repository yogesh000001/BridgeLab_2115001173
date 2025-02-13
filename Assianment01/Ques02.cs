using System;

public class Movie{
    public string movieTitle;
    public string director;
    public int yearOfRelease;
    public double rating;
    public Movie(string movieTitle,string director,int yearOfRelease,double rating){
        this.movieTitle = movieTitle;
        this.director = director;
        this.yearOfRelease = yearOfRelease;
        this.rating = rating;
    }
}
class Node{
    public Node prev;
    public Movie data;
    public Node next;
    public Node(Movie data){
        this.data = data;
        this.next = null;
        this.prev = null;
    }
}
public class MovieManagement{
    private Node head;
    private Node tail;
    public void addAtBegining(Movie data){
        Node newNode = new Node(data);
        if(head == null){
            head = tail = newNode;
            return;
        }
        newNode.next = head;
        head.prev = newNode;
        head = newNode;
    }
    public void addAtEnd(Movie data){
        Node newNode = new Node(data);
        if(head == null){
            head = tail = newNode;
            return;
        }
        tail.next = newNode;
        newNode.prev = tail;
        tail = newNode;
    }
    public void addAtSpecificPosition(int idx,Movie data){
        Node newNode = new Node(data);
        if(idx == 0){
            addAtBegining(data);
            return;
        }
        int i = 0;
        Node temp = head;
        while(i<idx-1){
            temp = temp.next;
            i++;
        }
        newNode.next = temp.next;
        newNode.prev = temp;
        temp.next.prev = newNode;
        temp.next = newNode;
    }
    public void removeMovie(string title){
        if(head == null){
            Console.WriteLine("No data!");
            return;
        }
        Node temp = head;
        if(temp.data.movieTitle == title){
            head = head.next;
            head.prev = null;
            return;
        }
        Node p = null;
        while(temp != null && temp.data.movieTitle != title){
            p = temp;
            temp = temp.next;
        }
        if(p.next.next == null){
            p.next = null;
            tail = p;
            return;
        }
        p.next = p.next.next;
        p.next.next.prev = p;
    }
    public void display(){
        if(head == null){
            Console.WriteLine("DLL is empty");
            return;
        }
        Node temp = head;
        while(temp != null){
            Console.WriteLine("The movieTitle is : "+temp.data.movieTitle+", director is : "+temp.data.director+", year of release"+temp.data.yearOfRelease+" and rating is : "+temp.data.rating);
            temp = temp.next;
        }
    }
    public void Search(string direc){
        if(head == null){
            Console.WriteLine("No movie present of such director");
            return;
        }
        Node temp = head;
        while(temp!=null &&temp.data.director != direc){
            temp = temp.next;
        }
        if(temp == null){
            Console.WriteLine("No data present for such director");
            return;
        }
        Console.WriteLine("The title of the movie : "+temp.data.movieTitle+" and director is : "+temp.data.director);
    }
    public void Update(string movieT,double r){
        Node temp = head;
        while(temp != null){
            if(temp.data.movieTitle == movieT){
                temp.data.rating = r;
                Console.WriteLine("Rating update successfully");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Movie not found!");
    }
}
class Program{
    public static void Main(string []args){
        Movie o1 = new Movie("Avengers","Tim",2000,4.9);
        Movie o2 = new Movie("Hulk","David",2012,4.3);
        Movie o3 = new Movie("Avatar","Dravid",2011,5.0);
        Movie o4 = new Movie("Bahubali","Sanjay",2018,4.5);
        MovieManagement m1 = new MovieManagement();
        m1.addAtBegining(o1);
        m1.addAtBegining(o2);
        m1.addAtEnd(o3);
        m1.addAtSpecificPosition(1,o4);
        // m1.removeMovie("Bahubali");
        m1.Update("Bahubali",4.9);
        m1.display(); 
        // m1.Search("Tim");
    }
}