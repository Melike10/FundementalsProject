// See https://aka.ms/new-console-template for more information

// 3 farklı method kullanmak istedim. 1- hem parametre almayıp hem değer döndürmeyen, parametre almayıp değer döndüren, hem parametre alıp hem değer döndüren.

Console.WriteLine("Merhaba, 3 farklı program ile karşınızdayız. Seçtiğiniz programın numarasını girerek işleme devam edebilirsiniz. Programlarımız: \n 1- Rastgele Sayı Bulma Oyunu\r\n\r\n 2- Hesap Makinesi\r\n\r\n 3- Ortalama Hesaplama");

// kullanıcıdan seçtiği programı alıyoruz.
char p = Convert.ToChar(Console.ReadLine());
switch (p)
{
    case '1':
        FindRandomValue();
        break;
    case '2':
        // kullanıcıdan sayıları ve işlemi almamız gerekiyor.

        char op;
        do
        {
            Console.Write("Yapmak istediğiniz işlem (+,-,*,/): ");
            op = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (op != '+' && op != '-' && op != '*' && op != '/');

        Console.Write("1.sayımız :");
        int num1 = Convert.ToInt32(Console.ReadLine());
    divideByZero: Console.Write("2.sayımız :");
        int num2 = Convert.ToInt32(Console.ReadLine());


        if (op == '/' && num2 == 0)
        {
            Console.WriteLine("Bölme işleminde sıfıra bölme hatası yaşamamak adına lütfen 2. sayıyı sıfırdan farklı giriniz!");
            // goto yapısını da kullanmak istedim. Fakat do while daha temiz kod.
            goto divideByZero;

        }

        Console.WriteLine("İşlemin sonucu " + Counter(num1, num2, op));
        break;

    case '3':

        Console.WriteLine("Öğrencinin not ortalaması = " + CountGrade());
        break;

    default:
        Console.WriteLine("Geçerli bir bilgi girmediniz.1,2 veya 3 girmelisiniz.");
        break;


}



// Rastgele tahmin oyunu. Guess random integer number game
void FindRandomValue()// method değer almıyor ve döndürmüyor 
{
    Console.WriteLine("1-100 arasında bir sayı tuttum bakalım 5 tahmin hakkın dolmadan aklımdaki sayıyı bulabilecek misin?");
    Random random = new Random();
    int r = random.Next(1, 101);
    for (int i = 1; i <= 5; i++)
    {
        Console.Write("Tahminini alalım: ");
        if (!int.TryParse(Console.ReadLine(), out int guessValue))
        {
            Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen geçerli bir sayı giriniz.");
            i--;
            continue;
        }

        if (guessValue == r)
        {

            Console.WriteLine("Tebrikler, sayıyı bildiniz.");
            break;
        }
        else if (i == 5 && guessValue != r)
        {
            Console.WriteLine("Maalesef haklarınız bitti ve tuttuğum sayıyı bulamadınız. Aklımdaki sayı = " + r);
            break;
        }
        else if (guessValue < r)

            Console.WriteLine("Daha yüksek bir sayı söylemeliydin. Kalan canınız " + (5 - i));

        else

            Console.WriteLine("Daha düşük bir sayı söylemeliydin. Kalan canınız " + (5 - i));





    }

}
// hesap makinesi
double Counter(int num1, int num2, char op)// method değer alıyor ve döndürüyor 
{
    double res = 0;

    switch (op)
    {
        case '+':
            res = num1 + num2;
            break;
        case '-':
            res = num1 - num2;
            break;
        case '*':
            res = num1 * num2;
            break;
        case '/':
            res = num1 / num2;
            break;

    }

    return res;


}
// ders ortalaması hesaplama
string CountGrade()// değer almayıp string dönen method
{
    Console.WriteLine("Öğrencinin ders notlarını giriniz.");
    double total = 0;
    for (int i = 1; i < 4; i++)
    {

        double grade;
        do
        {
            Console.Write($"{i}. Ders Notu: ");
        } while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100);

        total += grade;
    }
    double average = total / 3;

    /* if (average >= 90)
         return "AA";
     else if (average >= 85)
         return "BA";
     else if (average >= 80)
         return "BB";
     else if (average >= 75)
         return "CB";
     else if (average >= 70)
         return "CC";
     else if (average >= 65)
         return "DC";
     else if (average >= 60)
         return "DD";
     else if (average >= 55)
         return "FD";
     else
         return "FF";*/
    // daha hızlı olması ve farklı olması adına switch ile düzenledim.chatgbt yardımı alınmıştır :) 
    return average switch
    {
        >= 90 => "AA",
        >= 85 => "BA",
        >= 80 => "BB",
        >= 75 => "CB",
        >= 70 => "CC",
        >= 65 => "DC",
        >= 60 => "DD",
        >= 55 => "FD",
        _ => "FF",
    };
}


