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
            // set player index randomly
            Random randomFirstPlayerIndex = new Random();
            randomIndex = randomFirstPlayerIndex.Next(0, playerFirstCard.Count-1);
            Random randomSecondPlayerIndex = new Random();
            Random randomThirdPlayerIndex = new Random();
            //


            //place the image in the given picture box

            //



        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
