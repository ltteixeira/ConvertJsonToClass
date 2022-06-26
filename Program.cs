using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ConvertJsonToClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\Branco\Desktop\inserts\coinmarkt\response-teste.json");
            string jsonString = r.ReadToEnd();
            Data dados = JsonConvert.DeserializeObject<Data>(jsonString);

            // não testado
            //using (StreamWriter file = File.CreateText(@"C:\Users\Branco\Desktop\inserts\coinmarkt\novo.txt"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, dados);
            //}
        }
    }
}
class Data
{
    public CryptoCurrencyList data { get; set; } = new CryptoCurrencyList();
}

class CryptoCurrencyList
{
    public List<Item> cryptoCurrencyList { get; set; } = new List<Item>();
}

class Item
{
    public int id { get; set; }

    public string name { get; set; }

    public string symbol { get; set; }

    public string slug { get; set; }

    public int cmcRank { get; set; }
}