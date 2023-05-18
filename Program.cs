//namespace ConsoleApp9
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Pinkodu daxil et");
//            int pinKod=int.Parse(Console.ReadLine());
//            Console.WriteLine("Balans növünü seç");
//            string BalansNovu=Console.ReadLine();


//            int balans = 350;
//            int cekmekIstediyinizMebleg;
//            int qaliqBalans;
//            int[] pulNovleri = {100,50,20,10,5,1 };




//            Console.WriteLine("Xos gelmişsiniz! Hal hazirda balansiniz:" +balans);

//            Console.WriteLine("Çıxartmaq istədiyiniz məbləği daxil edin");
//            cekmekIstediyinizMebleg=int.Parse(Console.ReadLine());

//            if (cekmekIstediyinizMebleg> balans)
//            {
//                Console.WriteLine("Balansda yeterli mebleq yoxdu");
//            }

//            else
//            {


//                for (int i=0; i<pulNovleri.Length; i++)
//                {
//                    int count = cekmekIstediyinizMebleg / pulNovleri[i];
//                    int qaliq = cekmekIstediyinizMebleg - count * pulNovleri[i];
//                    cekmekIstediyinizMebleg = qaliq;
//                    if (count > 0)
//                    {
//                        Console.WriteLine($"{count} eded {pulNovleri[i]} ");
//                    }
//                }

//            }





//        }
//    }
//}


//int[] numbers = { 6, 9, 16, 34, 58 };
//Array.Sort(numbers, (a, b) => b - a);
//foreach (var number in numbers)
//{
//    Console.WriteLine(number + "");
//}



//Console.WriteLine("Zəhmət olmasa doğum tarixinizi daxil edin (mm/dd/yyyy):");
//DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

//DateTime currentDate = DateTime.Now;
//TimeSpan difference = currentDate.Subtract(dateOfBirth);

//int ageInYears = difference.Days / 365;

//Console.WriteLine("Sizin yaşınız: " + ageInYears);
//Console.ReadLine();

//Console.WriteLine("Anadan oldugunuz ili daxil edin (mm/dd/yyyy):");
//int il = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("yas=" + DateTime.Now.Year +"-" +il+(DateTime.Now.Year-il));t


//using System.Collections;

//var qrupYoldaslari = new Hashtable()
//{
//    { "Ad1", "Vusal "},
//{ "Ad2", "Royal"},
//{ "Ad3", "Vuqar"},

//};

//qrupYoldaslari.Remove("Ad1");

//qrupYoldaslari.Add("Ad4", "Ilkin");
//foreach (DictionaryEntry item in qrupYoldaslari)
//{
//    Console.WriteLine(item.Value);
//}






//int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int a = array[0];
//int b = array[1];

//int[] newArray = new int[array.Length - 2];

//Array.Copy(array, 2, newArray, 0, array.Length - 2);

//Console.WriteLine("İlk 2 element: " + a + ", " + b);

//Console.WriteLine("Yeni:");

//foreach (int element in newArray)
//{
//    Console.Write(element + " ");
//}



//int eded = Convert.ToInt32(Console.ReadLine());

//int eded1 = (eded / 10);
//eded = eded1 % 100;
//Console.WriteLine(eded);






  static string GetNextName(ref int id)
{
    string returnText = "Next-" + id.ToString();
    id += 1;
    return returnText;
}
static void Main(string[] args)
{
    int i = 1;
    Console.WriteLine("Previous value of integer i:" + i.ToString());
    string test = GetNextName(ref i);
    Console.WriteLine("Current value of integer i:" + i.ToString());
}




