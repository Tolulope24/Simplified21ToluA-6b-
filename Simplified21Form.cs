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
            picThirdPlayerCard.Hide();

        }


        private void frmSimplified21_Load(object sender, EventArgs e)
        {

        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
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

            //place the image in the given picture box

            //


        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
