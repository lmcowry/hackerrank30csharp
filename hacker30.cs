//csharp
//0

class Solution {
    static void Main(String[] args) {
        // Declare a variable named 'inputString' to hold our input.
        String inputString;

        // Read a full line of input from stdin (cin) and save it to our variable, input_string.
        inputString = Console.ReadLine();

        // Print a string literal saying "Hello, World." to stdout using cout.
        Console.WriteLine("Hello, World.");

        // TODO: Write a line of code here that prints the contents of input_string to stdout.

        Console.WriteLine(inputString);
    }
}


//1


// Declare second integer, double, and String variables.
int secInt = Int32.Parse(Console.ReadLine());
double secDou = Double.Parse(Console.ReadLine());
string secStr = Console.ReadLine();

// Read and save an integer, double, and String to your variables.

// Print the sum of both integer variables on a new line.
Console.WriteLine(i + secInt);
// Print the sum of the double variables on a new line.
double douSum = d + secDou;
Console.WriteLine(douSum.ToString("0.0"));
// Concatenate and print the String variables on a new line
Console.WriteLine(s + secStr);
// The 's' variable above should be printed first.


//2

using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        decimal mealCost = Decimal.Parse(Console.ReadLine());
        decimal tipPercent = Decimal.Parse(Console.ReadLine());
        decimal taxPercent = Decimal.Parse(Console.ReadLine());

        decimal howMuchToTip = mealCost * (tipPercent / 100);
        decimal howMuchToTax = mealCost * (taxPercent / 100);

        decimal totalCost = mealCost + howMuchToTip + howMuchToTax;
        decimal totalRoundedCost = Math.Round(totalCost, 0);

        Console.WriteLine($"The total meal cost is {totalRoundedCost} dollars.");;
    }
}



// 3


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        string printStatement = "";
        if (N % 2 == 0)
        {
            if (N <= 5 && N >= 2)
            {
                printStatement = "Not Weird";
            }
            else if (N <= 20 && N >= 6)
            {
                printStatement = "Weird";
            }
            else if (N > 20)
            {
                printStatement = "Not Weird";
            }
        }
        else
        {
            printStatement = "Weird";
        }
        Console.WriteLine(printStatement);
    }
}



// 4

class Person {
    public int age;
	public Person(int initialAge) {
        // Add some more code to run some checks on initialAge
        if (initialAge < 0)
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            initialAge = 0;
        }
        this.age = initialAge;
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console
        if (this.age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (this.age >= 13 && this.age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are old.");
        }
     }

     public void yearPasses() {
        // Increment the age of the person in here
        this.age++;
     }

//5

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}


// 6

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int howManyStrings = Convert.ToInt32(Console.ReadLine());

        List<string> stringList = new List<string>();
        string line = "";

        for(int counter = 0; counter < howManyStrings; counter++)
        {
            stringList.Add(Console.ReadLine());
        }

        // this would be used if we didn't have howManyStrings as input
        // while((line = Console.ReadLine()) != null)
        // {
        //     stringList.Add(line);
        // }


        foreach(string x in stringList)
        {
            string printEvenString = "";
            string printOddString = "";
            for(int y = 0; y < x.Length; y += 2)
            {
                printEvenString += x[y];
            }
            for(int z = 1; z < x.Length; z += 2)
            {
                printOddString += x[z];
            }
            Console.WriteLine($"{printEvenString} {printOddString}");
        }
    }
}


//7

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);

        for(int counter = n - 1; counter >= 0; counter--){
            Console.Write($"{arr[counter]} ");
        }

}
}


//8

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int howMany = Int32.Parse(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        for (int counter = 0; counter < howMany; counter++)
        {
            string fullString = Console.ReadLine();
            string[] bothParts = fullString.Split(' ');
            phoneBook.Add(bothParts[0], bothParts[1]);
        }

        string input = Console.ReadLine();

        do
        {
            if (phoneBook.ContainsKey(input))
            {
                Console.WriteLine($"{input}={phoneBook[input]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            input = Console.ReadLine();
        }while(!string.IsNullOrEmpty(input));

    }
}

// 9

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int Factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int theNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Factorial(theNumber));


    }

}


