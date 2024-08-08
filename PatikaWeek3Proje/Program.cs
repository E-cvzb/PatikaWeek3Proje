using System.ComponentModel.Design;

Console.WriteLine("Merhaba hoşgeldiniz");
Console.WriteLine("3 adet proramımız var hangisini kullanmak istiyorsunuz");
Console.WriteLine("1- Rastgele Sayı Bulma Oyunu \n2- Hesap Makinesi \n3- Ortalama Hesaplama ");
string seçim = Console.ReadLine().ToLower().Trim(); //Herhangi küçük veya büyük harf uyumsuzluğunu önlemek için bütün harfleri küçük harf kullanacak ve baştali sayıların girilmesi durumunda anlaması için de trim kullandım

if (seçim == "1- rastgele sayı bulma oyunu " || seçim == "1" || seçim == "ratgele sayı bulma oyunu")
{
    RandomNumberGame();
}
else if (seçim == "2-hesap makinesi" || seçim == "2" || seçim == "hesap makinesi")
{
    Calculator();
}
else if (seçim == "3-ortalama hesaplama" || seçim == "3" || seçim == "ortalama hesaplama")
{
    AverageCalculation();
}
else
{
    Console.WriteLine("Geçerisiz program girdiniz");
}

void RandomNumberGame()// Rastgele sayı bulma oynu döngüsü
{
    Random rnd= new Random();
    Console.WriteLine("Merhaba oyuna hoşgeldiniz ");
    Console.WriteLine("1 ile 100 arasında bir sayı seçerek bizim seçtiğimiz sayıyı bulmaya çalışacaksınız");
    Console.WriteLine("Lütfen tahmininizi giriniz");
    Console.WriteLine("Doğru tahmin yapmak için 5 tahmın hakkınız var ");
    
    int randomNumber=rnd.Next(1,101);
    



    for (int i = 1; i <= 5; i++)// 5 defa dönmesi için for döngüsü oluşturdum
    {
        int life = 5 - i;// Kalan can hakkını göstermesi için tanımlandı

        int enteredNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kalan canınız------->" +life);

        if (randomNumber < enteredNumber)
            Console.WriteLine("Daha küçük bir sayı giriniz.Lütfen tekrar sayı girniz");
        else if (enteredNumber < randomNumber)
            Console.WriteLine("Daha büyük bir sayı giriniz.Lütfen tekrar sayı giriniz");
        else
            Console.WriteLine("Tebrikler yarışmayı kazandınız ");
        if (randomNumber != enteredNumber && i == 5)
            Console.WriteLine("Yarışmayı kaybettiniz ");
        
    }
    
}

double Calculator() //Hesap makinesi
{ 

Console.WriteLine("Lütfen ilk sayınızı giriniz.");
int number1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen gimek istediğiniz 2. sayıyı giriniz");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen yapmak istediğiniz işlemi belirtiniz( + - / * )");
char process= Convert.ToChar(Console.ReadLine());

if (process == '+')
{
    double conclusion = number1 + number2;
    Console.WriteLine("Yapmış olduğunuz işlemin sonucu-------->" + conclusion);


}
else if (process == '-')
{
    double conclusion = number1 - number2;
    Console.WriteLine("Yapmış olduğunuz işemin sonucu --------> " + conclusion);

}
else if (process=='/') 
{
    if (number2 == 0)// Bölenin sıfır olası durumda tanımsız olacağı için 0 durumunu değerlendiriyoruz 
    {
        Console.WriteLine("Bölme işleminde 2. sayı 0 a eşit olnunca tanımsız işlem olur bu işlem yapılamaz");
    }
    else
    {
        double conclusion = number1 / number2;
        Console.WriteLine("Yapmış olduğunuz işlemin sonucu -------> " + conclusion);
    }
}
else if (process== '*')
    {
        double conclusion = number1 * number2;
        Console.WriteLine("Yapmış olduğunuz işlemin sonucu ------->" + conclusion);
    }
    else
    {
        Console.WriteLine("Yanlış işlem girişi yaptınız");
    }

    return process;
}

void AverageCalculation()// Not ortalaması hesaplama 
{
    Console.WriteLine("Lütfen 1. sınav notunuzu giriniz.");
    double exam1= Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Lütfen 2. sınav notunu giriniz.");
    double exam2= Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Lütfen 3.sınav notunu giriniz.");
    double exam3= Convert.ToDouble(Console.ReadLine());

    if (exam1>100 || 0> exam1)// Sınav notunun geçersiz olduğu durumu değerlendirirken aralıkları veya bağlacı ile bağlayak iki durumda değerlendirildi 
    {
        Console.WriteLine("Girmiş olduğunuz 1. sınav notu geçersizdir programı sonlanıdrıyorum.");
        return;
    }
    else if(exam2>100 || exam2<0)
     {
        Console.WriteLine("Girmiş olduğunuz 2. sınav notu geçersizdir programı sonlandırıyorum");
        return;
    }
    else if (exam3<0 || exam3 > 100)
    {
        Console.WriteLine("Girmiş olduğunuz 3. sınav notu geçersizdir programı sonlandırıyorum");
        return;
    }
    else
    {
        Console.WriteLine("Notunuz Hesaplanıyor"); 
    }

    double average= (exam1+exam2+exam3) / 3 ;
    Console.WriteLine("Not ortamanız ------>" + average);
    if (average >= 90)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı ------> AA");
    }
    else if (average <90 && average >=85)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı ------> BA");
    }
    else if (average<85 && average >= 80)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı ------> BB");
    } 
    else if(average<80 && average >= 75)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı -------> CB");
    } 
    else if (average<75 && average >= 70)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı ------> CC");
    }
    else if (average<70 && average>= 65)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı ------> DC");
    }
    else if (average<65 && average >= 60)
    {

        Console.WriteLine("Not ortalamanızın harf karşılığı ------> DD");
    }
    else if (average<60 && average >= 55)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı ------> FD");
    }
    else if (average < 55)
    {
        Console.WriteLine("Not ortalamanızın harf karşılığı ------> FF");
    }
}




