namespace lab9
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
            this.components = new System.ComponentModel.Container();
            this.btnFileOpen1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxX1 = new System.Windows.Forms.TextBox();
            this.txtBoxY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxY2 = new System.Windows.Forms.TextBox();
            this.txtBoxX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorLine1 = new System.Windows.Forms.Button();
            this.txtBoxLineColor1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBoxXAxisType = new System.Windows.Forms.ComboBox();
            this.cmbBoxLineType1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxAxisColor1 = new System.Windows.Forms.TextBox();
            this.btnColorAxis1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxLineColor2 = new System.Windows.Forms.TextBox();
            this.btnColorLine2 = new System.Windows.Forms.Button();
            this.btnFileOpen2 = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxYAxisType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFileOpen1
            // 
            this.btnFileOpen1.Location = new System.Drawing.Point(54, 9);
            this.btnFileOpen1.Name = "btnFileOpen1";
            this.btnFileOpen1.Size = new System.Drawing.Size(192, 53);
            this.btnFileOpen1.TabIndex = 2;
            this.btnFileOpen1.Text = "Открыть файл с первой серией данных";
            this.btnFileOpen1.UseVisualStyleBackColor = true;
            this.btnFileOpen1.Click += new System.EventHandler(this.btnFileOpen1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // txtBoxX1
            // 
            this.txtBoxX1.Location = new System.Drawing.Point(35, 93);
            this.txtBoxX1.Multiline = true;
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxX1.Size = new System.Drawing.Size(211, 22);
            this.txtBoxX1.TabIndex = 5;
            // 
            // txtBoxY1
            // 
            this.txtBoxY1.Location = new System.Drawing.Point(36, 126);
            this.txtBoxY1.Name = "txtBoxY1";
            this.txtBoxY1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxY1.Size = new System.Drawing.Size(210, 22);
            this.txtBoxY1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Первая серия данных";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вторая серия данных";
            // 
            // txtBoxY2
            // 
            this.txtBoxY2.Location = new System.Drawing.Point(352, 123);
            this.txtBoxY2.Name = "txtBoxY2";
            this.txtBoxY2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxY2.Size = new System.Drawing.Size(210, 22);
            this.txtBoxY2.TabIndex = 11;
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.Location = new System.Drawing.Point(351, 93);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxX2.Size = new System.Drawing.Size(211, 22);
            this.txtBoxX2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "X";
            // 
            // btnColorLine1
            // 
            this.btnColorLine1.Location = new System.Drawing.Point(167, 205);
            this.btnColorLine1.Name = "btnColorLine1";
            this.btnColorLine1.Size = new System.Drawing.Size(110, 28);
            this.btnColorLine1.TabIndex = 13;
            this.btnColorLine1.Text = "Выбрать цвет";
            this.btnColorLine1.UseVisualStyleBackColor = true;
            this.btnColorLine1.Click += new System.EventHandler(this.btnColorLine1_Click);
            // 
            // txtBoxLineColor1
            // 
            this.txtBoxLineColor1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxLineColor1.Location = new System.Drawing.Point(9, 208);
            this.txtBoxLineColor1.Name = "txtBoxLineColor1";
            this.txtBoxLineColor1.ReadOnly = true;
            this.txtBoxLineColor1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxLineColor1.Size = new System.Drawing.Size(152, 22);
            this.txtBoxLineColor1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Цвет линии для \r\nпервого графика";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Тип линии для \r\nпервого графика";
            // 
            // cmbBoxXAxisType
            // 
            this.cmbBoxXAxisType.FormattingEnabled = true;
            this.cmbBoxXAxisType.Items.AddRange(new object[] {
            "Обыкновенная ось",
            "Логарифмическая ось с основанием 10",
            "Декартова ось с датами или временем",
            "Отформатированная обыкновенная ось ",
            "Экспоненциальная ось"});
            this.cmbBoxXAxisType.Location = new System.Drawing.Point(333, 286);
            this.cmbBoxXAxisType.Name = "cmbBoxXAxisType";
            this.cmbBoxXAxisType.Size = new System.Drawing.Size(309, 24);
            this.cmbBoxXAxisType.TabIndex = 17;
            // 
            // cmbBoxLineType1
            // 
            this.cmbBoxLineType1.DropDownWidth = 350;
            this.cmbBoxLineType1.FormattingEnabled = true;
            this.cmbBoxLineType1.Items.AddRange(new object[] {
            "сплошная линия",
            "линия, состоящая из штрихов.",
            "линия, состоящая из точек",
            "штрих-пунктирная линия",
            "линия, состоящая из повторяющегося шаблона \"штрих-две точки\""});
            this.cmbBoxLineType1.Location = new System.Drawing.Point(9, 286);
            this.cmbBoxLineType1.Name = "cmbBoxLineType1";
            this.cmbBoxLineType1.Size = new System.Drawing.Size(305, 24);
            this.cmbBoxLineType1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = "Цвет оси для \r\nпервого графика";
            // 
            // txtBoxAxisColor1
            // 
            this.txtBoxAxisColor1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxAxisColor1.Location = new System.Drawing.Point(341, 211);
            this.txtBoxAxisColor1.Name = "txtBoxAxisColor1";
            this.txtBoxAxisColor1.ReadOnly = true;
            this.txtBoxAxisColor1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxAxisColor1.Size = new System.Drawing.Size(152, 22);
            this.txtBoxAxisColor1.TabIndex = 20;
            // 
            // btnColorAxis1
            // 
            this.btnColorAxis1.Location = new System.Drawing.Point(499, 208);
            this.btnColorAxis1.Name = "btnColorAxis1";
            this.btnColorAxis1.Size = new System.Drawing.Size(110, 28);
            this.btnColorAxis1.TabIndex = 19;
            this.btnColorAxis1.Text = "Выбрать цвет";
            this.btnColorAxis1.UseVisualStyleBackColor = true;
            this.btnColorAxis1.Click += new System.EventHandler(this.btnColorAxis1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Тип оси Х для графика";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 32);
            this.label15.TabIndex = 25;
            this.label15.Text = "Цвет точек для \r\nвторого графика";
            // 
            // txtBoxLineColor2
            // 
            this.txtBoxLineColor2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxLineColor2.Location = new System.Drawing.Point(9, 365);
            this.txtBoxLineColor2.Name = "txtBoxLineColor2";
            this.txtBoxLineColor2.ReadOnly = true;
            this.txtBoxLineColor2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxLineColor2.Size = new System.Drawing.Size(152, 22);
            this.txtBoxLineColor2.TabIndex = 24;
            // 
            // btnColorLine2
            // 
            this.btnColorLine2.Location = new System.Drawing.Point(167, 362);
            this.btnColorLine2.Name = "btnColorLine2";
            this.btnColorLine2.Size = new System.Drawing.Size(110, 28);
            this.btnColorLine2.TabIndex = 23;
            this.btnColorLine2.Text = "Выбрать цвет";
            this.btnColorLine2.UseVisualStyleBackColor = true;
            this.btnColorLine2.Click += new System.EventHandler(this.btnColorLine2_Click);
            // 
            // btnFileOpen2
            // 
            this.btnFileOpen2.Location = new System.Drawing.Point(372, 9);
            this.btnFileOpen2.Name = "btnFileOpen2";
            this.btnFileOpen2.Size = new System.Drawing.Size(172, 53);
            this.btnFileOpen2.TabIndex = 33;
            this.btnFileOpen2.Text = "Открыть файл со второй серией данных";
            this.btnFileOpen2.UseVisualStyleBackColor = true;
            this.btnFileOpen2.Click += new System.EventHandler(this.btnFileOpen2_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(437, 437);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(172, 30);
            this.btnPlot.TabIndex = 34;
            this.btnPlot.Text = "Посторить графики";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(655, 0);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(700, 467);
            this.zedGraph.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Тип оси Y для графика";
            // 
            // cmbBoxYAxisType
            // 
            this.cmbBoxYAxisType.FormattingEnabled = true;
            this.cmbBoxYAxisType.Items.AddRange(new object[] {
            "Обыкновенная ось",
            "Логарифмическая ось с основанием 10",
            "Декартова ось с датами или временем",
            "Отформатированная обыкновенная ось ",
            "Экспоненциальная ось"});
            this.cmbBoxYAxisType.Location = new System.Drawing.Point(333, 366);
            this.cmbBoxYAxisType.Name = "cmbBoxYAxisType";
            this.cmbBoxYAxisType.Size = new System.Drawing.Size(309, 24);
            this.cmbBoxYAxisType.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxYAxisType);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.btnFileOpen2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxLineColor2);
            this.Controls.Add(this.btnColorLine2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxAxisColor1);
            this.Controls.Add(this.btnColorAxis1);
            this.Controls.Add(this.cmbBoxLineType1);
            this.Controls.Add(this.cmbBoxXAxisType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxLineColor1);
            this.Controls.Add(this.btnColorLine1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxY2);
            this.Controls.Add(this.txtBoxX2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxY1);
            this.Controls.Add(this.txtBoxX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFileOpen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFileOpen1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorLine1;
        private System.Windows.Forms.TextBox txtBoxLineColor1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxAxisColor1;
        private System.Windows.Forms.Button btnColorAxis1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxLineColor2;
        private System.Windows.Forms.Button btnColorLine2;
        private System.Windows.Forms.Button btnFileOpen2;
        private System.Windows.Forms.Button btnPlot;
        public System.Windows.Forms.ComboBox cmbBoxXAxisType;
        public System.Windows.Forms.ComboBox cmbBoxLineType1;
        public System.Windows.Forms.TextBox txtBoxX1;
        public System.Windows.Forms.TextBox txtBoxY1;
        public System.Windows.Forms.TextBox txtBoxY2;
        public System.Windows.Forms.TextBox txtBoxX2;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbBoxYAxisType;
    }
}

