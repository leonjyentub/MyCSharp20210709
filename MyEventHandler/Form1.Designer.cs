
namespace MyEventHandler
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
            this.lblShow = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("新細明體", 16F);
            this.lblShow.Location = new System.Drawing.Point(40, 42);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(74, 27);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Image = global::MyEventHandler.Properties.Resources.天空;
            this.btnStart.Location = new System.Drawing.Point(26, 98);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 100);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "天空";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnTest.Image = global::MyEventHandler.Properties.Resources.水庫;
            this.btnTest.Location = new System.Drawing.Point(166, 98);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(130, 100);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "水庫";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPause.Image = global::MyEventHandler.Properties.Resources.庭園;
            this.btnPause.Location = new System.Drawing.Point(302, 98);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(130, 100);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "庭園";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Image = global::MyEventHandler.Properties.Resources.雪景;
            this.btnStop.Location = new System.Drawing.Point(438, 98);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 100);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "雪景";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

