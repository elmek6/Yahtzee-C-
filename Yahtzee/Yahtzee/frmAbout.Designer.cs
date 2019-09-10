/*
 * Created by SharpDevelop.
 * User: OM
 * Date: 4/9/2012
 * Time: 2:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Yahtzee
{
	partial class frmAbout
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(35, 206);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(399, 96);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "Yahtzee nedir ?\n\nbla bla bla";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(35, 12);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(399, 172);
			this.webBrowser1.TabIndex = 1;
			this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 353);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "frmAbout";
			this.Text = "frmAbout";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
