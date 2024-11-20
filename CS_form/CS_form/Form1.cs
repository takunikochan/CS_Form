using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        TestTextBox _TextBox;

        public Form1()
        {
            //コンポーネントの初期化 
            InitializeComponent();

      　   string[] strs =
      　   {
      　    "あ",
      　    "い",
      　    "う",
      　    "え",
      　    "お",
      　    "か",
      　    "き",
      　    "く",
      　    "け",
      　    "こ",
      　   };
            
            for (int i = 0; i < 10; i++) 
            { 
            TestButton testButton = new TestButton(this,i,(i % 5)*100,(i / 5)*100, 100, 100);
            Controls.Add(testButton);
            }

            _testLabel =
                new TestLabel("らべるです",10,300,100,500);
            Controls.Add(_testLabel);

            _TextBox = new TestTextBox("てきすとぼっくすです", 10,300,500,100);

                Controls.Add(_TextBox);
　　　　　　
        }
        public void LabelTextUpdade(string str)
        {
            _testLabel.TextUpdade(str);
        }

             public string ButtonLabelReplacement(string str)
        {
              string s = _TextBox.TextReplacement(str);

              return s;

        }


    }

}
