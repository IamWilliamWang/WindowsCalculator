using Microsoft.VisualBasic;
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

        private String Information = "计算器 v1.20";
        private String UpdateInformation =
            "v0.91 实现了基本的+-*/功能\n"+
            "v0.99 添加了菜单栏、帮助栏，修复了bug\n"+ 
            "v1.00 查看M值、历史纪录，增加了升级日志\n"+
            "v1.10 能释放文本框，计算结果下次可以直接使用\n"+
            "v1.11 修复了C键，上次的计算结果影响下次输入的bug\n"+
            "v1.15 可增加新窗口，解决负数不能计算的bug\n"+
            "v1.20 可使用基本的乘方、开方、阶乘、三角函数等运算";

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
            DialogResult dialogResult = MessageBox.Show("退出所有窗口？还是退出此窗口？", "退出提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) this.Close();
            else if (dialogResult == DialogResult.Yes) Application.Exit();
            
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
            MainWindow mainwindow = new MainWindow();
            mainwindow.ShowDialog();
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
                        double result = CalculatorProgram.getResult("0"+inputString);
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

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tmi = (ToolStripMenuItem)sender;
            double result = 0;
            
            switch(tmi.Text)
            {
                case "pi":
                    result = 3.14159265358979323846264;
                    break;
                case "x^2":
                    String input = Interaction.InputBox("输入x:", "x^2");
                    if (input == "")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = double.Parse(input) * double.Parse(input);
                    break;
                case "1/x":
                    String input2 = Interaction.InputBox("输入x:", "1/x");
                    if (input2 == "" || input2 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = 1 / double.Parse(input2);
                    break;
                case "x^y":
                    String input3 = Interaction.InputBox("输入x^y:", "x^y");
                    if (input3 == "")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Pow(double.Parse(input3.Split('^')[0]),double.Parse(input3.Split('^')[1]));
                    break;
                case "√x":
                    String input3_ = Interaction.InputBox("输入x^y:", "x^y");
                    if (input3_ == "")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Sqrt(double.Parse(input3_));
                    break;
                case "x!":
                    String input4 = Interaction.InputBox("输入x:", "x!");
                    if (input4 == "")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    int sum = 1;
                    for(int i=1;i<=double.Parse(input4);i++)
                    {
                        sum *= i;
                    }
                    MessageBox.Show(sum.ToString(),"结果");
                    return;
                case "sin(x)":
                    String input5 = Interaction.InputBox("输入x:", "sin(x) x使用弧度");
                    if (input5 == "" || input5 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Sin(double.Parse(input5));
                    break;
                case "cos(x)":
                    String input6 = Interaction.InputBox("输入x:", "cos(x) x使用弧度");
                    if (input6 == "" || input6 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Cos(double.Parse(input6));
                    break;
                case "tan(x)":
                    String input7 = Interaction.InputBox("输入x:", "tan(x) x使用弧度");
                    if (input7 == "" || input7 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Tan(double.Parse(input7));
                    break;
                case "asin(x)":
                    String input8 = Interaction.InputBox("输入x:", "asin(x) x使用弧度");
                    if (input8 == "" || input8 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Asin(double.Parse(input8));
                    break;
                case "acos(x)":
                    String input9 = Interaction.InputBox("输入x:", "acos(x) x使用弧度");
                    if (input9 == "" || input9 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Acos(double.Parse(input9));
                    break;
                case "atan(x)":
                    String input10 = Interaction.InputBox("输入x:", "atan(x) x使用弧度");
                    if (input10 == "" || input10 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Atan(double.Parse(input10));
                    break;
                case "sinh(x)":
                    String input11 = Interaction.InputBox("输入x:", "sinh(x) x使用弧度");
                    if (input11 == "" || input11 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Sinh(double.Parse(input11));
                    break;
                case "cosh(x)":
                    String input12 = Interaction.InputBox("输入x:", "cosh(x) x使用弧度");
                    if (input12 == "" || input12 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Cosh(double.Parse(input12));
                    break;
                case "tanh(x)":
                    String input13 = Interaction.InputBox("输入x:", "tanh(x) x使用弧度");
                    if (input13 == "" || input13 == "0")
                    {
                        MessageBox.Show("非法输入");
                        return;
                    }
                    result = Math.Tanh(double.Parse(input13));
                    break;
                
                default:
                    MessageBox.Show("未知错误","ERROR");
                    break;
            }

            inputString += result.ToString();
            resultTextBox.Text = inputString;
        }
    }
}