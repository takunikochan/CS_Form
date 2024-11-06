using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;
        public Form1()
        {
             InitializeComponent();
            
            for (int i = 0; i < 10; i++) 
            { 
            TestButton testButton10 = new TestButton(this,i,(i % 5)*100,(i / 5)*100, 100, 100);
            Controls.Add(testButton10);
            }

            _testLabel =
                new TestLabel("らべるです",10,300,100,500);
            Controls.Add(_testLabel);
　　　　　　
        }
        public void LabelTextUpdade(string str)
        {
            _testLabel.TextUpdade(str);
        }


    }

}
