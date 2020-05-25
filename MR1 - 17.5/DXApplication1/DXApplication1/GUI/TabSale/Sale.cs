using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.GUI
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            LoadAll();
        }
        void LoadPnTable()
        {
            Color[] color = new Color[] { Color.Aqua, Color.BlueViolet };
            pnTable.BackColor = Color.Azure;
            pnTable.AutoScroll = true;

            int size = pnTable.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;

            for (int i = 0; i < 50; ++i)
            {
                Button btn = new Button()
                {
                    Text = i.ToString(),
                    AutoSize = true,
                    Size = new Size(size - 10, size - 10),
                    BackColor = color[i % 2]
                };

                pnTable.Controls.Add(btn);
            }
        }

        void LoadPnlFood()
        {
            int sizeImg = 65;
            int sizeBtn = 90;
            for (int i = 0; i < 10; ++i)
            {
                Image img = System.Drawing.Image.FromFile(@"E:\DoAn\MR1 - 17.5\DXApplication1\DXApplication1\Image\FoodImg\TomHum.jpg");
                img = (Image)(new Bitmap(img, sizeImg, sizeImg));
                Button btn = new Button() { Size = new Size(sizeBtn, sizeBtn), FlatStyle = FlatStyle.Flat, BackgroundImageLayout = ImageLayout.Zoom, Image = img, Text = "300.000", TextAlign = ContentAlignment.BottomCenter, ImageAlign = ContentAlignment.TopCenter };
                btn.BackColor = Color.White;

                pnlFood.Controls.Add(btn);
            }
        }

        void LoadAll()
        {
            LoadPnTable();
            LoadPnlFood();
        }
    }
}
