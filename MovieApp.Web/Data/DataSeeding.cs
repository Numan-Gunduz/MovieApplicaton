using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
	public static class DataSeeding
	{
		public static void Seed(IApplicationBuilder app)
		{
				var scope = app.ApplicationServices.CreateScope();
				var context = scope.ServiceProvider.GetService<MovieContext>();

				context.Database.Migrate();

				if (context.Database.GetPendingMigrations().Count() == 0)
				{
					if (context.Movies.Count()== 0)
					{
							context.Movies.AddRange(
										 new List<Movie>()
		{
							new Movie
							{
								//MovieId = 1,
								Title = "Harry Potter",
								Description = " dayanan bir film serisaidiraa .\r\n",
								Director = "Prof. Dumbledore",
								ImageUrl = "1.jpg",
								GenreId = 3,
							},
							new Movie
							{
								//MovieId = 2,
								Title = "Prison Break",
								Description = "Mi yalnızca Lincoln'ı değil,\r\n",
								Director = "Michael Scofield",
								ImageUrl = "2.jpg",
								GenreId = 3,

							},
							new Movie
							{
								//MovieId = 3,
								Title = "Hobbit",
								Description = "Hır. \"Hobbit\" serisieyartik bir uyarlamasıdır.\r\n",
								Director = "Thorin Oakenshield",
								ImageUrl = "3.jpg",
								GenreId = 4,

							},
							new Movie
							{
								//MovieId = 4,
								Title = "Fantastik Canavarlar",
								Description = "Neya çıkmasına neden olur.",
								Director = "David Yates",
								ImageUrl = "18.jpg",
								GenreId = 3,

							},
							new Movie
							{
								//MovieId = 5,
								Title = "Hızlı Ve Öfkeli",
								Description = "Losini ve polis görevini birbirine düşürür.",
								Director = "Rob Cohen",
								ImageUrl = "19.jpg",
								GenreId = 4,

							},
							new Movie
							{
								//MovieId = 6,
								Title = "Kaptan Amerika",
								Description = "UlğSinematik Evreni'nde geniş etkiler bırakır.",
								Director = "Anthony ve Joe Russo",
								ImageUrl = "99.jpg",
								GenreId = 4,

							},
							new Movie
							{
								//MovieId = 7,
								Title = "Witcher",
								Description = "acera başlar.",
								Director = "Andrzej Sapkowski",
								ImageUrl = "4.jpg",
								GenreId = 3

							},
							new Movie
							{
								//MovieId = 8,
								Title = "Another Life",
								Description = "erinmaktadır.\r\n\r\n\r\n",
								Director = "Aaron Martin",
								ImageUrl = "6.jpg",
								GenreId = 5

							},
							new Movie
							{
								//MovieId = 9,
								Title = "Lost in Space",
								Description = " Ro",
								ImageUrl = "5.jpg",
								GenreId = 5

							},
							new Movie
							{
								//MovieId = 10,
								Title = "Stranger Things",
								Description = "S al",
								ImageUrl = "10.jpg",
								GenreId = 5

							},
							new Movie
							{
								//MovieId = 11,
								Title = "Breaking Bad",
								Description="breaj",
								//Description = "\"Breaking Bad\", kimya öğretmeni Walter White'ın, ölümcül kanser teşhisi konulduktan sonra kimya bilgisini uyuşturucu ticaretine dönüştürerek ailesine maddi destek sağlama çabasını konu alır. Walter, eski öğrencisi Jesse Pinkman ile birlikte methamphetamine üreterek suç dünyasına adım atar. Ancak bu tehlikeli yola girdikçe, Walter'ın kişisel ve ahlaki sınırları zorlanır. \"Breaking Bad\", Walter'ın dönüşümünü ve uyuşturucu ticaretindeki yükselişini detaylı bir şekilde anlatan bir drama dizisidir.",
								Director = "Vince Gilligan",
								ImageUrl = "11.jpg",
								GenreId = 4

							},
							new Movie
							{
								//MovieId = 12,
								Title = "Game of Thrones",
								Description="breaj",

								//Description = "\"Game of Thrones\", George R.R. Martin'in \"A Song of Ice and Fire\" serisine dayanan, fantastik bir drama televizyon dizisidir. Westeros adlı kurgusal bir kıtada geçen dizi, taht mücadeleleri, entrikalar, büyü ve savaşları içeren zengin bir hikayeyi anlatır. Birçok farklı ailenin ve karakterin karmaşık ilişkilerini ve kaderlerini ele alırken, dizinin odak noktası, Demir Taht için yapılan mücadelelerdir. Zengin karakter gelişimi, şaşırtıcı olay örgüsü ve ölümsüz diyaloglarıyla \"Game of Thrones\", tarihe geçmiş bir televizyon fenomeni olarak bilinir.",
								Director = "David Benioff, D. B. Weiss",
								ImageUrl = "12.jpg",
								GenreId = 4

							},
							new Movie
							{
								//MovieId = 13,
								Title = "Sherlock",
								Description = "Drama",
								Director = "Mark Gatiss, Steven Moffat",
								ImageUrl = "13.jpg",
								GenreId = 3

							},
							new Movie
							{
								//MovieId = 14,
								Title = "Dark",
								Description = "Drama",

								//Description = "\"Sherlock\", Sir Arthur Conan Doyle'un ünlü dedektifi Sherlock Holmes'un modern bir uyarlamasıdır. Sherlock Holmes, sivri zekası, dikkat toplama yeteneği ve dedüktif becerileriyle tanınan bir özel dedektiftir. Dizi, Holmes'un en yakın arkadaşı ve yardımcısı Dr. John Watson ile birlikte Londra'da çeşitli suçları çözmesini konu alır. Modern zamanlara uyarlanmış bu versiyon, orijinal hikayelerin unsurlarını sürükleyici bir şekilde modern bir şehir manzarası içinde sunar. \"Sherlock\", karmaşık olay örgüleri, karakter gelişimi ve Benedict Cumberbatch ile Martin Freeman'ın performanslarıyla dikkat çeken bir dedektif dizisidir.",
								Director = "Baran bo Odar, Jantje Friese",
								ImageUrl = "14.jpg",
								GenreId = 5

							},
							new Movie
							{
								//MovieId = 15,
								Title = "Fleabag",
								Description = "Drama",

								//Description = "\"Fleabag\", Phoebe Waller-Bridge'in aynı adlı tiyatro oyunundan uyarlanan ve başrolünde yer aldığı bir televizyon dizisidir. Dizi, Londra'da yaşayan, keskin zekalı ancak karmaşık bir genç kadın olan Fleabag'in hikayesini anlatır. Fleabag, aile ilişkileri, aşk, kayıp ve kendi iç dünyasıyla başa çıkmaya çalışırken izleyiciyle içten bir bağ kurar. Dizinin mizah anlayışı, duygusal derinliği ve Waller-Bridge'in performansı, \"Fleabag\"i benzersiz kılar ve büyük bir beğeni toplamasına neden olur.",
								Director = "Phoebe Waller-Bridge",
								ImageUrl = "98.jpg",
								GenreId = 3

					},
				}
							);
					}
					if (context.Genres.Count()==0)
					{
						context.Genres.AddRange(
							
							new List<Genre>()
									{
									new Genre {/*GenreId = 1,*/ Name = "Macera"},
									new Genre {/*GenreId = 2,*/ Name = "Komedi"},
									new Genre {/*GenreId = 3,*/ Name = "Romantik"},
									new Genre {/*GenreId = 4,*/ Name = "Aksiyon"},
									new Genre {/*GenreId = 5,*/ Name = "Bilim Kurgu"}
									}
							);
						}
						context.SaveChanges();
			}
		} 
	}
}
