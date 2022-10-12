// замена символов строки
string text = " -  Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы взяли приступом согласие прусского короля";

string Riplace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}


string newText = Riplace(text,' ', '|');
string newText2 = Riplace(text,'к', 'К');
string newText3 = Riplace(text,'с', 'С');
System.Console.WriteLine(newText);
System.Console.WriteLine(newText2);
System.Console.WriteLine(newText3);