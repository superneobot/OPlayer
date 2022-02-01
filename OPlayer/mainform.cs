using AngleSharp;
using AngleSharp.Io;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OPlayer
{
    public partial class mainform : Form
    {
        Kino kino = new Kino();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public string source;
        public string stream_url;
        public string quality;
        public string nsource;
        public string fname;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #region genres

        int genre;

        int all = 0;
        int anime = 7;
        int biography = 1848;
        int boevik = 65;
        int western = 5217;
        int voenniy = 843;
        int detective = 67;
        int detskiy = 1891;
        int foradult = 3614;
        int documentary = 6013;
        int drama = 50;
        int igra = 84253;
        int history = 1166;
        int comedy = 11;
        int concerte = 24579;
        int korotkometr = 431;
        int criminal = 517;
        int medodrama = 10;
        int music = 99;
        int mult = 8;
        int musical = 97;
        int news = 9042;
        int advent = 12;
        int realtv = 11729;
        int family = 98;
        int sport = 478;
        int tokshow = 86744;
        int thriller = 66;
        int horror = 418;
        int fantastic = 9;
        int noir = 21594;
        int fantasy = 83;
        int ceremony = 13420;

        List<int> list_allgenres;
        #endregion

        public mainform()
        {
            InitializeComponent();
            list_allgenres = new List<int>();
            #region list_genres_add
            list_allgenres.Add(all);
            list_allgenres.Add(anime);
            list_allgenres.Add(biography);
            list_allgenres.Add(boevik);
            list_allgenres.Add(western);
            list_allgenres.Add(voenniy);
            list_allgenres.Add(detective);
            list_allgenres.Add(detskiy);
            list_allgenres.Add(foradult);
            list_allgenres.Add(documentary);
            list_allgenres.Add(drama);
            list_allgenres.Add(igra);
            list_allgenres.Add(history);
            list_allgenres.Add(comedy);
            list_allgenres.Add(concerte);
            list_allgenres.Add(korotkometr);
            list_allgenres.Add(criminal);
            list_allgenres.Add(medodrama);
            list_allgenres.Add(music);
            list_allgenres.Add(mult);
            list_allgenres.Add(musical);
            list_allgenres.Add(news);
            list_allgenres.Add(advent);
            list_allgenres.Add(realtv);
            list_allgenres.Add(family);
            list_allgenres.Add(sport);
            list_allgenres.Add(tokshow);
            list_allgenres.Add(thriller);
            list_allgenres.Add(horror);
            list_allgenres.Add(fantastic);
            list_allgenres.Add(noir);
            list_allgenres.Add(fantasy);
            list_allgenres.Add(ceremony);

            genre_list.Items.AddRange(new object[] {
            "Все",
            "Анимэ",
            "Биография",
            "Боевик",
            "Вестерн",
            "Военный",
            "Детектив",
            "Детский",
            "Для взрослых",
            "Документальный",
            "Драма",
            "Игра",
            "История",
            "Комедия",
            "Концерт",
            "Короткометражка",
            "Криминал",
            "Мелодрама",
            "Музыка",
            "Мультфильм",
            "Мюзикл",
            "Новости",
            "Приключения",
            "Реальное тв",
            "Семейный",
            "Спорт",
            "Ток-шоу",
            "Триллер",
            "Ужасы",
            "Фантастика",
            "Фильм-нуар",
            "Фэнтези",
            "Церемония"});
            #endregion


        }

        private void top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        private void genre_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (genre_list.SelectedIndex)
            {
                case 0:
                    genre = 0;
                    LoadFilms(genre);
                    break;
                case 1:
                    genre = 7;
                    LoadFilms(genre);
                    break;
                case 2:
                    genre = 1848;
                    LoadFilms(genre);
                    break;
                case 3:
                    genre = 65;
                    LoadFilms(genre);
                    break;
                case 4:
                    genre = 5217;
                    LoadFilms(genre);
                    break;
                case 5:
                    genre = 843;
                    LoadFilms(genre);
                    break;
                case 6:
                    genre = 67;
                    LoadFilms(genre);
                    break;
                case 7:
                    genre = 1891;
                    LoadFilms(genre);
                    break;
                case 8:
                    genre = 3614;
                    LoadFilms(genre);
                    break;
                case 9:
                    genre = 6013;
                    LoadFilms(genre);
                    break;
                case 10:
                    genre = 50;
                    LoadFilms(genre);
                    break;
                case 11:
                    genre = 84253;
                    LoadFilms(genre);
                    break;
                case 12:
                    genre = 1166;
                    LoadFilms(genre);
                    break;
                case 13:
                    genre = 11;
                    LoadFilms(genre);
                    break;
                case 14:
                    genre = 24579;
                    LoadFilms(genre);
                    break;
                case 15:
                    genre = 431;
                    LoadFilms(genre);
                    break;
                case 16:
                    genre = 517;
                    LoadFilms(genre);
                    break;
                case 17:
                    genre = 10;
                    LoadFilms(genre);
                    break;
                case 18:
                    genre = 99;
                    LoadFilms(genre);
                    break;
                case 19:
                    genre = 8;
                    LoadFilms(genre);
                    break;
                case 20:
                    genre = 97;
                    LoadFilms(genre);
                    break;
                case 21:
                    genre = 9042;
                    LoadFilms(genre);
                    break;
                case 22:
                    genre = 12;
                    LoadFilms(genre);
                    break;
                case 23:
                    genre = 11729;
                    LoadFilms(genre);
                    break;
                case 24:
                    genre = 98;
                    LoadFilms(genre);
                    break;
                case 25:
                    genre = 478;
                    LoadFilms(genre);
                    break;
                case 26:
                    genre = 86744;
                    LoadFilms(genre);
                    break;
                case 27:
                    genre = 66;
                    LoadFilms(genre);
                    break;
                case 28:
                    genre = 418;
                    LoadFilms(genre);
                    break;
                case 29:
                    genre = 9;
                    LoadFilms(genre);
                    break;
                case 30:
                    genre = 21594;
                    LoadFilms(genre);
                    break;
                case 31:
                    genre = 83;
                    LoadFilms(genre);
                    break;
                case 32:
                    genre = 13420;
                    LoadFilms(genre);
                    break;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void get_films_Click(object sender, EventArgs e)
        {
            await kino.GetMaxFilms(genre);
            kino.links.Clear();
            kino.films.Clear();
            kino.pics.Clear();
            list_links.Items.Clear();
            bar.Maximum = kino.pages;
            for (int i = 1; i < kino.pages; i++)
            {


                await kino.GetPics(i, genre);
                await kino.GetFilms(i, genre);
                await kino.GetLinks(i, genre);

                for (int i1 = 0; i1 < kino.films.Count; i1++)
                {
                    string item = kino.films[i1];
                    list_links.Items.Add(item);

                    bar.Value = i;
                    string val = $"{(i * 100) / kino.pages}%";
                    bar.Progress = val;
                }
                status.Text = $"Обновляем категорию {genre_list.Items[genre_list.SelectedIndex]}";
                genre_list.Enabled = false;
            }
            bar.Value = 0;
            bar.Progress = "";
            Saving(genre);
            status.Text = "Готов";
            genre_list.Enabled = true;
        }

        private async void list_links_Click(object sender, EventArgs e)
        {
            quality_list.SelectedIndex = -1;
            dload.Text = "Скачать фильм";
            film_show.Enabled = false;
            quality_list.Enabled = false;
            dload.Enabled = false;
            try
            {
                if (list_links.SelectedIndices.Count >= 0)
                {

                    var pic_index = list_links.Items.IndexOf(list_links.SelectedItems[0]);

                    pbox.LoadAsync(kino.pics[pic_index]);
                    title.Text = kino.films[pic_index];

                    await GetStreamLink(kino.links[pic_index]);
                    await GetVideoSource(stream_url);
                    if (CheckURL(new Uri(stream_url)))
                    {
                        quality_list.Enabled = true;
                        fname = kino.films[pic_index].Replace(":", "-");
                    }
                    else
                    {
                        //
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public async void LoadFilms(int genre)
        {
            kino.links.Clear();
            kino.films.Clear();
            kino.pics.Clear();
            list_links.Items.Clear();
            pbox.Image = null;
            title.Text = "";
            get_films.Enabled = true;

            try
            {

                kino.links = LoadData($@"Data\links_{genre}.txt");
                kino.films = LoadData($@"Data\films_{genre}.txt");
                kino.pics = LoadData($@"Data\pics_{genre}.txt");
                bar.Maximum = kino.films.Count;
                await Task.Run(() =>
                {

                    for (int i = 0; i < kino.films.Count; i++)
                    {
                        Action add = () =>
                        {
                            list_links.Items.Add(kino.films[i]);
                            bar.Value = i;
                            bar.Progress = $"{i}/{kino.films.Count - 1}";
                        };
                        Invoke(add);
                    }
                });

            }
            catch
            {

            }
        }

        public void Saving(int genre)
        {

            Directory.CreateDirectory(Application.StartupPath + @"\Data");
            var path1 = Application.StartupPath + @"\Data\" + $"links_{genre}.txt";
            var path2 = Application.StartupPath + @"\Data\" + $"films_{genre}.txt";
            var path3 = Application.StartupPath + @"\Data\" + $"pics_{genre}.txt";
            SaveData(path1, kino.links);
            SaveData(path2, kino.films);
            SaveData(path3, kino.pics);
        }

        public void SaveData(string path, List<string> msc)
        {
            XmlTextWriter xw = new XmlTextWriter(path, Encoding.UTF8);
            //а это чтобы красиво было :)
            xw.Formatting = Formatting.Indented;
            XmlDictionaryWriter writer = XmlDictionaryWriter.CreateDictionaryWriter(xw);
            DataContractSerializer ser = new DataContractSerializer(typeof(List<string>));
            ser.WriteObject(writer, msc);
            writer.Close();
            xw.Close();
        }

        public List<string> LoadData(string path)
        {
            List<string> msc = null; using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                DataContractSerializer ser = new DataContractSerializer(typeof(List<string>));
                msc = (List<string>)ser.ReadObject(reader);
            }

            return msc;
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private string GetFileSize(Uri uriPath)
        {
            var webRequest = HttpWebRequest.Create(uriPath);
            webRequest.Method = "HEAD";

            using (var webResponse = webRequest.GetResponse())
            {
                var fileSize = webResponse.Headers.Get("Content-Length");
                var fileSizeInMegaByte = Math.Round(Convert.ToDouble(fileSize) / 1024.0 / 1024.0, 2);
                return fileSizeInMegaByte + " MB";
            }
        }

        private void quality_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (quality_list.SelectedIndex)
                {
                    case 0:
                        quality = "240.mp4";
                        nsource = $"{source}{quality}";
                        if (CheckURL(new Uri(nsource)) == true)
                        {
                            try
                            {
                                film_show.Enabled = true;
                                nsource = $"{source}{quality}";
                                dload.Text = $"Скачать фильм({GetFileSize(new Uri(nsource))})";
                                dload.Enabled = true;
                            }
                            catch
                            {
                                dload.Text = $"Скачать фильм";
                            }
                        }
                        else
                        {
                            film_show.Enabled = false;
                            dload.Enabled = false;
                            dload.Text = $"Скачать фильм";
                        }
                        break;
                    case 1:
                        quality = "360.mp4";
                        nsource = $"{source}{quality}";
                        if (CheckURL(new Uri(nsource)) == true)
                        {
                            try
                            {
                                film_show.Enabled = true;
                                nsource = $"{source}{quality}";
                                dload.Text = $"Скачать фильм({GetFileSize(new Uri(nsource))})";
                                dload.Enabled = true;
                            }
                            catch
                            {
                                dload.Text = $"Скачать фильм";
                            }
                        }
                        else
                        {
                            film_show.Enabled = false;
                            dload.Enabled = false;
                            dload.Text = $"Скачать фильм";
                        }
                        break;
                    case 2:
                        quality = "720.mp4";
                        nsource = $"{source}{quality}";
                        if (CheckURL(new Uri(nsource)) == true)
                        {
                            try
                            {
                                film_show.Enabled = true;
                                nsource = $"{source}{quality}";
                                dload.Text = $"Скачать фильм({GetFileSize(new Uri(nsource))})";
                                dload.Enabled = true;
                            }
                            catch
                            {
                                dload.Text = $"Скачать фильм";
                            }
                        }
                        else
                        {
                            film_show.Enabled = false;
                            dload.Enabled = false;
                            dload.Text = $"Скачать фильм";
                        }
                        break;
                    case 3:
                        quality = "1080.mp4";
                        nsource = $"{source}{quality}";
                        if (CheckURL(new Uri(nsource)) == true)
                        {
                            try
                            {
                                film_show.Enabled = true;
                                nsource = $"{source}{quality}";
                                dload.Text = $"Скачать фильм({GetFileSize(new Uri(nsource))})";
                                dload.Enabled = true;
                            }
                            catch
                            {
                                dload.Text = $"Скачать фильм";
                            }
                        }
                        else
                        {
                            film_show.Enabled = false;
                            dload.Enabled = false;
                            dload.Text = $"Скачать фильм";
                        }
                        break;
                }
            }
            catch
            {

            }
        }

        public async Task<string> GetStreamLink(string url)
        {
            var requester = new DefaultHttpRequester("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:70.0) Gecko/20100101 Firefox/69.0");
            var config = Configuration.Default.WithDefaultLoader().With(requester);
            var document = await BrowsingContext.New(config).OpenAsync(url);

            var get_script = document.QuerySelector("div[id='player-videocdn']");

            var stream = get_script.ToHtml();
            var str = stream.Trim().Split(';');
            var st = str[3].Replace("var src =", "").Replace("+", "").Replace("'", "").Trim();
            stream_url = st;

            return stream_url;
        }

        public async Task<string> GetVideoSource(string url)
        {
            var requester = new DefaultHttpRequester("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:70.0) Gecko/20100101 Firefox/69.0");
            var config = Configuration.Default.WithDefaultLoader().With(requester);
            var document = await BrowsingContext.New(config).OpenAsync(url);

            var source_box = document.QuerySelectorAll("input[type='hidden']");
            var uri = source_box[1].OuterHtml.Split(' ');

            var str = uri[7].Split('/');
            var st = (str[2] + str[3] + str[4] + str[5]).Replace("\\", "/");
            var link = $"https://{st}";
            source = link;

            return source;

        }

        static bool CheckURL(Uri url)
        {
            if (String.IsNullOrEmpty(url.AbsoluteUri))
                return false;

            var request = HttpWebRequest.Create(url);
            try
            {
                HttpWebResponse res = request.GetResponse() as HttpWebResponse;

                if (res.StatusDescription == "OK")
                    return true;
            }
            catch
            {
            }
            return false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await GetVideoSource(stream_url);
                var nsource = $"{source}{quality}";
                System.Diagnostics.Process.Start("wmplayer.exe", nsource);
            }
            catch (Exception ex2)
            {
                MessageBox.Show($"К сожалению видео не доступно", "Online Video Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void dload_Click(object sender, EventArgs e)
        {
            var path = Application.StartupPath;
            try
            {
                await GetVideoSource(stream_url);
                var nsource = $"{source}{quality}";
                //textBox1.Text = nsource;
                // MessageBox.Show(Path.Combine(path, $"{fname}({chooseQuality.SelectedItem}).mp4"));
                using (WebClient client = new WebClient())
                {
                    client.DownloadProgressChanged += (s, a) => { loading.Value = a.ProgressPercentage; loading.Progress = $"{a.ProgressPercentage}%"; status.Text = $"Качаем видео - {fname}"; };

                    //client.DownloadFileAsync(new Uri(nsource), Path.Combine(path, $"{fname}({chooseQuality.SelectedItem}).mp4"));
                    if (nsource != null)
                    {
                        SaveFileDialog savedialog = new SaveFileDialog();
                        savedialog.Title = "Сохранить видео как...";
                        savedialog.OverwritePrompt = true;
                        savedialog.CheckPathExists = true;
                        savedialog.Filter = "MP4 Video File(*.mp4)|*.mp4|All files (*.*)|*.*";
                        savedialog.ShowHelp = true;
                        var saveFileName = $"{fname}({quality_list.SelectedItem}).mp4";
                        savedialog.FileName = saveFileName;
                        if (savedialog.ShowDialog() == DialogResult.OK)
                        {

                            try
                            {
                                //image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                                client.DownloadFileAsync(new Uri(nsource), savedialog.FileName);
                            }
                            catch
                            {
                                MessageBox.Show("Невозможно сохранить видео", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    client.DownloadFileCompleted += delegate { loading.Value = 0; loading.Progress = "Загрузка завершена"; status.Text = "Готов"; };
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show($"К сожалению видео не доступно", "Online Video Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
