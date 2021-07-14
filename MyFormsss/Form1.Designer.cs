
namespace MyFormsss
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnNewForm = new System.Windows.Forms.Button();
            this.btnOrderbyScore = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBox.Font = new System.Drawing.Font("新細明體", 14F);
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 23;
            this.lstBox.Location = new System.Drawing.Point(12, 12);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(549, 234);
            this.lstBox.TabIndex = 0;
            // 
            // btnNewForm
            // 
            this.btnNewForm.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnNewForm.Location = new System.Drawing.Point(12, 435);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(151, 40);
            this.btnNewForm.TabIndex = 1;
            this.btnNewForm.Text = "輸入資料";
            this.btnNewForm.UseVisualStyleBackColor = true;
            this.btnNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // btnOrderbyScore
            // 
            this.btnOrderbyScore.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnOrderbyScore.Location = new System.Drawing.Point(12, 252);
            this.btnOrderbyScore.Name = "btnOrderbyScore";
            this.btnOrderbyScore.Size = new System.Drawing.Size(151, 40);
            this.btnOrderbyScore.TabIndex = 2;
            this.btnOrderbyScore.Text = "按分數排序";
            this.btnOrderbyScore.UseVisualStyleBackColor = true;
            this.btnOrderbyScore.Click += new System.EventHandler(this.btnOrderbyScore_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnShowPass.Location = new System.Drawing.Point(12, 308);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(151, 40);
            this.btnShowPass.TabIndex = 3;
            this.btnShowPass.Text = "只顯示及格";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("新細明體", 14F);
            this.lblRecords.Location = new System.Drawing.Point(497, 252);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(64, 24);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "label1";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("新細明體", 14F);
            this.lblAverage.Location = new System.Drawing.Point(497, 291);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(64, 24);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 487);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnOrderbyScore);
            this.Controls.Add(this.btnNewForm);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnNewForm;
        private System.Windows.Forms.Button btnOrderbyScore;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblAverage;
    }
}

