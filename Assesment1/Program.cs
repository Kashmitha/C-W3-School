using System;

class Book
{
    public int bookId;
    public string title;
    public string author;
    public bool available;

    public Book(int Id, string bookTitle, string bookAuthor){
        this.bookId = Id;
        this.title = bookTitle;
        this.author = bookAuthor;
        available = true;
    }
    public void borrowBook(){
        if(available){
            available = false;
            Console.WriteLine($"Book {title} is has been borrowed");
        }else
        {
            Console.WriteLine($"Book {title} is already borrowed");
        }
    }
    public void returnBook(){
        if(!available){
            available = true;
            Console.WriteLine($"Book {title} has been return");
        }else
        {
            Console.WriteLine($"Book {title} was not borrowed");
        }
    }
    public void displayInfo(){
        Console.WriteLine($"BookID: {bookId}, Title: '{title}', Author: '{author}', Available: {available}");
    }
}

class Member{
    public int memberId;
    public string name;
    public Book borrowedBook;

    public Member(int MemberId, string Name){
        this.memberId = MemberId;
        this.name = Name;
        borrowedBook = null;
    }
    public void borrowBook(Book b){
        if(b.available){
            borrowedBook = b;
            b.borrowBook();
        }else
        {
            Console.WriteLine($"Sorry, {b.title} is not available");
        }
    }
    public void returnBook(){
        if(borrowedBook != null){
            borrowedBook.returnBook();
            borrowedBook = null;
        }else
        {
            Console.WriteLine("No book to return");
        }       
    }
    public void displayInfo() {
        Console.WriteLine($"MemberID: {memberId}, Name: {name}");
        if (borrowedBook != null)
        {
            Console.WriteLine("Borrowed Book:");
            borrowedBook.displayInfo();
        }
        else
        {
            Console.WriteLine("No book currently borrowed.");
        }
    }
}

class LibraryManagement
{
    public static void Main(string[] args)
    {
        Book myBook1 = new Book(1,"GoT","George");
        Book myBook2 = new Book(2,"HoT","Martin");
        Book myBook3 = new Book(3,"DoT","R.R.");

        Member member1 = new Member(101, "Alice");
        Member member2 = new Member(102, "Bob");

        member1.borrowBook(myBook1);
        member2.borrowBook(myBook2);
        member1.borrowBook(myBook1);

        Console.WriteLine("\nBook Details:");
        myBook1.displayInfo();
        myBook2.displayInfo();
        myBook3.displayInfo();

        Console.WriteLine("\nMember Details:");
        member1.displayInfo();
        member2.displayInfo();
    }
}