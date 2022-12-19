using BlazorNotificationCounter.Data;

namespace BlazorNotificationCounter.Services
{
    public class ProductsServices:IProductsServices
    {
        public List<Product> products = new List<Product>
    {
        new Product{Id=1,
            Title="Galexy S22",
            Discription="This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer",
            ImageUrl="/images/fah0fo6vqayjk5j-1200x675.jpg",
            Qte=0,
            Price=2000,
            Category="Smartphone"
        },
         new Product{Id=2,
            Title="SAMSUNG GALAXY Z",
            Discription="Ecran pliable intérieur 6.7’’ AMOLED 2X - Ecran couverture 1.9 - Affichage: 120 Hz écran principal - Processeur: Octa Core Qualcomm SM8350 Snapdragon 888 (5 nm+) (1x2,84 GHz Kryo 680 & 3x2,42 GHz Kryo 680 & 4x1,80 GHz Kryo 680) - Système d'exploitation: Android 11 - Mémoire RAM: 8 Go - Stockage: 256 Go",
            ImageUrl="/images/sm-zflip3-bk.jpg",
            Qte=0,
            Price=36900,
            Category="Smartphone"
        },
         new Product{Id=3,
            Title="iPhone 12",
            Discription="The new finish complements the beautiful flat-edge design of iPhone 12, which features an advanced dual-camera system, Super Retina XDR display with the Ceramic Shield front cover, A14 Bionic, and 5G",
            ImageUrl="/images/iphone-12.jpg",
            Qte=0,
            Price=4000,
            Category="Smartphone"
        },
         new Product{Id=4,
            Title="Galexy S22",
            Discription="This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer",
            ImageUrl="/images/fah0fo6vqayjk5j-1200x675.jpg",
            Qte=0,
            Price=2000,
            Category="Smartphone"
        },
         new Product{Id=5,
            Title="SAMSUNG GALAXY Z",
            Discription="Ecran pliable intérieur 6.7’’ AMOLED 2X - Ecran couverture 1.9 - Affichage: 120 Hz écran principal - Processeur: Octa Core Qualcomm SM8350 Snapdragon 888 (5 nm+) (1x2,84 GHz Kryo 680 & 3x2,42 GHz Kryo 680 & 4x1,80 GHz Kryo 680) - Système d'exploitation: Android 11 - Mémoire RAM: 8 Go - Stockage: 256 Go",
            ImageUrl="/images/sm-zflip3-bk.jpg",
            Qte=0,
            Price=36900,
            Category="Smartphone"
        },
         new Product{Id=6,
            Title="iPhone 12",
            Discription="The new finish complements the beautiful flat-edge design of iPhone 12, which features an advanced dual-camera system, Super Retina XDR display with the Ceramic Shield front cover, A14 Bionic, and 5G",
            ImageUrl="/images/iphone-12.jpg",
            Qte=0,
            Price=4000,
            Category="Smartphone"
        },
         new Product{Id=7,
            Title="Galexy S22",
            Discription="This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer",
            ImageUrl="/images/fah0fo6vqayjk5j-1200x675.jpg",
            Qte=0,
            Price=2000,
            Category="Smartphone"
        },
         new Product{Id=8,
            Title="SAMSUNG GALAXY Z",
            Discription="Ecran pliable intérieur 6.7’’ AMOLED 2X - Ecran couverture 1.9 - Affichage: 120 Hz écran principal - Processeur: Octa Core Qualcomm SM8350 Snapdragon 888 (5 nm+) (1x2,84 GHz Kryo 680 & 3x2,42 GHz Kryo 680 & 4x1,80 GHz Kryo 680) - Système d'exploitation: Android 11 - Mémoire RAM: 8 Go - Stockage: 256 Go",
            ImageUrl="/images/sm-zflip3-bk.jpg",
            Qte=0,
            Price=36900,
            Category="Smartphone"
        },
         new Product{Id=9,
            Title="iPhone 12",
            Discription="The new finish complements the beautiful flat-edge design of iPhone 12, which features an advanced dual-camera system, Super Retina XDR display with the Ceramic Shield front cover, A14 Bionic, and 5G",
            ImageUrl="/images/iphone-12.jpg",
            Qte=0,
            Price=4000,
            Category="Smartphone"
        }
    };

        public async Task<List<Product>>GetProducts()
        {
          return products;
        }

        public async Task<Product>GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }


    }
}
