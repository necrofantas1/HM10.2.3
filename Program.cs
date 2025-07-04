#region hn10.2
using System.Text;

bool isValid = true;
char toEnd = 'x';
string userInput;
int podiiCount = 1;


StringBuilder zvit = new StringBuilder();
StringBuilder podii = new StringBuilder();

Console.WriteLine("введіть події одну за одною , (для завершення напиши x):");



while (isValid)
{
    Console.Write($"подія {podiiCount} : ");
    userInput = Console.ReadLine();


    if (userInput.ToLower() == "x")
    {
        isValid = false;
        continue;
    }

    else if (string.IsNullOrWhiteSpace(userInput))
    {

        Console.WriteLine("ви нічого не ввели...");
        podiiCount--;
        continue;
    }

    podii.AppendLine(userInput);
    podiiCount++;
}

// формування звіту
zvit.AppendLine("звіт про події");
zvit.AppendLine($"дата: {DateTime.Now.ToShortDateString()}");
zvit.AppendLine("-------------------------");
zvit.AppendLine("список подій:");
zvit.AppendLine(podii.ToString());
Console.WriteLine("-------------------------");
Console.WriteLine(zvit.ToString());


#endregion


//#region HN10.3

//const string text = "aaaa,  5555,   bbb,          lol";

//string textWithoutSpaces = text.Replace(" ", "");ss

//Console.WriteLine($"Нормалізований текст: {textWithoutSpaces}");


//#endregion


