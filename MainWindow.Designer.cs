namespace Calculator
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonBracketRight = new System.Windows.Forms.Button();
            this.buttonBracketLeft = new System.Windows.Forms.Button();
            this.clickButton_C = new System.Windows.Forms.Button();
            this.clickButton_Mplus = new System.Windows.Forms.Button();
            this.clickButton_MR = new System.Windows.Forms.Button();
            this.clickButton_MC = new System.Windows.Forms.Button();
            this.clickButton_divide = new System.Windows.Forms.Button();
            this.clickButton_Equal = new System.Windows.Forms.Button();
            this.clickButton_dot = new System.Windows.Forms.Button();
            this.clickButton_0 = new System.Windows.Forms.Button();
            this.clickButton_multiply = new System.Windows.Forms.Button();
            this.clickButton_3 = new System.Windows.Forms.Button();
            this.clickButton_2 = new System.Windows.Forms.Button();
            this.clickButton_1 = new System.Windows.Forms.Button();
            this.clickButton_minus = new System.Windows.Forms.Button();
            this.clickButton_6 = new System.Windows.Forms.Button();
            this.clickButton_5 = new System.Windows.Forms.Button();
            this.clickButton_4 = new System.Windows.Forms.Button();
            this.clickButton_plus = new System.Windows.Forms.Button();
            this.clickButton_9 = new System.Windows.Forms.Button();
            this.clickButton_8 = new System.Windows.Forms.Button();
            this.clickButton_7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史纪录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.文本框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.升级日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.inputGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.buttonAC);
            this.inputGroupBox.Controls.Add(this.buttonBackspace);
            this.inputGroupBox.Controls.Add(this.buttonBracketRight);
            this.inputGroupBox.Controls.Add(this.buttonBracketLeft);
            this.inputGroupBox.Controls.Add(this.clickButton_C);
            this.inputGroupBox.Controls.Add(this.clickButton_Mplus);
            this.inputGroupBox.Controls.Add(this.clickButton_MR);
            this.inputGroupBox.Controls.Add(this.clickButton_MC);
            this.inputGroupBox.Controls.Add(this.clickButton_divide);
            this.inputGroupBox.Controls.Add(this.clickButton_Equal);
            this.inputGroupBox.Controls.Add(this.clickButton_dot);
            this.inputGroupBox.Controls.Add(this.clickButton_0);
            this.inputGroupBox.Controls.Add(this.clickButton_multiply);
            this.inputGroupBox.Controls.Add(this.clickButton_3);
            this.inputGroupBox.Controls.Add(this.clickButton_2);
            this.inputGroupBox.Controls.Add(this.clickButton_1);
            this.inputGroupBox.Controls.Add(this.clickButton_minus);
            this.inputGroupBox.Controls.Add(this.clickButton_6);
            this.inputGroupBox.Controls.Add(this.clickButton_5);
            this.inputGroupBox.Controls.Add(this.clickButton_4);
            this.inputGroupBox.Controls.Add(this.clickButton_plus);
            this.inputGroupBox.Controls.Add(this.clickButton_9);
            this.inputGroupBox.Controls.Add(this.clickButton_8);
            this.inputGroupBox.Controls.Add(this.clickButton_7);
            this.inputGroupBox.Location = new System.Drawing.Point(0, 73);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(328, 211);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "输入框";
            // 
            // buttonAC
            // 
            this.buttonAC.Location = new System.Drawing.Point(5, 178);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(75, 23);
            this.buttonAC.TabIndex = 23;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.clickButton);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(170, 53);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(75, 23);
            this.buttonBackspace.TabIndex = 22;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.clickButton);
            // 
            // buttonBracketRight
            // 
            this.buttonBracketRight.Location = new System.Drawing.Point(88, 54);
            this.buttonBracketRight.Name = "buttonBracketRight";
            this.buttonBracketRight.Size = new System.Drawing.Size(75, 23);
            this.buttonBracketRight.TabIndex = 21;
            this.buttonBracketRight.Text = ")";
            this.buttonBracketRight.UseVisualStyleBackColor = true;
            this.buttonBracketRight.Click += new System.EventHandler(this.clickButton);
            // 
            // buttonBracketLeft
            // 
            this.buttonBracketLeft.Location = new System.Drawing.Point(6, 53);
            this.buttonBracketLeft.Name = "buttonBracketLeft";
            this.buttonBracketLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonBracketLeft.TabIndex = 20;
            this.buttonBracketLeft.Text = "(";
            this.buttonBracketLeft.UseVisualStyleBackColor = true;
            this.buttonBracketLeft.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_C
            // 
            this.clickButton_C.Location = new System.Drawing.Point(251, 20);
            this.clickButton_C.Name = "clickButton_C";
            this.clickButton_C.Size = new System.Drawing.Size(75, 23);
            this.clickButton_C.TabIndex = 19;
            this.clickButton_C.Text = "C";
            this.clickButton_C.UseVisualStyleBackColor = true;
            this.clickButton_C.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_Mplus
            // 
            this.clickButton_Mplus.Location = new System.Drawing.Point(170, 20);
            this.clickButton_Mplus.Name = "clickButton_Mplus";
            this.clickButton_Mplus.Size = new System.Drawing.Size(75, 23);
            this.clickButton_Mplus.TabIndex = 18;
            this.clickButton_Mplus.Text = "M+";
            this.clickButton_Mplus.UseVisualStyleBackColor = true;
            this.clickButton_Mplus.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_MR
            // 
            this.clickButton_MR.Location = new System.Drawing.Point(88, 20);
            this.clickButton_MR.Name = "clickButton_MR";
            this.clickButton_MR.Size = new System.Drawing.Size(75, 23);
            this.clickButton_MR.TabIndex = 17;
            this.clickButton_MR.Text = "MR";
            this.clickButton_MR.UseVisualStyleBackColor = true;
            this.clickButton_MR.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_MC
            // 
            this.clickButton_MC.Location = new System.Drawing.Point(6, 21);
            this.clickButton_MC.Name = "clickButton_MC";
            this.clickButton_MC.Size = new System.Drawing.Size(75, 23);
            this.clickButton_MC.TabIndex = 16;
            this.clickButton_MC.Text = "MC";
            this.clickButton_MC.UseVisualStyleBackColor = true;
            this.clickButton_MC.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_divide
            // 
            this.clickButton_divide.Location = new System.Drawing.Point(251, 149);
            this.clickButton_divide.Name = "clickButton_divide";
            this.clickButton_divide.Size = new System.Drawing.Size(75, 23);
            this.clickButton_divide.TabIndex = 15;
            this.clickButton_divide.Text = "/";
            this.clickButton_divide.UseVisualStyleBackColor = true;
            this.clickButton_divide.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_Equal
            // 
            this.clickButton_Equal.Location = new System.Drawing.Point(251, 181);
            this.clickButton_Equal.Name = "clickButton_Equal";
            this.clickButton_Equal.Size = new System.Drawing.Size(75, 23);
            this.clickButton_Equal.TabIndex = 14;
            this.clickButton_Equal.Text = "=";
            this.clickButton_Equal.UseVisualStyleBackColor = true;
            this.clickButton_Equal.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_dot
            // 
            this.clickButton_dot.Location = new System.Drawing.Point(169, 179);
            this.clickButton_dot.Name = "clickButton_dot";
            this.clickButton_dot.Size = new System.Drawing.Size(75, 23);
            this.clickButton_dot.TabIndex = 13;
            this.clickButton_dot.Text = ".";
            this.clickButton_dot.UseVisualStyleBackColor = true;
            this.clickButton_dot.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_0
            // 
            this.clickButton_0.Location = new System.Drawing.Point(87, 178);
            this.clickButton_0.Name = "clickButton_0";
            this.clickButton_0.Size = new System.Drawing.Size(75, 23);
            this.clickButton_0.TabIndex = 12;
            this.clickButton_0.Text = "0";
            this.clickButton_0.UseVisualStyleBackColor = true;
            this.clickButton_0.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_multiply
            // 
            this.clickButton_multiply.Location = new System.Drawing.Point(251, 116);
            this.clickButton_multiply.Name = "clickButton_multiply";
            this.clickButton_multiply.Size = new System.Drawing.Size(75, 23);
            this.clickButton_multiply.TabIndex = 11;
            this.clickButton_multiply.Text = "*";
            this.clickButton_multiply.UseVisualStyleBackColor = true;
            this.clickButton_multiply.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_3
            // 
            this.clickButton_3.Location = new System.Drawing.Point(170, 148);
            this.clickButton_3.Name = "clickButton_3";
            this.clickButton_3.Size = new System.Drawing.Size(75, 23);
            this.clickButton_3.TabIndex = 10;
            this.clickButton_3.Text = "3";
            this.clickButton_3.UseVisualStyleBackColor = true;
            this.clickButton_3.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_2
            // 
            this.clickButton_2.Location = new System.Drawing.Point(88, 149);
            this.clickButton_2.Name = "clickButton_2";
            this.clickButton_2.Size = new System.Drawing.Size(75, 23);
            this.clickButton_2.TabIndex = 9;
            this.clickButton_2.Text = "2";
            this.clickButton_2.UseVisualStyleBackColor = true;
            this.clickButton_2.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_1
            // 
            this.clickButton_1.Location = new System.Drawing.Point(6, 150);
            this.clickButton_1.Name = "clickButton_1";
            this.clickButton_1.Size = new System.Drawing.Size(75, 23);
            this.clickButton_1.TabIndex = 8;
            this.clickButton_1.Text = "1";
            this.clickButton_1.UseVisualStyleBackColor = true;
            this.clickButton_1.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_minus
            // 
            this.clickButton_minus.Location = new System.Drawing.Point(251, 85);
            this.clickButton_minus.Name = "clickButton_minus";
            this.clickButton_minus.Size = new System.Drawing.Size(75, 23);
            this.clickButton_minus.TabIndex = 7;
            this.clickButton_minus.Text = "-";
            this.clickButton_minus.UseVisualStyleBackColor = true;
            this.clickButton_minus.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_6
            // 
            this.clickButton_6.Location = new System.Drawing.Point(171, 118);
            this.clickButton_6.Name = "clickButton_6";
            this.clickButton_6.Size = new System.Drawing.Size(75, 23);
            this.clickButton_6.TabIndex = 6;
            this.clickButton_6.Text = "6";
            this.clickButton_6.UseVisualStyleBackColor = true;
            this.clickButton_6.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_5
            // 
            this.clickButton_5.Location = new System.Drawing.Point(89, 117);
            this.clickButton_5.Name = "clickButton_5";
            this.clickButton_5.Size = new System.Drawing.Size(75, 23);
            this.clickButton_5.TabIndex = 5;
            this.clickButton_5.Text = "5";
            this.clickButton_5.UseVisualStyleBackColor = true;
            this.clickButton_5.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_4
            // 
            this.clickButton_4.Location = new System.Drawing.Point(5, 118);
            this.clickButton_4.Name = "clickButton_4";
            this.clickButton_4.Size = new System.Drawing.Size(75, 23);
            this.clickButton_4.TabIndex = 4;
            this.clickButton_4.Text = "4";
            this.clickButton_4.UseVisualStyleBackColor = true;
            this.clickButton_4.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_plus
            // 
            this.clickButton_plus.Location = new System.Drawing.Point(251, 53);
            this.clickButton_plus.Name = "clickButton_plus";
            this.clickButton_plus.Size = new System.Drawing.Size(75, 23);
            this.clickButton_plus.TabIndex = 3;
            this.clickButton_plus.Text = "+";
            this.clickButton_plus.UseVisualStyleBackColor = true;
            this.clickButton_plus.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_9
            // 
            this.clickButton_9.Location = new System.Drawing.Point(171, 85);
            this.clickButton_9.Name = "clickButton_9";
            this.clickButton_9.Size = new System.Drawing.Size(75, 23);
            this.clickButton_9.TabIndex = 2;
            this.clickButton_9.Text = "9";
            this.clickButton_9.UseVisualStyleBackColor = true;
            this.clickButton_9.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_8
            // 
            this.clickButton_8.Location = new System.Drawing.Point(89, 85);
            this.clickButton_8.Name = "clickButton_8";
            this.clickButton_8.Size = new System.Drawing.Size(75, 23);
            this.clickButton_8.TabIndex = 1;
            this.clickButton_8.Text = "8";
            this.clickButton_8.UseVisualStyleBackColor = true;
            this.clickButton_8.Click += new System.EventHandler(this.clickButton);
            // 
            // clickButton_7
            // 
            this.clickButton_7.Location = new System.Drawing.Point(5, 84);
            this.clickButton_7.Name = "clickButton_7";
            this.clickButton_7.Size = new System.Drawing.Size(75, 23);
            this.clickButton_7.TabIndex = 0;
            this.clickButton_7.Text = "7";
            this.clickButton_7.UseVisualStyleBackColor = true;
            this.clickButton_7.Click += new System.EventHandler(this.clickButton);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem1,
            this.StripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuItem1
            // 
            this.StripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新窗口ToolStripMenuItem,
            this.查看mToolStripMenuItem,
            this.历史纪录ToolStripMenuItem,
            this.清空全部ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.StripMenuItem1.Name = "StripMenuItem1";
            this.StripMenuItem1.Size = new System.Drawing.Size(56, 21);
            this.StripMenuItem1.Text = "主菜单";
            // 
            // 新窗口ToolStripMenuItem
            // 
            this.新窗口ToolStripMenuItem.Enabled = false;
            this.新窗口ToolStripMenuItem.Name = "新窗口ToolStripMenuItem";
            this.新窗口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新窗口ToolStripMenuItem.Text = "新窗口";
            this.新窗口ToolStripMenuItem.Click += new System.EventHandler(this.新窗口ToolStripMenuItem_Click);
            // 
            // 查看mToolStripMenuItem
            // 
            this.查看mToolStripMenuItem.Name = "查看mToolStripMenuItem";
            this.查看mToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查看mToolStripMenuItem.Text = "查看M";
            this.查看mToolStripMenuItem.Click += new System.EventHandler(this.查看mToolStripMenuItem_Click);
            // 
            // 历史纪录ToolStripMenuItem
            // 
            this.历史纪录ToolStripMenuItem.Name = "历史纪录ToolStripMenuItem";
            this.历史纪录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.历史纪录ToolStripMenuItem.Text = "历史纪录";
            this.历史纪录ToolStripMenuItem.Click += new System.EventHandler(this.历史纪录ToolStripMenuItem_Click);
            // 
            // 清空全部ToolStripMenuItem
            // 
            this.清空全部ToolStripMenuItem.Name = "清空全部ToolStripMenuItem";
            this.清空全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空全部ToolStripMenuItem.Text = "清空全部";
            this.清空全部ToolStripMenuItem.Click += new System.EventHandler(this.清空全部ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // StripMenuItem2
            // 
            this.StripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文本框ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.StripMenuItem2.Name = "StripMenuItem2";
            this.StripMenuItem2.Size = new System.Drawing.Size(44, 21);
            this.StripMenuItem2.Text = "帮助";
            // 
            // 文本框ToolStripMenuItem
            // 
            this.文本框ToolStripMenuItem.Name = "文本框ToolStripMenuItem";
            this.文本框ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.文本框ToolStripMenuItem.Text = "释放文本框";
            this.文本框ToolStripMenuItem.Click += new System.EventHandler(this.文本框ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.升级日志ToolStripMenuItem,
            this.关于ToolStripMenuItem1});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            //this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // 升级日志ToolStripMenuItem
            // 
            this.升级日志ToolStripMenuItem.Name = "升级日志ToolStripMenuItem";
            this.升级日志ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.升级日志ToolStripMenuItem.Text = "升级日志";
            this.升级日志ToolStripMenuItem.Click += new System.EventHandler(this.升级日志ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem1.Text = "关于本程序";
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.resultTextBox);
            this.ResultGroupBox.Location = new System.Drawing.Point(7, 28);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultGroupBox.Size = new System.Drawing.Size(321, 46);
            this.ResultGroupBox.TabIndex = 2;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "结果";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(4, 17);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(309, 21);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "计算器";
            this.inputGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Button clickButton_divide;
        private System.Windows.Forms.Button clickButton_Equal;
        private System.Windows.Forms.Button clickButton_dot;
        private System.Windows.Forms.Button clickButton_0;
        private System.Windows.Forms.Button clickButton_multiply;
        private System.Windows.Forms.Button clickButton_3;
        private System.Windows.Forms.Button clickButton_2;
        private System.Windows.Forms.Button clickButton_1;
        private System.Windows.Forms.Button clickButton_minus;
        private System.Windows.Forms.Button clickButton_6;
        private System.Windows.Forms.Button clickButton_5;
        private System.Windows.Forms.Button clickButton_4;
        private System.Windows.Forms.Button clickButton_plus;
        private System.Windows.Forms.Button clickButton_9;
        private System.Windows.Forms.Button clickButton_8;
        private System.Windows.Forms.Button clickButton_7;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Button clickButton_C;
        private System.Windows.Forms.Button clickButton_Mplus;
        private System.Windows.Forms.Button clickButton_MR;
        private System.Windows.Forms.Button clickButton_MC;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonBracketRight;
        private System.Windows.Forms.Button buttonBracketLeft;
        private System.Windows.Forms.ToolStripMenuItem 历史纪录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文本框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 升级日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
    }

}