//10

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        int theMost = 0;
        int howMany = 0;
        foreach (char x in binary){
            if (x.Equals('1'))
            {
                howMany++;
                if (howMany > theMost){
                    theMost = howMany;
                }
            }
            else
            {
                howMany = 0;
            }

        }
        Console.WriteLine(theMost);
    }
}

// 11

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        int a, b, c, d, e, f, g;
        int theSum = 0;
        int? highestSum = null;

        for (int rowCounter = 0; rowCounter < arr.Length; rowCounter++)
        {
            for (int cellsInRowCounter = 0; cellsInRowCounter < arr[rowCounter].Length; cellsInRowCounter++)
            {
                //if there are three spots in the row && two rows underneath
                if (((cellsInRowCounter + 2) < arr[rowCounter].Length) && ((rowCounter + 2) < arr.Length))
                {
                    a = arr[rowCounter][cellsInRowCounter];
                    b = arr[rowCounter][cellsInRowCounter + 1];
                    c = arr[rowCounter][cellsInRowCounter + 2];

                    d = arr[rowCounter + 1][cellsInRowCounter + 1];

                    e = arr[rowCounter + 2][cellsInRowCounter];
                    f = arr[rowCounter + 2][cellsInRowCounter + 1];
                    g = arr[rowCounter + 2][cellsInRowCounter + 2];

                    theSum = a + b + c + d + e + f + g;

                    if (highestSum == null)
                    {
                        highestSum = theSum;
                    }

                    if (theSum > highestSum)
                    {
                        highestSum = theSum;
                    }
                }
            }
        }

        Console.WriteLine(highestSum);
    }
}


// 12

class Student : Person{
    private int[] testScores;

