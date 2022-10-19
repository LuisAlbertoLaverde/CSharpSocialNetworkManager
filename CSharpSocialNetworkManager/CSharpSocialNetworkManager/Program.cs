// See https://aka.ms/new-console-template for more information

using CSharpSocialNetworkManager.Models;
using System.Linq;


AppManager app = new AppManager();
Console.WriteLine($"Bienvenido a {app.AppTittle}");

while (true)
{
    User User = new User();
    Console.WriteLine("Redes sociales disponibles");

    foreach (var item in app.SocialNetworks.Concat(app.SocialNetworksWithGroups))
    {
        Console.WriteLine($"{item.Name}");
    }
    Console.WriteLine("Escriba el nombre de la red social a la que desea ingresar");
    string socialNetworkName = Console.ReadLine();

    var SocialNetworkSelected=app.SocialNetworks.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName);

    {
        Console.Write(app.GetSocialNetWorkInformation(SocialNetworkSelected));
    }        

    var SocialNetworkwithGroupsSelected = app.SocialNetworksWithGroups.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName);

    {
        Console.Write(app.GetSocialNetWorkInformation(SocialNetworkwithGroupsSelected));
    }

    Console.WriteLine("");
    Console.WriteLine("1=Agregar nuevo usuario, 2=Para las estadisticas");

    var optionSelected= int.Parse(Console.ReadLine());

    switch (optionSelected)
    {
        case 1:
            {
                Console.WriteLine("Por favor ingrese su nombre");
                User.Name = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su correo electronico");
                User.Email = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su edad");
                User.Age = short.Parse(Console.ReadLine());

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
                if (SocialNetworkSelected!=null)
                {
                    int indexElement = app.SocialNetworks.IndexOf(SocialNetworkSelected);
                    app.SocialNetworks[indexElement].Users.Add(User);
                }
                if (SocialNetworkwithGroupsSelected!=null)
                {
                    int indexElement = app.SocialNetworksWithGroups.IndexOf(SocialNetworkwithGroupsSelected);
                    app.SocialNetworksWithGroups[indexElement].Users.Add(User);
                }
            }
            break;
        case 2:
            if (SocialNetworkSelected !=null)
            {
                Console.WriteLine(app.GetSocialNetWorkStats(SocialNetworkSelected));   
            }
            if (SocialNetworkwithGroupsSelected !=null)
            {
                Console.WriteLine(app.GetSocialNetWorkStats(SocialNetworkwithGroupsSelected));
            }
            break;
    }
}



