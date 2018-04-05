using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PLAY2
{
    public partial class panel_menu : Form
    {
        int maxrows = 20;


        public panel_menu()
        {
            pes_tb();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void pes_tb()
        {
            //cnn = new SqlConnection("Data Source=192.168.2.39,1433; Network Library=DBMSSOCN;Initial Catalog=Catalgo; User ID=admin;Password=caixilour1");  //coneção
            // cnn = new SqlConnection("Data Source=192.168.2.168,1433; Network Library=DBMSSOCN;Initial Catalog=caixilour_estoque; User ID=admin;Password=caixilour");
            ////ligar tab
            // SqlConnection cnn = new SqlConnection("Data Source=192.168.1.2,1433; Network Library=DBMSSOCN;Initial Catalog=catalogo; User ID=admin;Password=caixilour");



            PictureBox[] pb_array = new PictureBox[maxrows];//array de ing
            int n;
            int i = 0;
            int x = 0;

            //panel.Controls.Clear();

            for (n = 0; n <= maxrows - 1; n++)
            {
                // comverte byte ei img
                //Byte[] fotos = (byte[])dat_tab_tab.Rows[n]["Imagem"];
                //MemoryStream ms = new MemoryStream(fotos);
               // System.Drawing.Image fotos_s = System.Drawing.Image.FromStream(ms);
                //cria pb no panel_menu
                x++;
                pb_array[n] = new PictureBox();
                pb_array[n].Location = new Point(16 + ((x - 1) * 155), 10 + (146 * i));
                pb_array[n].Size = new Size(133, 140);
                pb_array[n].SizeMode = PictureBoxSizeMode.Zoom;
                pb_array[n].Image = pictureBox1.BackgroundImage;
                //pb_array[n].Image = fotos_s;
                pb_array[n].Name = Convert.ToString(n);
                this.Controls.Add(panel);
                pb_array[n].Click += new EventHandler(this.click_fotos_Click);
                panel.Controls.Add(pb_array[n]);
                if (x == 5)
                {
                    x = 0;
                    i = i + 1;
                }
            }
        
        }
        public void click_fotos_Click(object sender, EventArgs e)
        {

            var Pictur = sender as PictureBox;
            for (int i = 0; i < maxrows; i++)
            {
                if (Pictur != null && Pictur.Name == Convert.ToString(i))
                {
                }  
            }
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            panel.AutoScroll = true;
            System.Drawing.Rectangle r = this.ClientRectangle;
        }
    }
}