    /*
    *   Class Constructor
    *
    *   Parameters:
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here

    public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
    {
        this.testScores = scores;
    }

    /*
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here

    public char Calculate()
    {
        double theAverage = testScores.Average();
        if (theAverage < 40)
        {
            return 'T';
        }
        else if (theAverage < 55)
        {
            return 'D';
        }
        else if (theAverage < 70)
        {
            return 'P';
        }
        else if (theAverage < 80)
        {
            return 'A';
        }
        else if (theAverage < 90)
        {
            return 'E';
        }
        else if (theAverage <= 100)
        {
            return 'O';
        }
        return 'X';
    }
}



// 13

//Write MyBook class


using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected  String author;

    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

class MyBook: Book
{
    protected int Price;

    public MyBook(string title, string author, int price): base(title, author)
    {
        Price = price;

    }

    public override void display()
    {
        string wholeString = $"Title: {this.title}\nAuthor: {this.author}\nPrice: {this.Price}";
        Console.WriteLine(wholeString);
    }
}


// 14



using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

// Add your code here
public Difference(int[] theElements)
{
    this.elements = theElements;

}

public void computeDifference()
{
    int top = this.elements.Max();
    int bottom = this.elements.Min();
    this.maximumDifference = top - bottom;

}

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}


// 15





using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }

}
class Solution {

public static Node insert(Node head,int data)
{
  //Complete this method

    Node nodeToAdd = new Node(data);

    if (head == null)
    {
        head = nodeToAdd;
    }
    else
    {
        Node current = head;
        while (current.next != null)
        {
            current = current.next;
        }

        current.next = nodeToAdd;

    }
    return head;
}


public static void display(Node head)
{
    Node start=head;
    while(start!=null)
    {
        Console.Write(start.data+" ");
        start=start.next;
    }
}
static void Main(String[] args) {

    Node head=null;
    int T=Int32.Parse(Console.ReadLine());
    while(T-->0){
        int data=Int32.Parse(Console.ReadLine());
        head=insert(head,data);
    }
    display(head);
}
}


// 16

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        try
        {
            int convertedS = Convert.ToInt32(S);
            Console.WriteLine(convertedS);
        }
        catch(System.FormatException)
        {
            Console.WriteLine("Bad String");
        }

    }
}


// 17



using System;
//Write your code here


class Calculator
{
    public int power (int theN, int theP)
    {
        if (theN < 0 || theP < 0)
        {
            throw new System.ArgumentException("n and p should be non-negative");
        }

        return Convert.ToInt32(Math.Pow(theN, theP));

    }
}

class Solution{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }



    }
}


//18
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    //Write your code here
    public Stack<char> theStack = new Stack<char>();
    public Queue<char> theQueue = new Queue<char>();

    public void pushCharacter(char ch)
    {
        theStack.Push(ch);
    }

    public char popCharacter()
    {
        return theStack.Pop();
    }

    public void enqueueCharacter(char ch)
    {
        theQueue.Enqueue(ch);
    }

    public char dequeueCharacter()
    {
        return theQueue.Dequeue();
    }


        static void Main(String[] args) {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s) {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++) {
                if (obj.popCharacter() != obj.dequeueCharacter()) {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome) {
                Console.Write("The word, {0}, is a palindrome.", s);
            } else {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }



// 19 interfaces
//Write your code here

using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}

class Calculator : AdvancedArithmetic {
    public int divisorSum(int n){
        int theSum = 0;
        for (int counter = 1; counter <= n; counter++){
            if (n % counter == 0){
                theSum += counter;
            }
        }
        return theSum;
    }
}
class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}

//20 sorting

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);

        int totalSwapCounter = 0;

        bool didItSwap = true;


        while (didItSwap == true)
        {
            int eachSwapCounter = 0;
            for (int arrIdx = 0; arrIdx < a.Length - 1; arrIdx++)
            {
                if (a[arrIdx] > a[arrIdx + 1])
                {
                    int tmp = a[arrIdx];
                    a[arrIdx] = a[arrIdx + 1];
                    a[arrIdx + 1] = tmp;

                    totalSwapCounter++;
                    eachSwapCounter++;
                }
            }

            if (eachSwapCounter == 0)
            {
                didItSwap = false;
            }

        }

        Console.WriteLine($"Array is sorted in {totalSwapCounter} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Length - 1]}");

    }
}


// 21
using System;

class Printer
{
public static void PrintArray<T>(T[] array)
{
    foreach (T thing in array)
    {
        Console.WriteLine(thing);
    }
}

static void Main(string[] args)
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] intArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        intArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    n = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        stringArray[i] = Console.ReadLine();
    }

    PrintArray<Int32>(intArray);
    PrintArray<String>(stringArray);
}
}

// from day 22
// had to look it up.  spent at least 3 hours on it.

using System;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{
static int getHeight(Node root)
{
    if (root == null)
    {
        return -1;
    }

    return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
}

static Node insert(Node root, int data){
    if(root==null){
        return new Node(data);
    }
    else{
        Node cur;
        if(data<=root.data){
            cur=insert(root.left,data);
            root.left=cur;
        }
        else{
            cur=insert(root.right,data);
            root.right=cur;
        }
        return root;
    }
}
static void Main(String[] args){
    Node root=null;
    int T=Int32.Parse(Console.ReadLine());
    while(T-->0){
        int data=Int32.Parse(Console.ReadLine());
        root=insert(root,data);
    }
    int height=getHeight(root);
    Console.WriteLine(height);

}
}


//22 another answer, not mine

static int getHeight(Node root){
  //Write your code here
    if(root == null){
        return 0;
    }

    if(root.left == null && root.right == null){
        return -1;
    }

    int left = getHeight(root.left);
    int right = getHeight(root.right);

    if(left > right){
        return 1 + left;
    } else {
        return 1 + right;
    }
}

//23.  so I looked for an answer, got one that was close, and then fucking went line by line
// with it until I understood it.  And then I wrote this from scratch:
// binary search tree breadth first traversal level first traversal bst

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

    static void levelOrder(Node root){
    List<Node> theList = new List<Node>();
    theList.Add(root);

    Node current = root;

    while (theList.Count() > 0)
    {
        if (current.left != null)
        {
            theList.Add(current.left);
        }
        if (current.right != null)
        {
            theList.Add(current.right);
        }
        Console.Write($"{theList[0].data} ");
        theList.RemoveAt(0);
        current = theList[0];

    }
}

static Node insert(Node root, int data){
    if(root==null){
        return new Node(data);
    }
    else{
        Node cur;
        if(data<=root.data){
            cur=insert(root.left,data);
            root.left=cur;
        }
        else{
            cur=insert(root.right,data);
            root.right=cur;
        }
        return root;
    }
}
static void Main(String[] args){
    Node root=null;
    int T=Int32.Parse(Console.ReadLine());
    while(T-->0){
        int data=Int32.Parse(Console.ReadLine());
        root=insert(root,data);
    }
    levelOrder(root);

}
}
