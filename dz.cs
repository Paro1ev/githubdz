var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


class order 
{
    int id;
    string product;
    string sender;
    string consignee;
    string address;
    string status;

public order(int id, string product, string sender, string consignee, string address, string status)
        {
            Id = id;
            Product = product;
            Sender = sender;
            Consignee = consignee;
            Address = address;
            Status = status;
        }    
    public Int Id { get => id; set => id = value; }
    public String Product { get => product; set => product = value; }
    public String Sender { get => sender; set => sender = value; }
    public String Consignee { get => consignee; set => consignee = value; }
    public String Address { get => address; set => address = value; }
    public String Status { get => status; set => status = value; }
}