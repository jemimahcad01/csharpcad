
class Program{


    static void Main(string [] arg)
{
    Console.WriteLine("Welcome to C# Method");
    printMSG();
    printmethod();
    printmethodwith();
    printmsgto();
    voidprintwith();
    voidvoidprintwith();
    returnmsg();
    methodmsg();
    returnmsgstring(); 

}

    static void printMSG()
    {
        Console.WriteLine("C# is printed");
    }
   
    static void printmethod()
    {
        Console.WriteLine("welcome");
    }
   
static void printmethodwith()
{
    Console.WriteLine("hello");
}
 
 static void printmsgto()
 {
    Console.WriteLine("welcome to c# method to learn");
 }


static void voidprintwith()
{
    string name ="cloud developer";
    Console.WriteLine(name);
    if(name=="cloud developer")
    {
        Console.WriteLine("value printed voidprint is correct");
    }
    else
    {
        Console.WriteLine("value printed voidprint is wrong");
    }
}




static void voidvoidprintwith()
{
    string name ="web designer";
    Console.WriteLine(name);
    if(name=="web designer")
    {
        Console.WriteLine("word start with w is correct");
    }
    else
    {
        Console.WriteLine("word start with d is wrong");
    }
}


static void returnmsg(){
    string name ="cadbatch2 is cloud developer";
   Console.WriteLine(name);
    
}

static int methodmsg()
{
 int batchnumber=01;
 return batchnumber;
}

static string  returnmsgstring()
{
    string name ="cloud application developer";
    return name;
}











}