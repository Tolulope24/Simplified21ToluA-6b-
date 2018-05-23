using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21ToluA_6b_
{
    public partial class frmSimplified21 : Form
    {
        public frmSimplified21()
        {
            InitializeComponent();
        }


        private void GenerateDeckCard(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location 
            PictureBox tmpDeck = new PictureBox();
            Point pntCard = new System.Drawing.Point(x, y);
            // set the location of the picture box
            tmpDeck.Location = pntCard;
            // assign the card to the picture box
            tmpDeck.Image = Properties.Resources.d01;
            // stretch the Card to the size of the picture box
            tmpDeck.SizeMode = PictureBoxSizeMode.StretchImage;
            // make the height and width to be the same as the card
            tmpDeck.ClientSize = new Size(Properties.Resources.c01.Width, Properties.Resources.c01.Height);
            // add the picture box to the form
            this.Controls.Add(tmpDeck);


        }


        private void GenerateComputerDeckCards()
        {
            GenerateDeckCard(23, 230);
            GenerateDeckCard(100, 230);
            GenerateDeckCard(177, 230);
        }

        private void GeneratePlayerDeckCards()
        {
            // generate each of the picture boxes on the form
            GenerateDeckCard(23, 30);
            GenerateDeckCard(100, 30);
            GenerateDeckCard(177, 30);

        }
        private void frmSimplified21_Load(object sender, EventArgs e)
        {

        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            GeneratePlayerDeckCards();
            int randomIndex;


            // create an empty list of card images
            List<Image> Card = new List<Image>();
            // add elements to list
            Card.Add(Properties.Resources.c01);
            Card.Add(Properties.Resources.c02);
            Card.Add(Properties.Resources.c03);
            Card.Add(Properties.Resources.c04);
            Card.Add(Properties.Resources.c05);
            Card.Add(Properties.Resources.c06);
            Card.Add(Properties.Resources.c07);
            Card.Add(Properties.Resources.c08);
            Card.Add(Properties.Resources.c09);
            Card.Add(Properties.Resources.c10);
            Card.Add(Properties.Resources.c11);
            Card.Add(Properties.Resources.c12);
            Card.Add(Properties.Resources.c13);
            Card.Add(Properties.Resources.d01);
            Card.Add(Properties.Resources.d02);
            Card.Add(Properties.Resources.d03);
            Card.Add(Properties.Resources.d04);
            Card.Add(Properties.Resources.d05);
            Card.Add(Properties.Resources.d06);
            Card.Add(Properties.Resources.d07);
            Card.Add(Properties.Resources.d08);
            Card.Add(Properties.Resources.d09);
            Card.Add(Properties.Resources.d10);
            Card.Add(Properties.Resources.d11);
            Card.Add(Properties.Resources.d12);
            Card.Add(Properties.Resources.d13);
            Card.Add(Properties.Resources.h01);
            Card.Add(Properties.Resources.h01);
            Card.Add(Properties.Resources.h02);
            Card.Add(Properties.Resources.h03);
            Card.Add(Properties.Resources.h04);
            Card.Add(Properties.Resources.h05);
            Card.Add(Properties.Resources.h06);
            Card.Add(Properties.Resources.h07);
            Card.Add(Properties.Resources.h08);
            Card.Add(Properties.Resources.h09);
            Card.Add(Properties.Resources.h10);
            Card.Add(Properties.Resources.h11);
            Card.Add(Properties.Resources.h12);
            Card.Add(Properties.Resources.h13);
            Card.Add(Properties.Resources.s01);
            Card.Add(Properties.Resources.s02);
            Card.Add(Properties.Resources.s03);
            Card.Add(Properties.Resources.s04);
            Card.Add(Properties.Resources.s05);
            Card.Add(Properties.Resources.s06);
            Card.Add(Properties.Resources.s07);
            Card.Add(Properties.Resources.s08);
            Card.Add(Properties.Resources.s09);
            Card.Add(Properties.Resources.s10);
            Card.Add(Properties.Resources.s11);
            Card.Add(Properties.Resources.s12);
            Card.Add(Properties.Resources.s13);
            // set player index randomly in the first player card
            Random randomCardIndex = new Random();
            randomIndex = randomCardIndex.Next(0, Card.Count-1);

            
            if (randomIndex == 0)
            {
                Card.Insert (randomIndex,Properties.Resources.c01);
                Card.RemoveAt(0);
            }
            else if (randomIndex == 1)
            {
                Card.Insert(randomIndex, Properties.Resources.c02);
            }
            else if (randomIndex == 2)
            {
                Card.Insert(randomIndex, Properties.Resources.c03);
            }
            else if (randomIndex == 3)
            {
                Card.Insert(randomIndex, Properties.Resources.c04);
            }
            else if (randomIndex == 4)
            {
                Card.Insert(randomIndex, Properties.Resources.c05);
            }
            else if (randomIndex == 5)
            {
                Card.Insert(randomIndex, Properties.Resources.c06);
            }
            
            else if (randomIndex == 6)
            {
                Card.Insert(randomIndex, Properties.Resources.c07);
            }
            else if (randomIndex == 7)
            {
                Card.Insert(randomIndex, Properties.Resources.c08);
            }
            else if (randomIndex == 8)
            {
                Card.Insert(randomIndex, Properties.Resources.c09);
            }
            else if (randomIndex == 9)
            {
                Card.Insert(randomIndex, Properties.Resources.c10);
            }
            else if (randomIndex == 10)
            {
                Card.Insert(randomIndex, Properties.Resources.c11);
            }
            else if (randomIndex == 11)
            {
                Card.Insert(randomIndex, Properties.Resources.c12);
            }
            else if (randomIndex == 12)
            {
                Card.Insert(randomIndex, Properties.Resources.c13);
            }
            else if (randomIndex == 13)
            {
                Card.Insert(randomIndex, Properties.Resources.d01);
            }
            /*
            else if (randomIndex == 14)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d02;
            }
            else if (randomIndex == 15)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d03;
            }
            else if (randomIndex == 16)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d04;
            }
            else if (randomIndex == 17)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d05;
            }
            else if (randomIndex == 18)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d06;
            }
            else if (randomIndex == 19)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d07;
            }
            else if (randomIndex == 20)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d08;
            }
            else if (randomIndex == 21)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d09;
            }
            else if (randomIndex == 22)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d10;
            }
            else if (randomIndex == 23)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d11;
            }
            else if (randomIndex == 24)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d12;
            }
            else if (randomIndex == 25)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d13;
            }
            else if (randomIndex == 26)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h01;
            }
            else if (randomIndex == 27)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h02;
            }
            else if (randomIndex == 28)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h03;
            }
            else if (randomIndex == 29)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h04;
            }
            else if (randomIndex == 30)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h05;
            }
            else if (randomIndex == 31)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h06;
            }
            else if (randomIndex == 32)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h07;
            }
            else if (randomIndex == 33)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h08;
            }
            else if (randomIndex == 34)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h09;
            }
            else if (randomIndex == 35)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h10;
            }
            else if (randomIndex == 36)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h11;
            }
            else if (randomIndex == 37)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h12;
            }
            else if (randomIndex == 38)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h13;
            }
            else if (randomIndex == 39)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s01;
            }
            else if (randomIndex == 40)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s02;
            }
            else if (randomIndex == 41)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s03;
            }
            else if (randomIndex == 42)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s04;
            }
            else if (randomIndex == 43)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s05;
            }
            else if (randomIndex == 44)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s06;
            }
            else if (randomIndex == 45)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s07;
            }
            else if (randomIndex == 46)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s08;
            }
            else if (randomIndex == 47)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s09;
            }
            else if (randomIndex == 48)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s10;
            }
            else if (randomIndex == 49)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s11;
            }
            else if (randomIndex == 50)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s12;
            }
            else 
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s13;
            }
            

            //

            //place the image in the given picture box

            //
            */


        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
