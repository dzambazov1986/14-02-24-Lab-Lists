int n = int.Parse(Console.ReadLine());

List<string> products = new List<string>();
string[] productsArray = new string[n];

for (int i = 0; i < n; i++)
{
    string product = Console.ReadLine();

    products.Add(product);
    productsArray[i] = product;
}
products.Sort();
for (int i = 0; i < productsArray.Length; i++)
{

    Console.WriteLine($"{i + 1}.{products[i]}");
}