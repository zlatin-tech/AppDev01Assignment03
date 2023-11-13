namespace Assignment03
{
    partial class HugeNumberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.int1Label = new System.Windows.Forms.Label();
            this.hugeNb1 = new System.Windows.Forms.TextBox();
            this.int2Label = new System.Windows.Forms.Label();
            this.hugeNb2 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.isEqualBtn = new System.Windows.Forms.Button();
            this.substractBtn = new System.Windows.Forms.Button();
            this.isNotEqualBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.isGreaterThanBtn = new System.Windows.Forms.Button();
            this.remainderBtn = new System.Windows.Forms.Button();
            this.isLessThanBtn = new System.Windows.Forms.Button();
            this.isGreaterThanOrEqualBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.isLessThanOrEqualBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // int1Label
            // 
            this.int1Label.AutoSize = true;
            this.int1Label.Location = new System.Drawing.Point(58, 30);
            this.int1Label.Name = "int1Label";
            this.int1Label.Size = new System.Drawing.Size(40, 13);
            this.int1Label.TabIndex = 0;
            this.int1Label.Text = "Integer";
            // 
            // hugeNb1
            // 
            this.hugeNb1.Location = new System.Drawing.Point(124, 30);
            this.hugeNb1.MaxLength = 40;
            this.hugeNb1.Name = "hugeNb1";
            this.hugeNb1.Size = new System.Drawing.Size(632, 20);
            this.hugeNb1.TabIndex = 1;
            // 
            // int2Label
            // 
            this.int2Label.AutoSize = true;
            this.int2Label.Location = new System.Drawing.Point(58, 79);
            this.int2Label.Name = "int2Label";
            this.int2Label.Size = new System.Drawing.Size(40, 13);
            this.int2Label.TabIndex = 2;
            this.int2Label.Text = "Integer";
            // 
            // hugeNb2
            // 
            this.hugeNb2.Location = new System.Drawing.Point(124, 79);
            this.hugeNb2.MaxLength = 40;
            this.hugeNb2.Name = "hugeNb2";
            this.hugeNb2.Size = new System.Drawing.Size(632, 20);
            this.hugeNb2.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(61, 150);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // isEqualBtn
            // 
            this.isEqualBtn.Location = new System.Drawing.Point(61, 196);
            this.isEqualBtn.Name = "isEqualBtn";
            this.isEqualBtn.Size = new System.Drawing.Size(90, 23);
            this.isEqualBtn.TabIndex = 5;
            this.isEqualBtn.Text = "Are Equal";
            this.isEqualBtn.UseVisualStyleBackColor = true;
            this.isEqualBtn.Click += new System.EventHandler(this.isEqualBtn_Click);
            // 
            // substractBtn
            // 
            this.substractBtn.Location = new System.Drawing.Point(181, 150);
            this.substractBtn.Name = "substractBtn";
            this.substractBtn.Size = new System.Drawing.Size(120, 23);
            this.substractBtn.TabIndex = 6;
            this.substractBtn.Text = "Substract";
            this.substractBtn.UseVisualStyleBackColor = true;
            this.substractBtn.Click += new System.EventHandler(this.substractBtn_Click);
            // 
            // isNotEqualBtn
            // 
            this.isNotEqualBtn.Location = new System.Drawing.Point(181, 196);
            this.isNotEqualBtn.Name = "isNotEqualBtn";
            this.isNotEqualBtn.Size = new System.Drawing.Size(120, 23);
            this.isNotEqualBtn.TabIndex = 7;
            this.isNotEqualBtn.Text = "Are Not Equal";
            this.isNotEqualBtn.UseVisualStyleBackColor = true;
            this.isNotEqualBtn.Click += new System.EventHandler(this.isNotEqualBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(335, 150);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(109, 23);
            this.multiplyBtn.TabIndex = 9;
            this.multiplyBtn.Text = "Multiply";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(485, 150);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(106, 23);
            this.divideBtn.TabIndex = 10;
            this.divideBtn.Text = "Divide";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // isGreaterThanBtn
            // 
            this.isGreaterThanBtn.Location = new System.Drawing.Point(335, 196);
            this.isGreaterThanBtn.Name = "isGreaterThanBtn";
            this.isGreaterThanBtn.Size = new System.Drawing.Size(109, 23);
            this.isGreaterThanBtn.TabIndex = 11;
            this.isGreaterThanBtn.Text = "Is Greater Than";
            this.isGreaterThanBtn.UseVisualStyleBackColor = true;
            this.isGreaterThanBtn.Click += new System.EventHandler(this.isGreaterThanBtn_Click);
            // 
            // remainderBtn
            // 
            this.remainderBtn.Location = new System.Drawing.Point(624, 150);
            this.remainderBtn.Name = "remainderBtn";
            this.remainderBtn.Size = new System.Drawing.Size(132, 23);
            this.remainderBtn.TabIndex = 12;
            this.remainderBtn.Text = "Remainder";
            this.remainderBtn.UseVisualStyleBackColor = true;
            this.remainderBtn.Click += new System.EventHandler(this.remainderBtn_Click);
            // 
            // isLessThanBtn
            // 
            this.isLessThanBtn.Location = new System.Drawing.Point(485, 196);
            this.isLessThanBtn.Name = "isLessThanBtn";
            this.isLessThanBtn.Size = new System.Drawing.Size(106, 23);
            this.isLessThanBtn.TabIndex = 14;
            this.isLessThanBtn.Text = "Is Less Than";
            this.isLessThanBtn.UseVisualStyleBackColor = true;
            this.isLessThanBtn.Click += new System.EventHandler(this.isLessThanBtn_Click);
            // 
            // isGreaterThanOrEqualBtn
            // 
            this.isGreaterThanOrEqualBtn.Location = new System.Drawing.Point(624, 196);
            this.isGreaterThanOrEqualBtn.Name = "isGreaterThanOrEqualBtn";
            this.isGreaterThanOrEqualBtn.Size = new System.Drawing.Size(132, 23);
            this.isGreaterThanOrEqualBtn.TabIndex = 15;
            this.isGreaterThanOrEqualBtn.Text = "IsGreaterThanOrEqual";
            this.isGreaterThanOrEqualBtn.UseVisualStyleBackColor = true;
            this.isGreaterThanOrEqualBtn.Click += new System.EventHandler(this.isGreaterThanOrEqualBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(58, 304);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 17;
            this.resultLabel.Text = "Result";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(124, 296);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(632, 20);
            this.resultText.TabIndex = 18;
            // 
            // isLessThanOrEqualBtn
            // 
            this.isLessThanOrEqualBtn.Location = new System.Drawing.Point(320, 238);
            this.isLessThanOrEqualBtn.Name = "isLessThanOrEqualBtn";
            this.isLessThanOrEqualBtn.Size = new System.Drawing.Size(142, 23);
            this.isLessThanOrEqualBtn.TabIndex = 19;
            this.isLessThanOrEqualBtn.Text = "IsLessThanOrEqual";
            this.isLessThanOrEqualBtn.UseVisualStyleBackColor = true;
            this.isLessThanOrEqualBtn.Click += new System.EventHandler(this.isLessThanOrEqualBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(335, 336);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 23);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // HugeNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.isLessThanOrEqualBtn);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.isGreaterThanOrEqualBtn);
            this.Controls.Add(this.isLessThanBtn);
            this.Controls.Add(this.remainderBtn);
            this.Controls.Add(this.isGreaterThanBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.isNotEqualBtn);
            this.Controls.Add(this.substractBtn);
            this.Controls.Add(this.isEqualBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.hugeNb2);
            this.Controls.Add(this.int2Label);
            this.Controls.Add(this.hugeNb1);
            this.Controls.Add(this.int1Label);
            this.Name = "HugeNumberForm";
            this.Text = "Huge Integer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label int1Label;
        private System.Windows.Forms.TextBox hugeNb1;
        private System.Windows.Forms.Label int2Label;
        private System.Windows.Forms.TextBox hugeNb2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button isEqualBtn;
        private System.Windows.Forms.Button substractBtn;
        private System.Windows.Forms.Button isNotEqualBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button isGreaterThanBtn;
        private System.Windows.Forms.Button remainderBtn;
        private System.Windows.Forms.Button isLessThanBtn;
        private System.Windows.Forms.Button isGreaterThanOrEqualBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button isLessThanOrEqualBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

