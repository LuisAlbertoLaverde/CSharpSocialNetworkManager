using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetworkManager.Models
{
    class AppManager
    {
        public string AppTittle { get; set; }

        public AppManager()
        {
            AppTittle = "Adminsitrador de redes sociales";
            SocialNetworks = new List<SocialNetwork>();
            SocialNetworksWithGroups = new List<SocialNetworksWhitGroups>();
            InitializeSocialNetworks();
        }
        public void InitializeSocialNetworks()
        {
            SocialNetworks.Add(new SocialNetwork()
            {
                Name = "Instagram",
                Description = "Red social para intercambio de fotos y videos cortos",
                Users = new List<User>(),
                DateCreated = new DateTime(2010, 5, 20),
            });
            SocialNetworks.Add(new SocialNetwork()
            {
                Name = "Twitter",
                Description = "Red social para intercambio de mensajes cortos",
                Users = new List<User>(),
                DateCreated = new DateTime(2009, 12, 10),
            });
            SocialNetworksWithGroups.Add(new SocialNetworksWhitGroups()
            {
                Name = "Facebook",
                Description = "Red social para intercambio de fotos, videos pensamientos y debates",
                Users = new List<User>(),
                Groups=new List<string>() { "Programadores CSharp", "Amantes de la musica", "Programadores Go"},
                DateCreated = new DateTime(2012, 8, 15),
            });
        }
        public List<SocialNetwork>SocialNetworks { get; set; }
        public List<SocialNetworksWhitGroups>SocialNetworksWithGroups { get; set; }
        public String GetSocialNetWorkInformation<T>(T socialNetwork )
        {
            if (socialNetwork == null)
                return "";

            StringBuilder stringBuilder = new StringBuilder();

            var SocialNetworkItem = socialNetwork as SocialNetwork;

            stringBuilder.AppendLine($"Nombre : {SocialNetworkItem.Name}");
            stringBuilder.AppendLine($"Descripcion : {SocialNetworkItem.Description}");
            stringBuilder.AppendLine($"Año de creación : {SocialNetworkItem.DateCreated.Year}");

            if (socialNetwork is SocialNetworksWhitGroups)
            {
                var SocialNetworkWithGroupsItem = socialNetwork as SocialNetworksWhitGroups;

                stringBuilder.AppendLine($"Grupos: {string.Join(",", SocialNetworkWithGroupsItem.Groups)}");
            }

            return stringBuilder.ToString();
        }

        public String GetSocialNetWorkStats<T>(T socialNetwork)
        {
            if (socialNetwork == null)
                return "";

            StringBuilder stringBuilder = new StringBuilder();

            var SocialNetworkItem = socialNetwork as SocialNetwork;

            stringBuilder.AppendLine($"Cantidad de usuarios : {SocialNetworkItem.Users.Count}");
            stringBuilder.AppendLine($"Promedio de edad : {SocialNetworkItem.Users.Average(p=> p.Age)}");
            stringBuilder.AppendLine($"El usuario de mayor edad tiene : {SocialNetworkItem.Users.Max(p=> p.Age)} años");
            stringBuilder.AppendLine($"El usuario de menor edad tiene : {SocialNetworkItem.Users.Min(p=> p.Age)} años");

            if (socialNetwork is SocialNetworksWhitGroups)
            {
                var SocialNetworkWithGroupsItem = socialNetwork as SocialNetworksWhitGroups;

                stringBuilder.AppendLine($"Cantidad de grupos: {SocialNetworkWithGroupsItem.Groups.Count}");
            }

            return stringBuilder.ToString();
        }

    }
}
