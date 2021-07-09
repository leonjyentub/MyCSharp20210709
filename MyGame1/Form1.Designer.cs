
namespace MyGame1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgListDices = new System.Windows.Forms.ImageList(this.components);
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListDices
            // 
            this.imgListDices.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDices.ImageStream")));
            this.imgListDices.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDices.Images.SetKeyName(0, "d1.jpg");
            this.imgListDices.Images.SetKeyName(1, "d2.jpg");
            this.imgListDices.Images.SetKeyName(2, "d3.jpg");
            this.imgListDices.Images.SetKeyName(3, "d4.jpg");
            this.imgListDices.Images.SetKeyName(4, "d5.jpg");
            this.imgListDices.Images.SetKeyName(5, "d6.jpg");
            // 
            // picDice2
            // 
            this.picDice2.Location = new System.Drawing.Point(202, 64);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(100, 100);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 0;
            this.picDice2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnStart.Location = new System.Drawing.Point(63, 249);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 48);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnStop.Location = new System.Drawing.Point(319, 249);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 48);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("新細明體", 18F);
            this.lblPoint.Location = new System.Drawing.Point(58, 194);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(73, 30);
            this.lblPoint.TabIndex = 3;
            this.lblPoint.Text = "點數";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picDice1
            // 
            this.picDice1.Location = new System.Drawing.Point(63, 64);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(100, 100);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 4;
            this.picDice1.TabStop = false;
            // 
            // picDice3
            // 
            this.picDice3.Location = new System.Drawing.Point(341, 64);
            this.picDice3.Name = "picDice3";
            this.picDice3.Size = new System.Drawing.Size(100, 100);
            this.picDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice3.TabIndex = 5;
            this.picDice3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 324);
            this.Controls.Add(this.picDice3);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picDice2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListDices;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice3;
    }
}

