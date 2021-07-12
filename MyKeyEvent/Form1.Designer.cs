
namespace MyKeyEvent
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtBox.Location = new System.Drawing.Point(43, 34);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(203, 35);
            this.txtBox.TabIndex = 0;
            this.txtBox.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnTest.Location = new System.Drawing.Point(43, 92);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(203, 63);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Enter += new System.EventHandler(this.btnTest_Enter);
            this.btnTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTest_KeyDown);
            this.btnTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnTest_KeyPress);
            this.btnTest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnTest_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 217);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnTest;
    }
}

