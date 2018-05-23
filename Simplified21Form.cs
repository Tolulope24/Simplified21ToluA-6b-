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
            picFirstComputerCard.Hide();
            picsecondComputerCard.Hide();
            picThirdComputerCard.Hide();
        }

        private void frmSimplified21_Load(object sender, EventArgs e)
        {

        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            int randomIndex;
            int secondRandomIndex;
            int thirdRandomIndex;
            // create an empty list of card images
            List<Image> playerFirstCard = new List<Image>();
            // add elements to list
            playerFirstCard.Add(Properties.Resources.c01);
            playerFirstCard.Add(Properties.Resources.c02);
            playerFirstCard.Add(Properties.Resources.c03);
            playerFirstCard.Add(Properties.Resources.c04);
            playerFirstCard.Add(Properties.Resources.c05);
            playerFirstCard.Add(Properties.Resources.c06);
            playerFirstCard.Add(Properties.Resources.c07);
            playerFirstCard.Add(Properties.Resources.c08);
            playerFirstCard.Add(Properties.Resources.c09);
            playerFirstCard.Add(Properties.Resources.c10);
            playerFirstCard.Add(Properties.Resources.c11);
            playerFirstCard.Add(Properties.Resources.c12);
            playerFirstCard.Add(Properties.Resources.c13);
            playerFirstCard.Add(Properties.Resources.d01);
            playerFirstCard.Add(Properties.Resources.d02);
            playerFirstCard.Add(Properties.Resources.d03);
            playerFirstCard.Add(Properties.Resources.d04);
            playerFirstCard.Add(Properties.Resources.d05);
            playerFirstCard.Add(Properties.Resources.d06);
            playerFirstCard.Add(Properties.Resources.d07);
            playerFirstCard.Add(Properties.Resources.d08);
            playerFirstCard.Add(Properties.Resources.d09);
            playerFirstCard.Add(Properties.Resources.d10);
            playerFirstCard.Add(Properties.Resources.d11);
            playerFirstCard.Add(Properties.Resources.d12);
            playerFirstCard.Add(Properties.Resources.d13);
            playerFirstCard.Add(Properties.Resources.h01);
            playerFirstCard.Add(Properties.Resources.h01);
            playerFirstCard.Add(Properties.Resources.h02);
            playerFirstCard.Add(Properties.Resources.h03);
            playerFirstCard.Add(Properties.Resources.h04);
            playerFirstCard.Add(Properties.Resources.h05);
            playerFirstCard.Add(Properties.Resources.h06);
            playerFirstCard.Add(Properties.Resources.h07);
            playerFirstCard.Add(Properties.Resources.h08);
            playerFirstCard.Add(Properties.Resources.h09);
            playerFirstCard.Add(Properties.Resources.h10);
            playerFirstCard.Add(Properties.Resources.h11);
            playerFirstCard.Add(Properties.Resources.h12);
            playerFirstCard.Add(Properties.Resources.h13);
            playerFirstCard.Add(Properties.Resources.s01);
            playerFirstCard.Add(Properties.Resources.s02);
            playerFirstCard.Add(Properties.Resources.s03);
            playerFirstCard.Add(Properties.Resources.s04);
            playerFirstCard.Add(Properties.Resources.s05);
            playerFirstCard.Add(Properties.Resources.s06);
            playerFirstCard.Add(Properties.Resources.s07);
            playerFirstCard.Add(Properties.Resources.s08);
            playerFirstCard.Add(Properties.Resources.s09);
            playerFirstCard.Add(Properties.Resources.s10);
            playerFirstCard.Add(Properties.Resources.s11);
            playerFirstCard.Add(Properties.Resources.s12);
            playerFirstCard.Add(Properties.Resources.s13);
            // create an empty list of card images
            List<Image> playerSecondCard = new List<Image>();
            // add elements to list
            playerSecondCard.Add(Properties.Resources.c01);
            playerSecondCard.Add(Properties.Resources.c02);
            playerSecondCard.Add(Properties.Resources.c03);
            playerSecondCard.Add(Properties.Resources.c04);
            playerSecondCard.Add(Properties.Resources.c05);
            playerSecondCard.Add(Properties.Resources.c06);
            playerSecondCard.Add(Properties.Resources.c07);
            playerSecondCard.Add(Properties.Resources.c08);
            playerSecondCard.Add(Properties.Resources.c09);
            playerSecondCard.Add(Properties.Resources.c10);
            playerSecondCard.Add(Properties.Resources.c11);
            playerSecondCard.Add(Properties.Resources.c12);
            playerSecondCard.Add(Properties.Resources.c13);
            playerSecondCard.Add(Properties.Resources.d01);
            playerSecondCard.Add(Properties.Resources.d02);
            playerSecondCard.Add(Properties.Resources.d03);
            playerSecondCard.Add(Properties.Resources.d04);
            playerSecondCard.Add(Properties.Resources.d05);
            playerSecondCard.Add(Properties.Resources.d06);
            playerSecondCard.Add(Properties.Resources.d07);
            playerSecondCard.Add(Properties.Resources.d08);
            playerSecondCard.Add(Properties.Resources.d09);
            playerSecondCard.Add(Properties.Resources.d10);
            playerSecondCard.Add(Properties.Resources.d11);
            playerSecondCard.Add(Properties.Resources.d12);
            playerSecondCard.Add(Properties.Resources.d13);
            playerSecondCard.Add(Properties.Resources.h01);
            playerSecondCard.Add(Properties.Resources.h01);
            playerSecondCard.Add(Properties.Resources.h02);
            playerSecondCard.Add(Properties.Resources.h03);
            playerSecondCard.Add(Properties.Resources.h04);
            playerSecondCard.Add(Properties.Resources.h05);
            playerSecondCard.Add(Properties.Resources.h06);
            playerSecondCard.Add(Properties.Resources.h07);
            playerSecondCard.Add(Properties.Resources.h08);
            playerSecondCard.Add(Properties.Resources.h09);
            playerSecondCard.Add(Properties.Resources.h10);
            playerSecondCard.Add(Properties.Resources.h11);
            playerSecondCard.Add(Properties.Resources.h12);
            playerSecondCard.Add(Properties.Resources.h13);
            playerSecondCard.Add(Properties.Resources.s01);
            playerSecondCard.Add(Properties.Resources.s02);
            playerSecondCard.Add(Properties.Resources.s03);
            playerSecondCard.Add(Properties.Resources.s04);
            playerSecondCard.Add(Properties.Resources.s05);
            playerSecondCard.Add(Properties.Resources.s06);
            playerSecondCard.Add(Properties.Resources.s07);
            playerSecondCard.Add(Properties.Resources.s08);
            playerSecondCard.Add(Properties.Resources.s09);
            playerSecondCard.Add(Properties.Resources.s10);
            playerSecondCard.Add(Properties.Resources.s11);
            playerSecondCard.Add(Properties.Resources.s12);
            playerSecondCard.Add(Properties.Resources.s13);
            // create an empty list of card images
            List<Image> playerThirdCard = new List<Image>();
            // add elements to list
            playerThirdCard.Add(Properties.Resources.c01);
            playerThirdCard.Add(Properties.Resources.c02);
            playerThirdCard.Add(Properties.Resources.c03);
            playerThirdCard.Add(Properties.Resources.c04);
            playerThirdCard.Add(Properties.Resources.c05);
            playerThirdCard.Add(Properties.Resources.c06);
            playerThirdCard.Add(Properties.Resources.c07);
            playerThirdCard.Add(Properties.Resources.c08);
            playerThirdCard.Add(Properties.Resources.c09);
            playerThirdCard.Add(Properties.Resources.c10);
            playerThirdCard.Add(Properties.Resources.c11);
            playerThirdCard.Add(Properties.Resources.c12);
            playerThirdCard.Add(Properties.Resources.c13);
            playerThirdCard.Add(Properties.Resources.d01);
            playerThirdCard.Add(Properties.Resources.d02);
            playerThirdCard.Add(Properties.Resources.d03);
            playerThirdCard.Add(Properties.Resources.d04);
            playerThirdCard.Add(Properties.Resources.d05);
            playerThirdCard.Add(Properties.Resources.d06);
            playerThirdCard.Add(Properties.Resources.d07);
            playerThirdCard.Add(Properties.Resources.d08);
            playerThirdCard.Add(Properties.Resources.d09);
            playerThirdCard.Add(Properties.Resources.d10);
            playerThirdCard.Add(Properties.Resources.d11);
            playerThirdCard.Add(Properties.Resources.d12);
            playerThirdCard.Add(Properties.Resources.d13);
            playerThirdCard.Add(Properties.Resources.h01);
            playerThirdCard.Add(Properties.Resources.h01);
            playerThirdCard.Add(Properties.Resources.h02);
            playerThirdCard.Add(Properties.Resources.h03);
            playerThirdCard.Add(Properties.Resources.h04);
            playerThirdCard.Add(Properties.Resources.h05);
            playerThirdCard.Add(Properties.Resources.h06);
            playerThirdCard.Add(Properties.Resources.h07);
            playerThirdCard.Add(Properties.Resources.h08);
            playerThirdCard.Add(Properties.Resources.h09);
            playerThirdCard.Add(Properties.Resources.h10);
            playerThirdCard.Add(Properties.Resources.h11);
            playerThirdCard.Add(Properties.Resources.h12);
            playerThirdCard.Add(Properties.Resources.h13);
            playerThirdCard.Add(Properties.Resources.s01);
            playerThirdCard.Add(Properties.Resources.s02);
            playerThirdCard.Add(Properties.Resources.s03);
            playerThirdCard.Add(Properties.Resources.s04);
            playerThirdCard.Add(Properties.Resources.s05);
            playerThirdCard.Add(Properties.Resources.s06);
            playerThirdCard.Add(Properties.Resources.s07);
            playerThirdCard.Add(Properties.Resources.s08);
            playerThirdCard.Add(Properties.Resources.s09);
            playerThirdCard.Add(Properties.Resources.s10);
            playerThirdCard.Add(Properties.Resources.s11);
            playerThirdCard.Add(Properties.Resources.s12);
            playerThirdCard.Add(Properties.Resources.s13);
            // set player index randomly in the first player card
            Random randomFirstPlayerIndex = new Random();
            randomIndex = randomFirstPlayerIndex.Next(0, playerFirstCard.Count-1);

            if (randomIndex == 1)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c01;
            }
            else if (randomIndex == 2)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c02;
            }
            else if (randomIndex == 3)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c03;
            }
            else if (randomIndex == 4)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c04;
            }
            else if (randomIndex == 5)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c05;
            }
            else if (randomIndex == 6)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c06;
            }
            else if (randomIndex == 7)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c07;
            }
            else if (randomIndex == 8)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c08;
            }
            else if (randomIndex == 9)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c09;
            }
            else if (randomIndex == 10)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c10;
            }
            else if (randomIndex == 11)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c11;
            }
            else if (randomIndex == 12)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c12;
            }
            else if (randomIndex == 13)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.c13;
            }
            else if (randomIndex == 14)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d01;
            }
            else if (randomIndex == 15)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d02;
            }
            else if (randomIndex == 16)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d03;
            }
            else if (randomIndex == 17)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d04;
            }
            else if (randomIndex == 18)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d05;
            }
            else if (randomIndex == 19)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d06;
            }
            else if (randomIndex == 20)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d07;
            }
            else if (randomIndex == 21)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d08;
            }
            else if (randomIndex == 22)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d09;
            }
            else if (randomIndex == 23)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d10;
            }
            else if (randomIndex == 24)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d11;
            }
            else if (randomIndex == 25)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d12;
            }
            else if (randomIndex == 26)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.d13;
            }
            else if (randomIndex == 27)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h01;
            }
            else if (randomIndex == 28)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h02;
            }
            else if (randomIndex == 29)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h03;
            }
            else if (randomIndex == 30)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h04;
            }
            else if (randomIndex == 31)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h05;
            }
            else if (randomIndex == 32)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h06;
            }
            else if (randomIndex == 33)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h07;
            }
            else if (randomIndex == 34)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h08;
            }
            else if (randomIndex == 35)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h09;
            }
            else if (randomIndex == 36)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h10;
            }
            else if (randomIndex == 37)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h11;
            }
            else if (randomIndex == 38)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h12;
            }
            else if (randomIndex == 39)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.h13;
            }
            else if (randomIndex == 40)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s01;
            }
            else if (randomIndex == 41)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s02;
            }
            else if (randomIndex == 42)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s03;
            }
            else if (randomIndex == 43)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s04;
            }
            else if (randomIndex == 44)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s05;
            }
            else if (randomIndex == 45)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s06;
            }
            else if (randomIndex == 46)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s07;
            }
            else if (randomIndex == 47)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s08;
            }
            else if (randomIndex == 48)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s09;
            }
            else if (randomIndex == 49)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s10;
            }
            else if (randomIndex == 50)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s11;
            }
            else if (randomIndex == 51)
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s12;
            }
            else 
            {
                this.picFirstPlayerCard.Image = Properties.Resources.s13;
            }

            // set player index randomly in the second
            Random randomSecondPlayerIndex = new Random();
            secondRandomIndex = randomSecondPlayerIndex.Next(0, playerSecondCard.Count - 1);

            if (secondRandomIndex == 1)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c01;
            }
            else if (secondRandomIndex == 2)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c02;
            }
            else if (secondRandomIndex == 3)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c03;
            }
            else if (secondRandomIndex == 4)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c04;
            }
            else if (secondRandomIndex == 5)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c05;
            }
            else if (secondRandomIndex == 6)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c06;
            }
            else if (secondRandomIndex == 7)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c07;
            }
            else if (secondRandomIndex == 8)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c08;
            }
            else if (secondRandomIndex == 9)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c09;
            }
            else if (secondRandomIndex == 10)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c10;
            }
            else if (secondRandomIndex == 11)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c11;
            }
            else if (secondRandomIndex == 12)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c12;
            }
            else if (secondRandomIndex == 13)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c13;
            }
            else if (secondRandomIndex == 14)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d01;
            }
            else if (secondRandomIndex == 15)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d02;
            }
            else if (secondRandomIndex == 16)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d03;
            }
            else if (secondRandomIndex == 17)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d04;
            }
            else if (secondRandomIndex == 18)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d05;
            }
            else if (secondRandomIndex == 19)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d06;
            }
            else if (secondRandomIndex == 20)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d07;
            }
            else if (secondRandomIndex == 21)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d08;
            }
            else if (secondRandomIndex == 22)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d09;
            }
            else if (secondRandomIndex == 23)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d10;
            }
            else if (secondRandomIndex == 24)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d11;
            }
            else if (secondRandomIndex == 25)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d12;
            }
            else if (secondRandomIndex == 26)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d13;
            }
            else if (secondRandomIndex == 27)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h01;
            }
            else if (secondRandomIndex == 28)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h02;
            }
            else if (secondRandomIndex == 29)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h03;
            }
            else if (secondRandomIndex == 30)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h04;
            }
            else if (secondRandomIndex == 31)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h05;
            }
            else if (secondRandomIndex == 32)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h06;
            }
            else if (secondRandomIndex == 33)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h07;
            }
            else if (secondRandomIndex == 34)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h08;
            }
            else if (secondRandomIndex == 35)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h09;
            }
            else if (secondRandomIndex == 36)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h10;
            }
            else if (secondRandomIndex == 37)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h11;
            }
            else if (secondRandomIndex == 38)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h12;
            }
            else if (secondRandomIndex == 39)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h13;
            }
            else if (secondRandomIndex == 40)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s01;
            }
            else if (secondRandomIndex == 41)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s02;
            }
            else if (secondRandomIndex == 42)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s03;
            }
            else if (secondRandomIndex == 43)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s04;
            }
            else if (secondRandomIndex == 44)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s05;
            }
            else if (secondRandomIndex == 45)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s06;
            }
            else if (secondRandomIndex == 46)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s07;
            }
            else if (secondRandomIndex == 47)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s08;
            }
            else if (secondRandomIndex == 48)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s09;
            }
            else if (secondRandomIndex == 49)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s10;
            }
            else if (secondRandomIndex == 50)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s11;
            }
            else if (secondRandomIndex == 51)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s12;
            }
            else 
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s13;
            }
            // set player index randomly in the third
            Random randomThirdPlayerIndex = new Random();
            thirdRandomIndex = randomThirdPlayerIndex.Next(0, playerThirdCard.Count - 1);
            if (secondRandomIndex == 1)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c01;
            }
            else if (secondRandomIndex == 2)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c02;
            }
            else if (secondRandomIndex == 3)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c03;
            }
            else if (secondRandomIndex == 4)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c04;
            }
            else if (secondRandomIndex == 5)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c05;
            }
            else if (secondRandomIndex == 6)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c06;
            }
            else if (secondRandomIndex == 7)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c07;
            }
            else if (secondRandomIndex == 8)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c08;
            }
            else if (secondRandomIndex == 9)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c09;
            }
            else if (secondRandomIndex == 10)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c10;
            }
            else if (secondRandomIndex == 11)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c11;
            }
            else if (secondRandomIndex == 12)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c12;
            }
            else if (secondRandomIndex == 13)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.c13;
            }
            else if (secondRandomIndex == 14)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d01;
            }
            else if (secondRandomIndex == 15)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d02;
            }
            else if (secondRandomIndex == 16)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d03;
            }
            else if (secondRandomIndex == 17)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d04;
            }
            else if (secondRandomIndex == 18)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d05;
            }
            else if (secondRandomIndex == 19)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d06;
            }
            else if (secondRandomIndex == 20)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d07;
            }
            else if (secondRandomIndex == 21)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d08;
            }
            else if (secondRandomIndex == 22)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d09;
            }
            else if (secondRandomIndex == 23)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d10;
            }
            else if (secondRandomIndex == 24)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d11;
            }
            else if (secondRandomIndex == 25)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d12;
            }
            else if (secondRandomIndex == 26)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.d13;
            }
            else if (secondRandomIndex == 27)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h01;
            }
            else if (secondRandomIndex == 28)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h02;
            }
            else if (secondRandomIndex == 29)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h03;
            }
            else if (secondRandomIndex == 30)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h04;
            }
            else if (secondRandomIndex == 31)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h05;
            }
            else if (secondRandomIndex == 32)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h06;
            }
            else if (secondRandomIndex == 33)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h07;
            }
            else if (secondRandomIndex == 34)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h08;
            }
            else if (secondRandomIndex == 35)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h09;
            }
            else if (secondRandomIndex == 36)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h10;
            }
            else if (secondRandomIndex == 37)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h11;
            }
            else if (secondRandomIndex == 38)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h12;
            }
            else if (secondRandomIndex == 39)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.h13;
            }
            else if (secondRandomIndex == 40)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s01;
            }
            else if (secondRandomIndex == 41)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s02;
            }
            else if (secondRandomIndex == 42)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s03;
            }
            else if (secondRandomIndex == 43)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s04;
            }
            else if (secondRandomIndex == 44)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s05;
            }
            else if (secondRandomIndex == 45)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s06;
            }
            else if (secondRandomIndex == 46)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s07;
            }
            else if (secondRandomIndex == 47)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s08;
            }
            else if (secondRandomIndex == 48)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s09;
            }
            else if (secondRandomIndex == 49)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s10;
            }
            else if (secondRandomIndex == 50)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s11;
            }
            else if (secondRandomIndex == 51)
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s12;
            }
            else
            {
                this.picSecondPlayerCard.Image = Properties.Resources.s13;
            }

            //

            //place the image in the given picture box

            //



        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
