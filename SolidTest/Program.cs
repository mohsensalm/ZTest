using SolidTest;
MotorInsurance motorInsurance = new PrivateCarInsurance();
Console.WriteLine("PrivateCarInsurance => PassengerCover => " + motorInsurance.GetPassengerCover());

motorInsurance = new TwoWheelerInsurance();
Console.WriteLine("TwoWheelerInsurance => PassengerCover => " + motorInsurance.GetPassengerCover());

motorInsurance = new CommercialVehicleInsurance();
Console.WriteLine("CommercialVehicleInsurance => PassengerCover => " + motorInsurance.GetPassengerCover());

Console.ReadKey();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
