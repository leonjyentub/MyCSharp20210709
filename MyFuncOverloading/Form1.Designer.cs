
namespace MyFuncOverloading
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtA.Location = new System.Drawing.Point(26, 57);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 35);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(132, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtB.Location = new System.Drawing.Point(164, 57);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 35);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblResult.Location = new System.Drawing.Point(26, 109);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 34);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 423);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblResult;
    }
}

