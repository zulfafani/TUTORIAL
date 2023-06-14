using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

public class Item
{
	public string name { get; set; }
	public int price { get; set; }
}
public class Program
{
	public static void Main(string[] args)
	{
		Item item = new Item{name = "pulpen", price = 2000};
		
		//Serialization konversi object ke string
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(Item));
		using (StreamWriter writer = new StreamWriter("item.xml"))
		{
			xmlSerializer.Serialize(writer, item);
		}
		
		string jsonString = JsonSerializer.Serialize(item);
		File.WriteAllText("item.json", jsonString);
		
		// Deserialized konversi string ke object
		Item deserializedItem;
		using (StreamReader reader = new StreamReader("item.xml"))
		{
			deserializedItem = (Item)xmlSerializer.Deserialize(reader);
		}
		Console.WriteLine($"Deserialized Item: {deserializedItem.name}, {deserializedItem.price}");
		
		string jsonFromFile = File.ReadAllText("item.json");
		Item deserializedItem2 = JsonSerializer.Deserialize<Item>(jsonFromFile);
		Console.WriteLine($"Deserialized Item: {deserializedItem2.name}, {deserializedItem2.price}");
	}
}