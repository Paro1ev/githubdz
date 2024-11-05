var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Order> repo = new List<Order>()
{
    new Order(1, "Вазелин", "Аптека Галоперидол", "Логинов К.Д", "Ленина 52", "Отправлен")
};

app.MapGet("/", () => repo);
app.MapPost("/", (Order ord) => repo.Add(ord));
app.MapPut("/{id}", (int id, OrderUpdateDto dto) =>
{
    Order buffer = repo.Find(ord => ord.Id == id);
    if (buffer == null)
        return Results.NotFound("Такого заказа нету");
    buffer.Status = dto.Status;
    return Results.Ok(buffer);
});
app.Run();

class OrderUpdateDto
{
    string status;

    public string Status { get => status; set => status = value; }
}

class Order 
{
    int id;
    string product;
    string sender;
    string consignee;
    string address;
    string status;

public Order(int id, string product, string sender, string consignee, string address, string status)
        {
            Id = id;
            Product = product;
            Sender = sender;
            Consignee = consignee;
            Address = address;
            Status = status;
        }    
    public int Id { get => id; set => id = value; }
    public string Product { get => product; set => product = value; }
    public string Sender { get => sender; set => sender = value; }
    public string Consignee { get => consignee; set => consignee = value; }
    public string Address { get => address; set => address = value; }
    public string Status { get => status; set => status = value; }
}