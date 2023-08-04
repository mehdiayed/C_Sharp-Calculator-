namespace Calculatrice_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button0 = new Button();
            buttonVirgule = new Button();
            buttonEgale = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMC = new Button();
            buttonMPlus = new Button();
            buttonSlash = new Button();
            buttonPlus = new Button();
            buttonMoins = new Button();
            buttonFois = new Button();
            textBox1 = new TextBox();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Location = new Point(10, 385);
            button0.Name = "button0";
            button0.Size = new Size(135, 53);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_clickNumbers;
            // 
            // buttonVirgule
            // 
            buttonVirgule.Location = new Point(164, 385);
            buttonVirgule.Name = "buttonVirgule";
            buttonVirgule.Size = new Size(57, 53);
            buttonVirgule.TabIndex = 1;
            buttonVirgule.Text = ",";
            buttonVirgule.UseVisualStyleBackColor = true;
            buttonVirgule.Click += button_clickNumbers;
            // 
            // buttonEgale
            // 
            buttonEgale.Location = new Point(239, 311);
            buttonEgale.Name = "buttonEgale";
            buttonEgale.Size = new Size(73, 127);
            buttonEgale.TabIndex = 2;
            buttonEgale.Text = "=";
            buttonEgale.UseVisualStyleBackColor = true;
            buttonEgale.Click += EgaleButton;
            // 
            // button3
            // 
            button3.Location = new Point(164, 311);
            button3.Name = "button3";
            button3.Size = new Size(57, 53);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_clickNumbers;
            // 
            // button2
            // 
            button2.Location = new Point(85, 311);
            button2.Name = "button2";
            button2.Size = new Size(60, 53);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_clickNumbers;
            // 
            // button1
            // 
            button1.Location = new Point(10, 311);
            button1.Name = "button1";
            button1.Size = new Size(59, 53);
            button1.TabIndex = 5;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_clickNumbers;
            // 
            // button4
            // 
            button4.Location = new Point(10, 239);
            button4.Name = "button4";
            button4.Size = new Size(59, 53);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_clickNumbers;
            // 
            // button5
            // 
            button5.Location = new Point(85, 239);
            button5.Name = "button5";
            button5.Size = new Size(60, 53);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_clickNumbers;
            // 
            // button6
            // 
            button6.Location = new Point(164, 239);
            button6.Name = "button6";
            button6.Size = new Size(57, 53);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_clickNumbers;
            // 
            // button7
            // 
            button7.Location = new Point(10, 169);
            button7.Name = "button7";
            button7.Size = new Size(59, 53);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_clickNumbers;
            // 
            // button8
            // 
            button8.Location = new Point(85, 169);
            button8.Name = "button8";
            button8.Size = new Size(60, 53);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_clickNumbers;
            // 
            // button9
            // 
            button9.Location = new Point(164, 169);
            button9.Name = "button9";
            button9.Size = new Size(57, 53);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_clickNumbers;
            // 
            // buttonMC
            // 
            buttonMC.Location = new Point(10, 99);
            buttonMC.Name = "buttonMC";
            buttonMC.Size = new Size(59, 53);
            buttonMC.TabIndex = 14;
            buttonMC.Text = "C";
            buttonMC.UseVisualStyleBackColor = true;
            buttonMC.Click += buttonMC_Click;
            // 
            // buttonMPlus
            // 
            buttonMPlus.Location = new Point(85, 99);
            buttonMPlus.Name = "buttonMPlus";
            buttonMPlus.Size = new Size(60, 53);
            buttonMPlus.TabIndex = 13;
            buttonMPlus.Text = "M+";
            buttonMPlus.UseVisualStyleBackColor = true;
            buttonMPlus.Click += button14_Click;
            // 
            // buttonSlash
            // 
            buttonSlash.Location = new Point(164, 99);
            buttonSlash.Name = "buttonSlash";
            buttonSlash.Size = new Size(57, 53);
            buttonSlash.TabIndex = 12;
            buttonSlash.Text = "/";
            buttonSlash.UseVisualStyleBackColor = true;
            buttonSlash.Click += OperatorClickEvent;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(239, 239);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(73, 53);
            buttonPlus.TabIndex = 15;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += OperatorClickEvent;
            // 
            // buttonMoins
            // 
            buttonMoins.Location = new Point(239, 169);
            buttonMoins.Name = "buttonMoins";
            buttonMoins.Size = new Size(73, 53);
            buttonMoins.TabIndex = 16;
            buttonMoins.Text = "-";
            buttonMoins.UseVisualStyleBackColor = true;
            buttonMoins.Click += OperatorClickEvent;
            // 
            // buttonFois
            // 
            buttonFois.Location = new Point(239, 99);
            buttonFois.Name = "buttonFois";
            buttonFois.Size = new Size(73, 53);
            buttonFois.TabIndex = 17;
            buttonFois.Text = "*";
            buttonFois.UseVisualStyleBackColor = true;
            buttonFois.Click += OperatorClickEvent;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 37);
            textBox1.TabIndex = 18;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.BackColor = SystemColors.ActiveCaption;
            labelCurrentOperation.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentOperation.Location = new Point(12, 19);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 21);
            labelCurrentOperation.TabIndex = 19;
            labelCurrentOperation.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(labelCurrentOperation);
            Controls.Add(textBox1);
            Controls.Add(buttonFois);
            Controls.Add(buttonMoins);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMC);
            Controls.Add(buttonMPlus);
            Controls.Add(buttonSlash);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(buttonEgale);
            Controls.Add(buttonVirgule);
            Controls.Add(button0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0;
        private Button buttonVirgule;
        private Button buttonEgale;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonMC;
        private Button buttonMPlus;
        private Button buttonSlash;
        private Button buttonPlus;
        private Button buttonMoins;
        private Button buttonFois;
        private TextBox textBox1;
        private Label labelCurrentOperation;
    }
}