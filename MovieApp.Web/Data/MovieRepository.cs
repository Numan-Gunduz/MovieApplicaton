//using MovieApp.Web.Entity;
//using MovieApp.Web.Model;
//using System.Collections.Generic;
//using System.Linq;

//namespace MovieApp.Web.Data
//{
//	public class MovieRepository
//	{
//		private static readonly List <Movie> _movies = null;

//		static MovieRepository()
//		{
//			_movies = new List<Movie>
//	        {
//		new Movie
//		{
//			MovieId = 1,
//			Title = "Harry Potter",
//			Description = "Harry Potter serisi, J.K. Rowling'in yazdığı fantastik roman serisine dayanan bir film serisidir. Hogwarts Büyücülük ve Cadılık Okulu'na giden genç bir büyücü olan Harry Potter'ın maceralarını anlatan bu seride, Harry, sadık arkadaşları Ron ve Hermione ile birlikte büyücülük dünyasının karanlık güçlerine karşı mücadele eder. Harry'nin, efsanevi Kara Lord Voldemort ile olan kaderi, büyü dünyasının kaderini belirleyecektir. Macera, dostluk ve büyü dolu bu seride Harry, sıradışı dünyasını keşfeder ve büyük bir savaşın ortasında kendisini bulur.\r\n",
//			Director = "Prof. Dumbledore",
//			ImageUrl = "1.jpg",
//			GenreId = 1,
//		},
//		new Movie
//		{
//			MovieId = 2,
//			Title = "Prison Break",
//			Description = "Michael Scofield, suçsuz yere hapsedilen abisi Lincoln Burrows'u kurtarmak için bir hapishaneden kaçma planı yapar. Ancak bu plan, yalnızca Lincoln'ı değil,\r\n",
//			Director = "Michael Scofield",
//			ImageUrl = "2.jpg",
//            GenreId = 4,

//        },
//		new Movie
//		{
//			MovieId = 3,
//			Title = "Hobbit",
//			Description = "Hobbit, J.R.R. Tolkien'in aynı adlı romanına dayanan bir film serisidir. Orta Dünya'da geçen bu epik fantastik macera, Hobbit Bilbo Baggins'in, cüce kralı Thorin Meşe Kalkan ve bir grup cüce ile birlikte Ejderha Smaug'un hüküm sürdüğü Erebor Dağı'na yolculuğunu konu alır. Bilbo, beklenmedik bir kahraman olur ve dostlarıyla birlikte bir dizi tehlikeli olay ve fantastik yaratıkla karşılaşır. \"Hobbit\" serisi, dostluk, cesaret ve sürükleyici bir dünya yaratma konusundaki eşsiz yetenekleriyle tanınan Tolkien'in eserinin sinematik bir uyarlamasıdır.\r\n",
//			Director = "Thorin Oakenshield",
//			ImageUrl = "3.jpg",
//            GenreId = 4,

//        },
//		new Movie
//		{
//			MovieId = 4,
//			Title = "Fantastik Canavarlar",
//			Description = "Newt Scamander, 1920'lerin sihirli dünyasında, dünya genelinde fantastik yaratıkları keşfetmek üzere yola çıkar. Ancak, New York'a vardığında, gizemli bir sihirbazın kaçan canavarlardan bir kaos çıkarmasıyla olaylar gelişir. Bu olaylar, sihirli topluluğun gizli dünyasının ortaya çıkmasına neden olur.",
//			Director = "David Yates",
//			ImageUrl = "18.jpg",
//            GenreId = 1,

//        },
//		new Movie
//		{
//			MovieId = 5,
//			Title = "Hızlı Ve Öfkeli",
//			Description = "Los Angeles sokaklarındaki illegal yarışlarda yeteneklerini sergileyen Dominic Toretto ve Brian O'Conner, hız tutkunu bir grup arabadan oluşan bir aileyi keşfederler. Ancak, Brian polis olduğunu itiraf etmek zorundadır ve bu durum, Dominic'in çetesini ve polis görevini birbirine düşürür.",
//			Director = "Rob Cohen",
//			ImageUrl = "19.jpg",
//            GenreId = 4,

