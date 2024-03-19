using Real_Estate.Models;

List <Property> properties = new List<Property>();

Property house1 = new(1, "House One", "Rua do X", 155000f, 3, Real_Estate.Models.Type.House, Locale.Urban, DealType.Sale);
Property ap1 = new(2, "Apartment One", "Rua do Y", 2500f, 2, Real_Estate.Models.Type.Apartment, Locale.Urban, DealType.Rent);
Property farm1 = new(3, "Farm One", "Rua do Z", 455000f, 4, Real_Estate.Models.Type.Farm, Locale.Rural, DealType.Sale);

properties.Add(house1);
properties.Add(ap1);
properties.Add(farm1);
house1.ImagePaths.Add("propertyPictures\\house1_image.jpg");
house1.ImagePaths.Add("propertyPictures\\house1_image2.jpg");
house1.ImagePaths.Add("propertyPictures\\house1_image3.jpg");
ap1.ImagePaths.Add("propertyPictures\\ap1_image.jpg");
farm1.ImagePaths.Add("propertyPictures\\farm1_image.jpg");

foreach (var p in properties)
{
    Console.WriteLine($@"Property [{p.PropertyId}]
    Street: {p.PropertyAddress}
    Value: {p.PropertyValue}
    Rooms: {p.PropertyRooms}
    Type: {p.PropertyType}
    Locale: {p.PropertyLocale}
    Deal type: {p.PropertyDealType}");
    foreach (var img in p.ImagePaths)
    {
        Console.WriteLine($"    Image Path: {img}");
    }
    Console.WriteLine("------------------------------------------------------");
}