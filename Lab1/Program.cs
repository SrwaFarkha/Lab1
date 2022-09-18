using System.Numerics;
Main();

static void Main()
{
    Console.WriteLine("Write a string: "); //uppmanar att mata in en sträng
    string input1 = Console.ReadLine();
    Console.Clear(); // tar bort strängen innan subStringCheker körs
    SubStringChecker(input1); //anropar SubStringCheker metoden
}

static void SubStringChecker(string text) //SubStringCheker retunerar inget. Tar in text i metoden
{
    long sum = 0;    

    for (int i = 0; i < text.Length; i++) //Loopar igenom text som vi tog in i metoden
    {
        if (Char.IsNumber(text,i)) //Kollar om det finns nummer i text
        {

            for (int j = i + 1 ; j < text.Length; j++) //Kollar elementet ett steg före i yttre loopen
            {
                if (!Char.IsNumber(text, j)) //Kollar om det inte finns nummer i text. Om det inte finns breakar vi
                {
                    break;  
                }
                if (text[j] == text[i]) //Om det finns nummer och element i och j är samma fortsätt..
                {
                    string subString1 = text.Substring(0, i); //Tar ut delsträng ur strängen och färgar om
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(subString1);

                    string subString2 = text.Substring(i, j - i + 1);//Tar ut matchade start/slut siffra som delsträng
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(subString2);

                    string subString3 = text.Substring(j + 1, text.Length - j - 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(subString3);

                    sum = sum + long.Parse(subString2);
                    break;
                }
            }
        }
    }
    Console.WriteLine();//Tom rad
    Console.WriteLine("The sum of the string is: " + sum ); //skriver ut summan

}