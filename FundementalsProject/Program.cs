// See https://aka.ms/new-console-template for more information

// Rastgele tahmin oyunu. Guess random integer number game
void FindRandomValue()
{
    Console.WriteLine("1-100 arasında bir sayı tuttum bakalım 5 tahmin hakkın dolmadan aklımdaki sayıyı bulabilecek misin?");
    Random random = new Random();
    int r = random.Next(1, 100);
    for (int i = 1; i <= 5; i++)
    {
        Console.Write("Tahminini alalım: ");
        int guessValue = Convert.ToInt32(Console.ReadLine());

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
int Counter(int num1, int num2, char op)
{
    int res = -1;

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
        default:
            Console.WriteLine("Geçersiz bir işlem seçtiniz!");
            break;
    }

    return res;


}
// ders ortalaması hesaplama
string CountGrade()
{
    Console.WriteLine("Öğrencinin ders notlarını giriniz.");
    double grade, res = 0;
    for (int i = 1; i < 4; i++)
    {
    control: Console.Write(i + ". Ders Notu:");
        grade = Convert.ToDouble(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Lütfen geçerli bir not giriniz.(0-100 arasında)");
            goto control;
        }
        res += grade;
    }
    res /= 3;

    if (res <= 100 && res >= 90)
        return "AA";
    else if (res < 90 && res >= 85)
        return "BA";
    else if (res < 85 && res >= 80)
        return "BB";
    else if (res < 80 && res >= 75)
        return "CB";
    else if (res < 75 && res >= 70)
        return "CC";
    else if (res < 70 && res >= 65)
        return "DC";
    else if (res < 65 && res >= 60)
        return "DD";
    else if (res < 60 && res >= 55)
        return "FD";
    else
        return "FF";
}

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
        Console.Write("Yapmak istediğiniz işlem (+,-,*,/):");
        char op = Convert.ToChar(Console.ReadLine());
        Console.Write("1.sayımız :");
        int num1 = Convert.ToInt32(Console.ReadLine());
    divideByZero: Console.Write("2.sayımız :");
     int num2 = Convert.ToInt32(Console.ReadLine());


        if (op == '/' && num2 == 0)
        {
            Console.WriteLine("Bölme işleminde sıfıra bölme hatası yaşamamak adına lütfen 2. sayıyı sıfırdan farklı giriniz!");
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


