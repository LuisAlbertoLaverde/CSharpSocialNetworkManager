// See https://aka.ms/new-console-template for more information

using CSharpSocialNetworkManager.Models;

AppManager app = new AppManager();
Console.WriteLine($"Bienvenido a {app.AppTittle}");

User User = new User();
Console.WriteLine("Redes sociales disponibles");
foreach (var item in app.SocialNetworks)
{
    Console.WriteLine($"{item.Name}");
}
foreach (var item in app.SocialNetworksWithGroups)
{
    Console.WriteLine($"{item.Name}");
}
Console.WriteLine("Escriba el nombre de la red social a la que desea ingresar");
string socialNetworkName = Console.ReadLine();
foreach (var item in app.SocialNetworks)
{
    if (item.Name.ToLower() == socialNetworkName.ToLower())
    {
        Console.WriteLine(app.GetSocialNetWorkInformation(item));
    }
}
foreach (var item in app.SocialNetworksWithGroups)
{
    if (item.Name.ToLower() == socialNetworkName.ToLower())
    {
        Console.WriteLine(app.GetSocialNetWorkInformation(item));
    }

}
return;

Console.WriteLine("Por favor ingrese su nombre");
User.Name = Console.ReadLine();
Console.WriteLine("Por favor ingrese su correo electronico");
User.Email = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
User.Age =short.Parse(Console.ReadLine());

//name= User.Name;
//email= User.Email;
//User.Age = age; 

if (User.IsValid())
{
    Console.WriteLine("Sus datos son:");
    Console.WriteLine($"Nombre: {User.Name}");
    Console.WriteLine($"Correo electronico: {User.Email}");
    Console.WriteLine($"Edad: {User.Age}");
    Console.WriteLine($"Estado activo: {User.IsActive}");
    Console.WriteLine($"Fecha de ingreso: {User.DateCreated}");
}
else
    Console.WriteLine("Los datos del usuario no son validos");


