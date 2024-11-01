using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_form
{
    class TestButton : Button
    {
        public TestButton(int x,int y,int widht,int height)
        {
            //ClickイベントにOnClick関数を問登録
            //botannwo 
            
            Click += OnClick;

            //ボタン内に文字を表示
            Text = "ボタン";

            Location = new Point(x,y);         //ボタンの位置
            Size = new Size(widht,height);     //ボタンのサイズ

        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("あいうえお");
        }
        

    }
}
