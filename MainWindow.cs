using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainWindow : Form
    {
        private String inputString = "";
        private double mNumber = 0;
        private String saves = "";
        private Boolean editTextBoxEditable = false;
        private String LatestResult;
        private Boolean LastestVisualable;

        private String Information = "计算器 v1.11";
        private String UpdateInformation =
            "v0.91 实现了基本的+-*/功能\n"+
            "v0.99 添加了菜单栏、帮助栏，修复了bug\n"+ 
            "v1.00 查看M值、历史纪录，增加了升级日志\n"+
            "v1.10 能释放文本框，计算结果可以直接使用\n"+
            "v1.15(未完成)可增加新窗口";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void 查看mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("M = " + mNumber, "查看M的值");
        }

        private void 历史纪录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(saves == "" ? "没有历史记录" : saves, "历史纪录的存档",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void 清空全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputString = "";
            resultTextBox.Text = "0";
            mNumber = 0;
            saves = "";
            LastestVisualable = false;
            MessageBox.Show("清除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 升级日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UpdateInformation, "升级日志", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Information, "关于本程序", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 新窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainWindow());
        }

        private void 文本框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否" + (editTextBoxEditable == true ? "锁定" : "释放") + "结果框？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            if (editTextBoxEditable == false)
            {
                editTextBoxEditable = true;
                resultTextBox.ReadOnly = false;
                文本框ToolStripMenuItem.Text = "锁定文本框";
            }

            else
            {
                editTextBoxEditable = false;
                resultTextBox.ReadOnly = true;
                文本框ToolStripMenuItem.Text = "释放文本框";
            }
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button clickevent = (Button)sender;
            switch (clickevent.Text)
            {
                case "MC":
                    mNumber = 0;
                    break;
                case "MR":
                    inputString += mNumber.ToString();
                    resultTextBox.Text = inputString;
                    break;
                case "M+":
                    int index;
                    if ((index = resultTextBox.Text.LastIndexOf('=')) != -1)
                    {
                        mNumber += Double.Parse(resultTextBox.Text.Substring(index + 1));
                    }
                    else
                        MessageBox.Show("请先按下等号。", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "C":
                    int indexTemp = inputString.LastIndexOfAny(CalculatorProgram.yunsuanfu.ToCharArray());
                    if(inputString=="")
                    {
                        resultTextBox.Text = "0";
                    }
                    else
                    {
                        inputString = inputString.Remove(indexTemp);
                        resultTextBox.Text = inputString;
                    }
                    break;
                case "AC":
                    inputString = "";
                    resultTextBox.Text = "0";
                    LastestVisualable = false;
                    break;
                case "←":
                    if (inputString.Length != 0)
                    {
                        inputString = inputString.Remove(inputString.Length - 1);
                        resultTextBox.Text = inputString == "" ? "0" : inputString;
                    }
                    break;
                case "=":
                    if(editTextBoxEditable == true)
                    {
                        inputString = resultTextBox.Text;
                    }
                    try
                    {
                        double result = CalculatorProgram.getResult(inputString);
                        inputString = inputString + "=" + result;
                        resultTextBox.Text = inputString;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("警告：表达式有错误！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    /*储存*/
                    saves += inputString + "\n";
                    //Console.WriteLine("结果是 " + result);
                    LatestResult = inputString.Substring(inputString.IndexOf('=')+1);//储存最后一次结果
                    inputString = "";
                    LastestVisualable = true;
                    break;
                case "(":
                case ")":
                case "+":
                case "-":
                case "*":
                case "/":
                case ".":
                    inputString += (LastestVisualable ? LatestResult:"") + clickevent.Text;
                    resultTextBox.Text = inputString;
                    LastestVisualable = false;
                    break;
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    inputString += clickevent.Text;
                    resultTextBox.Text = inputString;
                    LastestVisualable = false;
                    break;
            }
        }
    }
}