namespace lab6
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RectangleCheck = new System.Windows.Forms.RadioButton();
            this.PentagonCheck = new System.Windows.Forms.RadioButton();
            this.NameBox = new System.Windows.Forms.RichTextBox();
            this.RouteText = new System.Windows.Forms.RichTextBox();
            this.NameInp = new System.Windows.Forms.Label();
            this.X1TextBox = new System.Windows.Forms.RichTextBox();
            this.x1 = new System.Windows.Forms.Label();
            this.y1Text = new System.Windows.Forms.Label();
            this.Y1TextBox = new System.Windows.Forms.RichTextBox();
            this.y2Text = new System.Windows.Forms.Label();
            this.Y2TextBox = new System.Windows.Forms.RichTextBox();
            this.x1Text = new System.Windows.Forms.Label();
            this.X2TextBox = new System.Windows.Forms.RichTextBox();
            this.y3Text = new System.Windows.Forms.Label();
            this.Y3TextBox = new System.Windows.Forms.RichTextBox();
            this.x3Text = new System.Windows.Forms.Label();
            this.X3TextBox = new System.Windows.Forms.RichTextBox();
            this.y4Text = new System.Windows.Forms.Label();
            this.Y4TextBox = new System.Windows.Forms.RichTextBox();
            this.x4Text = new System.Windows.Forms.Label();
            this.X4TextBox = new System.Windows.Forms.RichTextBox();
            this.y5Text = new System.Windows.Forms.Label();
            this.Y5TextBox = new System.Windows.Forms.RichTextBox();
            this.x5Text = new System.Windows.Forms.Label();
            this.X5TextBox = new System.Windows.Forms.RichTextBox();
            this.SelectFigure = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ChooseRoute = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 258);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(101, 32);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(639, 112);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(101, 32);
            this.MoveButton.TabIndex = 1;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(639, 50);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 32);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RectangleCheck
            // 
            this.RectangleCheck.AutoSize = true;
            this.RectangleCheck.Location = new System.Drawing.Point(119, 266);
            this.RectangleCheck.Name = "RectangleCheck";
            this.RectangleCheck.Size = new System.Drawing.Size(74, 17);
            this.RectangleCheck.TabIndex = 3;
            this.RectangleCheck.TabStop = true;
            this.RectangleCheck.Text = "Rectangle";
            this.RectangleCheck.UseVisualStyleBackColor = true;
            this.RectangleCheck.CheckedChanged += new System.EventHandler(this.RectangleCheck_CheckedChanged);
            // 
            // PentagonCheck
            // 
            this.PentagonCheck.AutoSize = true;
            this.PentagonCheck.Location = new System.Drawing.Point(190, 266);
            this.PentagonCheck.Name = "PentagonCheck";
            this.PentagonCheck.Size = new System.Drawing.Size(71, 17);
            this.PentagonCheck.TabIndex = 4;
            this.PentagonCheck.TabStop = true;
            this.PentagonCheck.Text = "Pentagon";
            this.PentagonCheck.UseVisualStyleBackColor = true;
            this.PentagonCheck.CheckedChanged += new System.EventHandler(this.PentagonCheck_CheckedChanged);
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(80, 304);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(125, 27);
            this.NameBox.TabIndex = 10;
            this.NameBox.Text = "";
            // 
            // RouteText
            // 
            this.RouteText.Enabled = false;
            this.RouteText.Location = new System.Drawing.Point(639, 169);
            this.RouteText.Name = "RouteText";
            this.RouteText.Size = new System.Drawing.Size(101, 30);
            this.RouteText.TabIndex = 11;
            this.RouteText.Text = "";
            this.RouteText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RouteText_KeyPress);
            // 
            // NameInp
            // 
            this.NameInp.AllowDrop = true;
            this.NameInp.AutoSize = true;
            this.NameInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInp.Location = new System.Drawing.Point(12, 304);
            this.NameInp.Name = "NameInp";
            this.NameInp.Size = new System.Drawing.Size(62, 22);
            this.NameInp.TabIndex = 12;
            this.NameInp.Text = "Name:";
            this.NameInp.UseMnemonic = false;
            // 
            // X1TextBox
            // 
            this.X1TextBox.Enabled = false;
            this.X1TextBox.Location = new System.Drawing.Point(301, 258);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.Size = new System.Drawing.Size(27, 40);
            this.X1TextBox.TabIndex = 13;
            this.X1TextBox.Text = "";
            this.X1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1TextBox_KeyPress);
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1.Location = new System.Drawing.Point(268, 268);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(27, 22);
            this.x1.TabIndex = 14;
            this.x1.Text = "X:";
            // 
            // y1Text
            // 
            this.y1Text.AutoSize = true;
            this.y1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y1Text.Location = new System.Drawing.Point(334, 268);
            this.y1Text.Name = "y1Text";
            this.y1Text.Size = new System.Drawing.Size(27, 22);
            this.y1Text.TabIndex = 16;
            this.y1Text.Text = "Y:";
            // 
            // Y1TextBox
            // 
            this.Y1TextBox.Enabled = false;
            this.Y1TextBox.Location = new System.Drawing.Point(367, 258);
            this.Y1TextBox.Name = "Y1TextBox";
            this.Y1TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y1TextBox.TabIndex = 15;
            this.Y1TextBox.Text = "";
            this.Y1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y1TextBox_KeyPress);
            // 
            // y2Text
            // 
            this.y2Text.AutoSize = true;
            this.y2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y2Text.Location = new System.Drawing.Point(511, 268);
            this.y2Text.Name = "y2Text";
            this.y2Text.Size = new System.Drawing.Size(27, 22);
            this.y2Text.TabIndex = 20;
            this.y2Text.Text = "Y:";
            // 
            // Y2TextBox
            // 
            this.Y2TextBox.Enabled = false;
            this.Y2TextBox.Location = new System.Drawing.Point(544, 258);
            this.Y2TextBox.Name = "Y2TextBox";
            this.Y2TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y2TextBox.TabIndex = 19;
            this.Y2TextBox.Text = "";
            this.Y2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y2TextBox_KeyPress);
            // 
            // x1Text
            // 
            this.x1Text.AutoSize = true;
            this.x1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1Text.Location = new System.Drawing.Point(441, 268);
            this.x1Text.Name = "x1Text";
            this.x1Text.Size = new System.Drawing.Size(27, 22);
            this.x1Text.TabIndex = 18;
            this.x1Text.Text = "X:";
            // 
            // X2TextBox
            // 
            this.X2TextBox.Enabled = false;
            this.X2TextBox.Location = new System.Drawing.Point(474, 258);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.Size = new System.Drawing.Size(27, 40);
            this.X2TextBox.TabIndex = 17;
            this.X2TextBox.Text = "";
            this.X2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X2TextBox_KeyPress);
            // 
            // y3Text
            // 
            this.y3Text.AutoSize = true;
            this.y3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y3Text.Location = new System.Drawing.Point(672, 268);
            this.y3Text.Name = "y3Text";
            this.y3Text.Size = new System.Drawing.Size(27, 22);
            this.y3Text.TabIndex = 24;
            this.y3Text.Text = "Y:";
            // 
            // Y3TextBox
            // 
            this.Y3TextBox.Enabled = false;
            this.Y3TextBox.Location = new System.Drawing.Point(705, 258);
            this.Y3TextBox.Name = "Y3TextBox";
            this.Y3TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y3TextBox.TabIndex = 23;
            this.Y3TextBox.Text = "";
            this.Y3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y3TextBox_KeyPress);
            // 
            // x3Text
            // 
            this.x3Text.AutoSize = true;
            this.x3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3Text.Location = new System.Drawing.Point(606, 268);
            this.x3Text.Name = "x3Text";
            this.x3Text.Size = new System.Drawing.Size(27, 22);
            this.x3Text.TabIndex = 22;
            this.x3Text.Text = "X:";
            // 
            // X3TextBox
            // 
            this.X3TextBox.Enabled = false;
            this.X3TextBox.Location = new System.Drawing.Point(639, 258);
            this.X3TextBox.Name = "X3TextBox";
            this.X3TextBox.Size = new System.Drawing.Size(27, 40);
            this.X3TextBox.TabIndex = 21;
            this.X3TextBox.Text = "";
            this.X3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X3TextBox_KeyPress);
            // 
            // y4Text
            // 
            this.y4Text.AutoSize = true;
            this.y4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y4Text.Location = new System.Drawing.Point(334, 325);
            this.y4Text.Name = "y4Text";
            this.y4Text.Size = new System.Drawing.Size(27, 22);
            this.y4Text.TabIndex = 28;
            this.y4Text.Text = "Y:";
            // 
            // Y4TextBox
            // 
            this.Y4TextBox.Enabled = false;
            this.Y4TextBox.Location = new System.Drawing.Point(367, 315);
            this.Y4TextBox.Name = "Y4TextBox";
            this.Y4TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y4TextBox.TabIndex = 27;
            this.Y4TextBox.Text = "";
            this.Y4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y4TextBox_KeyPress);
            // 
            // x4Text
            // 
            this.x4Text.AutoSize = true;
            this.x4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x4Text.Location = new System.Drawing.Point(268, 325);
            this.x4Text.Name = "x4Text";
            this.x4Text.Size = new System.Drawing.Size(27, 22);
            this.x4Text.TabIndex = 26;
            this.x4Text.Text = "X:";
            // 
            // X4TextBox
            // 
            this.X4TextBox.Enabled = false;
            this.X4TextBox.Location = new System.Drawing.Point(301, 315);
            this.X4TextBox.Name = "X4TextBox";
            this.X4TextBox.Size = new System.Drawing.Size(27, 40);
            this.X4TextBox.TabIndex = 25;
            this.X4TextBox.Text = "";
            this.X4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X4TextBox_KeyPress);
            // 
            // y5Text
            // 
            this.y5Text.AutoSize = true;
            this.y5Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y5Text.Location = new System.Drawing.Point(511, 325);
            this.y5Text.Name = "y5Text";
            this.y5Text.Size = new System.Drawing.Size(27, 22);
            this.y5Text.TabIndex = 32;
            this.y5Text.Text = "Y:";
            // 
            // Y5TextBox
            // 
            this.Y5TextBox.Enabled = false;
            this.Y5TextBox.Location = new System.Drawing.Point(544, 315);
            this.Y5TextBox.Name = "Y5TextBox";
            this.Y5TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y5TextBox.TabIndex = 31;
            this.Y5TextBox.Text = "";
            this.Y5TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y5TextBox_KeyPress);
            // 
            // x5Text
            // 
            this.x5Text.AutoSize = true;
            this.x5Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x5Text.Location = new System.Drawing.Point(443, 325);
            this.x5Text.Name = "x5Text";
            this.x5Text.Size = new System.Drawing.Size(27, 22);
            this.x5Text.TabIndex = 30;
            this.x5Text.Text = "X:";
            // 
            // X5TextBox
            // 
            this.X5TextBox.Enabled = false;
            this.X5TextBox.Location = new System.Drawing.Point(476, 315);
            this.X5TextBox.Name = "X5TextBox";
            this.X5TextBox.Size = new System.Drawing.Size(27, 40);
            this.X5TextBox.TabIndex = 29;
            this.X5TextBox.Text = "";
            this.X5TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X5TextBox_KeyPress);
            // 
            // SelectFigure
            // 
            this.SelectFigure.FormattingEnabled = true;
            this.SelectFigure.Location = new System.Drawing.Point(619, 10);
            this.SelectFigure.Name = "SelectFigure";
            this.SelectFigure.Size = new System.Drawing.Size(121, 21);
            this.SelectFigure.TabIndex = 34;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(455, 224);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(504, 50);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(101, 32);
            this.PrintButton.TabIndex = 37;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ChooseRoute
            // 
            this.ChooseRoute.FormattingEnabled = true;
            this.ChooseRoute.Location = new System.Drawing.Point(484, 119);
            this.ChooseRoute.Name = "ChooseRoute";
            this.ChooseRoute.Size = new System.Drawing.Size(121, 21);
            this.ChooseRoute.TabIndex = 38;
            this.ChooseRoute.SelectedIndexChanged += new System.EventHandler(this.ChooseRoute_SelectedIndexChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 367);
            this.Controls.Add(this.ChooseRoute);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectFigure);
            this.Controls.Add(this.y5Text);
            this.Controls.Add(this.Y5TextBox);
            this.Controls.Add(this.x5Text);
            this.Controls.Add(this.X5TextBox);
            this.Controls.Add(this.y4Text);
            this.Controls.Add(this.Y4TextBox);
            this.Controls.Add(this.x4Text);
            this.Controls.Add(this.X4TextBox);
            this.Controls.Add(this.y3Text);
            this.Controls.Add(this.Y3TextBox);
            this.Controls.Add(this.x3Text);
            this.Controls.Add(this.X3TextBox);
            this.Controls.Add(this.y2Text);
            this.Controls.Add(this.Y2TextBox);
            this.Controls.Add(this.x1Text);
            this.Controls.Add(this.X2TextBox);
            this.Controls.Add(this.y1Text);
            this.Controls.Add(this.Y1TextBox);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.X1TextBox);
            this.Controls.Add(this.NameInp);
            this.Controls.Add(this.RouteText);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PentagonCheck);
            this.Controls.Add(this.RectangleCheck);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.Create);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RadioButton RectangleCheck;
        private System.Windows.Forms.RadioButton PentagonCheck;
        private System.Windows.Forms.RichTextBox NameBox;
        private System.Windows.Forms.RichTextBox RouteText;
        private System.Windows.Forms.Label NameInp;
        private System.Windows.Forms.RichTextBox X1TextBox;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label y1Text;
        private System.Windows.Forms.RichTextBox Y1TextBox;
        private System.Windows.Forms.Label y2Text;
        private System.Windows.Forms.RichTextBox Y2TextBox;
        private System.Windows.Forms.Label x1Text;
        private System.Windows.Forms.RichTextBox X2TextBox;
        private System.Windows.Forms.Label y3Text;
        private System.Windows.Forms.RichTextBox Y3TextBox;
        private System.Windows.Forms.Label x3Text;
        private System.Windows.Forms.RichTextBox X3TextBox;
        private System.Windows.Forms.Label y4Text;
        private System.Windows.Forms.RichTextBox Y4TextBox;
        private System.Windows.Forms.Label x4Text;
        private System.Windows.Forms.RichTextBox X4TextBox;
        private System.Windows.Forms.Label y5Text;
        private System.Windows.Forms.RichTextBox Y5TextBox;
        private System.Windows.Forms.Label x5Text;
        private System.Windows.Forms.RichTextBox X5TextBox;
        private System.Windows.Forms.ComboBox SelectFigure;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ComboBox ChooseRoute;
    }
}

