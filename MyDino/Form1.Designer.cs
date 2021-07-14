
namespace MyDino
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
            this.picDino = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerJump = new System.Windows.Forms.Timer(this.components);
            this.timerRoad = new System.Windows.Forms.Timer(this.components);
            this.picTree = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).BeginInit();
            this.SuspendLayout();
            // 
            // picDino
            // 
            this.picDino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picDino.Image = global::MyDino.Properties.Resources.running;
            this.picDino.Location = new System.Drawing.Point(12, 169);
            this.picDino.Name = "picDino";
            this.picDino.Size = new System.Drawing.Size(85, 88);
            this.picDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDino.TabIndex = 0;
            this.picDino.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 1;
            // 
            // timerJump
            // 
            this.timerJump.Tick += new System.EventHandler(this.timerJump_Tick);
            // 
            // timerRoad
            // 
            this.timerRoad.Tick += new System.EventHandler(this.timerRoad_Tick);
            // 
            // picTree
            // 
            this.picTree.Image = global::MyDino.Properties.Resources.obstacle_1;
            this.picTree.Location = new System.Drawing.Point(765, 211);
            this.picTree.Name = "picTree";
            this.picTree.Size = new System.Drawing.Size(23, 46);
            this.picTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTree.TabIndex = 2;
            this.picTree.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.picTree);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picDino);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picDino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerJump;
        private System.Windows.Forms.Timer timerRoad;
        private System.Windows.Forms.PictureBox picTree;
    }
}

