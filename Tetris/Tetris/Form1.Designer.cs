namespace Tetris
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
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.drawArea = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
			this.SuspendLayout();
			// 
			// drawArea
			// 
			this.drawArea.BackColor = System.Drawing.Color.Black;
			this.drawArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drawArea.Location = new System.Drawing.Point(0, 0);
			this.drawArea.Name = "drawArea";
			this.drawArea.Size = new System.Drawing.Size(640, 480);
			this.drawArea.TabIndex = 0;
			this.drawArea.TabStop = false;
			this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.drawArea);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox drawArea;
	}
}

