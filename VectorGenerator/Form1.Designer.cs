namespace VectorGenerator
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
            txtVectorSize = new TextBox();
            btnVectorGenerator = new Button();
            label1 = new Label();
            txtVector = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtVectorSize
            // 
            txtVectorSize.Location = new Point(182, 106);
            txtVectorSize.Multiline = true;
            txtVectorSize.Name = "txtVectorSize";
            txtVectorSize.Size = new Size(67, 23);
            txtVectorSize.TabIndex = 0;
            // 
            // btnVectorGenerator
            // 
            btnVectorGenerator.Location = new Point(270, 106);
            btnVectorGenerator.Name = "btnVectorGenerator";
            btnVectorGenerator.Size = new Size(75, 23);
            btnVectorGenerator.TabIndex = 1;
            btnVectorGenerator.Text = "Generate";
            btnVectorGenerator.UseVisualStyleBackColor = true;
            btnVectorGenerator.Click += btnVectorGenerator_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 2;
            label1.Text = "Enter the vector size";
            // 
            // txtVector
            // 
            txtVector.Location = new Point(182, 145);
            txtVector.Name = "txtVector";
            txtVector.Size = new Size(100, 23);
            txtVector.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 4;
            label2.Text = "Vector generator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 147);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 5;
            label3.Text = "Vector";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 262);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtVector);
            Controls.Add(label1);
            Controls.Add(btnVectorGenerator);
            Controls.Add(txtVectorSize);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVectorSize;
        private Button btnVectorGenerator;
        private Label label1;
        private TextBox txtVector;
        private Label label2;
        private Label label3;
    }
}
