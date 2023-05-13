using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;

int number = 109577;
string numberInString= number.ToString();
char[] lerrers= numberInString.ToArray();
int counter0= 0;
int counter1= 0;
int counter2= 0;
int counter3= 0;    
int counter4= 0;
int counter5= 0;
int counter6= 0;
int counter7= 0;    
int counter8= 0;
int counter9 =0;
Console.WriteLine(" Wynik dla liczby " + number );
foreach (char letter in lerrers)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2') 
    {
        counter2++;
    }
    else if(letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    { 
        counter4++;
    }  
    else if (letter == '5')
    {
        counter5++; 
    }
    else if (letter == '6')
    {
        counter6++;
    }  
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if(letter == '9')
    {
        counter9++;
    }
    
}


Console.WriteLine("0 => " + counter0 + "\n1 => " + counter1 + "\n2 => " + counter2 + "\n3 => " + counter3 + "\n4 => " + counter4 + "\n5 => " + counter5 + "\n6 => " + counter6 + "\n7 => " + counter7 + "\n8 => " + counter8 + "\n9 => " + counter9 );
