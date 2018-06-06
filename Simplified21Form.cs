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
            picThirdPlayerCard.Hide();
            picFirstComputerCard.Hide();
            picSecondComputerCard.Hide();
            picThirdComputerCard.Hide();

        }
        const int MIN_NUMBER = 1;
        const int MAX_NUMBER = 13;
        //
        int Values;
        int secondPlayerValues;
        int thirdPlayerValues;
        //
        int computerValues;
        int computersecondValues;
        int computerthirdValues;

        
        int randomIndex;
        int secondRandomIndex;
        int thirdRandomIndex;
        

        Random Number = new Random();
        
        int computerRandomIndex;
        int computerSecondRandomIndex;
        int computerThirdRandomIndex;
        
        float sumPlayerCard;
        float sumComputerCard;

        List<Image> Card = new List<Image>();

        private void frmSimplified21_Load(object sender, EventArgs e)
        {

        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            // create an empty list of card images

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
            // Random Values
            Values = Number.Next(MIN_NUMBER, MAX_NUMBER + 1);
            if (Values == 1)
            {
                Card.Insert(Values, Properties.Resources.c01);
                Card.RemoveAt(1);
                Card.Insert(Values, Properties.Resources.d01);
                Card.Insert(Values, Properties.Resources.h01);
                Card.Insert(Values, Properties.Resources.s01);
            }
            else if (Values == 2)
            {
                Card.Insert(Values, Properties.Resources.c02);
                Card.Insert(Values, Properties.Resources.d02);
                Card.Insert(Values, Properties.Resources.h02);
                Card.Insert(Values, Properties.Resources.s02);
            }
            else if (Values == 3)
            {
                Card.Insert(Values, Properties.Resources.c03);
                Card.Insert(Values, Properties.Resources.d03);
                Card.Insert(Values, Properties.Resources.h03);
                Card.Insert(Values, Properties.Resources.s03);
            }
            else if (Values == 4)
            {
                Card.Insert(Values, Properties.Resources.c04);
                Card.Insert(Values, Properties.Resources.d04);
                Card.Insert(Values, Properties.Resources.h04);
                Card.Insert(Values, Properties.Resources.s04);
            }
            else if (Values == 5)
            {
                Card.Insert(Values, Properties.Resources.c05);
                Card.Insert(Values, Properties.Resources.d05);
                Card.Insert(Values, Properties.Resources.h05);
                Card.Insert(Values, Properties.Resources.s05);
            }
            else if (Values == 6)
            {
                Card.Insert(Values, Properties.Resources.c06);
                Card.Insert(Values, Properties.Resources.d06);
                Card.Insert(Values, Properties.Resources.h06);
                Card.Insert(Values, Properties.Resources.s06);
            }
            else if (Values == 7)
            {
                Card.Insert(Values, Properties.Resources.c07);
                Card.Insert(Values, Properties.Resources.d07);
                Card.Insert(Values, Properties.Resources.h07);
                Card.Insert(Values, Properties.Resources.s07);
            }
            else if (Values == 8)
            {
                Card.Insert(Values, Properties.Resources.c08);
                Card.Insert(Values, Properties.Resources.d08);
                Card.Insert(Values, Properties.Resources.h08);
                Card.Insert(Values, Properties.Resources.s08);
            }
            else if (Values == 9)
            {
                Card.Insert(Values, Properties.Resources.c09);
                Card.Insert(Values, Properties.Resources.d09);
                Card.Insert(Values, Properties.Resources.h09);
                Card.Insert(Values, Properties.Resources.s09);
            }
            else if (Values == 10)
            {
                Card.Insert(Values, Properties.Resources.c10);
                Card.Insert(Values, Properties.Resources.d10);
                Card.Insert(Values, Properties.Resources.h10);
                Card.Insert(Values, Properties.Resources.s10);
            }
            else if (Values == 11)
            {
                Card.Insert(Values, Properties.Resources.c11);
                Card.Insert(Values, Properties.Resources.d11);
                Card.Insert(Values, Properties.Resources.h11);
                Card.Insert(Values, Properties.Resources.s11);
            }
            else if (Values == 12)
            {
                Card.Insert(Values, Properties.Resources.c12);
                Card.Insert(Values, Properties.Resources.d12);
                Card.Insert(Values, Properties.Resources.h12);
                Card.Insert(Values, Properties.Resources.s12);
            }
            else
            {
                Card.Insert(Values, Properties.Resources.c13);
                Card.Insert(Values, Properties.Resources.d13);
                Card.Insert(Values, Properties.Resources.h13);
                Card.Insert(Values, Properties.Resources.s13);
            }
            secondPlayerValues = Number.Next(MIN_NUMBER, MAX_NUMBER + 1);

            if (secondPlayerValues == 1)
            {
                Card.Insert(Values, Properties.Resources.c01);
                Card.Insert(Values, Properties.Resources.d01);
                Card.Insert(Values, Properties.Resources.h01);
                Card.Insert(Values, Properties.Resources.s01);
            }
            else if (secondPlayerValues == 2)
            {
                Card.Insert(Values, Properties.Resources.c02);
                Card.Insert(Values, Properties.Resources.d02);
                Card.Insert(Values, Properties.Resources.h02);
                Card.Insert(Values, Properties.Resources.s02);
            }
            else if (secondPlayerValues == 3)
            {
                Card.Insert(Values, Properties.Resources.c03);
                Card.Insert(Values, Properties.Resources.d03);
                Card.Insert(Values, Properties.Resources.h03);
                Card.Insert(Values, Properties.Resources.s03);
            }
            else if (secondPlayerValues == 4)
            {
                Card.Insert(Values, Properties.Resources.c04);
                Card.Insert(Values, Properties.Resources.d04);
                Card.Insert(Values, Properties.Resources.h04);
                Card.Insert(Values, Properties.Resources.s04);
            }
            else if (secondPlayerValues == 5)
            {
                Card.Insert(Values, Properties.Resources.c05);
                Card.Insert(Values, Properties.Resources.d05);
                Card.Insert(Values, Properties.Resources.h05);
                Card.Insert(Values, Properties.Resources.s05);
            }
            else if (secondPlayerValues == 6)
            {
                Card.Insert(Values, Properties.Resources.c06);
                Card.Insert(Values, Properties.Resources.d06);
                Card.Insert(Values, Properties.Resources.h06);
                Card.Insert(Values, Properties.Resources.s06);
            }
            else if (secondPlayerValues == 7)
            {
                Card.Insert(Values, Properties.Resources.c07);
                Card.Insert(Values, Properties.Resources.d07);
                Card.Insert(Values, Properties.Resources.h07);
                Card.Insert(Values, Properties.Resources.s07);
            }
            else if (secondPlayerValues == 8)
            {
                Card.Insert(Values, Properties.Resources.c08);
                Card.Insert(Values, Properties.Resources.d08);
                Card.Insert(Values, Properties.Resources.h08);
                Card.Insert(Values, Properties.Resources.s08);
            }
            else if (secondPlayerValues == 9)
            {
                Card.Insert(Values, Properties.Resources.c09);
                Card.Insert(Values, Properties.Resources.d09);
                Card.Insert(Values, Properties.Resources.h09);
                Card.Insert(Values, Properties.Resources.s09);
            }
            else if (secondPlayerValues == 10)
            {
                Card.Insert(Values, Properties.Resources.c10);
                Card.Insert(Values, Properties.Resources.d10);
                Card.Insert(Values, Properties.Resources.h10);
                Card.Insert(Values, Properties.Resources.s10);
            }
            else if (secondPlayerValues == 11)
            {
                Card.Insert(Values, Properties.Resources.c11);
                Card.Insert(Values, Properties.Resources.d11);
                Card.Insert(Values, Properties.Resources.h11);
                Card.Insert(Values, Properties.Resources.s11);
            }
            else if (secondPlayerValues == 12)
            {
                Card.Insert(Values, Properties.Resources.c12);
                Card.Insert(Values, Properties.Resources.d12);
                Card.Insert(Values, Properties.Resources.h12);
                Card.Insert(Values, Properties.Resources.s12);
            }
            else
            {
                Card.Insert(Values, Properties.Resources.c13);
                Card.Insert(Values, Properties.Resources.d13);
                Card.Insert(Values, Properties.Resources.h13);
                Card.Insert(Values, Properties.Resources.s13);
            }
            thirdPlayerValues = Number.Next(MIN_NUMBER, MAX_NUMBER + 1);
            if (thirdPlayerValues == 1)
            {
                Card.Insert(Values, Properties.Resources.c01);
                Card.Insert(Values, Properties.Resources.d01);
                Card.Insert(Values, Properties.Resources.h01);
                Card.Insert(Values, Properties.Resources.s01);
            }
            else if (thirdPlayerValues == 2)
            {
                Card.Insert(Values, Properties.Resources.c02);
                Card.Insert(Values, Properties.Resources.d02);
                Card.Insert(Values, Properties.Resources.h02);
                Card.Insert(Values, Properties.Resources.s02);
            }
            else if (thirdPlayerValues == 3)
            {
                Card.Insert(Values, Properties.Resources.c03);
                Card.Insert(Values, Properties.Resources.d03);
                Card.Insert(Values, Properties.Resources.h03);
                Card.Insert(Values, Properties.Resources.s03);
            }
            else if (thirdPlayerValues == 4)
            {
                Card.Insert(Values, Properties.Resources.c04);
                Card.Insert(Values, Properties.Resources.d04);
                Card.Insert(Values, Properties.Resources.h04);
                Card.Insert(Values, Properties.Resources.s04);
            }
            else if (thirdPlayerValues == 5)
            {
                Card.Insert(Values, Properties.Resources.c05);
                Card.Insert(Values, Properties.Resources.d05);
                Card.Insert(Values, Properties.Resources.h05);
                Card.Insert(Values, Properties.Resources.s05);
            }
            else if (thirdPlayerValues == 6)
            {
                Card.Insert(Values, Properties.Resources.c06);
                Card.Insert(Values, Properties.Resources.d06);
                Card.Insert(Values, Properties.Resources.h06);
                Card.Insert(Values, Properties.Resources.s06);
            }
            else if (thirdPlayerValues == 7)
            {
                Card.Insert(Values, Properties.Resources.c07);
                Card.Insert(Values, Properties.Resources.d07);
                Card.Insert(Values, Properties.Resources.h07);
                Card.Insert(Values, Properties.Resources.s07);
            }
            else if (thirdPlayerValues == 8)
            {
                Card.Insert(Values, Properties.Resources.c08);
                Card.Insert(Values, Properties.Resources.d08);
                Card.Insert(Values, Properties.Resources.h08);
                Card.Insert(Values, Properties.Resources.s08);
            }
            else if (thirdPlayerValues == 9)
            {
                Card.Insert(Values, Properties.Resources.c09);
                Card.Insert(Values, Properties.Resources.d09);
                Card.Insert(Values, Properties.Resources.h09);
                Card.Insert(Values, Properties.Resources.s09);
            }
            else if (thirdPlayerValues == 10)
            {
                Card.Insert(Values, Properties.Resources.c10);
                Card.Insert(Values, Properties.Resources.d10);
                Card.Insert(Values, Properties.Resources.h10);
                Card.Insert(Values, Properties.Resources.s10);
            }
            else if (thirdPlayerValues == 11)
            {
                Card.Insert(Values, Properties.Resources.c11);
                Card.Insert(Values, Properties.Resources.d11);
                Card.Insert(Values, Properties.Resources.h11);
                Card.Insert(Values, Properties.Resources.s11);
            }
            else if (thirdPlayerValues == 12)
            {
                Card.Insert(Values, Properties.Resources.c12);
                Card.Insert(Values, Properties.Resources.d12);
                Card.Insert(Values, Properties.Resources.h12);
                Card.Insert(Values, Properties.Resources.s12);
            }
            else
            {
                Card.Insert(Values, Properties.Resources.c13);
                Card.Insert(Values, Properties.Resources.d13);
                Card.Insert(Values, Properties.Resources.h13);
                Card.Insert(Values, Properties.Resources.s13);
            }

            computerValues = Number.Next(MIN_NUMBER, MAX_NUMBER + 1);
            if (Values == 1)
            {
                Card.Insert(Values, Properties.Resources.c01);
                Card.Insert(Values, Properties.Resources.d01);
                Card.Insert(Values, Properties.Resources.h01);
                Card.Insert(Values, Properties.Resources.s01);
            }
            else if (computerValues == 2)
            {
                Card.Insert(Values, Properties.Resources.c02);
                Card.Insert(Values, Properties.Resources.d02);
                Card.Insert(Values, Properties.Resources.h02);
                Card.Insert(Values, Properties.Resources.s02);
            }
            else if (computerValues == 3)
            {
                Card.Insert(Values, Properties.Resources.c03);
                Card.Insert(Values, Properties.Resources.d03);
                Card.Insert(Values, Properties.Resources.h03);
                Card.Insert(Values, Properties.Resources.s03);
            }
            else if (computerValues == 4)
            {
                Card.Insert(Values, Properties.Resources.c04);
                Card.Insert(Values, Properties.Resources.d04);
                Card.Insert(Values, Properties.Resources.h04);
                Card.Insert(Values, Properties.Resources.s04);
            }
            else if (computerValues == 5)
            {
                Card.Insert(Values, Properties.Resources.c05);
                Card.Insert(Values, Properties.Resources.d05);
                Card.Insert(Values, Properties.Resources.h05);
                Card.Insert(Values, Properties.Resources.s05);
            }
            else if (computerValues == 6)
            {
                Card.Insert(Values, Properties.Resources.c06);
                Card.Insert(Values, Properties.Resources.d06);
                Card.Insert(Values, Properties.Resources.h06);
            }
            else if (computerValues == 7)
            {
                Card.Insert(Values, Properties.Resources.c07);
                Card.Insert(Values, Properties.Resources.d07);
                Card.Insert(Values, Properties.Resources.h07);
                Card.Insert(Values, Properties.Resources.s07);
            }
            else if (computerValues == 8)
            {
                Card.Insert(Values, Properties.Resources.c08);
                Card.Insert(Values, Properties.Resources.d08);
                Card.Insert(Values, Properties.Resources.h08);
                Card.Insert(Values, Properties.Resources.s08);
            }
            else if (computerValues == 9)
            {
                Card.Insert(Values, Properties.Resources.c09);
                Card.Insert(Values, Properties.Resources.d09);
                Card.Insert(Values, Properties.Resources.h09);
                Card.Insert(Values, Properties.Resources.s09);
            }
            else if (computerValues == 10)
            {
                Card.Insert(Values, Properties.Resources.c10);
                Card.Insert(Values, Properties.Resources.d10);
                Card.Insert(Values, Properties.Resources.h10);
                Card.Insert(Values, Properties.Resources.s10);
            }
            else if (computerValues == 11)
            {
                Card.Insert(Values, Properties.Resources.c11);
                Card.Insert(Values, Properties.Resources.d11);
                Card.Insert(Values, Properties.Resources.h11);
                Card.Insert(Values, Properties.Resources.s11);
            }
            else if (computerValues == 12)
            {
                Card.Insert(Values, Properties.Resources.c12);
                Card.Insert(Values, Properties.Resources.d12);
                Card.Insert(Values, Properties.Resources.h12);
                Card.Insert(Values, Properties.Resources.s12);
            }
            else
            {
                Card.Insert(Values, Properties.Resources.c13);
                Card.Insert(Values, Properties.Resources.d13);
                Card.Insert(Values, Properties.Resources.h13);
                Card.Insert(Values, Properties.Resources.s13);
            }
            computersecondValues = Number.Next(MIN_NUMBER, MAX_NUMBER + 1);
            if (computersecondValues == 1)
            {
                Card.Insert(Values, Properties.Resources.c01);
                Card.Insert(Values, Properties.Resources.d01);
                Card.Insert(Values, Properties.Resources.h01);
                Card.Insert(Values, Properties.Resources.s01);
            }
            else if (computersecondValues == 2)
            {
                Card.Insert(Values, Properties.Resources.c02);
                Card.Insert(Values, Properties.Resources.d02);
                Card.Insert(Values, Properties.Resources.h02);
                Card.Insert(Values, Properties.Resources.s02);
            }
            else if (computersecondValues == 3)
            {
                Card.Insert(Values, Properties.Resources.c03);
                Card.Insert(Values, Properties.Resources.d03);
                Card.Insert(Values, Properties.Resources.h03);
                Card.Insert(Values, Properties.Resources.s03);
            }
            else if (computersecondValues == 4)
            {
                Card.Insert(Values, Properties.Resources.c04);
                Card.Insert(Values, Properties.Resources.d04);
                Card.Insert(Values, Properties.Resources.h04);
                Card.Insert(Values, Properties.Resources.s04);
            }
            else if (computersecondValues == 5)
            {
                Card.Insert(Values, Properties.Resources.c05);
                Card.Insert(Values, Properties.Resources.d05);
                Card.Insert(Values, Properties.Resources.h05);
                Card.Insert(Values, Properties.Resources.s05);
            }
            else if (computersecondValues == 6)
            {
                Card.Insert(Values, Properties.Resources.c06);
                Card.Insert(Values, Properties.Resources.d06);
                Card.Insert(Values, Properties.Resources.h06);
                Card.Insert(Values, Properties.Resources.s06);
            }
            else if (computersecondValues == 7)
            {
                Card.Insert(Values, Properties.Resources.c07);
                Card.Insert(Values, Properties.Resources.d07);
                Card.Insert(Values, Properties.Resources.h07);
                Card.Insert(Values, Properties.Resources.s07);
            }
            else if (computersecondValues == 8)
            {
                Card.Insert(Values, Properties.Resources.c08);
                Card.Insert(Values, Properties.Resources.d08);
                Card.Insert(Values, Properties.Resources.h08);
                Card.Insert(Values, Properties.Resources.s08);
            }
            else if (computersecondValues == 9)
            {
                Card.Insert(Values, Properties.Resources.c09);
                Card.Insert(Values, Properties.Resources.d09);
                Card.Insert(Values, Properties.Resources.h09);
                Card.Insert(Values, Properties.Resources.s09);
            }
            else if (computersecondValues == 10)
            {
                Card.Insert(Values, Properties.Resources.c10);
                Card.Insert(Values, Properties.Resources.d10);
                Card.Insert(Values, Properties.Resources.h10);
                Card.Insert(Values, Properties.Resources.s10);
            }
            else if (computersecondValues == 11)
            {
                Card.Insert(Values, Properties.Resources.c11);
                Card.Insert(Values, Properties.Resources.d11);
                Card.Insert(Values, Properties.Resources.h11);
                Card.Insert(Values, Properties.Resources.s11);
            }
            else if (computersecondValues == 12)
            {
                Card.Insert(Values, Properties.Resources.c12);
                Card.Insert(Values, Properties.Resources.d12);
                Card.Insert(Values, Properties.Resources.h12);
                Card.Insert(Values, Properties.Resources.s12);
            }
            else
            {
                Card.Insert(Values, Properties.Resources.c13);
                Card.Insert(Values, Properties.Resources.d13);
                Card.Insert(Values, Properties.Resources.h13);
                Card.Insert(Values, Properties.Resources.s13);
            }
            computerthirdValues = Number.Next(MIN_NUMBER, MAX_NUMBER + 1);
            if (computerthirdValues == 1)
            {
                Card.Insert(Values, Properties.Resources.c01);
                Card.Insert(Values, Properties.Resources.d01);
                Card.Insert(Values, Properties.Resources.h01);
                Card.Insert(Values, Properties.Resources.s01);
            }
            else if (computerthirdValues == 2)
            {
                Card.Insert(Values, Properties.Resources.c02);
                Card.Insert(Values, Properties.Resources.d02);
                Card.Insert(Values, Properties.Resources.h02);
                Card.Insert(Values, Properties.Resources.s02);
            }
            else if (computerthirdValues == 3)
            {
                Card.Insert(Values, Properties.Resources.c03);
                Card.Insert(Values, Properties.Resources.d03);
                Card.Insert(Values, Properties.Resources.h03);
                Card.Insert(Values, Properties.Resources.s03);
            }
            else if (computerthirdValues == 4)
            {
                Card.Insert(Values, Properties.Resources.c04);
                Card.Insert(Values, Properties.Resources.d04);
                Card.Insert(Values, Properties.Resources.h04);
                Card.Insert(Values, Properties.Resources.s04);
            }
            else if (computerthirdValues == 5)
            {
                Card.Insert(Values, Properties.Resources.c05);
                Card.Insert(Values, Properties.Resources.d05);
                Card.Insert(Values, Properties.Resources.h05);
                Card.Insert(Values, Properties.Resources.s05);
            }
            else if (computerthirdValues == 6)
            {
                Card.Insert(Values, Properties.Resources.c06);
                Card.Insert(Values, Properties.Resources.d06);
                Card.Insert(Values, Properties.Resources.h06);
                Card.Insert(Values, Properties.Resources.s06);
            }
            else if (computerthirdValues == 7)
            {
                Card.Insert(Values, Properties.Resources.c07);
                Card.Insert(Values, Properties.Resources.d07);
                Card.Insert(Values, Properties.Resources.h07);
                Card.Insert(Values, Properties.Resources.s07);
            }
            else if (computerthirdValues == 8)
            {
                Card.Insert(Values, Properties.Resources.c08);
                Card.Insert(Values, Properties.Resources.d08);
                Card.Insert(Values, Properties.Resources.h08);
                Card.Insert(Values, Properties.Resources.s08);
            }
            else if (computerthirdValues == 9)
            {
                Card.Insert(Values, Properties.Resources.c09);
                Card.Insert(Values, Properties.Resources.d09);
                Card.Insert(Values, Properties.Resources.h09);
                Card.Insert(Values, Properties.Resources.s09);
            }
            else if (computerthirdValues == 10)
            {
                Card.Insert(Values, Properties.Resources.c10);
                Card.Insert(Values, Properties.Resources.d10);
                Card.Insert(Values, Properties.Resources.h10);
                Card.Insert(Values, Properties.Resources.s10);
            }
            else if (computerthirdValues == 11)
            {
                Card.Insert(Values, Properties.Resources.c11);
                Card.Insert(Values, Properties.Resources.d11);
                Card.Insert(Values, Properties.Resources.h11);
                Card.Insert(Values, Properties.Resources.s11);
            }
            else if (computerthirdValues == 12)
            {
                Card.Insert(Values, Properties.Resources.c12);
                Card.Insert(Values, Properties.Resources.d12);
                Card.Insert(Values, Properties.Resources.h12);
                Card.Insert(Values, Properties.Resources.s12);
            }
            else
            {
                Card.Insert(Values, Properties.Resources.c13);
                Card.Insert(Values, Properties.Resources.d13);
                Card.Insert(Values, Properties.Resources.h13);
                Card.Insert(Values, Properties.Resources.s13);
            }

             // set player index randomly in the first player card
             Random randomCardIndex = new Random();
             randomIndex = randomCardIndex.Next(0, Card.Count - 1);
             if (randomIndex == 0)
             {
                 Card.Insert(randomIndex, Properties.Resources.c01);
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
                 Values = 4;
                 Card.RemoveAt(3);
             }
             else if (randomIndex == 4)
             {
                 Card.Insert(randomIndex, Properties.Resources.c05);
                 Values = 5;
                 Card.RemoveAt(4);
             }
             else if (randomIndex == 5)
             {
                 Card.Insert(randomIndex, Properties.Resources.c06);
                 Values = 6;
                 Card.RemoveAt(5);
             }

             else if (randomIndex == 6)
             {
                 Card.Insert(randomIndex, Properties.Resources.c07);
                 Values = 7;
                 Card.RemoveAt(6);
             }
             else if (randomIndex == 7)
             {
                 Card.Insert(randomIndex, Properties.Resources.c08);
                 Values = 8;
                 Card.RemoveAt(7);
             }
             else if (randomIndex == 8)
             {
                 Card.Insert(randomIndex, Properties.Resources.c09);
                 Values = 9;
                 Card.RemoveAt(8);
             }
             else if (randomIndex == 9)
             {
                 Card.Insert(randomIndex, Properties.Resources.c10);
                 Values = 10;
                 Card.RemoveAt(9);
             }
             else if (randomIndex == 10)
             {
                 Card.Insert(randomIndex, Properties.Resources.c11);
                 Values = 11;
                 Card.RemoveAt(10);
             }
             else if (randomIndex == 11)
             {
                 Card.Insert(randomIndex, Properties.Resources.c12);
                 Values = 12;
                 Card.RemoveAt(11);
             }
             else if (randomIndex == 12)
             {
                 Card.Insert(randomIndex, Properties.Resources.c13);
                 Values = 13;
                 Card.RemoveAt(12);
             }
             else if (randomIndex == 13)
             {
                 Card.Insert(randomIndex, Properties.Resources.d01);
                 Values = 1;
                 Card.RemoveAt(13);
             }
             else if (randomIndex == 14)
             {
                 Card.Insert(randomIndex, Properties.Resources.d02);
                 Values = 2;
                 Card.RemoveAt(14);
             }
             else if (randomIndex == 15)
             {
                 Card.Insert(randomIndex, Properties.Resources.d03);
                 Values = 3;
                 Card.RemoveAt(15);
             }
             else if (randomIndex == 16)
             {
                 Card.Insert(randomIndex, Properties.Resources.d04);
                 Values = 4;
                 Card.RemoveAt(16);
             }
             else if (randomIndex == 17)
             {
                 Card.Insert(randomIndex, Properties.Resources.d05);
                 Values = 5;
                 Card.RemoveAt(17);
             }
             else if (randomIndex == 18)
             {
                 Card.Insert(randomIndex, Properties.Resources.d06);
                 Values = 6;
                 Card.RemoveAt(18);
             }
             else if (randomIndex == 19)
             {
                 Card.Insert(randomIndex, Properties.Resources.d07);
                 Values = 7;
                 Card.RemoveAt(19);
             }
             else if (randomIndex == 20)
             {
                 Card.Insert(randomIndex, Properties.Resources.d08);
                 Values = 8;
                 Card.RemoveAt(20);
             }
             else if (randomIndex == 21)
             {
                 Card.Insert(randomIndex, Properties.Resources.d09);
                 Values = 9;
                 Card.RemoveAt(21);
             }
             else if (randomIndex == 22)
             {
                 Card.Insert(randomIndex, Properties.Resources.d10);
                 Values = 10;
                 Card.RemoveAt(22);
             }
             else if (randomIndex == 23)
             {
                 Card.Insert(randomIndex, Properties.Resources.d11);
                 Values = 11;
                 Card.RemoveAt(23);
             }
             else if (randomIndex == 24)
             {
                 Card.Insert(randomIndex, Properties.Resources.d12);
                 Values = 12;
                 Card.RemoveAt(24);
             }
             else if (randomIndex == 25)
             {
                 Card.Insert(randomIndex, Properties.Resources.d13);
                 Values = 13;
                 Card.RemoveAt(25);
             }
             else if (randomIndex == 26)
             {
                 Card.Insert(randomIndex, Properties.Resources.h01);
                 Values = 1;
                 Card.RemoveAt(26);
             }
             else if (randomIndex == 27)
             {
                 Card.Insert(randomIndex, Properties.Resources.h02);
                 Values = 2;
                 Card.RemoveAt(27);
             }
             else if (randomIndex == 28)
             {
                 Card.Insert(randomIndex, Properties.Resources.h03);
                 Values = 3;
                 Card.RemoveAt(28);
             }
             else if (randomIndex == 29)
             {
                 Card.Insert(randomIndex, Properties.Resources.h04);
                 Values = 4;
                 Card.RemoveAt(29);
             }
             else if (randomIndex == 30)
             {
                 Card.Insert(randomIndex, Properties.Resources.h05);
                 Values = 5;
                 Card.RemoveAt(30);
             }
             else if (randomIndex == 31)
             {
                 Card.Insert(randomIndex, Properties.Resources.h06);
                 Values = 6;
                 Card.RemoveAt(31);
             }
             else if (randomIndex == 32)
             {
                 Card.Insert(randomIndex, Properties.Resources.h07);
                 Values = 7;
                 Card.RemoveAt(32);
             }
             else if (randomIndex == 33)
             {
                 Card.Insert(randomIndex, Properties.Resources.h08);
                 Values = 8;
                 Card.RemoveAt(33);
             }
             else if (randomIndex == 34)
             {
                 Card.Insert(randomIndex, Properties.Resources.h09);
                 Values = 9;
                 Card.RemoveAt(34);
             }
             else if (randomIndex == 35)
             {
                 Card.Insert(randomIndex, Properties.Resources.h10);
                 Values = 10;
                 Card.RemoveAt(35);
             }
             else if (randomIndex == 36)
             {
                 Card.Insert(randomIndex, Properties.Resources.h11);
                 Values = 11;
                 Card.RemoveAt(36);
             }
             else if (randomIndex == 37)
             {
                 Card.Insert(randomIndex, Properties.Resources.h12);
                 Values = 12;
                 Card.RemoveAt(37);
             }
             else if (randomIndex == 38)
             {
                 Card.Insert(randomIndex, Properties.Resources.h13);
                 Values = 13;
                 Card.RemoveAt(38);
             }
             else if (randomIndex == 39)
             {
                 Card.Insert(randomIndex, Properties.Resources.s01);
                 Values = 1;
                 Card.RemoveAt(39);
             }
             else if (randomIndex == 40)
             {
                 Card.Insert(randomIndex, Properties.Resources.s02);
                 Values = 2;
                 Card.RemoveAt(40);
             }
             else if (randomIndex == 41)
             {
                 Card.Insert(randomIndex, Properties.Resources.s03);
                 Values = 3;
                 Card.RemoveAt(41);
             }
             else if (randomIndex == 42)
             {
                 Card.Insert(randomIndex, Properties.Resources.s04);
                 Values = 4;
                 Card.RemoveAt(42);
             }
             else if (randomIndex == 43)
             {
                 Card.Insert(randomIndex, Properties.Resources.s05);
                 Values = 5;
                 Card.RemoveAt(43);
             }
             else if (randomIndex == 44)
             {
                 Card.Insert(randomIndex, Properties.Resources.s06);
                 Values = 6;
                 Card.RemoveAt(44);
             }
             else if (randomIndex == 45)
             {
                 Values = 7;
                 Card.Insert(randomIndex, Properties.Resources.s07);
                 Card.RemoveAt(45);
             }
             else if (randomIndex == 46)
             {
                 Values = 8;
                 Card.Insert(randomIndex, Properties.Resources.s08);
                 Card.RemoveAt(46);
             }
             else if (randomIndex == 47)
             {
                 Card.Insert(randomIndex, Properties.Resources.s09);
                 Values = 9;
                 Card.RemoveAt(47);
             }
             else if (randomIndex == 48)
             {
                 Values = 10;
                 Card.Insert(randomIndex, Properties.Resources.s10);
                 Card.RemoveAt(48);
             }
             else if (randomIndex == 49)
             {
                 Values = 11;
                 Card.Insert(randomIndex, Properties.Resources.s11);
                 Card.RemoveAt(49);
             }
             else if (randomIndex == 50)
             {
                 Values = 12;
                 Card.Insert(randomIndex, Properties.Resources.s12);
                 Card.RemoveAt(50);
             }
             else
             {
                 Values = 13;
                 Card.Insert(randomIndex, Properties.Resources.s13);
                 Card.RemoveAt(51);
             }
             //
             //
             //
             //
             secondRandomIndex = randomCardIndex.Next(0, Card.Count - 1);

             if (secondRandomIndex == 0)
             {
                 Values = 1;
                 Card.Insert(secondRandomIndex, Properties.Resources.c01);
                 Card.RemoveAt(0);
             }
             else if (secondRandomIndex == 1)
             {
                 Values = 2;
                 Card.Insert(secondRandomIndex, Properties.Resources.c02);
                 Card.RemoveAt(1);
             }
             else if (secondRandomIndex == 2)
             {
                 Values = 3;
                 Card.Insert(secondRandomIndex, Properties.Resources.c03);
                 Card.RemoveAt(2);
             }
             else if (secondRandomIndex == 3)
             {
                 Values = 4;
                 Card.Insert(secondRandomIndex, Properties.Resources.c04);
                 Card.RemoveAt(3);
             }
             else if (secondRandomIndex == 4)
             {
                 Values = 5;
                 Card.Insert(randomIndex, Properties.Resources.c05);
                 Card.RemoveAt(4);
             }
             else if (secondRandomIndex == 5)
             {
                 Values = 6;
                 Card.Insert(secondRandomIndex, Properties.Resources.c06);
                 Card.RemoveAt(5);
             }

             else if (secondRandomIndex == 6)
             {
                 Values = 7;
                 Card.Insert(secondRandomIndex, Properties.Resources.c07);
                 Card.RemoveAt(6);
             }
             else if (secondRandomIndex == 7)
             {
                 Values = 8;
                 Card.Insert(secondRandomIndex, Properties.Resources.c08);
                 Card.RemoveAt(7);
             }
             else if (secondRandomIndex == 8)
             {
                 Values = 9;
                 Card.Insert(secondRandomIndex, Properties.Resources.c09);
                 Card.RemoveAt(8);
             }
             else if (secondRandomIndex == 9)
             {
                 Values = 10;
                 Card.Insert(secondRandomIndex, Properties.Resources.c10);
                 Card.RemoveAt(9);
             }
             else if (secondRandomIndex == 10)
             {
                 Values = 11;
                 Card.Insert(secondRandomIndex, Properties.Resources.c11);
                 Card.RemoveAt(10);
             }
             else if (secondRandomIndex == 11)
             {
                 Values = 12;
                 Card.Insert(secondRandomIndex, Properties.Resources.c12);
                 Card.RemoveAt(11);
             }
             else if (secondRandomIndex == 12)
             {
                 Values = 2;
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
             // sum of player number
             sumPlayerCard = randomIndex + secondRandomIndex + thirdRandomIndex;
             // insert list to player picture box
             picFirstPlayerCard.Image = Card[randomIndex];
             picSecondplayerCard.Image = Card[secondRandomIndex];
             picThirdPlayerCard.Image = Card[thirdRandomIndex];
             //
             //
             //
             //
             // set Card randomly to Computer's First card
             computerRandomIndex = randomCardIndex.Next(0, Card.Count - 1);

             if (computerRandomIndex == 0)
             {
                 computerRandomIndex = 1;
                 Card.Insert(computerRandomIndex, Properties.Resources.c01);
                 Card.RemoveAt(0);
             }
             else if (computerRandomIndex == 1)
             {
                 computerRandomIndex = 2;
                 Card.Insert(computerRandomIndex, Properties.Resources.c02);
                 Card.RemoveAt(1);
             }
             else if (computerRandomIndex == 2)
             {
                 computerRandomIndex = 3;
                 Card.Insert(computerRandomIndex, Properties.Resources.c03);
                 Card.RemoveAt(2);
             }
             else if (computerRandomIndex == 3)
             {
                 computerRandomIndex = 4;
                 Card.Insert(computerRandomIndex, Properties.Resources.c04);
                 Card.RemoveAt(3);
             }
             else if (computerRandomIndex == 4)
             {
                 computerRandomIndex = 5;
                 Card.Insert(computerRandomIndex, Properties.Resources.c05);
                 Card.RemoveAt(4);
             }
             else if (computerRandomIndex == 5)
             {
                 computerRandomIndex = 6;
                 Card.Insert(computerRandomIndex, Properties.Resources.c06);
                 Card.RemoveAt(5);
             }

             else if (computerRandomIndex == 6)
             {
                 computerRandomIndex = 7;
                 Card.Insert(computerRandomIndex, Properties.Resources.c07);
                 Card.RemoveAt(6);
             }
             else if (computerRandomIndex == 7)
             {
                 computerRandomIndex = 8;
                 Card.Insert(computerRandomIndex, Properties.Resources.c08);
                 Card.RemoveAt(7);
             }
             else if (computerRandomIndex == 8)
             {
                 computerRandomIndex = 9;
                 Card.Insert(computerRandomIndex, Properties.Resources.c09);
                 Card.RemoveAt(8);
             }
             else if (computerRandomIndex == 9)
             {
                 computerRandomIndex = 10;
                 Card.Insert(computerRandomIndex, Properties.Resources.c10);
                 Card.RemoveAt(9);
             }
             else if (computerRandomIndex == 10)
             {
                 computerRandomIndex = 11;
                 Card.Insert(computerRandomIndex, Properties.Resources.c11);
                 Card.RemoveAt(10);
             }
             else if (computerRandomIndex == 11)
             {
                 computerRandomIndex = 12;
                 Card.Insert(computerRandomIndex, Properties.Resources.c12);
                 Card.RemoveAt(11);
             }
             else if (computerRandomIndex == 12)
             {
                 computerRandomIndex = 13;
                 Card.Insert(computerRandomIndex, Properties.Resources.c13);
                 Card.RemoveAt(12);
             }
             else if (computerRandomIndex == 13)
             {
                 computerRandomIndex = 1;
                 Card.Insert(computerRandomIndex, Properties.Resources.d01);
                 Card.RemoveAt(13);
             }
             else if (computerRandomIndex == 14)
             {
                 computerRandomIndex = 2;
                 Card.Insert(computerRandomIndex, Properties.Resources.d02);
                 Card.RemoveAt(14);
             }
             else if (computerRandomIndex == 15)
             {
                 computerRandomIndex = 3;
                 Card.Insert(computerRandomIndex, Properties.Resources.d03);
                 Card.RemoveAt(15);
             }
             else if (computerRandomIndex == 16)
             {
                 computerRandomIndex = 4;
                 Card.Insert(computerRandomIndex, Properties.Resources.d04);
                 Card.RemoveAt(16);
             }
             else if (computerRandomIndex == 17)
             {
                 computerRandomIndex = 5;
                 Card.Insert(computerRandomIndex, Properties.Resources.d05);
                 Card.RemoveAt(17);
             }
             else if (computerRandomIndex == 18)
             {
                 computerRandomIndex = 6;
                 Card.Insert(computerRandomIndex, Properties.Resources.d06);
                 Card.RemoveAt(18);
             }
             else if (computerRandomIndex == 19)
             {
                 computerRandomIndex = 7;
                 Card.Insert(computerRandomIndex, Properties.Resources.d07);
                 Card.RemoveAt(19);
             }
             else if (computerRandomIndex == 20)
             {
                 computerRandomIndex = 8;
                 Card.Insert(computerRandomIndex, Properties.Resources.d08);
                 Card.RemoveAt(20);
             }
             else if (computerRandomIndex == 21)
             {
                 computerRandomIndex = 9;
                 Card.Insert(computerRandomIndex, Properties.Resources.d09);
                 Card.RemoveAt(21);
             }
             else if (computerRandomIndex == 22)
             {
                 computerRandomIndex = 10;
                 Card.Insert(computerRandomIndex, Properties.Resources.d10);
                 Card.RemoveAt(22);
             }
             else if (computerRandomIndex == 23)
             {
                 computerRandomIndex = 11;
                 Card.Insert(computerRandomIndex, Properties.Resources.d11);
                 Card.RemoveAt(23);
             }
             else if (computerRandomIndex == 24)
             {
                 computerRandomIndex = 12;
                 Card.Insert(computerRandomIndex, Properties.Resources.d12);
                 Card.RemoveAt(24);
             }
             else if (computerRandomIndex == 25)
             {
                 computerRandomIndex = 13;
                 Card.Insert(computerRandomIndex, Properties.Resources.d13);
                 Card.RemoveAt(25);
             }
             else if (computerRandomIndex == 26)
             {
                 computerRandomIndex = 1;
                 Card.Insert(computerRandomIndex, Properties.Resources.h01);
                 Card.RemoveAt(26);
             }
             else if (computerRandomIndex == 27)
             {
                 computerRandomIndex = 2;
                 Card.Insert(computerRandomIndex, Properties.Resources.h02);
                 Card.RemoveAt(27);
             }
             else if (computerRandomIndex == 28)
             {
                 computerRandomIndex = 3;
                 Card.Insert(computerRandomIndex, Properties.Resources.h03);
                 Card.RemoveAt(28);
             }
             else if (computerRandomIndex == 29)
             {
                 computerRandomIndex = 4;
                 Card.Insert(computerRandomIndex, Properties.Resources.h04);
                 Card.RemoveAt(29);
             }
             else if (computerRandomIndex == 30)
             {
                 computerRandomIndex = 5;
                 Card.Insert(computerRandomIndex, Properties.Resources.h05);
                 Card.RemoveAt(30);
             }
             else if (computerRandomIndex == 31)
             {
                 computerRandomIndex = 6;
                 Card.Insert(computerRandomIndex, Properties.Resources.h06);
                 Card.RemoveAt(31);
             }
             else if (computerRandomIndex == 32)
             {
                 computerRandomIndex = 7;
                 Card.Insert(computerRandomIndex, Properties.Resources.h07);
                 Card.RemoveAt(32);
             }
             else if (computerRandomIndex == 33)
             {
                 computerRandomIndex = 8;
                 Card.Insert(computerRandomIndex, Properties.Resources.h08);
                 Card.RemoveAt(33);
             }
             else if (computerRandomIndex == 34)
             {
                 computerRandomIndex = 9;
                 Card.Insert(computerRandomIndex, Properties.Resources.h09);
                 Card.RemoveAt(34);
             }
             else if (computerRandomIndex == 35)
             {
                 computerRandomIndex = 10;
                 Card.Insert(computerRandomIndex, Properties.Resources.h10);
                 Card.RemoveAt(35);
             }
             else if (computerRandomIndex == 36)
             {
                 computerRandomIndex = 11;
                 Card.Insert(computerRandomIndex, Properties.Resources.h11);
                 Card.RemoveAt(36);
             }
             else if (computerRandomIndex == 37)
             {
                 computerRandomIndex = 12;
                 Card.Insert(computerRandomIndex, Properties.Resources.h12);
                 Card.RemoveAt(37);
             }
             else if (computerRandomIndex == 38)
             {
                 computerRandomIndex = 13;
                 Card.Insert(computerRandomIndex, Properties.Resources.h13);
                 Card.RemoveAt(38);
             }
             else if (computerRandomIndex == 39)
             {
                 computerRandomIndex = 1;
                 Card.Insert(computerRandomIndex, Properties.Resources.s01);
                 Card.RemoveAt(39);
             }
             else if (computerRandomIndex == 40)
             {
                 computerRandomIndex = 2;
                 Card.Insert(computerRandomIndex, Properties.Resources.s02);
                 Card.RemoveAt(40);
             }
             else if (computerRandomIndex == 41)
             {
                 computerRandomIndex = 3;
                 Card.Insert(computerRandomIndex, Properties.Resources.s03);
                 Card.RemoveAt(41);
             }
             else if (computerRandomIndex == 42)
             {
                 computerRandomIndex = 4;
                 Card.Insert(computerRandomIndex, Properties.Resources.s04);
                 Card.RemoveAt(42);
             }
             else if (computerRandomIndex == 43)
             {
                 computerRandomIndex = 5;
                 Card.Insert(computerRandomIndex, Properties.Resources.s05);
                 Card.RemoveAt(43);
             }
             else if (computerRandomIndex == 44)
             {
                 computerRandomIndex = 6;
                 Card.Insert(computerRandomIndex, Properties.Resources.s06);
                 Card.RemoveAt(44);
             }
             else if (computerRandomIndex == 45)
             {
                 computerRandomIndex = 7;
                 Card.Insert(computerRandomIndex, Properties.Resources.s07);
                 Card.RemoveAt(45);
             }
             else if (computerRandomIndex == 46)
             {
                 computerRandomIndex = 8;
                 Card.Insert(computerRandomIndex, Properties.Resources.s08);
                 Card.RemoveAt(46);
             }
             else if (computerRandomIndex == 47)
             {
                 computerRandomIndex = 9;
                 Card.Insert(computerRandomIndex, Properties.Resources.s09);
                 Card.RemoveAt(47);
             }
             else if (computerRandomIndex == 48)
             {
                 computerRandomIndex = 10;
                 Card.Insert(computerRandomIndex, Properties.Resources.s10);
                 Card.RemoveAt(48);
             }
             else if (computerRandomIndex == 49)
             {
                 computerRandomIndex = 11;
                 Card.Insert(computerRandomIndex, Properties.Resources.s11);
                 Card.RemoveAt(49);
             }
             else if (computerRandomIndex == 50)
             {
                 computerRandomIndex = 12;
                 Card.Insert(computerRandomIndex, Properties.Resources.s12);
                 Card.RemoveAt(50);
             }
             else
             {
                 computerRandomIndex = 13;
                 Card.Insert(computerRandomIndex, Properties.Resources.s13);
                 Card.RemoveAt(51);
             }
             //
             //
             //
             computerSecondRandomIndex = randomCardIndex.Next(0, Card.Count - 1);
             if (computerSecondRandomIndex == 0)
             {
                 computerSecondRandomIndex = 1;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c01);
                 Card.RemoveAt(0);
             }
             else if (computerSecondRandomIndex == 1)
             {
                 computerSecondRandomIndex = 2;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c02);
                 Card.RemoveAt(1);
             }
             else if (computerSecondRandomIndex == 2)
             {
                 computerSecondRandomIndex = 3;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c03);
                 Card.RemoveAt(2);
             }
             else if (computerSecondRandomIndex == 3)
             {
                 computerSecondRandomIndex = 4;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c04);
                 Card.RemoveAt(3);
             }
             else if (computerSecondRandomIndex == 4)
             {
                 computerSecondRandomIndex = 5;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c05);
                 Card.RemoveAt(4);
             }
             else if (computerSecondRandomIndex == 5)
             {
                 computerSecondRandomIndex = 6;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c06);
                 Card.RemoveAt(5);
             }

             else if (computerSecondRandomIndex == 6)
             {
                 computerSecondRandomIndex = 7;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c07);
                 Card.RemoveAt(6);
             }
             else if (computerSecondRandomIndex == 7)
             {
                 computerSecondRandomIndex = 8;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c08);
                 Card.RemoveAt(7);
             }
             else if (computerSecondRandomIndex == 8)
             {
                 computerSecondRandomIndex = 9;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c09);
                 Card.RemoveAt(8);
             }
             else if (computerSecondRandomIndex == 9)
             {
                 computerSecondRandomIndex = 10;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c10);
                 Card.RemoveAt(9);
             }
             else if (computerSecondRandomIndex == 10)
             {
                 computerSecondRandomIndex = 11;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c11);
                 Card.RemoveAt(10);
             }
             else if (computerSecondRandomIndex == 11)
             {
                 computerSecondRandomIndex = 12;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c12);
                 Card.RemoveAt(11);
             }
             else if (computerSecondRandomIndex == 12)
             {
                 computerSecondRandomIndex = 13;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.c13);
                 Card.RemoveAt(12);
             }
             else if (computerSecondRandomIndex == 13)
             {
                 computerSecondRandomIndex = 1;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d01);
                 Card.RemoveAt(13);
             }
             else if (computerSecondRandomIndex == 14)
             {
                 computerSecondRandomIndex = 2;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d02);
                 Card.RemoveAt(14);
             }
             else if (computerSecondRandomIndex == 15)
             {
                 computerSecondRandomIndex = 3;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d03);
                 Card.RemoveAt(15);
             }
             else if (computerSecondRandomIndex == 16)
             {
                 computerSecondRandomIndex = 4;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d04);
                 Card.RemoveAt(16);
             }
             else if (computerSecondRandomIndex == 17)
             {
                 computerSecondRandomIndex = 5;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d05);
                 Card.RemoveAt(17);
             }
             else if (computerSecondRandomIndex == 18)
             {
                 computerSecondRandomIndex = 6;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d06);
                 Card.RemoveAt(18);
             }
             else if (computerSecondRandomIndex == 19)
             {
                 computerSecondRandomIndex = 7;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d07);
                 Card.RemoveAt(19);
             }
             else if (computerSecondRandomIndex == 20)
             {
                 computerSecondRandomIndex = 8;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d08);
                 Card.RemoveAt(20);
             }
             else if (computerSecondRandomIndex == 21)
             {
                 computerSecondRandomIndex = 9;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d09);
                 Card.RemoveAt(21);
             }
             else if (computerSecondRandomIndex == 22)
             {
                 computerSecondRandomIndex = 10;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d10);
                 Card.RemoveAt(22);
             }
             else if (computerSecondRandomIndex == 23)
             {
                 computerSecondRandomIndex = 11;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d11);
                 Card.RemoveAt(23);
             }
             else if (computerSecondRandomIndex == 24)
             {
                 computerSecondRandomIndex = 12;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d12);
                 Card.RemoveAt(24);
             }
             else if (computerSecondRandomIndex == 25)
             {
                 computerSecondRandomIndex = 13;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.d13);
                 Card.RemoveAt(25);
             }
             else if (computerSecondRandomIndex == 26)
             {
                 computerSecondRandomIndex = 1;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h01);
                 Card.RemoveAt(26);
             }
             else if (computerSecondRandomIndex == 27)
             {
                 computerSecondRandomIndex = 2;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h02);
                 Card.RemoveAt(27);
             }
             else if (computerSecondRandomIndex == 28)
             {
                 computerSecondRandomIndex = 3;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h03);
                 Card.RemoveAt(28);
             }
             else if (computerSecondRandomIndex == 29)
             {
                 computerSecondRandomIndex = 4;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h04);
                 Card.RemoveAt(29);
             }
             else if (computerSecondRandomIndex == 30)
             {
                 computerSecondRandomIndex = 5;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h05);
                 Card.RemoveAt(30);
             }
             else if (computerSecondRandomIndex == 31)
             {
                 computerSecondRandomIndex = 6;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h06);
                 Card.RemoveAt(31);
             }
             else if (computerSecondRandomIndex == 32)
             {
                 computerSecondRandomIndex = 7;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h07);
                 Card.RemoveAt(32);
             }
             else if (computerSecondRandomIndex == 33)
             {
                 computerSecondRandomIndex = 8;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h08);
                 Card.RemoveAt(33);
             }
             else if (computerSecondRandomIndex == 34)
             {
                 computerSecondRandomIndex = 9;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h09);
                 Card.RemoveAt(34);
             }
             else if (computerSecondRandomIndex == 35)
             {
                 computerSecondRandomIndex = 10;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h10);
                 Card.RemoveAt(35);
             }
             else if (computerSecondRandomIndex == 36)
             {
                 computerSecondRandomIndex = 11;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h11);
                 Card.RemoveAt(36);
             }
             else if (computerSecondRandomIndex == 37)
             {
                 computerSecondRandomIndex = 12;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h12);
                 Card.RemoveAt(37);
             }
             else if (computerSecondRandomIndex == 38)
             {
                 computerSecondRandomIndex = 13;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.h13);
                 Card.RemoveAt(38);
             }
             else if (computerSecondRandomIndex == 39)
             {
                 computerSecondRandomIndex = 1;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s01);
                 Card.RemoveAt(39);
             }
             else if (computerSecondRandomIndex == 40)
             {
                 computerSecondRandomIndex = 3;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s02);
                 Card.RemoveAt(40);
             }
             else if (computerSecondRandomIndex == 41)
             {
                 computerSecondRandomIndex = 3;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s03);
                 Card.RemoveAt(41);
             }
             else if (computerSecondRandomIndex == 42)
             {
                 computerSecondRandomIndex = 4;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s04);
                 Card.RemoveAt(42);
             }
             else if (computerSecondRandomIndex == 43)
             {
                 computerSecondRandomIndex = 5;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s05);
                 Card.RemoveAt(43);
             }
             else if (computerSecondRandomIndex == 44)
             {
                 computerSecondRandomIndex = 6;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s06);
                 Card.RemoveAt(44);
             }
             else if (computerSecondRandomIndex == 45)
             {
                 computerSecondRandomIndex = 7;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s07);
                 Card.RemoveAt(45);
             }
             else if (computerSecondRandomIndex == 46)
             {
                 computerSecondRandomIndex = 8;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s08);
                 Card.RemoveAt(46);
             }
             else if (computerSecondRandomIndex == 47)
             {
                 computerSecondRandomIndex = 9;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s09);
                 Card.RemoveAt(47);
             }
             else if (computerSecondRandomIndex == 48)
             {
                 computerSecondRandomIndex = 10;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s10);
                 Card.RemoveAt(48);
             }
             else if (computerSecondRandomIndex == 49)
             {
                 computerSecondRandomIndex = 11;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s11);
                 Card.RemoveAt(49);
             }
             else if (computerSecondRandomIndex == 50)
             {
                 computerSecondRandomIndex = 12;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s12);
                 Card.RemoveAt(50);
             }
             else
             {
                 computerSecondRandomIndex = 13;
                 Card.Insert(computerSecondRandomIndex, Properties.Resources.s13);
                 Card.RemoveAt(51);
             }
             //
             //
             //
             computerThirdRandomIndex = randomCardIndex.Next(0, Card.Count - 1);
             if (randomIndex == 0)
             {
                 computerThirdRandomIndex = 1;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c01);
                 Card.RemoveAt(0);
             }
             else if (computerThirdRandomIndex == 1)
             {
                 computerThirdRandomIndex = 2;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c02);
                 Card.RemoveAt(1);
             }
             else if (computerThirdRandomIndex == 2)
             {
                 computerThirdRandomIndex = 3;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c03);
                 Card.RemoveAt(2);
             }
             else if (computerThirdRandomIndex == 3)
             {
                 computerThirdRandomIndex = 4;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c04);
                 Card.RemoveAt(3);
             }
             else if (computerThirdRandomIndex == 4)
             {
                 computerThirdRandomIndex = 5;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c05);
                 Card.RemoveAt(4);
             }
             else if (computerThirdRandomIndex == 5)
             {
                 computerThirdRandomIndex = 6;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c06);
                 Card.RemoveAt(5);
             }

             else if (computerThirdRandomIndex == 6)
             {
                 computerThirdRandomIndex = 7;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c07);
                 Card.RemoveAt(6);
             }
             else if (computerThirdRandomIndex == 7)
             {
                 computerThirdRandomIndex = 8;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c08);
                 Card.RemoveAt(7);
             }
             else if (computerThirdRandomIndex == 8)
             {
                 computerThirdRandomIndex = 9;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c09);
                 Card.RemoveAt(8);
             }
             else if (computerThirdRandomIndex == 9)
             {
                 computerThirdRandomIndex = 9;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c10);
                 Card.RemoveAt(9);
             }
             else if (computerThirdRandomIndex == 10)
             {
                 computerThirdRandomIndex = 10;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c11);
                 Card.RemoveAt(10);
             }
             else if (computerThirdRandomIndex == 11)
             {
                 computerThirdRandomIndex = 12;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c12);
                 Card.RemoveAt(11);
             }
             else if (computerThirdRandomIndex == 12)
             {
                 computerThirdRandomIndex = 13;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.c13);
                 Card.RemoveAt(12);
             }
             else if (randomIndex == 13)
             {
                 computerThirdRandomIndex = 1;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d01);
                 Card.RemoveAt(13);
             }
             else if (computerThirdRandomIndex == 14)
             {
                 computerThirdRandomIndex = 2;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d02);
                 Card.RemoveAt(14);
             }
             else if (computerThirdRandomIndex == 15)
             {
                 computerThirdRandomIndex = 3;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d03);
                 Card.RemoveAt(15);
             }
             else if (computerThirdRandomIndex == 16)
             {
                 computerThirdRandomIndex = 4;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d04);
                 Card.RemoveAt(16);
             }
             else if (computerThirdRandomIndex == 17)
             {
                 computerThirdRandomIndex = 5;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d05);
                 Card.RemoveAt(17);
             }
             else if (computerThirdRandomIndex == 18)
             {
                 computerThirdRandomIndex = 6;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d06);
                 Card.RemoveAt(18);
             }
             else if (computerThirdRandomIndex == 19)
             {
                 computerThirdRandomIndex = 7;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d07);
                 Card.RemoveAt(19);
             }
             else if (computerThirdRandomIndex == 20)
             {
                 computerThirdRandomIndex = 8;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d08);
                 Card.RemoveAt(20);
             }
             else if (computerThirdRandomIndex == 21)
             {
                 computerThirdRandomIndex = 9;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d09);
                 Card.RemoveAt(21);
             }
             else if (computerThirdRandomIndex == 22)
             {
                 computerThirdRandomIndex = 10;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d10);
                 Card.RemoveAt(22);
             }
             else if (computerThirdRandomIndex == 23)
             {
                 computerThirdRandomIndex = 11;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d11);
                 Card.RemoveAt(23);
             }
             else if (computerThirdRandomIndex == 24)
             {
                 computerThirdRandomIndex = 12;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d12);
                 Card.RemoveAt(24);
             }
             else if (computerThirdRandomIndex == 25)
             {
                 computerThirdRandomIndex = 13;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.d13);
                 Card.RemoveAt(25);
             }
             else if (computerThirdRandomIndex == 26)
             {
                 computerThirdRandomIndex = 1;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h01);
                 Card.RemoveAt(26);
             }
             else if (computerThirdRandomIndex == 27)
             {
                 computerThirdRandomIndex = 2;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h02);
                 Card.RemoveAt(27);
             }
             else if (computerThirdRandomIndex == 28)
             {
                 computerThirdRandomIndex = 3;
                 Card.Insert(randomIndex, Properties.Resources.h03);
                 Card.RemoveAt(28);
             }
             else if (computerThirdRandomIndex == 29)
             {
                 computerThirdRandomIndex = 4;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h04);
                 Card.RemoveAt(29);
             }
             else if (computerThirdRandomIndex == 30)
             {
                 computerThirdRandomIndex = 5;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h05);
                 Card.RemoveAt(30);
             }
             else if (computerThirdRandomIndex == 31)
             {
                 computerThirdRandomIndex = 8;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h06);
                 Card.RemoveAt(31);
             }
             else if (computerThirdRandomIndex == 32)
             {
                 computerThirdRandomIndex = 7;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h07);
                 Card.RemoveAt(32);
             }
             else if (computerThirdRandomIndex == 33)
             {
                 computerThirdRandomIndex = 8;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h08);
                 Card.RemoveAt(33);
             }
             else if (computerThirdRandomIndex == 34)
             {
                 computerThirdRandomIndex = 9;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h09);
                 Card.RemoveAt(34);
             }
             else if (computerThirdRandomIndex == 35)
             {
                 computerThirdRandomIndex = 10;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h10);
                 Card.RemoveAt(35);
             }
             else if (computerThirdRandomIndex == 36)
             {
                 computerThirdRandomIndex = 11;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h11);
                 Card.RemoveAt(36);
             }
             else if (computerThirdRandomIndex == 37)
             {
                 computerThirdRandomIndex = 12;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h12);
                 Card.RemoveAt(37);
             }
             else if (computerThirdRandomIndex == 38)
             {
                 computerThirdRandomIndex = 13;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.h13);
                 Card.RemoveAt(38);
             }
             else if (computerThirdRandomIndex == 39)
             {
                 computerThirdRandomIndex = 1;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s01);
                 Card.RemoveAt(39);
             }
             else if (computerThirdRandomIndex == 40)
             {
                 Values = 2;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s02);
                 Card.RemoveAt(40);
             }
             else if (computerThirdRandomIndex == 41)
             {
                 Values = 3;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s03);
                 Card.RemoveAt(41);
             }
             else if (randomIndex == 42)
             {
                 Values = 4;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s04);
                 Card.RemoveAt(42);
             }
             else if (computerThirdRandomIndex == 43)
             {
                 Values = 5;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s05);
                 Card.RemoveAt(43);
             }
             else if (computerThirdRandomIndex == 44)
             {
                 Values = 6;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s06);
                 Card.RemoveAt(44);
             }
             else if (computerThirdRandomIndex == 45)
             {
                 Values = 7;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s07);
                 Card.RemoveAt(45);
             }
             else if (computerThirdRandomIndex == 46)
             {
                 Values = 8;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s08);
                 Card.RemoveAt(46);
             }
             else if (computerThirdRandomIndex == 47)
             {
                 Values = 9;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s09);
                 Card.RemoveAt(47);
             }
             else if (computerThirdRandomIndex == 48)
             {
                 Values = 10;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s10);
                 Card.RemoveAt(48);
             }
             else if (computerThirdRandomIndex == 49)
             {
                 Values = 11;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s11);
                 Card.RemoveAt(49);
             }
             else if (computerThirdRandomIndex == 50)
             {
                 Values = 12;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s12);
                 Card.RemoveAt(50);
             }
             else
             {
                 Values = 13;
                 Card.Insert(computerThirdRandomIndex, Properties.Resources.s13);
                 Card.RemoveAt(51);
             }
             
           
        }
        private void btnStay_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            btnStart.Enabled = false;
            picThirdPlayerCard.Enabled = false;
            picFirstComputerCard.Show();
            picSecondComputerCard.Show();
            picThirdComputerCard.Show();
            picThirdPlayerCard.Hide();

            //List<Image> Card = new List<Image>();

            // sum for the computer
            sumComputerCard = computerValues + computersecondValues + computerthirdValues;
            picFirstComputerCard.Image = Card[computerValues];
            picSecondComputerCard.Image = Card[computersecondValues];
            picThirdComputerCard.Image = Card[computerthirdValues];
            // sum for the player
            sumPlayerCard = Values + secondPlayerValues + secondPlayerValues;
            picFirstPlayerCard.Image = Card[Values];
            picSecondplayerCard.Image = Card[secondPlayerValues];
            picThirdPlayerCard.Image = Card[thirdPlayerValues];

            if ((sumPlayerCard > 21) && (sumComputerCard < 21))
            {
                MessageBox.Show("Computer wins!!!", "You Lose!!");
            }
            if ((sumPlayerCard <= 21) && (sumComputerCard >= 21))
            {
                MessageBox.Show("You Win!!", "Winner!!");
            }
            if ((sumPlayerCard < 21) && (sumComputerCard < 21))
            {
                MessageBox.Show("Tie!!", "No Winners");
            }
            if (sumPlayerCard > 21)
            {
                MessageBox.Show("Computer Wins!!!", "You Lose!!");
            }
            if ((sumPlayerCard >= 21) && (sumComputerCard >= 21))
            {
                MessageBox.Show("Computer wins!!!", "Bust!");
            }
        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            btnStay.Enabled = false;
            btnStart.Enabled = false;
            btnHit.Enabled = false;
            picThirdPlayerCard.Enabled = true;
            picFirstComputerCard.Show();
            picSecondComputerCard.Show();
            picThirdComputerCard.Show();
            picThirdPlayerCard.Show();

            //List<Image> Card = new List<Image>();

            // sum for the computer
            sumComputerCard = computerValues + computersecondValues + computerthirdValues;
            picFirstComputerCard.Image = Card[computerValues];
            picSecondComputerCard.Image = Card[computersecondValues];
            picThirdComputerCard.Image = Card[computerthirdValues];
            // sum for the player
            sumPlayerCard = Values + secondPlayerValues + secondPlayerValues;
            picFirstPlayerCard.Image = Card[Values];
            picSecondplayerCard.Image = Card[secondPlayerValues];
            picThirdPlayerCard.Image = Card[thirdPlayerValues];

            if ((sumPlayerCard > 21) && (sumComputerCard < 21))
            {
                MessageBox.Show("Computer wins!!!", "You Lose!!");
            }
            if ((sumPlayerCard <= 21) && (sumComputerCard >= 21))
            {
                MessageBox.Show("You Win!!", "Winner!!");
            }
            if ((sumPlayerCard < 21) && (sumComputerCard < 21))
            {
                MessageBox.Show("Tie!!", "No Winners");
            }
            if (sumPlayerCard > 21)
            {
                MessageBox.Show("Computer Wins!!!", "You Lose!!");
            }
            if ((sumPlayerCard >= 21) && (sumComputerCard >= 21))
            {
                MessageBox.Show("Computer wins!!!", "Bust!");
            }
        }
        private void picThirdPlayerCard_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