//        },
//		new Movie
//		{
//			MovieId = 6,
//			Title = "Kaptan Amerika",
//			Description = "Uluslararası topluluk, süper kahramanların faaliyetlerini kontrol altına almak için bir anlaşma önerdiğinde, Kaptan Amerika ve Iron Man arasında bir bölünme ortaya çıkar. Kaptan Amerika, kişisel özgürlükleri savunurken, Iron Man, güvenlik ve hesap verebilirlik talep eder. Kahramanlar arasındaki bu iç savaş, Marvel Sinematik Evreni'nde geniş etkiler bırakır.",
//			Director = "Anthony ve Joe Russo",
//			ImageUrl = "99.jpg",
//            GenreId = 4,

//        },
//		new Movie
//		{
//			MovieId = 7,
//			Title = "Witcher",
//			Description = "\"The Witcher\", Andrzej Sapkowski'nin fantastik roman serisinden uyarlanan bir dizidir. Baş karakter Geralt of Rivia, canavar avcısı olarak bilinen bir witcher'dır. Dizi, Geralt'ın kaderi, güçlü büyücü Yennefer ve gizemli Ciri ile kesişen olayları anlatır. Sihir, politika ve tehlikeli yaratıklarla dolu bu karanlık ve epik dünyada, karakterlerin kaderleri birbirine bağlanır ve büyük bir macera başlar.",
//			Director = "Andrzej Sapkowski",
//			ImageUrl = "4.jpg",
//            GenreId = 1

//        },
//		new Movie
//		{
//			MovieId = 8,
//			Title = "Another Life",
//			Description = "Another Life, bir uzay gemisi mürettebatının, dünya dışında keşif yapmak üzere gönderildiği bir görevi konu alır. Dizi, gizemli bir uzaylı artefaktının keşfi ve bu artefaktın dünya ile iletişim kurma girişimlerini içerir. Ana karakter Niko Breckinridge, geminin komutanı olarak liderlik ederken, ekip, uzayda karşılaştıkları bilinmeyen tehditlerle mücadele etmek zorundadır. \"Another Life\", bilim kurgu ve gerilim unsurlarını bir araya getirerek izleyicilere uzayda geçen heyecan dolu bir hikaye sunmaktadır.\r\n\r\n\r\n",
//			Director = "Aaron Martin",
//			ImageUrl = "6.jpg",
//            GenreId = 5

//        },
//		new Movie
//		{
//			MovieId = 9,
//			Title = "Lost in Space",
//			Description = " Robinson ailesinin, Alpha Centauri adlı gezegene yerleşmeye giden bir uzay kolonisine katılmak üzere gönderildiği uzay yolculuğunu konu alır. Ancak, beklenmedik bir olay sonucunda aile, uzak bir galakside terk edilmiş bir gezegende mahsur kalır. Dizi, ailenin hayatta kalma mücadelesini, gizemli gezegenin tehlikelerini ve robotlarıyla olan ilişkilerini ele alır. \"Lost in Space\", aile bağları, bilim kurgu ve macera unsurlarını içeren bir hikayeyi izleyicilere sunar.",
//			Director = "Irwin Allen",
//			ImageUrl = "5.jpg",
//            GenreId = 5

//        },
//		new Movie
//		{
//			MovieId = 10,
//			Title = "Stranger Things",
//			Description = "Stranger Things, 1980'lerde Hawkins adlı küçük bir kasabada geçen, paranormal olayları konu alan bir dizidir. Dizi, kaybolan bir çocuk, gizemli bir kız, anlaşılamayan bir boyut ve doğaüstü güçlere sahip yaratıklar arasındaki bağlantıyı araştıran bir grup çocuğun hikayesini anlatır. Hawkins kasabası, sıradan gibi görünen yaşamlarının altında gizemli olaylar barındırmaktadır. Stranger Things, 80'lerin kültürüne, bilim kurgu ve korku türlerine olan bir saygı duruşuyla izleyicilere nostaljik bir deneyim sunar.",
//			Director = "Duffer Brothers",
//			ImageUrl = "10.jpg",
//            GenreId = 5

//        },
//		new Movie
//		{
//			MovieId = 11,
//			Title = "Breaking Bad",
//			Description = "\"Breaking Bad\", kimya öğretmeni Walter White'ın, ölümcül kanser teşhisi konulduktan sonra kimya bilgisini uyuşturucu ticaretine dönüştürerek ailesine maddi destek sağlama çabasını konu alır. Walter, eski öğrencisi Jesse Pinkman ile birlikte methamphetamine üreterek suç dünyasına adım atar. Ancak bu tehlikeli yola girdikçe, Walter'ın kişisel ve ahlaki sınırları zorlanır. \"Breaking Bad\", Walter'ın dönüşümünü ve uyuşturucu ticaretindeki yükselişini detaylı bir şekilde anlatan bir drama dizisidir.",
//			Director = "Vince Gilligan",
//			ImageUrl = "11.jpg",
//            GenreId = 4

