using ClassLibrary1.ORM.Entity.Concerte;
using SteamProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamProject.UI
{
    public partial class GameList : Form
    {
        int AddedGame_Height = 0;
        int fromLeft = 0, fromUp = 0;
        public GameList()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();
        private void GameList_Load(object sender, EventArgs e)
        {
            List<Game> games = db.Games.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();

            foreach (var item in games)
            {
                
                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                    GroupBox groupBox = new GroupBox();
                    PictureBox pictureBox = new PictureBox();
                    Label labelname = new Label();
                    Label labeldesc = new Label();

                    flowLayoutPanel.Width = 200;
                    flowLayoutPanel.Height = 500;
                    flowLayoutPanel.Location = new Point(200, 80);

                    groupBox.Size = new Size(500, 500);


                    labelname.Text = item.Name;
                    labelname.AutoSize = true;
                    labelname.Width = flowLayoutPanel.Width;


                    pictureBox.Height = 300;
                    pictureBox.Image = new Bitmap(item.PictureUrl);
                    pictureBox.Width = flowLayoutPanel.Width;

                    labeldesc.AutoSize = false;
                    labeldesc.Text = item.Descreption;
                    labeldesc.Height = 100;
                    labeldesc.Width = flowLayoutPanel.Width;

                    flowLayoutPanel.Controls.Add(labelname);
                    flowLayoutPanel.Controls.Add(pictureBox);
                    flowLayoutPanel.Controls.Add(labeldesc);
                    this.Controls.Add(flowLayoutPanel);
                    fromUp = (flowLayoutPanel.Height * (AddedGame_Height / flowLayoutPanel.Height));

                    AddedGame_Height += flowLayoutPanel.Height;

                    switch (AddedGame_Height > this.Height)
                    {
                        case true:
                            fromUp = 0;
                            fromLeft += flowLayoutPanel.Width + 100;
                            AddedGame_Height = flowLayoutPanel.Height;
                            break;
                    }
                    flowLayoutPanel.Location = new Point(fromLeft + 0, fromUp + 20);
                
               
            }
        }
    }
}
