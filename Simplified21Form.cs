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
            picSecondComputerCard.Hide();
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
                Card.RemoveAt(1);
            }
            else if (randomIndex == 2)
            {
                Card.Insert(randomIndex, Properties.Resources.c03);
                Card.RemoveAt(2);
            }
            else if (randomIndex == 3)
            {
                Card.Insert(randomIndex, Properties.Resources.c04);
                Card.RemoveAt(3);
            }
            else if (randomIndex == 4)
            {
                Card.Insert(randomIndex, Properties.Resources.c05);
                Card.RemoveAt(4);
            }
            else if (randomIndex == 5)
            {
                Card.Insert(randomIndex, Properties.Resources.c06);
                Card.RemoveAt(5);
            }
            
            else if (randomIndex == 6)
            {
                Card.Insert(randomIndex, Properties.Resources.c07);
                Card.RemoveAt(6);
            }
            else if (randomIndex == 7)
            {
                Card.Insert(randomIndex, Properties.Resources.c08);
                Card.RemoveAt(7);
            }
            else if (randomIndex == 8)
            {
                Card.Insert(randomIndex, Properties.Resources.c09);
                Card.RemoveAt(8);
            }
            else if (randomIndex == 9)
            {
                Card.Insert(randomIndex, Properties.Resources.c10);
                Card.RemoveAt(9);
            }
            else if (randomIndex == 10)
            {
                Card.Insert(randomIndex, Properties.Resources.c11);
                Card.RemoveAt(10);
            }
            else if (randomIndex == 11)
            {
                Card.Insert(randomIndex, Properties.Resources.c12);
                Card.RemoveAt(11);
            }
            else if (randomIndex == 12)
            {
                Card.Insert(randomIndex, Properties.Resources.c13);
                Card.RemoveAt(12);
            }
            else if (randomIndex == 13)
            {
                Card.Insert(randomIndex, Properties.Resources.d01);
                Card.RemoveAt(13);
            }
            else if (randomIndex == 14)
            {
                Card.Insert(randomIndex, Properties.Resources.d02);
                Card.RemoveAt(14);
            }
            else if (randomIndex == 15)
            {
                Card.Insert(randomIndex, Properties.Resources.d03);
                Card.RemoveAt(15);
            }
            else if (randomIndex == 16)
            {
                Card.Insert(randomIndex, Properties.Resources.d04);
                Card.RemoveAt(16);
            }
            else if (randomIndex == 17)
            {
                Card.Insert(randomIndex, Properties.Resources.d05);
                Card.RemoveAt(17);
            }
            else if (randomIndex == 18)
            {
               Card.Insert(randomIndex, Properties.Resources.d06);
                Card.RemoveAt(18);
            }
            else if (randomIndex == 19)
            {
                Card.Insert(randomIndex, Properties.Resources.d07);
                Card.RemoveAt(19);
            }
            else if (randomIndex == 20)
            {
                Card.Insert(randomIndex, Properties.Resources.d08);
                Card.RemoveAt(20);
            }
            else if (randomIndex == 21)
            {
                Card.Insert(randomIndex, Properties.Resources.d09);
                Card.RemoveAt(21);
            }
            else if (randomIndex == 22)
            {
                Card.Insert(randomIndex, Properties.Resources.d10);
                Card.RemoveAt(22);
            }
            else if (randomIndex == 23)
            {
                Card.Insert(randomIndex, Properties.Resources.d11);
                Card.RemoveAt(23);
            }
            else if (randomIndex == 24)
            {
                Card.Insert(randomIndex, Properties.Resources.d12);
                Card.RemoveAt(24);
            }
            else if (randomIndex == 25)
            {
                Card.Insert(randomIndex, Properties.Resources.d13);
                Card.RemoveAt(25);
            }
            else if (randomIndex == 26)
            {
                Card.Insert(randomIndex, Properties.Resources.h01);
                Card.RemoveAt(26);
            }
            else if (randomIndex == 27)
            {
                Card.Insert(randomIndex, Properties.Resources.h02);
                Card.RemoveAt(27);
            }
            else if (randomIndex == 28)
            {
                Card.Insert(randomIndex, Properties.Resources.h03);
                Card.RemoveAt(28);
            }
            else if (randomIndex == 29)
            {
                Card.Insert(randomIndex, Properties.Resources.h04);
                Card.RemoveAt(29);
            }
            else if (randomIndex == 30)
            {
                Card.Insert(randomIndex, Properties.Resources.h05);
                Card.RemoveAt(30);
            }
            else if (randomIndex == 31)
            {
                Card.Insert(randomIndex, Properties.Resources.h06);
                Card.RemoveAt(31);
            }
            else if (randomIndex == 32)
            {
                Card.Insert(randomIndex, Properties.Resources.h07);
                Card.RemoveAt(32);
            }
            else if (randomIndex == 33)
            {
                Card.Insert(randomIndex, Properties.Resources.h08);
                Card.RemoveAt(33);
            }
            else if (randomIndex == 34)
            {
                Card.Insert(randomIndex, Properties.Resources.h09);
                Card.RemoveAt(34);
            }
            else if (randomIndex == 35)
            {
                Card.Insert(randomIndex, Properties.Resources.h10);
                Card.RemoveAt(35);
            }
            else if (randomIndex == 36)
            {
                Card.Insert(randomIndex, Properties.Resources.h11);
                Card.RemoveAt(36);
            }
            else if (randomIndex == 37)
            {
                Card.Insert(randomIndex, Properties.Resources.h12);
                Card.RemoveAt(37);
            }
            else if (randomIndex == 38)
            {
                Card.Insert(randomIndex, Properties.Resources.h13);
                Card.RemoveAt(38);
            }
            else if (randomIndex == 39)
            {
                Card.Insert(randomIndex, Properties.Resources.s01);
                Card.RemoveAt(39);
            }
            else if (randomIndex == 40)
            {
                Card.Insert(randomIndex, Properties.Resources.s02);
                Card.RemoveAt(40);
            }
            else if (randomIndex == 41)
            {
                Card.Insert(randomIndex, Properties.Resources.s03);
                Card.RemoveAt(41);
            }
            else if (randomIndex == 42)
            {
                Card.Insert(randomIndex, Properties.Resources.s04);
                Card.RemoveAt(42);
            }
            else if (randomIndex == 43)
            {
                Card.Insert(randomIndex, Properties.Resources.s05);
                Card.RemoveAt(43);
            }
            else if (randomIndex == 44)
            {
                Card.Insert(randomIndex, Properties.Resources.s06);
                Card.RemoveAt(44);
            }
            else if (randomIndex == 45)
            {
                Card.Insert(randomIndex, Properties.Resources.s07);
                Card.RemoveAt(45);
            }
            else if (randomIndex == 46)
            {
                Card.Insert(randomIndex, Properties.Resources.s08);
                Card.RemoveAt(46);
            }
            else if (randomIndex == 47)
            {
                Card.Insert(randomIndex, Properties.Resources.s09);
                Card.RemoveAt(47);
            }
            else if (randomIndex == 48)
            {
                Card.Insert(randomIndex, Properties.Resources.s10);
                Card.RemoveAt(48);
            }
            else if (randomIndex == 49)
            {
                Card.Insert(randomIndex, Properties.Resources.s11);
                Card.RemoveAt(49);
            }
            else if (randomIndex == 50)
            {
                Card.Insert(randomIndex, Properties.Resources.s12);
                Card.RemoveAt(50);
            }
            else 
            {
                Card.Insert(randomIndex, Properties.Resources.s13);
                Card.RemoveAt(51);
            }

            //
            secondRandomIndex = randomCardIndex.Next(0, Card.Count - 1);

             if (secondRandomIndex == 0)
            {
                Card.Insert (secondRandomIndex, Properties.Resources.c01);
                Card.RemoveAt(0);
            }
            else if (secondRandomIndex == 1)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c02);
                Card.RemoveAt(1);
            }
            else if (secondRandomIndex == 2)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c03);
                Card.RemoveAt(2);
            }
            else if (secondRandomIndex == 3)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c04);
                Card.RemoveAt(3);
            }
            else if (secondRandomIndex == 4)
            {
                Card.Insert(randomIndex, Properties.Resources.c05);
                Card.RemoveAt(4);
            }
            else if (secondRandomIndex == 5)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c06);
                Card.RemoveAt(5);
            }
            
            else if (secondRandomIndex == 6)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c07);
                Card.RemoveAt(6);
            }
            else if (secondRandomIndex == 7)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c08);
                Card.RemoveAt(7);
            }
            else if (secondRandomIndex == 8)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c09);
                Card.RemoveAt(8);
            }
            else if (secondRandomIndex == 9)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c10);
                Card.RemoveAt(9);
            }
            else if (secondRandomIndex == 10)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c11);
                Card.RemoveAt(10);
            }
            else if (secondRandomIndex == 11)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c12);
                Card.RemoveAt(11);
            }
            else if (secondRandomIndex == 12)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.c13);
                Card.RemoveAt(12);
            }
            else if (secondRandomIndex == 13)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d01);
                Card.RemoveAt(13);
            }
            else if (secondRandomIndex == 14)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d02);
                Card.RemoveAt(14);
            }
            else if (secondRandomIndex == 15)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d03);
                Card.RemoveAt(15);
            }
            else if (secondRandomIndex == 16)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d04);
                Card.RemoveAt(16);
            }
            else if (secondRandomIndex == 17)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d05);
                Card.RemoveAt(17);
            }
            else if (secondRandomIndex == 18)
            {
               Card.Insert(secondRandomIndex, Properties.Resources.d06);
                Card.RemoveAt(18);
            }
            else if (secondRandomIndex == 19)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d07);
                Card.RemoveAt(19);
            }
            else if (secondRandomIndex == 20)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d08);
                Card.RemoveAt(20);
            }
            else if (secondRandomIndex == 21)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d09);
                Card.RemoveAt(21);
            }
            else if (secondRandomIndex == 22)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d10);
                Card.RemoveAt(22);
            }
            else if (secondRandomIndex == 23)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d11);
                Card.RemoveAt(23);
            }
            else if (secondRandomIndex == 24)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d12);
                Card.RemoveAt(24);
            }
            else if (secondRandomIndex == 25)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.d13);
                Card.RemoveAt(25);
            }
            else if (secondRandomIndex == 26)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h01);
                Card.RemoveAt(26);
            }
            else if (secondRandomIndex == 27)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h02);
                Card.RemoveAt(27);
            }
            else if (secondRandomIndex == 28)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h03);
                Card.RemoveAt(28);
            }
            else if (secondRandomIndex == 29)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h04);
                Card.RemoveAt(29);
            }
            else if (secondRandomIndex == 30)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h05);
                Card.RemoveAt(30);
            }
            else if (secondRandomIndex == 31)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h06);
                Card.RemoveAt(31);
            }
            else if (secondRandomIndex == 32)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h07);
                Card.RemoveAt(32);
            }
            else if (secondRandomIndex == 33)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h08);
                Card.RemoveAt(33);
            }
            else if (secondRandomIndex == 34)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h09);
                Card.RemoveAt(34);
            }
            else if (secondRandomIndex == 35)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h10);
                Card.RemoveAt(35);
            }
            else if (secondRandomIndex == 36)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h11);
                Card.RemoveAt(36);
            }
            else if (secondRandomIndex == 37)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h12);
                Card.RemoveAt(37);
            }
            else if (secondRandomIndex == 38)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.h13);
                Card.RemoveAt(38);
            }
            else if (secondRandomIndex == 39)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s01);
                Card.RemoveAt(39);
            }
            else if (secondRandomIndex == 40)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s02);
                Card.RemoveAt(40);
            }
            else if (secondRandomIndex == 41)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s03);
                Card.RemoveAt(41);
            }
            else if (secondRandomIndex == 42)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s04);
                Card.RemoveAt(42);
            }
            else if (secondRandomIndex == 43)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s05);
                Card.RemoveAt(43);
            }
            else if (secondRandomIndex == 44)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s06);
                Card.RemoveAt(44);
            }
            else if (secondRandomIndex == 45)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s07);
                Card.RemoveAt(45);
            }
            else if (secondRandomIndex == 46)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s08);
                Card.RemoveAt(46);
            }
            else if (secondRandomIndex == 47)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s09);
                Card.RemoveAt(47);
            }
            else if (secondRandomIndex == 48)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s10);
                Card.RemoveAt(48);
            }
            else if (secondRandomIndex == 49)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s11);
                Card.RemoveAt(49);
            }
            else if (secondRandomIndex == 50)
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s12);
                Card.RemoveAt(50);
            }
            else 
            {
                Card.Insert(secondRandomIndex, Properties.Resources.s13);
                Card.RemoveAt(51);
            }

            thirdRandomIndex = randomCardIndex.Next(0, Card.Count - 1);

            if (thirdRandomIndex == 0)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c01);
                Card.RemoveAt(0);
            }
            else if (thirdRandomIndex == 1)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c02);
                Card.RemoveAt(1);
            }
            else if (thirdRandomIndex == 2)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c03);
                Card.RemoveAt(2);
            }
            else if (thirdRandomIndex == 3)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c04);
                Card.RemoveAt(3);
            }
            else if (thirdRandomIndex == 4)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c05);
                Card.RemoveAt(4);
            }
            else if (thirdRandomIndex == 5)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c06);
                Card.RemoveAt(5);
            }

            else if (thirdRandomIndex == 6)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c07);
                Card.RemoveAt(6);
            }
            else if (thirdRandomIndex == 7)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c08);
                Card.RemoveAt(7);
            }
            else if (thirdRandomIndex == 8)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c09);
                Card.RemoveAt(8);
            }
            else if (thirdRandomIndex == 9)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c10);
                Card.RemoveAt(9);
            }
            else if (thirdRandomIndex == 10)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c11);
                Card.RemoveAt(10);
            }
            else if (thirdRandomIndex == 11)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c12);
                Card.RemoveAt(11);
            }
            else if (thirdRandomIndex == 12)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.c13);
                Card.RemoveAt(12);
            }
            else if (thirdRandomIndex == 13)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d01);
                Card.RemoveAt(13);
            }
            else if (thirdRandomIndex == 14)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d02);
                Card.RemoveAt(14);
            }
            else if (thirdRandomIndex == 15)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d03);
                Card.RemoveAt(15);
            }
            else if (thirdRandomIndex == 16)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d04);
                Card.RemoveAt(16);
            }
            else if (thirdRandomIndex == 17)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d05);
                Card.RemoveAt(17);
            }
            else if (thirdRandomIndex == 18)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d06);
                Card.RemoveAt(18);
            }
            else if (thirdRandomIndex == 19)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d07);
                Card.RemoveAt(19);
            }
            else if (thirdRandomIndex == 20)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d08);
                Card.RemoveAt(20);
            }
            else if (thirdRandomIndex == 21)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d09);
                Card.RemoveAt(21);
            }
            else if (thirdRandomIndex == 22)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d10);
                Card.RemoveAt(22);
            }
            else if (thirdRandomIndex == 23)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d11);
                Card.RemoveAt(23);
            }
            else if (thirdRandomIndex == 24)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d12);
                Card.RemoveAt(24);
            }
            else if (thirdRandomIndex == 25)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.d13);
                Card.RemoveAt(25);
            }
            else if (thirdRandomIndex == 26)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h01);
                Card.RemoveAt(26);
            }
            else if (thirdRandomIndex == 27)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h02);
                Card.RemoveAt(27);
            }
            else if (thirdRandomIndex == 28)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h03);
                Card.RemoveAt(28);
            }
            else if (thirdRandomIndex == 29)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h04);
                Card.RemoveAt(29);
            }
            else if (thirdRandomIndex == 30)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h05);
                Card.RemoveAt(30);
            }
            else if (thirdRandomIndex == 31)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h06);
                Card.RemoveAt(31);
            }
            else if (thirdRandomIndex == 32)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h07);
                Card.RemoveAt(32);
            }
            else if (thirdRandomIndex == 33)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h08);
                Card.RemoveAt(33);
            }
            else if (thirdRandomIndex == 34)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h09);
                Card.RemoveAt(34);
            }
            else if (secondRandomIndex == 35)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h10);
                Card.RemoveAt(35);
            }
            else if (thirdRandomIndex == 36)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h11);
                Card.RemoveAt(36);
            }
            else if (thirdRandomIndex == 37)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h12);
                Card.RemoveAt(37);
            }
            else if (thirdRandomIndex == 38)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.h13);
                Card.RemoveAt(38);
            }
            else if (thirdRandomIndex == 39)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s01);
                Card.RemoveAt(39);
            }
            else if (thirdRandomIndex == 40)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s02);
                Card.RemoveAt(40);
            }
            else if (thirdRandomIndex == 41)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s03);
                Card.RemoveAt(41);
            }
            else if (thirdRandomIndex == 42)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s04);
                Card.RemoveAt(42);
            }
            else if (thirdRandomIndex == 43)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s05);
                Card.RemoveAt(43);
            }
            else if (thirdRandomIndex == 44)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s06);
                Card.RemoveAt(44);
            }
            else if (thirdRandomIndex == 45)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s07);
                Card.RemoveAt(45);
            }
            else if (thirdRandomIndex == 46)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s08);
                Card.RemoveAt(46);
            }
            else if (thirdRandomIndex == 47)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s09);
                Card.RemoveAt(47);
            }
            else if (thirdRandomIndex == 48)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s10);
                Card.RemoveAt(48);
            }
            else if (thirdRandomIndex == 49)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s11);
                Card.RemoveAt(49);
            }
            else if (thirdRandomIndex == 50)
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s12);
                Card.RemoveAt(50);
            }
            else
            {
                Card.Insert(thirdRandomIndex, Properties.Resources.s13);
                Card.RemoveAt(51);
            }










            // add list to picture box

            picFirstPlayerCard.Image = Card[randomIndex];
            picSecondplayerCard.Image = Card[secondRandomIndex];
            picThirdPlayerCard.Image = Card[randomIndex];

            //

            //place the image in the given picture box

            //


        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
