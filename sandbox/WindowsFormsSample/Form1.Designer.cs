
namespace WindowsFormsSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._button1 = new System.Windows.Forms.Button();
            this._button2 = new System.Windows.Forms.Button();
            this._button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _button1
            // 
            this._button1.Location = new System.Drawing.Point(12, 12);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(75, 23);
            this._button1.TabIndex = 0;
            this._button1.Text = "button1";
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this._button1_Click);
            // 
            // _button2
            // 
            this._button2.Location = new System.Drawing.Point(12, 41);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(75, 23);
            this._button2.TabIndex = 1;
            this._button2.Text = "button2";
            this._button2.UseVisualStyleBackColor = true;
            // 
            // _button3
            // 
            this._button3.Location = new System.Drawing.Point(12, 70);
            this._button3.Name = "_button3";
            this._button3.Size = new System.Drawing.Size(75, 23);
            this._button3.TabIndex = 2;
            this._button3.Text = "button2";
            this._button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._button3);
            this.Controls.Add(this._button2);
            this.Controls.Add(this._button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _button1;
        private System.Windows.Forms.Button _button2;
        private System.Windows.Forms.Button _button3;
        private System.Windows.Forms.Button button1;
    }
}

