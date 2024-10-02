namespace Calculator
{
    partial class Form1
    {
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
            btnAdd = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnSub = new Button();
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(17, 370);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(540, 370);
            btnDiv.Margin = new Padding(5, 4, 5, 4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(107, 32);
            btnDiv.TabIndex = 1;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(363, 370);
            btnMul.Margin = new Padding(5, 4, 5, 4);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(107, 32);
            btnMul.TabIndex = 2;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(185, 370);
            btnSub.Margin = new Padding(5, 4, 5, 4);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(107, 32);
            btnSub.TabIndex = 3;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(270, 73);
            txtFirst.Margin = new Padding(5, 4, 5, 4);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(199, 29);
            txtFirst.TabIndex = 4;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(271, 199);
            txtSecond.Margin = new Padding(5, 4, 5, 4);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(199, 29);
            txtSecond.TabIndex = 5;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(270, 486);
            txtResult.Margin = new Padding(5, 4, 5, 4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(199, 29);
            txtResult.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 77);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 7;
            label1.Text = "First";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 202);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 8;
            label2.Text = "Second";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 490);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 9;
            label3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(684, 615);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Controls.Add(btnSub);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDiv;
        private Button btnMul;
        private Button btnSub;
        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
