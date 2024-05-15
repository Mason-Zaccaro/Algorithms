//17. Список товаров, имеющихся на складе, включает в себя наименование товара,
// количество единиц товара, цену единицы и дату поступления товара на склад.
// Вывести список товаров, стоимость которых превышает 100 000 рублей.

class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime DateAdd { get; set; }

    public decimal TotalCost => Quantity * Price;
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Товар_1", Quantity = 10, Price = 10000, DateAdd = new DateTime(2024, 3, 15) },
            new Product { Name = "Товар_2", Quantity = 5, Price = 8000, DateAdd = new DateTime(2024, 3, 10) },
            new Product { Name = "Товар_3", Quantity = 20, Price = 6000, DateAdd = new DateTime(2024, 3, 18) },
            new Product { Name = "Товар_4", Quantity = 8, Price = 12000, DateAdd = new DateTime(2024, 3, 5) }
        };

        Stack<Product> expensiveProducts = new Stack<Product>();

        foreach (var product in products)
        {
            if (product.TotalCost >= 100000)
            {
                expensiveProducts.Push(product);
            }
        }

        Console.WriteLine("Список товаров, стоимостью больше 100 000 руб:");
        while (expensiveProducts.Count > 0)
        {
            var product = expensiveProducts.Pop();
            Console.WriteLine($"Наименование: {product.Name}, Количество: {product.Quantity}, " +
                              $"Цена за единицу: {product.Price}, Дата поступления: {product.DateAdd}");
        }
    }
}