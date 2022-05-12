
namespace Фоновая7_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RombRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IsSquareAnsLabel = new System.Windows.Forms.Label();
            this.SideBAnsLabel = new System.Windows.Forms.Label();
            this.SideAAnsLabel = new System.Windows.Forms.Label();
            this.PerimetrAnsLabel = new System.Windows.Forms.Label();
            this.AreaAnsLabel = new System.Windows.Forms.Label();
            this.IsSquareLabel = new System.Windows.Forms.Label();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.SideALabel = new System.Windows.Forms.Label();
            this.PerimetrLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.SideTextBox = new System.Windows.Forms.TextBox();
            this.RedactButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.RombRadioButton);
            this.groupBox1.Controls.Add(this.RectangleRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор фигуры";
            // 
            // RombRadioButton
            // 
            this.RombRadioButton.AutoSize = true;
            this.RombRadioButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RombRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RombRadioButton.Location = new System.Drawing.Point(365, 68);
            this.RombRadioButton.Name = "RombRadioButton";
            this.RombRadioButton.Size = new System.Drawing.Size(52, 17);
            this.RombRadioButton.TabIndex = 1;
            this.RombRadioButton.TabStop = true;
            this.RombRadioButton.Text = "Ромб";
            this.RombRadioButton.UseVisualStyleBackColor = false;
            this.RombRadioButton.Click += new System.EventHandler(this.RombRadioButton_Click);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RectangleRadioButton.Location = new System.Drawing.Point(181, 68);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(115, 17);
            this.RectangleRadioButton.TabIndex = 0;
            this.RectangleRadioButton.TabStop = true;
            this.RectangleRadioButton.Text = "Четырёхугольник";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.Click += new System.EventHandler(this.RectangleRadioButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 332);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.IsSquareAnsLabel);
            this.groupBox2.Controls.Add(this.SideBAnsLabel);
            this.groupBox2.Controls.Add(this.SideAAnsLabel);
            this.groupBox2.Controls.Add(this.PerimetrAnsLabel);
            this.groupBox2.Controls.Add(this.AreaAnsLabel);
            this.groupBox2.Controls.Add(this.IsSquareLabel);
            this.groupBox2.Controls.Add(this.SideBLabel);
            this.groupBox2.Controls.Add(this.SideALabel);
            this.groupBox2.Controls.Add(this.PerimetrLabel);
            this.groupBox2.Controls.Add(this.AreaLabel);
            this.groupBox2.Location = new System.Drawing.Point(3, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 299);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики фигуры";
            this.groupBox2.Visible = false;
            // 
            // IsSquareAnsLabel
            // 
            this.IsSquareAnsLabel.AutoSize = true;
            this.IsSquareAnsLabel.Location = new System.Drawing.Point(146, 240);
            this.IsSquareAnsLabel.Name = "IsSquareAnsLabel";
            this.IsSquareAnsLabel.Size = new System.Drawing.Size(41, 13);
            this.IsSquareAnsLabel.TabIndex = 9;
            this.IsSquareAnsLabel.Text = "label10";
            this.IsSquareAnsLabel.Visible = false;
            this.IsSquareAnsLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // SideBAnsLabel
            // 
            this.SideBAnsLabel.AutoSize = true;
            this.SideBAnsLabel.Location = new System.Drawing.Point(146, 192);
            this.SideBAnsLabel.Name = "SideBAnsLabel";
            this.SideBAnsLabel.Size = new System.Drawing.Size(35, 13);
            this.SideBAnsLabel.TabIndex = 8;
            this.SideBAnsLabel.Text = "label9";
            this.SideBAnsLabel.Visible = false;
            // 
            // SideAAnsLabel
            // 
            this.SideAAnsLabel.AutoSize = true;
            this.SideAAnsLabel.Location = new System.Drawing.Point(146, 142);
            this.SideAAnsLabel.Name = "SideAAnsLabel";
            this.SideAAnsLabel.Size = new System.Drawing.Size(35, 13);
            this.SideAAnsLabel.TabIndex = 7;
            this.SideAAnsLabel.Text = "label8";
            this.SideAAnsLabel.Visible = false;
            // 
            // PerimetrAnsLabel
            // 
            this.PerimetrAnsLabel.AutoSize = true;
            this.PerimetrAnsLabel.Location = new System.Drawing.Point(146, 95);
            this.PerimetrAnsLabel.Name = "PerimetrAnsLabel";
            this.PerimetrAnsLabel.Size = new System.Drawing.Size(35, 13);
            this.PerimetrAnsLabel.TabIndex = 6;
            this.PerimetrAnsLabel.Text = "label7";
            this.PerimetrAnsLabel.Visible = false;
            // 
            // AreaAnsLabel
            // 
            this.AreaAnsLabel.AutoSize = true;
            this.AreaAnsLabel.Location = new System.Drawing.Point(146, 50);
            this.AreaAnsLabel.Name = "AreaAnsLabel";
            this.AreaAnsLabel.Size = new System.Drawing.Size(35, 13);
            this.AreaAnsLabel.TabIndex = 5;
            this.AreaAnsLabel.Text = "label6";
            this.AreaAnsLabel.Visible = false;
            // 
            // IsSquareLabel
            // 
            this.IsSquareLabel.AutoSize = true;
            this.IsSquareLabel.Location = new System.Drawing.Point(22, 240);
            this.IsSquareLabel.Name = "IsSquareLabel";
            this.IsSquareLabel.Size = new System.Drawing.Size(120, 13);
            this.IsSquareLabel.TabIndex = 4;
            this.IsSquareLabel.Text = "Является квадратом?";
            this.IsSquareLabel.Visible = false;
            // 
            // SideBLabel
            // 
            this.SideBLabel.AutoSize = true;
            this.SideBLabel.Location = new System.Drawing.Point(22, 192);
            this.SideBLabel.Name = "SideBLabel";
            this.SideBLabel.Size = new System.Drawing.Size(59, 13);
            this.SideBLabel.TabIndex = 3;
            this.SideBLabel.Text = "Сторона Б";
            this.SideBLabel.Visible = false;
            // 
            // SideALabel
            // 
            this.SideALabel.AutoSize = true;
            this.SideALabel.Location = new System.Drawing.Point(22, 142);
            this.SideALabel.Name = "SideALabel";
            this.SideALabel.Size = new System.Drawing.Size(59, 13);
            this.SideALabel.TabIndex = 2;
            this.SideALabel.Text = "Сторона А";
            this.SideALabel.Visible = false;
            // 
            // PerimetrLabel
            // 
            this.PerimetrLabel.AutoSize = true;
            this.PerimetrLabel.Location = new System.Drawing.Point(22, 95);
            this.PerimetrLabel.Name = "PerimetrLabel";
            this.PerimetrLabel.Size = new System.Drawing.Size(58, 13);
            this.PerimetrLabel.TabIndex = 1;
            this.PerimetrLabel.Text = "Периметр";
            this.PerimetrLabel.Visible = false;
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(22, 50);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(54, 13);
            this.AreaLabel.TabIndex = 0;
            this.AreaLabel.Text = "Площадь";
            this.AreaLabel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.AngleTextBox);
            this.groupBox3.Controls.Add(this.HeightTextBox);
            this.groupBox3.Controls.Add(this.SideTextBox);
            this.groupBox3.Controls.Add(this.RedactButton);
            this.groupBox3.Controls.Add(this.CreateButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(365, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 312);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных о фигуре";
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Enabled = false;
            this.AngleTextBox.Location = new System.Drawing.Point(121, 166);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(175, 20);
            this.AngleTextBox.TabIndex = 7;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Enabled = false;
            this.HeightTextBox.Location = new System.Drawing.Point(121, 118);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(175, 20);
            this.HeightTextBox.TabIndex = 6;
            // 
            // SideTextBox
            // 
            this.SideTextBox.Enabled = false;
            this.SideTextBox.Location = new System.Drawing.Point(121, 61);
            this.SideTextBox.Name = "SideTextBox";
            this.SideTextBox.Size = new System.Drawing.Size(175, 20);
            this.SideTextBox.TabIndex = 5;
            // 
            // RedactButton
            // 
            this.RedactButton.Enabled = false;
            this.RedactButton.Location = new System.Drawing.Point(40, 264);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(327, 33);
            this.RedactButton.TabIndex = 4;
            this.RedactButton.Text = "Редактировать фигуру";
            this.RedactButton.UseVisualStyleBackColor = true;
            this.RedactButton.Visible = false;
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Enabled = false;
            this.CreateButton.Location = new System.Drawing.Point(40, 225);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(327, 33);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Создать фигуру";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Угол";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Фоновая работа 7_1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RombRadioButton;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label IsSquareAnsLabel;
        private System.Windows.Forms.Label SideBAnsLabel;
        private System.Windows.Forms.Label SideAAnsLabel;
        private System.Windows.Forms.Label PerimetrAnsLabel;
        private System.Windows.Forms.Label AreaAnsLabel;
        private System.Windows.Forms.Label IsSquareLabel;
        private System.Windows.Forms.Label SideBLabel;
        private System.Windows.Forms.Label SideALabel;
        private System.Windows.Forms.Label PerimetrLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox SideTextBox;
        private System.Windows.Forms.Button RedactButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

