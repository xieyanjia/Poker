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
    public partial class frmPoker : Form
    {
        #region 欄位
        /// <summary>
        /// 用來存放牌桌上5張牌的 PictureBox 陣列，陣列大小為 5，代表牌桌上最多只能顯示5張牌
        /// </summary>
        PictureBox[] pic = new PictureBox[5];

        /// <summary>
        /// 所有撲克牌的編號陣列，包含52張牌的編號，從0到51，代表一副完整的撲克牌
        /// </summary>
        int[] allPoker = new int[52];

        /// <summary>
        /// 紀錄玩家手牌的編號陣列，大小為5，代表玩家最多只能持有5張牌，初始值為0，表示玩家尚未持有任何牌
        /// </summary>
        int[] playerPoker = new int[5];

        #endregion

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
        }


        #region 自定義方法
        private void InitializePoker()
        {
            // 動態產生5張牌
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetImage("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                // 初始狀態下，牌面朝下，無法點擊
                pic[i].Enabled = false;
                // 設定 Tag 為 "back"，表示牌面朝下
                pic[i].Tag = "back";
                pic[i].Visible = true;

                // 將 pic 丟至到 grpPorker 內
                this.grpPoker.Controls.Add(pic[i]);
                // pic[i].MouseClick += new MouseEventHandler(pic_Click);

                pic[i].Click += Pic_Click;
            }
        }

        /// <summary>
        /// 顯示五張撲克牌到桌面上
        /// </summary>
        private void ShowCards()
        {
            for (int i = 0; i < playerPoker.Length; i++)
            {
                pic[i].Image = this.GetImage($"pic{playerPoker[i] + 1}");
            }
        }

        /// <summary>
        /// 取得圖片的方法，根據圖片名稱從資源檔中取得對應的圖片
        /// </summary>
        /// <param name="name">string 的牌名</param>
        /// <returns></returns>
        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        /// <summary>
        /// 取得圖片的方法，根據牌的編號從資源檔中取得對應的圖片
        /// </summary>
        /// <param name="num">撲克牌編號</param>
        /// <returns></returns>
        private Image GetImage(int num)
        {
            return GetImage($"pic{num}");
        }

        /// <summary>
        /// 將52張牌的編號隨機打亂的方法，使用 Fisher-Yates 洗牌算法，確保每張牌都有相同的機會被選中，達到真正的隨機效果
        /// </summary>
        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }
        #endregion

        #region 事件處理程序

        /// <summary>
        /// 牌桌上每張牌的 Click 事件處理程序，當點擊圖片時，會顯示該圖片的名稱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            int index = int.Parse(pic.Name.Replace("pic", ""));

            int cardNum = playerPoker[index] + 1;

            // 如果牌面朝下，則將牌面朝上，顯示該牌的圖片；如果牌面朝上，則將牌面朝下，顯示背面圖片
            if (pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = GetImage(cardNum);
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetImage("back");
            }
        }


        /// <summary>
        /// 當點擊發牌按鈕時，會隨機產生5張牌並顯示在牌桌上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDealCard_Click(object sender, EventArgs e)
        {
            // 將上一把牌型的結果清空
            this.lblResult.Text = "";

            // 將牌桌上的圖片換成 back 圖片，表示牌面朝下
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Image = GetImage("back");
            }

            // 將所有撲克牌的編號從0到51存入 allPoker 陣列中
            for (int i = 0; i < allPoker.Length; i++)
            {
                allPoker[i] = i;
            }

            // 洗牌
            this.Shuffle();

            // 暫停500ms
            await Task.Delay(500);

            // 將洗牌後的前5張牌的編號存入 playerPoker 陣列中，代表玩家手牌的編號
            for (int i = 0; i < playerPoker.Length; i++)
            {
                // 取前52張牌的前5張牌給玩家
                playerPoker[i] = allPoker[i];
                //// 將玩家手牌的圖片顯示在牌桌上，根據玩家手牌的編號從資源檔中取得對應的圖片
                //pic[i].Image = GetImage(playerPoker[i] + 1);
            }

            //// 測試同花大順
            //playerPoker[0] = 51;
            //playerPoker[1] = 47;
            //playerPoker[2] = 43;
            //playerPoker[3] = 39;
            //playerPoker[4] = 3;

            // 顯示玩家手牌的圖片在牌桌上
            this.ShowCards();

            // 啟用所有牌的點擊事件
            for (int i = 0; i < pic.Length; i++)
            {
                // 將牌面朝上的圖片設定為可點擊
                pic[i].Enabled = true;
                // 將 Tag 設定為 "front"，表示牌面朝上
                pic[i].Tag = "front";
            }
            // 啟用換牌按鈕
            this.btnChangeCard.Enabled = true;
            this.btnDealCard.Enabled = false;

        }

        /// <summary>
        /// 當點擊換牌按鈕時，會將玩家選擇要換掉的牌從牌桌上移除，並從洗牌後的牌堆中抽取新的牌替換掉被換掉的牌，最後顯示在牌桌上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int startIndex = 5; // 從洗牌後的牌堆中抽取新的牌的起始索引，因為前5張牌已經給玩家了，所以從第6張牌開始抽取

            for (int i = 0; i < playerPoker.Length; i++)
            {
                // 如果牌面朝下，表示玩家選擇要換掉這張牌，則從洗牌後的牌堆中抽取新的牌替換掉被換掉的牌，並將牌面朝上顯示在牌桌上
                if (pic[i].Tag.ToString() == "back")
                {
                    // 將玩家手牌的編號換成新的牌的編號
                    playerPoker[i] = allPoker[startIndex];
                    startIndex++;
                    // 將新的牌的圖片顯示在牌桌上，根據新的牌的編號從資源檔中取得對應的圖片
                    pic[i].Image = GetImage(playerPoker[i] + 1);
                    pic[i].Tag = "front";
                }
            }

            for (int i = 0; i < pic.Length; i++)
            {
                // 將牌面朝上的圖片設定為不可點擊，表示玩家已經完成換牌
                pic[i].Enabled = false;
            }
            // 禁用換牌按鈕
            this.btnChangeCard.Enabled = false;

            // 將判斷牌型的按鈕啟用，讓玩家可以點擊判斷牌型
            this.btnCheck.Enabled = true;
        }

        /// <summary>
        /// 當點擊判斷牌型按鈕時，會根據玩家手牌的編號從資源檔中取得對應的牌型，並顯示在 lblResult 上，讓玩家知道自己手上的牌是什麼牌型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            // 計錄目前五張撲克牌的花色的陣列
            int[] pokerColor = new int[5];
            // 計錄目前五張撲克牌的點數的陣列
            int[] pokerPoint = new int[5];

            for (int i = 0; i < playerPoker.Length; i++)
            {
                // 根據玩家手牌的編號，計算出該牌的花色
                pokerColor[i] = playerPoker[i] % 4;
                // 根據玩家手牌的編號，計算出該牌的點數
                pokerPoint[i] = playerPoker[i] / 4;
            }

            #region 測試計算出來的花色和點數是否正確
            //============================================================================
            //string result = "";
            //for (int i = 0; i < playerPoker.Length; i++)
            //{
            //    // 取得花色編號
            //    int icolor = pokerColor[i];
            //    // 取得點數編號
            //    int ipoint = pokerPoint[i];
            //    // 根據花色編號和點數編號，組合成牌的名稱，最後將所有牌的名稱組合成一個字串顯示在 lblResult 上
            //    result += $"{colorList[icolor]}{pointList[ipoint]} ";
            //}
            //// 顯示玩家撲克牌的花色和點數
            //this.lblResult.Text = result;
            //============================================================================
            #endregion

            // 計錄花色和點數出現次數的陣列
            int[] colorCount = new int[4];
            int[] pointCount = new int[13];

            // 統計 color 和 point 出現次數
            for (int i = 0; i < pokerColor.Length; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }

            // 將 colorCount 和 colorList 兩個陣列一起排序，根據 colorCount 的值從小到大排序，讓出現次數最少的花色排在前面，最後將排序後的 colorList 顯示在 lblResult 上，讓玩家知道自己手上的牌的花色分布
            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);

            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            // 判斷是否為同花
            bool isFlush = (colorCount[0] == 5);
            // 判斷是否為五張單張
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 &&
            pointCount[3] == 1 && pointCount[4] == 1);
            // 判斷是否為差四
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            // 判斷是否為大順
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) &&
            pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            // 判斷是否為同花大順
            bool isRoyalisFlush = isFlush && isRoyal;
            // 判斷是否為同花順
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            // 判斷是否為順子
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            // 判斷是否為鐵支
            bool isFourOfAKind = (pointCount[0] == 4);
            // 判斷是否為葫蘆
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            // 判斷是否為三條
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            // 判斷是否為兩對
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            // 判斷是否為一對
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);

            string result = "";
            if (isRoyalisFlush)
            {
                result = $"{colorList[0]} 同花大順";
            }
            else if (isStraightFlush)
            {
                result = $"{colorList[0]} 同花順";
            }
            else if (isStraight)
            {
                result = "順子";
            }
            else if (isFourOfAKind)
            {
                result = $"{pointList[0]} 鐵支";
            }
            else if (isFullHouse)
            {
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
            }
            else if (isFlush)
            {
                result = $"{colorList[0]} 同花";
            }
            else if (isThreeOfAKind)
            {
                result = $"{pointList[0]} 三條";
            }
            else if (isTwoPair)
            {
                result = $"{pointList[0]},{pointList[1]} 兩對";
            }
            else if (isOnePair)
            {
                result = $"{pointList[0]} 一對";
            }
            else
            {
                result = "雜牌";
            }
            lblResult.Text = result;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;

            btnDealCard.Enabled = true;
        }

        /// <summary>
        /// 當表單被按下鍵盤時觸發
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPoker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.btnDealCard.Enabled == false)
            {
                //MessageBox.Show($"你按下了 {e.KeyChar} 建");
                switch(e.KeyChar)
                {
                    case 'q': // 同花大順
                        playerPoker[0] = 51;
                        playerPoker[1] = 47;
                        playerPoker[2] = 43;
                        playerPoker[3] = 39;
                        playerPoker[4] = 3;
                        break;
                    case 'w': // 同花順
                        playerPoker[0] = 37;
                        playerPoker[1] = 33;
                        playerPoker[2] = 29;
                        playerPoker[3] = 25;
                        playerPoker[4] = 21;
                        break;
                    case 'e': // 同花
                        playerPoker[0] = 50;
                        playerPoker[1] = 38;
                        playerPoker[2] = 34;
                        playerPoker[3] = 22;
                        playerPoker[4] = 18;
                        break;
                    case 'r': // 鐵支
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 38;
                        playerPoker[3] = 37;
                        playerPoker[4] = 36;
                        break;
                    case 't': // 葫蘆
                        playerPoker[0] = 30;
                        playerPoker[1] = 29;
                        playerPoker[2] = 6;
                        playerPoker[3] = 5;
                        playerPoker[4] = 4;
                        break;
                    case 'y': // 三條
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 15;
                        playerPoker[3] = 14;
                        playerPoker[4] = 13;
                        break;
                }

                this.ShowCards();
            }

        }

        #endregion
    }
}
