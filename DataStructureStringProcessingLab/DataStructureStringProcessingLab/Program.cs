// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Please enter a word to reverse: ");
string userWord = Console.ReadLine();

Console.WriteLine(ReverseString(userWord));

Console.WriteLine(Reverse(userWord));

//string str = "Alligator";
//Console.WriteLine(ReverseString(str));
//Console.WriteLine(Reverse(str));


//Without using a stack
static string Reverse(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}


//With using a stack
static string ReverseString(string str)
{
    Stack<char> chars = new Stack<char>();

    foreach (char c in str)
    {
        chars.Push(c);
    }

    str = "";
    while (chars.Count != 0)
    {
        str += chars.Peek();
        chars.Pop();
    }
    return str;
}