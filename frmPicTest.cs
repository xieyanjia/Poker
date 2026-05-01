using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPicTest : Form
    {
        public frmPicTest()
        {
            InitializeComponent();
        }

        #region
        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }
        private Image GetImage(int num)
        {
            return GetImage($"pic{num}");
        }
        

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int r = rnd.Next(1, 53);

            this.picTest.Image = GetImage(r);  

            this.lblNum.Text = $"{r}";
        }
        /// <summary>
        /// 當點擊圖片時，將圖片換成 back 圖片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTest_Click(object sender, EventArgs e)
        {
            this.picTest.Image = GetImage("back");
        }
        
        #endregion
    }
}
