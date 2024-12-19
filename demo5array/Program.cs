//datatype[] arrayee=new datatype
int[] numbers = new int[4];

numbers[0] = 5;
numbers[1] = 11;
numbers[2] = 14;
numbers[3] = 14;

Console.WriteLine("Index 1 :" + numbers[1]);
Console.WriteLine("length : "+numbers.Length);


for (int i = 1; i < numbers.Length; i++) 
{
    Console.WriteLine(numbers[i]);
}
//taske2 
string[] xx= new string[4];

xx[0] = "fatma";
xx[1] = "sara";
xx[2] = "mariam";
xx[3] = "nora";



//Console.WriteLine("Index 1 :" + xx[1]);
//Console.WriteLine("length : " + xx.Length);


for (int i = 1; i < xx.Length; i++)
{
    Console.WriteLine(xx[i]);
}