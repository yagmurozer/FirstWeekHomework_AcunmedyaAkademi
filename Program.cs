using System.Text.RegularExpressions;

// 1- Sayının pozitif, negatif veya sıfır olduğunu belirleme
Console.WriteLine("Lütfen sayıyı girin:");
int num = int.Parse(Console.ReadLine()); 

if (num < 0)
{
    Console.WriteLine(num + " sayısı negatiftir.");
}
else if (num > 0)
{
    Console.WriteLine(num + "sayısı pozitiftir.");
}
else
{
    Console.WriteLine(num + "sıfıra eşittir.");
}



// 2- Gün ismi belirleme
Console.WriteLine("Lütfen haftanın kaçıncı günü olduğunu yazınız:");
int n = int.Parse(Console.ReadLine()); //haftanın kaçıncı günü olduğu bilgisini alır

while (n > 7 || n < 1)
{
    Console.WriteLine("Geçersiz sayı. Lütfen yeniden girin:");
    n = int.Parse(Console.ReadLine());
}

string day = null;
switch (n) 
{
    case 1: 
        day = "Pazartesi"; 
        break;
    case 2: 
        day = "Salı"; 
        break;
    case 3: 
        day = "Çarşamba"; 
        break;
    case 4: 
        day = "Perşembe"; 
        break;
    case 5: 
        day = "Cuma"; 
        break;
    case 6: 
        day = "Cumartesi"; 
        break;
    case 7: 
        day = "Pazar";
        break;
}

    Console.WriteLine(day + " günüdür.");




// 3- Hesap makinesi
Console.WriteLine("Birinci sayıyı yazın:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı yazın:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("+, -, / ve * işlemlerinden birini seçin:");
char process = Convert.ToChar(Console.ReadLine());

double result = 0;
switch (process)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Geçersiz işlem!");
        break;

}

Console.WriteLine("Sonuç:" + result);



// 4- üç sayıdan en büyüğünü bulma
Console.WriteLine("lütfen 1. sayıyı girin");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("lütfen 2. sayıyı girin");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("lütfen 3. sayıyı girin");
double num3 = Convert.ToDouble(Console.ReadLine());

double maxnum = 0;
if (num1 > num2 && num1 > num3)
{
    maxnum = num1;
}
else if (num2 > num1 && num2 > num3)
{
    maxnum = num2;
}
else
{
    maxnum = num3;
}

Console.WriteLine("En büyük olan sayı:" + maxnum); 



// 5- şifre güçlülüğü kontrol etme
Console.WriteLine("Şifreyi giriniz:");
string password = Console.ReadLine();

while (!PasswordControl(password))
{
    Console.WriteLine("Şifreyi tekrar giriniz:");
    password = Console.ReadLine();
}    
bool PasswordControl(string password)
{
    bool hasUpperCase = password.Any(char.IsUpper);
    char[] specialChar = { '@', ',', '.', '#', '$', '%', '/', '*', '-', '_' };
    bool hasSpecialChar = password.Any(c => specialChar.Contains(c));


    if (password.Length < 8)
    {
        Console.WriteLine("Şifre en az 8 karakter içermelidir!");
        return false;
    }
    else if (!hasUpperCase)
    {
        Console.WriteLine("Şifre en az bir tane büyük harf içermelidir!");
        return false;
    }
    else if (!hasSpecialChar)
    {
        Console.WriteLine("Şifre en az  1 tane @, /, $, % gibi özel karakter içermelidir!");
        return false;
    }
    else
    {
        Console.WriteLine("Şifre oluşturuldu.");
        return true;
    }
}

// Regex sınıfı ile çözümü:
Console.Write("Lütfen bir şifre girin: ");
string password = Console.ReadLine();

bool length = sifre.Length >= 8;
bool hasUpperCase = Regex.IsMatch(password, "[A-Z]");
bool hasSpecialchar = Regex.IsMatch(password, "[@#$%]");

if (length && hasUpperCase && hasSpecialchar)
{
    Console.WriteLine("Şifre güçlü.");
}
else
{
    Console.WriteLine("Şifre zayıf. Eksikler:");

    if (!length)
        Console.WriteLine("- Şifre en az 8 karakter uzunluğunda olmalı.");

    if (!hasUpperCase)
        Console.WriteLine("- Şifre en az bir büyük harf içermeli.");

    if (!hasSpecialchar)
        Console.WriteLine("- Şifre en az bir özel karakter (@, #, $, %) içermeli.");
}
