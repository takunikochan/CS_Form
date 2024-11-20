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
        Form1 _form1;

        public TestButton(Form1 form1, int id, int x, int y, int widht, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //botannwo 

            Click += OnClick;

            //      //ボタン内に文字を表示
            //      Text = id.ToString();

            if (id == 0)
            {
                Text = "あ";
            }
            else if (id == 1)
            {
                Text = "い";
            }
            else if (id == 2)
            {
                Text = "う";
            }
            else if (id == 3)
            {
                Text = "え";
            }
            else if (id == 4)
            {
                Text = "お";
            }
            else if (id == 5)
            {
                Text = "か";
            }
            else if (id == 6)
            {
                Text = "き";
            }
            else if (id == 7)
            {
                Text = "く";
            }
            else if (id == 8)
            {
                Text = "け";
            }
            else if (id == 9)
            {
                Text = "こ";
            }

            //ボタンの生成場所を指定
            Location = new Point(x, y);

            //ボタンのサイズを指定
            Size = new Size(widht, height);

            }
        

        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdade(Text);
        }
        

    }
}
