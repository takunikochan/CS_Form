using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_form
{
    internal class TestLabel : Label
    {
        public TestLabel(string str, int x, int y, int widht, int height)
        {

            //ボタン内に文字を表示
            Text = str.ToString();

            //ボタンの生成場所を指定
            Location = new Point(x, y);

            //ボタンのサイズを指定
            Size = new Size(widht, height);

        }
        /// <summary>
        /// ラベルの文字更新関数
        /// </summary>
        /// <param name="str"></param>
        public void TextUpdade(string str)
        {
            Text = str;
        }

    }
}
