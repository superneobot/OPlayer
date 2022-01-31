using AngleSharp;
using AngleSharp.Io;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OPlayer
{
    public class Kino
    {
        public List<string> links;
        public List<string> films;
        public List<string> pics;
        public int genre;


        public int pages;
        string asrequester;

        public Kino()
        {
            links = new List<string>();
            films = new List<string>();
            pics = new List<string>();
            asrequester = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:70.0) Gecko/20100101 Firefox/69.0";

        }

        public async Task<List<string>> GetLinks(int page, int genre)
        {
            var url = $"https://nu3.hdreska.club/search?q=&group=&year=&genre={genre}&type=2&country=&tag=&order=mostRecent&yearFrom=1960&yearTo=2022&ratingFrom=&ratingTo=10&sameMovieId=&p={page}";

            var requester = new DefaultHttpRequester(asrequester);
            var config = Configuration.Default.WithDefaultLoader().With(requester);
            var document = await BrowsingContext.New(config).OpenAsync(url);


            var allfilms = document.QuerySelectorAll("div[class='th-item']");

            foreach (var item in allfilms)
            {
                var pic = item.QuerySelector("a[class='th-in with-mask']");
                var pic_link = pic.GetAttribute("href");
                var alink = "https://nu3.hdreska.club" + pic_link;

                links.Add(alink);
            }
            return links;
        }

        public async Task<List<string>> GetFilms(int page, int genre)
        {
            var url = $"https://nu3.hdreska.club/search?q=&group=&year=&genre={genre}&type=2&country=&tag=&order=mostRecent&yearFrom=1960&yearTo=2022&ratingFrom=&ratingTo=10&sameMovieId=&p={page}";

            var requester = new DefaultHttpRequester(asrequester);
            var config = Configuration.Default.WithDefaultLoader().With(requester);
            var document = await BrowsingContext.New(config).OpenAsync(url);


            var allfilms = document.QuerySelectorAll("div[class='th-item']");

            foreach (var item in allfilms)
            {
                var pic = item.QuerySelector("img");
                var pic_link = pic.GetAttribute("alt");
                films.Add(pic_link);
            }

            return films;
        }

        public async Task<List<string>> GetPics(int page, int genre)
        {
            var url = $"https://nu3.hdreska.club/search?q=&group=&year=&genre={genre}&type=2&country=&tag=&order=mostRecent&yearFrom=1960&yearTo=2022&ratingFrom=&ratingTo=10&sameMovieId=&p={page}";

            var requester = new DefaultHttpRequester(asrequester);
            var config = Configuration.Default.WithDefaultLoader().With(requester);
            var document = await BrowsingContext.New(config).OpenAsync(url);


            var films = document.QuerySelectorAll("div[class='th-item']");

            foreach (var item in films)
            {
                var pic = item.QuerySelector("img");
                var pic_link = pic.GetAttribute("srcset");
                pics.Add("https://nu3.hdreska.club" + pic_link);
            }

            return pics;
        }

        public async Task<int> GetMaxFilms(int genre)
        {
            var url = $"https://nu3.hdreska.club/search?q=&group=&year=&genre={genre}&type=2&country=&tag=&order=mostRecent&yearFrom=1960&yearTo=2022&ratingFrom=&ratingTo=10&sameMovieId=&p=2";

            var requester = new DefaultHttpRequester(asrequester);
            var config = Configuration.Default.WithDefaultLoader().With(requester);
            var document = await BrowsingContext.New(config).OpenAsync(url);

            var navigate = document.QuerySelector("div[class='navigation']");
            var allpages = navigate.QuerySelectorAll("a");
            if (allpages.Length == 7)
            {
                var page = allpages[5].TextContent;
                pages = Convert.ToInt32(page);
            }
            else if (allpages.Length == 6)
            {
                var page = allpages[4].TextContent;
                pages = Convert.ToInt32(page);
            }
            else if (allpages.Length == 0)
            {
                pages = 1;
            }
            else if (allpages.Length == 4)
            {
                var page = allpages[2].TextContent;
                pages = Convert.ToInt32(page);
            }
            else if (allpages.Length == 3)
            {
                var page = allpages[2].TextContent;
                pages = Convert.ToInt32(page);
            }


            return pages;

        }

    }
}
