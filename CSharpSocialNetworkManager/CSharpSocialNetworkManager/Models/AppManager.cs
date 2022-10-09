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
                Name = "Twiter",
                Description = "Red social para intercambio de mensajes cortos",
                Users = new List<User>(),
                DateCreated = new DateTime(2009, 12, 10),
            });
            SocialNetworksWithGroups.Add(new SocialNetworksWhitGroups()
            {
                Name = "Facebook",
                Description = "Red social para intercambio de fotos, videos pensamientos y debates",
                Users = new List<User>(),
                DateCreated = new DateTime(2012, 8, 15),
            });
        }
        public List<SocialNetwork>SocialNetworks { get; set; }
        public List<SocialNetworksWhitGroups>SocialNetworksWithGroups { get; set; }
    }
}
