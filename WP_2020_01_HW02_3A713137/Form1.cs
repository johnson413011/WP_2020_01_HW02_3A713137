using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713137.Properties;

namespace WP_2020_01_HW02_3A713137
{
    public partial class Form1 : Form
    {
        //新增陣列
        List<Image> pc = new List<Image>();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //產生亂數
            int index = (new Random()).Next(51) + 1;
            //顯示圖片
            pic.Image = pc[index];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //載入圖片
            pc.Add(Resources._1);
            pc.Add(Resources._2);
            pc.Add(Resources._3);
            pc.Add(Resources._4);
            pc.Add(Resources._5);
            pc.Add(Resources._6);
            pc.Add(Resources._7);
            pc.Add(Resources._8);
            pc.Add(Resources._9);
            pc.Add(Resources._10);
            pc.Add(Resources._11);
            pc.Add(Resources._12);
            pc.Add(Resources._13);
            pc.Add(Resources._14);
            pc.Add(Resources._15);
            pc.Add(Resources._16);
            pc.Add(Resources._17);
            pc.Add(Resources._18);
            pc.Add(Resources._19);
            pc.Add(Resources._20);
            pc.Add(Resources._21);
            pc.Add(Resources._22);
            pc.Add(Resources._23);
            pc.Add(Resources._24);
            pc.Add(Resources._25);
            pc.Add(Resources._26);
            pc.Add(Resources._27);
            pc.Add(Resources._28);
            pc.Add(Resources._29);
            pc.Add(Resources._30);
            pc.Add(Resources._31);
            pc.Add(Resources._32);
            pc.Add(Resources._33);
            pc.Add(Resources._34);
            pc.Add(Resources._35);
            pc.Add(Resources._36);
            pc.Add(Resources._37);
            pc.Add(Resources._38);
            pc.Add(Resources._39);
            pc.Add(Resources._40);
            pc.Add(Resources._41);
            pc.Add(Resources._42);
            pc.Add(Resources._43);
            pc.Add(Resources._44);
            pc.Add(Resources._45);
            pc.Add(Resources._46);
            pc.Add(Resources._47);
            pc.Add(Resources._48);
            pc.Add(Resources._49);
            pc.Add(Resources._50);
            pc.Add(Resources._51);
            pc.Add(Resources._52);
        }
    }
}
