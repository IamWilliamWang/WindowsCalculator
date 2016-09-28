using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainWindow : Form
    {
        private String inputString = "";
        private double mNumber = 0;
        private String saves = "";

        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void 查看mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("M = "+mNumber,"查看M的值");
        }

        private void 历史纪录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(saves==""?"没有历史记录":saves,"历史纪录的存档");
        }

        private void 清空全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputString = "";
            resultTextBox.Text = "0";
            mNumber = 0;
            saves = "";
            MessageBox.Show("清除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("计算器 v1.0正式版", "关于本程序", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button clickevent = (Button)sender;
            switch(clickevent.Text)
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
                    if ((index = inputString.LastIndexOf('=')) != -1)
                    {
                        mNumber += Double.Parse(inputString.Substring(index + 1));
                    }
                    else
                        MessageBox.Show("请先按下等号。","Tips",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case "C":
                    inputString = inputString.Remove(inputString.LastIndexOfAny(CalculatorProgram.yunsuanfu.ToCharArray()));
                    resultTextBox.Text = inputString;
                    break;
                case "AC":
                    inputString = "";
                    resultTextBox.Text = "0";
                    break;
                case "←":
                    if(inputString.Length!=0)
                    {
                        inputString = inputString.Remove(inputString.Length - 1);
                        resultTextBox.Text = inputString==""?"0":inputString;
                    }
                    break;
                case "=":
                    try
                    {
                        double result = CalculatorProgram.getResult(inputString);
                        inputString = inputString + "=" + result;
                        resultTextBox.Text = inputString;
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("警告：表达式有错误！","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                    /*储存*/
                    saves += inputString + "\n";
                    //Console.WriteLine("结果是 " + result);
                    break;    
                case "(":
                case ")":
                case "+":
                case "-":
                case "*":
                case "/":
                case ".":
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
                    break;
            }
        }
    }
}