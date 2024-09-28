internal class Program
{
    private static void Main(string[] args)
    {
        #region YazdırmaKomutlari
        //Console.WriteLine("Merhaba Dünya");
        Console.Write("Selam Dünya");

        Console.WriteLine("****** Yemek Kategorileri ********");
        Console.WriteLine();
        Console.WriteLine("1-) Çorbalar");
        Console.WriteLine("2-) Ana Yemekler");
        Console.WriteLine("3-) Soğuk Başlangıçlar");
        Console.WriteLine("4-) Salatalar");
        Console.WriteLine("5-) TaLİRAılar");
        Console.WriteLine("6-) İçecekler");
        Console.WriteLine();
        Console.WriteLine("****** Yemek Kategorileri ********");
        #endregion

        #region Variables
        //string = tür , name = değişken adı
        string name;
        name = "Umut";
        Console.WriteLine(name);

        string customerName;
        string customerSurname;
        string customerPhone;
        string customerEmail, district, city;

        customerName = "Melih";
        customerSurname = "Çınar";
        customerPhone = "905539898071";
        customerEmail = "tosun.umutt@gmail.com";
        district = "Kartal";
        city = "İstanbul";

        //Console.WriteLine("**** Rezervasyon Kartı ****");
        //Console.WriteLine();
        //Console.WriteLine("-------------------------------------------------");
        //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
        //Console.WriteLine("İletişim: " + customerPhone);
        //Console.WriteLine("Email Adresi: " + customerEmail);
        //Console.WriteLine("Adres Bilgisi: " + district + "/" + city);
        //Console.WriteLine("-------------------------------------------------");

        //Console.WriteLine();

        //customerName = "Ayşegül";
        //customerSurname = "Kaya";
        //customerPhone = "+90 400 300 80 70";
        //customerEmail = "test@gmail.com";
        //district = "Sapanca";
        //city = "Sakarya";

        //Console.WriteLine("-------------------------------------------------");
        //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
        //Console.WriteLine("İletişim: " + customerPhone);
        //Console.WriteLine("Email Adresi: " + customerEmail);
        //Console.WriteLine("Adres: " + district + "/" + city);
        //Console.WriteLine("-------------------------------------------------");

        #endregion

        #region Number Variables

        //int
        //int number = 10;
        //Console.WriteLine(number);

        int hamburgerPrice = 200;
        int cokePrice = 33;
        int waterPrice = 20;
        int friesPrice = 30;
        int pizzaPrice = 250;
        int lemonadePrice = 70;

        Console.WriteLine("**** Restoran Menü Fiyatı ****");
        Console.WriteLine();
        Console.WriteLine("-----Hamburger: " + hamburgerPrice + " LİRA");
        Console.WriteLine("-----Pizza: " + pizzaPrice + " LİRA");
        Console.WriteLine("-----Kola: " + cokePrice + " LİRA");
        Console.WriteLine("-----Limonata: " + lemonadePrice + " LİRA");
        Console.WriteLine("-----Kızartma: " + friesPrice + " LİRA");
        Console.WriteLine("-----Su: " + waterPrice + " LİRA");
        Console.WriteLine();
        Console.WriteLine("**** Restoran Menü Fiyatı ****");


        Console.WriteLine();
        int hamburgerCount;
        int cokeCount;
        int waterCount;
        int friesCount;
        int pizzaCount;
        int lemonadeCount;

        int totalHamgurgerPrice;
        int totalCokePrice;
        int totalWaterPrice;
        int totalFriesPrice;
        int totalPizzaPrice;
        int totalLemonadePrice;

        hamburgerCount = 5;
        cokeCount = 6;
        waterCount = 2;
        friesCount = 0;
        pizzaCount = 0;
        lemonadeCount = 0;

        totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
        totalCokePrice = cokeCount * cokePrice;
        totalWaterPrice = waterCount * waterPrice;
        totalLemonadePrice = lemonadeCount * lemonadePrice;
        totalFriesPrice = friesCount * friesPrice;
        totalPizzaPrice = pizzaCount * pizzaPrice;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Hamburger Tutarı : " + totalHamgurgerPrice + " LİRA");
        Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + " LİRA");
        Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + " LİRA");
        Console.WriteLine("Kola Tutarı : " + totalCokePrice + " LİRA");
        Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + " LİRA");
        Console.WriteLine("Su Tutarı : " + totalWaterPrice + " LİRA");

        Console.WriteLine();

        int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

        Console.WriteLine("Tutar : " + totalPrice + " Lira");

        #endregion


        Console.Read();

    }
}