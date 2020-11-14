using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_9a713046.Properties;

namespace WP_2020_01_HW02_9a713046
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();   //讀檔
        int brank = 52;                         //宣告一個數
        public Form1()
        {
            InitializeComponent();
        }
        #region 加入圖片

        
        private void frmGame(object sender, EventArgs e)
        {
            list.Add(Resources.g0);
            list.Add(Resources.g1);
            list.Add(Resources.g2);
            list.Add(Resources.g3);
            list.Add(Resources.g4);
            list.Add(Resources.g5);
            list.Add(Resources.g6); 
            list.Add(Resources.g7);
            list.Add(Resources.g8);
            list.Add(Resources.g9);
            list.Add(Resources.g10);
            list.Add(Resources.g11);
            list.Add(Resources.g12);
            list.Add(Resources.g13);
            list.Add(Resources.g14);
            list.Add(Resources.g15);
            list.Add(Resources.g16);
            list.Add(Resources.g17);
            list.Add(Resources.g18);
            list.Add(Resources.g19);
            list.Add(Resources.g20);
            list.Add(Resources.g21);
            list.Add(Resources.g22);
            list.Add(Resources.g23);
            list.Add(Resources.g24);
            list.Add(Resources.g25);
            list.Add(Resources.g26);
            list.Add(Resources.g27);
            list.Add(Resources.g28);
            list.Add(Resources.g29);
            list.Add(Resources.g30);
            list.Add(Resources.g31);
            list.Add(Resources.g32);
            list.Add(Resources.g33);
            list.Add(Resources.g34);
            list.Add(Resources.g35);
            list.Add(Resources.g36);
            list.Add(Resources.g37);
            list.Add(Resources.g38);
            list.Add(Resources.g39);
            list.Add(Resources.g40);
            list.Add(Resources.g41);
            list.Add(Resources.g42);
            list.Add(Resources.g43);
            list.Add(Resources.g44);
            list.Add(Resources.g45);
            list.Add(Resources.g46);
            list.Add(Resources.g47);
            list.Add(Resources.g48);
            list.Add(Resources.g49);
            list.Add(Resources.g50);
            list.Add(Resources.g51);
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {            
            Random poker = new Random();                        //產生亂數
            int image = poker.Next(52);                         //共52張圖
            picResult.Image = list[image];                      //輸出圖片

            brank--;                                            //遞減
            label1.Text = ("剩餘牌數為:" + brank);              //遞減後輸出結果
            if (brank <= 0)                                     //條件
            {
                button1.Enabled = false;                        //條件成立輸出結果
            }

        }
    }
}
