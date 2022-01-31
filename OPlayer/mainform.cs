using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OPlayer
{
    public partial class mainform : Form
    {
        Kino kino = new Kino();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        

        public mainform()
        {
            InitializeComponent();
           
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
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void get_films_Click(object sender, EventArgs e)
        {
            await kino.GetPics(2, 1166);
            await kino.GetFilms(2, 1166);
            foreach (var item in kino.pics)
            {
                list_links.Items.Add(item);
            }
        }

        private void list_links_Click(object sender, EventArgs e)
        {
            if (list_links.SelectedIndices.Count >= 0)
            {
                var pic_index = list_links.Items.IndexOf(list_links.SelectedItems[0]);

                pbox.LoadAsync(kino.pics[pic_index]);
                title.Text = kino.films[pic_index];
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

    }
}
