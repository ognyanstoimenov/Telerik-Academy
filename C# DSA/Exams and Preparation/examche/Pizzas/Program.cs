namespace Pizza
{
	using System;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Collections.Generic;
	using System.Linq;

	static class Program
	{
		static void Main()
		{
			#region Menu
			var lines = @"- Mediteraneo
  - motsarela - 122g
  - domaten sos - 104g
  - presni domati - 30g
  - zeleni chushki - 69g
  - krave sirene - 195g
  - maslini - 56g
- Alfredo
  - smetana - 191g
  - motsarela - 194g
  - pileshko file - 12g
  - beybi spanak - 127g
- Vita
  - domaten sos - 59g
  - motsarela - 97g
  - beybi spanak - 147g
  - krave sirene - 28g
  - presni domati - 55g
- Margarita
  - domaten sos - 6g
  - motsarela - 152g
- Chikenita
  - domaten sos - 30g
  - motsarela - 17g
  - pileshko file - 199g
  - peperoni - 166g
  - domati - 144g
  - emental - 79g
- Dominos Spetsialna
  - domaten sos - 161g
  - motsarela - 137g
  - shunka - 181g
  - bekon - 37g
  - zeleni chushki - 158g
  - luk - 183g
  - gabi - 90g
- ChikChiRik
  - domaten sos - 133g
  - motsarela - 20g
  - krehko pile - 64g
  - topeno sirene - 166g
  - tsarevitsa - 0g
- Karbonara
  - smetana - 40g
  - motsarela - 158g
  - bekon - 141g
  - gabi - 160g
- Amerikan Hot
  - domaten sos - 82g
  - motsarela - 88g
  - peperoni - 149g
  - halapenyo - 197g
  - luk - 196g
- Gardan Klasik
  - domaten sos - 165g
  - motsarela - 165g
  - maslini - 194g
  - zeleni chushki - 123g
  - luk - 91g
  - presni domati - 86g
  - gabi - 8g
- Peperoni Klasik
  - domaten sos - 105g
  - motsarela - 98g
  - peperoni - 186g
- Barbekyu Pile
  - barbekyu sos - 195g
  - motsarela - 169g
  - bekon - 20g
  - krehko pile - 26g
- Barbekyu Klasik
  - barbekyu sos - 147g
  - motsarela - 175g
  - bekon - 150g
  - pikantno teleshko - 104g
- Nyu york
  - domaten sos - 177g
  - motsarela - 152g
  - bekon - 151g
  - chedar - 126g
  - presni gabi - 18g
- Shunka Klasik
  - domaten sos - 110g
  - motsarela - 74g
  - shunka - 26g
  - zeleni chushki - 166g
  - presni gabi - 150g
- Zverska
  - domaten sos - 147g
  - motsarela - 125g
  - shunka - 9g
  - bekon - 78g
  - pikantno teleshko - 55g
- Italianska
  - domaten sos - 32g
  - motsarela - 61g
  - pesto - 79g
  - parmezan - 132g
  - presni domati - 60g
  - bosilek - 30g
- Havay
  - domaten sos - 81g
  - motsarela - 180g
  - shunka - 90g
  - ananas - 47g
- Balgarska
  - motsarela - 45g
  - domaten sos - 175g
  - luk - 163g
  - maslini - 146g
  - zeleni chushki - 110g
  - krave sirene - 0g
  - selska nadenitsa - 195g
  - presni domati - 53g
  - rigan - 159g
- Formadzhi
  - domaten sos - 72g
  - motsarela - 98g
  - chedar - 194g
  - krave sirene - 82g
  - parmezan - 117g
- Ton
  - domaten sos - 54g
  - motsarela - 119g
  - riba ton - 190g
  - presni domati - 78g
  - luk - 36g
- Chorizana
  - domaten sos - 56g
  - motsarela - 102g
  - chorizo - 161g
  - pileshko file - 63g
  - krave sirene - 197g
  - presni domati - 17g
- Meat Mania
  - domaten sos - 1g
  - motsarela - 111g
  - shunka - 83g
  - bekon - 129g
  - teleshko - 70g
  - pileshko file - 86g
  - chorizo - 182g
- Unika
  - domaten sos - 185g
  - motsarela - 177g
  - parmezan - 114g
  - peperoni - 44g
  - gabi - 49g
  - presni domati - 86g
  - rukola - 42g
- Bene
  - domaten sos - 139g
  - kashkaval - 93g
  - shunka - 129g
  - tsarevitsa - 149g
  - maslini - 4g
- Bondzhorno
  - domaten sos - 99g
  - kashkaval - 23g
  - svinsko file - 199g
  - gabi - 86g
  - kiseli krastavichki - 91g
- Vegetarianska
  - domaten sos - 9g
  - kashkaval - 184g
  - gabi - 67g
  - chushki - 42g
  - luk - 42g
  - tsarevitsa - 124g
- Venetsiya
  - domaten sos - 148g
  - kashkaval - 47g
  - gabi - 43g
  - pusheni gardi - 32g
  - yaytse - 50g
  - luk - 122g
- Garda
  - domaten sos - 84g
  - kashkaval - 35g
  - pileshko role - 107g
  - pusheno sirene - 197g
  - chushki - 113g
  - maslini - 151g
- Kaltsone
  - domaten sos - 21g
  - kashkaval - 142g
  - shunka - 195g
  - gabi - 127g
- Kaprichoza
  - domaten sos - 40g
  - kashkaval - 22g
  - yaytse - 57g
  - presni domati - 14g
  - magadanoz - 160g
  - shunka - 10g
  - maslini - 88g
  - pusheni gardi - 22g
  - gabi - 35g
- Kompaniola
  - domaten sos - 16g
  - kashkaval - 87g
  - bekon - 111g
  - gabi - 198g
  - rigan - 95g
- Meksikana
  - domaten sos - 119g
  - kashkaval - 147g
  - gabi - 88g
  - lukanka - 155g
  - tsarevitsa - 153g
  - luk - 83g
  - lyuta chushka - 60g
- Morski darove
  - domaten sos - 89g
  - kashkaval - 66g
  - midi - 6g
  - kalmari - 175g
  - limon - 142g
  - zehtin - 113g
  - rigan - 121g
- Kastelo
  - domaten sok - 195g
  - shunka - 89g
  - bekon - 88g
  - pusheno sirene - 19g
  - kashkaval - 114g
  - pileshko role - 30g
  - maslini - 63g
  - kiseli krastavichki - 179g
- Prima Vera
  - domaten sos - 126g
  - kashkaval - 155g
  - shunka - 26g
  - gabi - 44g
  - domati - 22g
  - zehtin - 64g
  - bosilek - 4g
- Proshuto
  - domaten sos - 58g
  - kashkaval - 136g
  - shunka - 30g
  - proshuto - 100g
  - maslini - 136g
- Rimini
  - domaten sos - 55g
  - kashkaval - 81g
  - shunka - 4g
  - bekon - 23g
  - lukanka - 188g
  - chushki - 91g
  - gabi - 147g
  - tsarevitsa - 57g
  - yaytse - 60g
- San Marko
  - domaten sos - 129g
  - kashkaval - 28g
  - gabi - 106g
  - lukanka - 38g
  - pusheno sirene - 91g
  - zehtin - 62g
- Tono
  - domaten sos - 155g
  - kashkaval - 60g
  - riba ton - 131g
  - ratsi - 124g
  - luk - 100g
  - chesan - 142g
  - limon - 106g
maika ti bil".Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

			var pizzas = new Dictionary<string, List<KeyValuePair<string, int>>>();

			bool inPizza = false;
			string currPizza = "";
			var currIngredients = new List<KeyValuePair<string, int>>();
			for (int i = 0; i < lines.Length; i++)
			{
				var line = lines[i];
				if (line[0] == '-' || i == lines.Length - 1)
				{
					if (inPizza)
					{
						currIngredients.Add(new KeyValuePair<string, int>("testo", 256));
						pizzas.Add(currPizza, currIngredients);
						currIngredients = new List<KeyValuePair<string, int>>();
					}
					currPizza = line.Substring(2);
				}
				else
				{
					inPizza = true;
					line = line.Substring(4);
					var keyvalue = line.Split(new string[] { " - " }, StringSplitOptions.None);
					var key = keyvalue[0];
					var value = int.Parse(keyvalue[1].Substring(0, keyvalue[1].IndexOf('g')));
					currIngredients.Add(new KeyValuePair<string, int>(key, value));
				}
			}
			#endregion

			var inputSb = new StringBuilder();
			while (true)
			{
				var line = Console.ReadLine();
				inputSb.Append(line);
				if (line.IndexOf('.') > -1) break;
			}
			var input = inputSb.ToString();

			input = Regex.Replace(input, @"pizza|Iskam|\.", "", RegexOptions.IgnoreCase);
			input = Regex.Replace(input, @"\s+", " ").Trim();
			var inputPizzas = input.Split(new string[] { ", ", " i " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Regex.Replace(x,@"[0-9]+","").Trim());
			var output = new Dictionary<string, int>();
			foreach (var inputPizza in inputPizzas)
			{
				var pizzaAndIngredients = inputPizza.Split(new string[] { "bez" }, StringSplitOptions.RemoveEmptyEntries);
				var pizza = pizzaAndIngredients[0].Trim();
				string[] removedIngredients = pizzaAndIngredients.Skip(1).Select(x => x.Trim()).ToArray();

				foreach (var pizz in pizzas)
				{
					if (pizz.Key.ToLower() == pizza.ToLower())
					{
						foreach (var ing in pizz.Value)
						{
							bool toBeRemoved = false;
							foreach (var remIng in removedIngredients)
							{
								if (ing.Key == remIng)
								{
									toBeRemoved = true;
								}
							}
							if (!toBeRemoved)
							{
								if (output.Keys.Any(x => x == ing.Key))
								{
									output[ing.Key] += ing.Value;
								}
								else
								{
									output.Add(ing.Key, ing.Value);
								}
							}
						}
						break;
					}
				}
			}
			output = output.OrderBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);
			foreach (var item in output)
			{
				Console.WriteLine("{0}: {1}g",item.Key,item.Value);
			}
		}
	}
}