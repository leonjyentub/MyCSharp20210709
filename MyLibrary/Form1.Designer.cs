
namespace MyLibrary
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
            this.chklistLeft = new System.Windows.Forms.CheckedListBox();
            this.chklistRight = new System.Windows.Forms.CheckedListBox();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklistLeft
            // 
            this.chklistLeft.CheckOnClick = true;
            this.chklistLeft.Font = new System.Drawing.Font("新細明體", 14F);
            this.chklistLeft.FormattingEnabled = true;
            this.chklistLeft.Location = new System.Drawing.Point(13, 13);
            this.chklistLeft.Name = "chklistLeft";
            this.chklistLeft.Size = new System.Drawing.Size(250, 274);
            this.chklistLeft.TabIndex = 0;
            // 
            // chklistRight
            // 
            this.chklistRight.CheckOnClick = true;
            this.chklistRight.Font = new System.Drawing.Font("新細明體", 14F);
            this.chklistRight.FormattingEnabled = true;
            this.chklistRight.Location = new System.Drawing.Point(361, 12);
            this.chklistRight.Name = "chklistRight";
            this.chklistRight.Size = new System.Drawing.Size(250, 274);
            this.chklistRight.TabIndex = 1;
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(270, 77);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(75, 23);
            this.btnToRight.TabIndex = 2;
            this.btnToRight.Text = ">>";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(270, 198);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "<<";
            this.btnToLeft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 305);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.chklistRight);
            this.Controls.Add(this.chklistLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklistLeft;
        private System.Windows.Forms.CheckedListBox chklistRight;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
    }
}