//        },
//		new Movie
//		{
//			MovieId = 12,
//			Title = "Game of Thrones",
//			Description = "\"Game of Thrones\", George R.R. Martin'in \"A Song of Ice and Fire\" serisine dayanan, fantastik bir drama televizyon dizisidir. Westeros adlı kurgusal bir kıtada geçen dizi, taht mücadeleleri, entrikalar, büyü ve savaşları içeren zengin bir hikayeyi anlatır. Birçok farklı ailenin ve karakterin karmaşık ilişkilerini ve kaderlerini ele alırken, dizinin odak noktası, Demir Taht için yapılan mücadelelerdir. Zengin karakter gelişimi, şaşırtıcı olay örgüsü ve ölümsüz diyaloglarıyla \"Game of Thrones\", tarihe geçmiş bir televizyon fenomeni olarak bilinir.",
//			Director = "David Benioff, D. B. Weiss",
//			ImageUrl = "12.jpg",
//            GenreId = 4

//        },
//			 new Movie
//		{
//			MovieId = 13,
//			Title = "Sherlock",
//			Description = "Drama",
//			Director = "Mark Gatiss, Steven Moffat",
//			ImageUrl = "13.jpg",
//            GenreId = 1

//        },
//		new Movie
//		{
//			MovieId = 14,
//			Title = "Dark",
//			Description = "\"Sherlock\", Sir Arthur Conan Doyle'un ünlü dedektifi Sherlock Holmes'un modern bir uyarlamasıdır. Sherlock Holmes, sivri zekası, dikkat toplama yeteneği ve dedüktif becerileriyle tanınan bir özel dedektiftir. Dizi, Holmes'un en yakın arkadaşı ve yardımcısı Dr. John Watson ile birlikte Londra'da çeşitli suçları çözmesini konu alır. Modern zamanlara uyarlanmış bu versiyon, orijinal hikayelerin unsurlarını sürükleyici bir şekilde modern bir şehir manzarası içinde sunar. \"Sherlock\", karmaşık olay örgüleri, karakter gelişimi ve Benedict Cumberbatch ile Martin Freeman'ın performanslarıyla dikkat çeken bir dedektif dizisidir.",
//			Director = "Baran bo Odar, Jantje Friese",
//			ImageUrl = "14.jpg",
//            GenreId = 5

//        },
//		new Movie
//		{
//			MovieId = 15,
//			Title = "Fleabag",
//			Description = "\"Fleabag\", Phoebe Waller-Bridge'in aynı adlı tiyatro oyunundan uyarlanan ve başrolünde yer aldığı bir televizyon dizisidir. Dizi, Londra'da yaşayan, keskin zekalı ancak karmaşık bir genç kadın olan Fleabag'in hikayesini anlatır. Fleabag, aile ilişkileri, aşk, kayıp ve kendi iç dünyasıyla başa çıkmaya çalışırken izleyiciyle içten bir bağ kurar. Dizinin mizah anlayışı, duygusal derinliği ve Waller-Bridge'in performansı, \"Fleabag\"i benzersiz kılar ve büyük bir beğeni toplamasına neden olur.",
//			Director = "Phoebe Waller-Bridge",
//			ImageUrl = "98.jpg",
//            GenreId = 3

//        },
//	        };
//		}


//		public static List <Movie> Movies
//		{
//			get
//			{
//				return _movies;
//			}
//		}
//		public static void Add(Movie movie)
//		{
//			movie.MovieId= _movies.Count() +1;
//			_movies.Add(movie);
//		}
//		public static Movie GetById(int id)
//		{
//			return _movies.FirstOrDefault(m=>m.MovieId == id);
//		}

//		public static void Edit(Movie m)
//		{
//			foreach (var movie in _movies)
//			{
//				if (movie.MovieId == m.MovieId)
//				{
//					movie.Title=m.Title;
//					movie.Director=m.Director;
//					movie.Description = m.Description;
//					movie.ImageUrl=m.ImageUrl;
//					movie.GenreId = m.GenreId;
//					break;
//				}
//			}
//		}
//		public static void Delete(int MovieId)
//		{
//			var movie = GetById(MovieId);
//			if (movie != null)
//			{
//				_movies.Remove(movie);
//			}
//		}
//	}
//}
