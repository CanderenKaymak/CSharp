using Bogus.DataSets;
using Project.DAL.Context;
using Project.MODEL;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Strategy
{
    public class MyInitializer : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            #region MyCode
          

            ////menü için sahte girişler
            //foreach (Category item in categories)
            //{
            //    if (item.CategoryName == "Başlangıçlar")
            //    {
            //        List<SubCategory> subCategories = new List<SubCategory>
            //        {
            //            new SubCategory{SubName="Çorbalar",SubDescription="Kaşıklamaya Doyamayacaksınız"},
            //            new SubCategory{SubName="Salatalar",SubDescription="Anadolunun zengin yeşillikleriyle donatılmış harika eşlikçiler"}

            //        };
            //        context.SaveChanges();
            //    }
            //    else if (item.CategoryName == "Ara Sıcaklar")
            //    {
            //        List<Product> products = new List<Product>
            //        {
            //            new Product
            //            {
            //                ProductName ="Fellah Köfte",
            //                ProductContent ="Meat",
            //                ProductRegion =MODEL.Enum.Region.Marmara,
            //                ImagePath=new Images("tr").Food(),
            //                UnitPrice =200

            //            },
            //            new Product
            //            {
            //                ProductName ="Sarma",
            //                ProductContent ="Yaprak, et,pirinç",
            //                ProductRegion =MODEL.Enum.Region.Ege,
            //                ImagePath=new Images("tr").Food(),
            //                UnitPrice =150
            //            },
            //            new Product
            //            {
            //                ProductName ="Enginar Saçması",
            //                ProductContent ="Enginar ve sebzeler",
            //                ProductRegion =MODEL.Enum.Region.Akdeniz,
            //                ImagePath=new Images("tr").Food(),
            //                UnitPrice =80
            //            },
            //            new Product
            //             {
            //                ProductName ="Hamsilik",
            //                ProductContent ="Hamsi ve patates",
            //                ProductRegion =MODEL.Enum.Region.Karadeniz,
            //                ImagePath=new Images("tr").Food(),
            //                UnitPrice =100
            //            },
            //            new Product
            //             {
            //                ProductName ="Yeşil Mercimek Köftesi",
            //                ProductContent ="Yeşil Mercimek, Taze Soğan",
            //                ProductRegion =MODEL.Enum.Region.IcAnadolu,
            //                ImagePath=new Images("tr").Food(),
            //                UnitPrice =90
            //            },
            //            new Product
            //            {

            //                ProductName ="Kağıt Döner",
            //                ProductContent ="Et",
            //                ProductRegion =MODEL.Enum.Region.Dogu,
            //                ImagePath=new Images("tr").Food(),
            //                UnitPrice =180

            //            },
            //            new Product
            //             {
            //                ProductName ="Beyran",
            //                ProductContent ="Enginar ve sebzeler",
            //                ProductRegion =MODEL.Enum.Region.Guneydogu,
            //                ImagePath=new Images("tr").Food(),
            //                UnitPrice =160
            //            },

            //        };

            //        context.SaveChanges();
            //    }
            //    else if (item.CategoryName == "Ana Yemekler")
            //    {
            //        List<SubCategory> subCategories = new List<SubCategory>
            //        {
            //        new SubCategory { SubName = "Etli Yemekler", SubDescription = "Et Yemekleri", ImagePath = new Images("tr").Food() },
            //        new SubCategory{SubName="Sebzeli Yemekler", SubDescription="Sebze Yemekleri",ImagePath=new Images("en").Food()}

            //        };
            //        foreach (SubCategory sub in subCategories)
            //        {
            //            if (sub.SubName == "Etli Yemekler")
            //            {
            //                List<Product> pr = new List<Product>
            //                {
            //                new Product
            //                {
            //                    ProductName = "Orman kebabı",
            //                    ProductContent ="Patates biber domates et",
            //                    ProductRegion =MODEL.Enum.Region.Ege,
            //                    ImagePath =new Images("en").Food(),
            //                    UnitPrice=200
            //                },
            //                new Product
            //                {
            //                    ProductName ="CiğerŞiş",
            //                    ProductContent ="Kuzu Ciğer ve baharatlar",
            //                    ProductRegion =MODEL.Enum.Region.Guneydogu,
            //                    ImagePath =new Images("en").Food(),
            //                    UnitPrice=200
            //                },
            //                new Product
            //                {
            //                    ProductName ="Etli Ekmek ",
            //                    ProductContent ="Kıyma, Soğan ve ince hamur ekmek ",
            //                    ProductRegion =MODEL.Enum.Region.IcAnadolu,
            //                    ImagePath =new Images("en").Food(),
            //                    UnitPrice=190
            //                }

            //                };

            //            }
            //            else if (sub.SubName == "Sebzeli Yemekler")
            //            {
            //                List<Product> pr = new List<Product>
            //                {
            //                    new Product
            //                    { ProductName="Bezelyeli Bamya",
            //                        ProductContent ="Bezelye ve bamya bir tencerede",
            //                        ProductRegion =MODEL.Enum.Region.Ege,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=200
            //                    },
            //                    new Product
            //                    {
            //                        ProductName ="Sebze Kebabı",
            //                        ProductContent ="Envai Çeşit Sebze",
            //                        ProductRegion =MODEL.Enum.Region.Marmara,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=190
            //                    },
            //                    new Product
            //                    {
            //                        ProductName ="Dağ Güveci",
            //                        ProductContent ="Doğu Anadolu tenceresi",
            //                        ProductRegion =MODEL.Enum.Region.Dogu,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=190
            //                    }
            //                };
            //            }


            //        }
            //        context.SaveChanges();

            //    }
            //    else if (item.CategoryName == "Tatlılar")
            //    {
            //        List<SubCategory> sc = new List<SubCategory>
            //        {
            //            new SubCategory{SubName="Sütlü",SubDescription="Organik Sütlü Enfes Tatlılar",ImagePath=new Images("en").Food()},
            //            new SubCategory{SubName="Şerbetli", SubDescription="Şekeriniz mi Düştü Yetiştik",ImagePath=new Images("en").Food()}
            //        };
            //        foreach (SubCategory sub in sc)
            //        {
            //            if (sub.SubName == "Sütlü")
            //            {
            //                List<Product> pro = new List<Product>
            //                {
            //                    new Product
            //                    {
            //                        ProductName ="Sütlaç",
            //                        ProductContent ="Pirinç Süt ve şeker",
            //                        ProductRegion =MODEL.Enum.Region.IcAnadolu,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=100
            //                    },
            //                    new Product
            //                    {
            //                        ProductName ="Kazandibi",
            //                        ProductContent ="Süt Kazanda",
            //                        ProductRegion =MODEL.Enum.Region.Karadeniz,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=100
            //                    },
            //                    new Product
            //                    {
            //                        ProductName ="Tavuk Göğsü",
            //                        ProductContent ="Tavuk Süt ",
            //                        ProductRegion =MODEL.Enum.Region.Marmara,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=100
            //                    }
            //                };
            //            }
            //            else if (sub.SubName == "Şerbetli")
            //            {
            //                List<Product> pro = new List<Product>
            //                {
            //                    new Product
            //                    {
            //                        ProductName ="Tulumba",
            //                        ProductContent ="Yedikçe ye",
            //                        ProductRegion =MODEL.Enum.Region.Ege,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=90
            //                    },
            //                    new Product
            //                    {
            //                        ProductName ="Kemalpaşa",
            //                        ProductContent ="Yedikçe Daha fazla ye",
            //                        ProductRegion =MODEL.Enum.Region.Akdeniz,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=80
            //                    },
            //                    new Product
            //                    {
            //                        ProductName ="Baklava",
            //                        ProductContent ="Antep,Maraş fıstığı ile coş",
            //                        ProductRegion =MODEL.Enum.Region.Guneydogu,
            //                        ImagePath =new Images("en").Food(),
            //                        UnitPrice=140
            //                    }
            //                };
            //            }
            //        }
            //        context.SaveChanges();
            //    }
            //    else if (item.CategoryName == "İçecekler")
            //    {
            //        List<Product> prp = new List<Product>
            //        {
            //            new Product
            //            {
            //                ProductName ="Ayran",
            //                ProductContent ="Yoğurt, su ve nane",
            //                ImagePath =new Images("en").Food(),
            //                UnitPrice =20
            //            },
            //            new Product
            //            { ProductName="Şalgam",
            //                ProductContent ="Turşu suyu",
            //                ProductRegion =MODEL.Enum.Region.Guneydogu,
            //                ImagePath =new Images("en").Food()
            //                ,UnitPrice=20
            //            }
            //        };
            //        context.SaveChanges();
            //    }
            //    context.SaveChanges();

            //}
            //context.SaveChanges();
            #endregion
            //Kullanıcı ve kullanıcı profil fake dataları
            for (int i = 0; i < 20; i++)
            {
                User apMember = new User();
                apMember.UserName = new Internet("en").UserName();
                apMember.Password ="123123";
                apMember.IsActive = true;
                apMember.IsBanned = false;
                apMember.Email = new Internet("en").Email();

                context.Users.Add(apMember);
                context.SaveChanges();

                UserProfile apdMember = new UserProfile();
                apdMember.FirstName = new Name("en").FirstName();
                apdMember.LastName = new Name("en").LastName();
                apdMember.Address = new Bogus.DataSets.Address("en").FullAddress();
                apdMember.ID = apMember.ID;
                apdMember.Country = new Bogus.DataSets.Address("en").Country();
                apdMember.City = new Bogus.DataSets.Address("en").City();
                apdMember.Phone = new PhoneNumbers("en").Locale;
                apdMember.ImagePath = new Images("en").People();
              

                context.UserProfiles.Add(apdMember);
                context.SaveChanges();
            }
            //Admin
            User admin = new User();
            admin.UserName = "canderen";
            admin.Password = "1234";
            admin.IsActive = true;
            admin.IsBanned = false;
            admin.Email = "rock-tochoose@hotmail.com";
            admin.UserRole = MODEL.Enum.Role.Admin;
            context.Users.Add(admin);
            context.SaveChanges();

            UserProfile adminP = new UserProfile();
            adminP.FirstName = "Canderen";
            adminP.LastName = "KAYMAK";
            adminP.Address = new Bogus.DataSets.Address("en").FullAddress();
            adminP.ID = admin.ID;
            adminP.Country = "Brasil";
            adminP.City = "Sivas";
            adminP.Phone = new PhoneNumbers("en").Locale;
            adminP.ImagePath = new Images("en").People();
            context.UserProfiles.Add(adminP);
            context.SaveChanges();



            //sahte evler
            #region Evler
            Supplier spd1 = new Supplier();
            spd1.ID = 1;
            spd1.SupplierName = "Sardırım";
            spd1.Email = "sardirim@gmail.com";
            spd1.Phone = "02162222221";
            spd1.UrlWebHome = "http:\\ www.sardirim.com";
            spd1.IsActive = true;
            spd1.IsBanned = false;
            spd1.Password = "123123";
            spd1.ConfirmPassword = "123123";
            spd1.SupRank = MODEL.Enum.Rank.Bir;
            spd1.SupRegion = MODEL.Enum.Region.Marmara;
            context.Suppliers.Add(spd1);
            context.SaveChanges();

            Supplier spd2 = new Supplier { ID = 2, SupplierName = "Yardırım", Email = "Yardirim@gmail.com", Phone = "02162222222", UrlWebHome = "http:\\ www.yardirim.com", IsActive = true, IsBanned = false, Password = "123123", ConfirmPassword = "123123", SupRank = MODEL.Enum.Rank.Bes, SupRegion = MODEL.Enum.Region.Guneydogu };
            context.Suppliers.Add(spd2);
            context.SaveChanges();

            Supplier spd3 = new Supplier { ID = 3, SupplierName = "Bandırım", Email = "bandirim@gmail.com", Phone = "02162222223", UrlWebHome = "http:\\ www.bandirim.com", IsActive = true, IsBanned = false, Password = "123123", ConfirmPassword = "123123", SupRank = MODEL.Enum.Rank.Uc, SupRegion = MODEL.Enum.Region.IcAnadolu };
            context.Suppliers.Add(spd3);
            context.SaveChanges();

            Supplier spd4 = new Supplier { ID = 4, SupplierName = "Vardırım", Email = "vardirim@gmail.com", Phone = "02162222224", UrlWebHome = "http:\\ www.vardirim.com", IsActive = true, IsBanned = false, Password = "123123", ConfirmPassword = "123123", SupRank = MODEL.Enum.Rank.Dort, SupRegion = MODEL.Enum.Region.Dogu };
            context.Suppliers.Add(spd4);
            context.SaveChanges();

            Supplier spd5 = new Supplier { ID = 5, SupplierName = "Kaldırım", Email = "kaldirim@gmail.com", Phone = "02162222225", UrlWebHome = "http:\\ www.kaldirim.com", IsActive = true, IsBanned = false, Password = "123123", ConfirmPassword = "123123", SupRank = MODEL.Enum.Rank.Iki, SupRegion = MODEL.Enum.Region.Karadeniz };
            context.Suppliers.Add(spd5);
            context.SaveChanges();

            Supplier spd6 = new Supplier { SupplierName = "Zardırım", Email = "zardirim@gmail.com", Phone = "02162222226", UrlWebHome = "http:\\ www.zardirim.com", IsActive = true, IsBanned = false, Password = "123123", ConfirmPassword = "123123", SupRank = MODEL.Enum.Rank.Uc, SupRegion = MODEL.Enum.Region.Akdeniz };
            context.Suppliers.Add(spd6);
            context.SaveChanges();

            Supplier spd7 = new Supplier { SupplierName = "Rardırım", Email = "rardirim@gmail.com", Phone = "02162222227", UrlWebHome = "http:\\ www.rardirim.com", IsActive = true, IsBanned = false, Password = "123123", ConfirmPassword = "123123", SupRank = MODEL.Enum.Rank.Dort, SupRegion = MODEL.Enum.Region.Ege };
            context.Suppliers.Add(spd7);
            context.SaveChanges();
            #endregion

            //kategoriler
            #region Kategoriler
            Category cat1 = new Category();
            cat1.ID = 1;
            cat1.CategoryName = "Başlangıçlar";
            cat1.Description = "Lezzete doymadan önce Lezzete doyun..!";
            cat1.ImagePath = new Images("tr").Food();
            context.Categories.Add(cat1);
            context.SaveChanges();

            Category cat2 = new Category { ID = 2, CategoryName = "Ara Sıcaklar", Description = "Güzel Başlangıçlardan sonra ufak iştah arttırıcılar", ImagePath = new Images("tr").Food() };
            context.Categories.Add(cat2);
            context.SaveChanges();

            Category cat3 = new Category { ID=3, CategoryName = "Ana Yemekler", Description = "Çeşit Lezzet Şöleni ", ImagePath = new Images("tr").Food() };
            context.Categories.Add(cat3);
            context.SaveChanges();

            Category cat4 = new Category { ID=4, CategoryName = "Tatlılar", Description = "Ülkemizin her bölgesinin misafirperverliğini yansıtan damak tatları", ImagePath = new Images("tr").Food() };
            context.Categories.Add(cat4);
            context.SaveChanges();

            Category cat5 = new Category { ID=5, CategoryName = "İçecekler", Description = "Boğazınızdan pürüssüzce akacak doğal seçimler", ImagePath = new Images("tr").Food() };
            context.Categories.Add(cat5);
            context.SaveChanges();
            #endregion

            List<Category> categories = new List<Category> { cat1,cat2,cat3,cat4,cat5};
          

            #region AltKategoriler
            SubCategory scat1 = new SubCategory { ID = 1, SubName = "Çorbalar", SubDescription = "Kaşıklamaya Doyamayacaksınız", ImagePath = new Images("tr").Food() ,CategoryID=1};
            context.SubCategories.Add(scat1);
            context.SaveChanges();

            SubCategory scat2 = new SubCategory { ID = 2, SubName = "Salatalar", SubDescription = "Anadolunun zengin yeşillikleriyle donatılmış harika eşlikçiler", ImagePath = new Images("tr").Food(),CategoryID=1 };
            context.SubCategories.Add(scat2);
            context.SaveChanges();

            SubCategory scat3 = new SubCategory { ID = 3, SubName = "Etli Yemekler", SubDescription = "Et Yemekleri", ImagePath = new Images("tr").Food(), CategoryID=3};
            context.SubCategories.Add(scat3);
            context.SaveChanges();

            SubCategory scat4 = new SubCategory { ID = 4, SubName = "Sebzeli Yemekler", SubDescription = "Sebze Yemekleri", ImagePath = new Images("en").Food(),CategoryID=3 };
            context.SubCategories.Add(scat4);
            context.SaveChanges();

            SubCategory scat5 = new SubCategory { ID = 5, SubName = "Sütlü", SubDescription = "Organik Sütlü Enfes Tatlılar", ImagePath = new Images("en").Food(),CategoryID=4 };
            context.SubCategories.Add(scat5);
            context.SaveChanges();

            SubCategory scat6 = new SubCategory { ID = 6, SubName = "Şerbetli", SubDescription = "Şekeriniz mi Düştü Yetiştik", ImagePath = new Images("en").Food(),CategoryID=4 };
            context.SubCategories.Add(scat6);
            context.SaveChanges();
            #endregion

            List<SubCategory> subCategories = new List<SubCategory> { scat1, scat2, scat3, scat4, scat5, scat6 };

            #region Ürünler
            Product pr1 = new Product
            {
                ID = 1,
                ProductName = "Fellah Köfte",
                ProductContent = "Meat",
                ProductRegion = MODEL.Enum.Region.Marmara,
                ImagePath = new Images("tr").Food(),
                UnitPrice = 200
                ,SubCategoryID=3
            };

            context.Products.Add(pr1);
            context.SaveChanges();

            Product pr2 = new Product
            {
                ID = 2,
                ProductName = "Sarma",
                ProductContent = "Yaprak, et,pirinç",
                ProductRegion = MODEL.Enum.Region.Ege,
                ImagePath = new Images("tr").Food(),
                UnitPrice = 150,
                CategoryID=2
            };

            context.Products.Add(pr2);
            context.SaveChanges();

            Product pr3 = new Product
            {
                ID = 3,
                ProductName = "Enginar Saçması",
                ProductContent = "Enginar ve sebzeler",
                ProductRegion = MODEL.Enum.Region.Akdeniz,
                ImagePath = new Images("tr").Food(),
                UnitPrice = 80,
                SubCategoryID=4
            };

            context.Products.Add(pr3);
            context.SaveChanges();

            Product pr4 = new Product
            {
                ID = 4,
                ProductName = "Hamsilik",
                ProductContent = "Hamsi ve patates",
                ProductRegion = MODEL.Enum.Region.Karadeniz,
                ImagePath = new Images("tr").Food(),
                UnitPrice = 100,
                SubCategoryID=3
            };

            context.Products.Add(pr4);
            context.SaveChanges();

            Product pr5 = new Product
            {
                ID = 5,
                ProductName = "Yeşil Mercimek Köftesi",
                ProductContent = "Yeşil Mercimek, Taze Soğan",
                ProductRegion = MODEL.Enum.Region.IcAnadolu,
                ImagePath = new Images("tr").Food(),
                UnitPrice = 90,
                CategoryID=2
                
            };

            context.Products.Add(pr5);
            context.SaveChanges();

            Product pr6 = new Product
            {
                ID = 6,
                ProductName = "Kağıt Döner",
                ProductContent = "Et",
                ProductRegion = MODEL.Enum.Region.Dogu,
                ImagePath = new Images("tr").Food(),
                UnitPrice = 180,
                SubCategoryID=3

            };

            context.Products.Add(pr6);
            context.SaveChanges();

            Product pr7 = new Product
            {
                ID = 7,
                ProductName = "Beyran",
                ProductContent = "Enginar ve sebzeler",
                ProductRegion = MODEL.Enum.Region.Guneydogu,
                ImagePath = new Images("tr").Food(),
                UnitPrice = 160,
                SubCategoryID=1
            };

            context.Products.Add(pr7);
            context.SaveChanges();

            Product pr8 = new Product
            {
                ID = 8,
                ProductName = "Orman kebabı",
                ProductContent = "Patates biber domates et",
                ProductRegion = MODEL.Enum.Region.Ege,
                ImagePath = new Images("en").Food(),
                UnitPrice = 200,
                SubCategoryID=3
            };

            context.Products.Add(pr8);
            context.SaveChanges();

            Product pr9 = new Product
            {
                ID = 9,
                ProductName = "CiğerŞiş",
                ProductContent = "Kuzu Ciğer ve baharatlar",
                ProductRegion = MODEL.Enum.Region.Guneydogu,
                ImagePath = new Images("en").Food(),
                UnitPrice = 200,
                SubCategoryID=3
            };

            context.Products.Add(pr9);
            context.SaveChanges();

            Product pr10 = new Product
            {
                ID = 10,
                ProductName = "Etli Ekmek ",
                ProductContent = "Kıyma, Soğan ve ince hamur ekmek ",
                ProductRegion = MODEL.Enum.Region.IcAnadolu,
                ImagePath = new Images("en").Food(),
                UnitPrice = 190,
                SubCategoryID=3
            };

            context.Products.Add(pr10);
            context.SaveChanges();

            Product pr11 = new Product
            {
                ID = 11,
                ProductName = "Bezelyeli Bamya",
                ProductContent = "Bezelye ve bamya bir tencerede",
                ProductRegion = MODEL.Enum.Region.Ege,
                ImagePath = new Images("en").Food(),
                UnitPrice = 200,
                SubCategoryID=4
            };

            context.Products.Add(pr11);
            context.SaveChanges();

            Product pr12 = new Product
            {
                ID = 12,
                ProductName = "Sebze Kebabı",
                ProductContent = "Envai Çeşit Sebze",
                ProductRegion = MODEL.Enum.Region.Marmara,
                ImagePath = new Images("en").Food(),
                UnitPrice = 190,
                SubCategoryID=4
            };

            context.Products.Add(pr12);
            context.SaveChanges();


            Product pr13 = new Product
            {
                ID = 13,
                ProductName = "Dağ Güveci",
                ProductContent = "Doğu Anadolu tenceresi",
                ProductRegion = MODEL.Enum.Region.Dogu,
                ImagePath = new Images("en").Food(),
                UnitPrice = 190,
                SubCategoryID=3

            };

            context.Products.Add(pr13);
            context.SaveChanges();

            Product pr14 = new Product
            {
                ID = 14,
                ProductName = "Sütlaç",
                ProductContent = "Pirinç Süt ve şeker",
                ProductRegion = MODEL.Enum.Region.IcAnadolu,
                ImagePath = new Images("en").Food(),
                UnitPrice = 100,
                SubCategoryID=5
            };

            context.Products.Add(pr14);
            context.SaveChanges();

            Product pr15 = new Product
            {
                ID = 15,
                ProductName = "Kazandibi",
                ProductContent = "Süt Kazanda",
                ProductRegion = MODEL.Enum.Region.Karadeniz,
                ImagePath = new Images("en").Food(),
                UnitPrice = 100,
                SubCategoryID=5
            };

            context.Products.Add(pr15);
            context.SaveChanges();

            Product pr16 = new Product
            {
                ID = 16,
                ProductName = "Tavuk Göğsü",
                ProductContent = "Tavuk Süt ",
                ProductRegion = MODEL.Enum.Region.Marmara,
                ImagePath = new Images("en").Food(),
                UnitPrice = 100,
                SubCategoryID=5
            };

            context.Products.Add(pr16);
            context.SaveChanges();

            Product pr17 = new Product
            {
                ID = 17,
                ProductName = "Tulumba",
                ProductContent = "Yedikçe ye",
                ProductRegion = MODEL.Enum.Region.Ege,
                ImagePath = new Images("en").Food(),
                UnitPrice = 90,
                SubCategoryID=6
            };

            context.Products.Add(pr17);
            context.SaveChanges();

            Product pr18 = new Product
            {
                ID = 18,
                ProductName = "Kemalpaşa",
                ProductContent = "Yedikçe Daha fazla ye",
                ProductRegion = MODEL.Enum.Region.Akdeniz,
                ImagePath = new Images("en").Food(),
                UnitPrice = 80,
                SubCategoryID=6
            };

            context.Products.Add(pr18);
            context.SaveChanges();

            Product pr19 = new Product
            {
                ID = 19,
                ProductName = "Baklava",
                ProductContent = "Antep,Maraş fıstığı ile coş",
                ProductRegion = MODEL.Enum.Region.Guneydogu,
                ImagePath = new Images("en").Food(),
                UnitPrice = 140,
                SubCategoryID=6
            };

            context.Products.Add(pr19);
            context.SaveChanges();

            Product pr20 = new Product
            {
                ID = 20,
                ProductName = "Ayran",
                ProductContent = "Yoğurt, su ve nane",
                ImagePath = new Images("en").Food(),
                UnitPrice = 20,
                CategoryID=5
                
            };

            context.Products.Add(pr20);
            context.SaveChanges();

            Product pr21 = new Product
            {
                ID = 21,
                ProductName = "Şalgam",
                ProductContent = "Turşu suyu",
                ProductRegion = MODEL.Enum.Region.Guneydogu,
                ImagePath = new Images("en").Food(),
                UnitPrice = 20,
                CategoryID=5
            };

            context.Products.Add(pr21);
            context.SaveChanges();
            #endregion

            List<Product> products = new List<Product> { };
            //menü için sahte girişler
            foreach (Category item in categories)
            {
                if      (item.CategoryName == "Başlangıçlar")
                {


                  
                }
                else if (item.CategoryName == "Ara Sıcaklar")
                {

                    
                }
                else if (item.CategoryName == "Ana Yemekler")
                {
                                           
                    foreach (SubCategory sub in subCategories)
                    {
                        if (sub.SubName == "Etli Yemekler")
                        {


                            

                        }
                        else if (sub.SubName == "Sebzeli Yemekler")
                        {
                            

                        }
                    }                
                }
                else if (item.CategoryName == "Tatlılar")
                {
                    foreach (SubCategory sub in subCategories)
                    {
                        if (sub.SubName == "Sütlü")
                        {
                            
                            
                        }
                        else if (sub.SubName == "Şerbetli")
                        {
                            
                        }
                    }
                    
                }
                else if (item.CategoryName == "İçecekler")
                {
                      
                }            
            }
            context.SaveChanges();
        }
    }
}
