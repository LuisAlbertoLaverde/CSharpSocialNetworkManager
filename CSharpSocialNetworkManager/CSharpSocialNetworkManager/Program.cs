// See https://aka.ms/new-console-template for more information

using CSharpSocialNetworkManager.Models;

AppManager App = new AppManager();
Console.WriteLine($"Bienvenido a {App.AppTittle}");

User User = new User(); 

Console.WriteLine("Por favor ingrese su nombre");
User.Name = Console.ReadLine();
Console.WriteLine("Por favor ingrese su correo electronico");
User.Email = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
User.Age =short.Parse(Console.ReadLine());

//name= User.Name;
//email= User.Email;
//User.Age = age; 

Console.WriteLine("Sus datos son:");
Console.WriteLine($"Nombre: {User.Name}");
Console.WriteLine($"Correo electronico: {User.Email}");
Console.WriteLine($"Edad: {User.Age}");
Console.WriteLine($"Estado activo: {User.IsActive}");
Console.WriteLine($"Fecha de ingreso: {User.DateCreated}");

