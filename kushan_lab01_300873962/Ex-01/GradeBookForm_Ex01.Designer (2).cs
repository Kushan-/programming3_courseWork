namespace Ex_01
{
    partial class Ex01
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
            this.avgBtn = new System.Windows.Forms.Button();
            this.sumBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.inputBtn = new System.Windows.Forms.Button();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.displayInputBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // avgBtn
            // 
            this.avgBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgBtn.Location = new System.Drawing.Point(310, 317);
            this.avgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.avgBtn.Name = "avgBtn";
            this.avgBtn.Size = new System.Drawing.Size(184, 36);
            this.avgBtn.TabIndex = 13;
            this.avgBtn.Text = "AVERAGE";
            this.avgBtn.UseVisualStyleBackColor = true;
            this.avgBtn.Click += new System.EventHandler(this.Calculate_Btn);
            // 
            // sumBtn
            // 
            this.sumBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumBtn.Location = new System.Drawing.Point(310, 258);
            this.sumBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(184, 38);
            this.sumBtn.TabIndex = 12;
            this.sumBtn.Text = "SUM";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.Calculate_Btn);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(310, 198);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(184, 36);
            this.removeBtn.TabIndex = 11;
            this.removeBtn.Text = "REMOVE";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(310, 136);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(182, 37);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // inputBtn
            // 
            this.inputBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBtn.Location = new System.Drawing.Point(310, 73);
            this.inputBtn.Margin = new System.Windows.Forms.Padding(4);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(182, 38);
            this.inputBtn.TabIndex = 9;
            this.inputBtn.Text = "INPUT";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(310, 28);
            this.gradeBox.Margin = new System.Windows.Forms.Padding(4);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(182, 20);
            this.gradeBox.TabIndex = 8;
            // 
            // displayInputBox
            // 
            this.displayInputBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayInputBox.FormattingEnabled = true;
            this.displayInputBox.Location = new System.Drawing.Point(35, 35);
            this.displayInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.displayInputBox.Name = "displayInputBox";
            this.displayInputBox.Size = new System.Drawing.Size(190, 316);
            this.displayInputBox.TabIndex = 7;
            this.displayInputBox.SelectedIndexChanged += new System.EventHandler(this.displayInputBox_SelectedIndexChanged);
            // 
            // Ex01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 376);
            this.Controls.Add(this.avgBtn);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.displayInputBox);
            this.Name = "Ex01";
            this.Text = "Grade Book Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avgBtn;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.ListBox displayInputBox;
    }
}

