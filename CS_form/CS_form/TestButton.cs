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

        public TestButton(Form1 form1, int id,int x,int y,int widht,int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を問登録
            //botannwo 

            Click += OnClick;

            //ボタン内に文字を表示
           Text = id.ToString();
           
            //ボタンの生成場所を指定
            Location = new Point(x,y);        
            
            //ボタンのサイズを指定
            Size = new Size(widht,height);    

        }

        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdade(Text);
        }
        

    }
}
