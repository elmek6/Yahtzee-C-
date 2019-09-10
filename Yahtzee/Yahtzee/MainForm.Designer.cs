/*
 * Created by SharpDevelop.
 * User: OM
 * Date: 4/9/2012
 * Time: 1:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Yahtzee
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSalla = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.lblKalsin1 = new System.Windows.Forms.Label();
            this.tmrZarlar = new System.Windows.Forms.Timer(this.components);
            this.lblZar1 = new System.Windows.Forms.Label();
            this.lblZar2 = new System.Windows.Forms.Label();
            this.lblKalsin2 = new System.Windows.Forms.Label();
            this.lblZar3 = new System.Windows.Forms.Label();
            this.lblKalsin3 = new System.Windows.Forms.Label();
            this.lblZar4 = new System.Windows.Forms.Label();
            this.lblKalsin4 = new System.Windows.Forms.Label();
            this.lblZar5 = new System.Windows.Forms.Label();
            this.lblKalsin5 = new System.Windows.Forms.Label();
            this.chkAcemiyim = new System.Windows.Forms.CheckBox();
            this.lblZarSay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn3turdes = new System.Windows.Forms.Button();
            this.btn4turdes = new System.Windows.Forms.Button();
            this.btnDoluEv = new System.Windows.Forms.Button();
            this.btnDarSokak = new System.Windows.Forms.Button();
            this.btnGenisSokak = new System.Windows.Forms.Button();
            this.btnYahtzee = new System.Windows.Forms.Button();
            this.btnSans = new System.Windows.Forms.Button();
            this.lbl3Turdes = new System.Windows.Forms.Label();
            this.lbl4Turdes = new System.Windows.Forms.Label();
            this.lblDoluEv = new System.Windows.Forms.Label();
            this.lblDarSokak = new System.Windows.Forms.Label();
            this.lblGenisSokak = new System.Windows.Forms.Label();
            this.lblYahtzee = new System.Windows.Forms.Label();
            this.lblSans = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_araTop = new System.Windows.Forms.Label();
            this.lbl_bonus = new System.Windows.Forms.Label();
            this.lbl_3turdes = new System.Windows.Forms.Label();
            this.lbl_4turdes = new System.Windows.Forms.Label();
            this.lbl_doluEv = new System.Windows.Forms.Label();
            this.lbl_darS = new System.Windows.Forms.Label();
            this.lbl_genisS = new System.Windows.Forms.Label();
            this.lbl_yahtzee = new System.Windows.Forms.Label();
            this.lbl_sans = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Lime;
            this.imageList1.Images.SetKeyName(0, "ZAR1.bmp");
            this.imageList1.Images.SetKeyName(1, "ZAR2.bmp");
            this.imageList1.Images.SetKeyName(2, "ZAR3.bmp");
            this.imageList1.Images.SetKeyName(3, "ZAR4.bmp");
            this.imageList1.Images.SetKeyName(4, "ZAR5.bmp");
            this.imageList1.Images.SetKeyName(5, "ZAR6.bmp");
            this.imageList1.Images.SetKeyName(6, "ZARa.bmp");
            this.imageList1.Images.SetKeyName(7, "ZARk.bmp");
            // 
            // btnSalla
            // 
            this.btnSalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.btnSalla, 5);
            this.btnSalla.Location = new System.Drawing.Point(3, 542);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(391, 42);
            this.btnSalla.TabIndex = 14;
            this.btnSalla.Text = "Zarları salla";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.BtnSallaClick);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location = new System.Drawing.Point(82, 142);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 67);
            this.button15.TabIndex = 15;
            this.button15.Text = "Yahtzee nedir ?";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15Click);
            // 
            // lblKalsin1
            // 
            this.lblKalsin1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKalsin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKalsin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalsin1.Location = new System.Drawing.Point(3, 510);
            this.lblKalsin1.Name = "lblKalsin1";
            this.lblKalsin1.Size = new System.Drawing.Size(73, 20);
            this.lblKalsin1.TabIndex = 16;
            this.lblKalsin1.Text = "KALSIN";
            this.lblKalsin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKalsin1.Visible = false;
            // 
            // tmrZarlar
            // 
            this.tmrZarlar.Interval = 50;
            this.tmrZarlar.Tick += new System.EventHandler(this.TmrZarlarTick);
            // 
            // lblZar1
            // 
            this.lblZar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZar1.ImageIndex = 6;
            this.lblZar1.ImageList = this.imageList1;
            this.lblZar1.Location = new System.Drawing.Point(3, 352);
            this.lblZar1.Name = "lblZar1";
            this.lblZar1.Size = new System.Drawing.Size(73, 150);
            this.lblZar1.TabIndex = 17;
            this.lblZar1.Click += new System.EventHandler(this.lblZarClick);
            // 
            // lblZar2
            // 
            this.lblZar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZar2.ImageIndex = 6;
            this.lblZar2.ImageList = this.imageList1;
            this.lblZar2.Location = new System.Drawing.Point(82, 352);
            this.lblZar2.Name = "lblZar2";
            this.lblZar2.Size = new System.Drawing.Size(73, 150);
            this.lblZar2.TabIndex = 19;
            this.lblZar2.Click += new System.EventHandler(this.lblZarClick);
            // 
            // lblKalsin2
            // 
            this.lblKalsin2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKalsin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKalsin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalsin2.Location = new System.Drawing.Point(82, 510);
            this.lblKalsin2.Name = "lblKalsin2";
            this.lblKalsin2.Size = new System.Drawing.Size(73, 20);
            this.lblKalsin2.TabIndex = 18;
            this.lblKalsin2.Text = "KALSIN";
            this.lblKalsin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKalsin2.Visible = false;
            // 
            // lblZar3
            // 
            this.lblZar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZar3.ImageIndex = 6;
            this.lblZar3.ImageList = this.imageList1;
            this.lblZar3.Location = new System.Drawing.Point(161, 352);
            this.lblZar3.Name = "lblZar3";
            this.lblZar3.Size = new System.Drawing.Size(73, 150);
            this.lblZar3.TabIndex = 21;
            this.lblZar3.Click += new System.EventHandler(this.lblZarClick);
            // 
            // lblKalsin3
            // 
            this.lblKalsin3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKalsin3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKalsin3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalsin3.Location = new System.Drawing.Point(161, 510);
            this.lblKalsin3.Name = "lblKalsin3";
            this.lblKalsin3.Size = new System.Drawing.Size(73, 20);
            this.lblKalsin3.TabIndex = 20;
            this.lblKalsin3.Text = "KALSIN";
            this.lblKalsin3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKalsin3.Visible = false;
            // 
            // lblZar4
            // 
            this.lblZar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZar4.ImageIndex = 6;
            this.lblZar4.ImageList = this.imageList1;
            this.lblZar4.Location = new System.Drawing.Point(240, 352);
            this.lblZar4.Name = "lblZar4";
            this.lblZar4.Size = new System.Drawing.Size(73, 150);
            this.lblZar4.TabIndex = 23;
            this.lblZar4.Click += new System.EventHandler(this.lblZarClick);
            // 
            // lblKalsin4
            // 
            this.lblKalsin4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKalsin4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKalsin4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalsin4.Location = new System.Drawing.Point(240, 510);
            this.lblKalsin4.Name = "lblKalsin4";
            this.lblKalsin4.Size = new System.Drawing.Size(73, 20);
            this.lblKalsin4.TabIndex = 22;
            this.lblKalsin4.Text = "KALSIN";
            this.lblKalsin4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKalsin4.Visible = false;
            // 
            // lblZar5
            // 
            this.lblZar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZar5.ImageIndex = 6;
            this.lblZar5.ImageList = this.imageList1;
            this.lblZar5.Location = new System.Drawing.Point(319, 352);
            this.lblZar5.Name = "lblZar5";
            this.lblZar5.Size = new System.Drawing.Size(75, 150);
            this.lblZar5.TabIndex = 25;
            this.lblZar5.Click += new System.EventHandler(this.lblZarClick);
            // 
            // lblKalsin5
            // 
            this.lblKalsin5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKalsin5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKalsin5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalsin5.Location = new System.Drawing.Point(319, 510);
            this.lblKalsin5.Name = "lblKalsin5";
            this.lblKalsin5.Size = new System.Drawing.Size(75, 20);
            this.lblKalsin5.TabIndex = 24;
            this.lblKalsin5.Text = "KALSIN";
            this.lblKalsin5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKalsin5.Visible = false;
            // 
            // chkAcemiyim
            // 
            this.chkAcemiyim.Location = new System.Drawing.Point(240, 3);
            this.chkAcemiyim.Name = "chkAcemiyim";
            this.chkAcemiyim.Size = new System.Drawing.Size(68, 23);
            this.chkAcemiyim.TabIndex = 29;
            this.chkAcemiyim.Text = "Acemiyim";
            this.chkAcemiyim.UseVisualStyleBackColor = true;
            this.chkAcemiyim.CheckedChanged += new System.EventHandler(this.ChkAcemiyimCheckedChanged);
            // 
            // lblZarSay
            // 
            this.lblZarSay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZarSay.Location = new System.Drawing.Point(3, 0);
            this.lblZarSay.Name = "lblZarSay";
            this.lblZarSay.Size = new System.Drawing.Size(68, 23);
            this.lblZarSay.TabIndex = 30;
            this.lblZarSay.Text = "0";
            this.lblZarSay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn3turdes, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btn4turdes, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnDoluEv, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnDarSokak, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnGenisSokak, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnYahtzee, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.btnSans, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.lbl3Turdes, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl4Turdes, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblDoluEv, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblDarSokak, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblGenisSokak, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblYahtzee, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblSans, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_araTop, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_bonus, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_3turdes, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_4turdes, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_doluEv, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_darS, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_genisS, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.lbl_yahtzee, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sans, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.lbl_toplam, 2, 15);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(406, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 588);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2.Location = new System.Drawing.Point(3, 39);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 29);
            this.lbl2.TabIndex = 33;
            this.lbl2.Text = "0";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl3.Location = new System.Drawing.Point(3, 75);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(44, 29);
            this.lbl3.TabIndex = 34;
            this.lbl3.Text = "0";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl4.Location = new System.Drawing.Point(3, 111);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(44, 29);
            this.lbl4.TabIndex = 35;
            this.lbl4.Text = "0";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl5.Location = new System.Drawing.Point(3, 147);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(44, 29);
            this.lbl5.TabIndex = 36;
            this.lbl5.Text = "0";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl6.Location = new System.Drawing.Point(3, 183);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(44, 29);
            this.lbl6.TabIndex = 37;
            this.lbl6.Text = "0";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.Location = new System.Drawing.Point(53, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(186, 26);
            this.btn1.TabIndex = 38;
            this.btn1.Text = "Birler";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.Location = new System.Drawing.Point(53, 41);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(186, 26);
            this.btn2.TabIndex = 39;
            this.btn2.Text = "İkiler";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.Location = new System.Drawing.Point(53, 77);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(186, 26);
            this.btn3.TabIndex = 40;
            this.btn3.Text = "Üçler";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.Location = new System.Drawing.Point(53, 113);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(186, 26);
            this.btn4.TabIndex = 41;
            this.btn4.Text = "Dörtler";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5.Location = new System.Drawing.Point(53, 149);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(186, 26);
            this.btn5.TabIndex = 42;
            this.btn5.Text = "Beşler";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.Location = new System.Drawing.Point(53, 185);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(186, 26);
            this.btn6.TabIndex = 43;
            this.btn6.Text = "Altılar";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnTuslar);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(53, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ara toplam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(53, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Bonus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "Tek hanelerin toplami 63ten büyükse 35 bonus puan");
            // 
            // btn3turdes
            // 
            this.btn3turdes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3turdes.Location = new System.Drawing.Point(53, 293);
            this.btn3turdes.Name = "btn3turdes";
            this.btn3turdes.Size = new System.Drawing.Size(186, 26);
            this.btn3turdes.TabIndex = 47;
            this.btn3turdes.Text = "Üç türdeş";
            this.btn3turdes.UseVisualStyleBackColor = true;
            this.btn3turdes.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btn4turdes
            // 
            this.btn4turdes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4turdes.Location = new System.Drawing.Point(53, 329);
            this.btn4turdes.Name = "btn4turdes";
            this.btn4turdes.Size = new System.Drawing.Size(186, 26);
            this.btn4turdes.TabIndex = 48;
            this.btn4turdes.Text = "Dört türdeş";
            this.btn4turdes.UseVisualStyleBackColor = true;
            this.btn4turdes.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btnDoluEv
            // 
            this.btnDoluEv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoluEv.Location = new System.Drawing.Point(53, 365);
            this.btnDoluEv.Name = "btnDoluEv";
            this.btnDoluEv.Size = new System.Drawing.Size(186, 26);
            this.btnDoluEv.TabIndex = 49;
            this.btnDoluEv.Text = "Dolu ev";
            this.btnDoluEv.UseVisualStyleBackColor = true;
            this.btnDoluEv.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btnDarSokak
            // 
            this.btnDarSokak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDarSokak.Location = new System.Drawing.Point(53, 401);
            this.btnDarSokak.Name = "btnDarSokak";
            this.btnDarSokak.Size = new System.Drawing.Size(186, 26);
            this.btnDarSokak.TabIndex = 50;
            this.btnDarSokak.Text = "Dar sokak";
            this.btnDarSokak.UseVisualStyleBackColor = true;
            this.btnDarSokak.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btnGenisSokak
            // 
            this.btnGenisSokak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenisSokak.Location = new System.Drawing.Point(53, 437);
            this.btnGenisSokak.Name = "btnGenisSokak";
            this.btnGenisSokak.Size = new System.Drawing.Size(186, 26);
            this.btnGenisSokak.TabIndex = 51;
            this.btnGenisSokak.Text = "Geniş sokak";
            this.btnGenisSokak.UseVisualStyleBackColor = true;
            this.btnGenisSokak.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btnYahtzee
            // 
            this.btnYahtzee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYahtzee.Location = new System.Drawing.Point(53, 473);
            this.btnYahtzee.Name = "btnYahtzee";
            this.btnYahtzee.Size = new System.Drawing.Size(186, 26);
            this.btnYahtzee.TabIndex = 52;
            this.btnYahtzee.Text = "Yahtzee";
            this.btnYahtzee.UseVisualStyleBackColor = true;
            this.btnYahtzee.Click += new System.EventHandler(this.btnTuslar);
            // 
            // btnSans
            // 
            this.btnSans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSans.Location = new System.Drawing.Point(53, 509);
            this.btnSans.Name = "btnSans";
            this.btnSans.Size = new System.Drawing.Size(186, 26);
            this.btnSans.TabIndex = 53;
            this.btnSans.Text = "Şans";
            this.btnSans.UseVisualStyleBackColor = true;
            this.btnSans.Click += new System.EventHandler(this.btnTuslar);
            // 
            // lbl3Turdes
            // 
            this.lbl3Turdes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl3Turdes.Location = new System.Drawing.Point(3, 291);
            this.lbl3Turdes.Name = "lbl3Turdes";
            this.lbl3Turdes.Size = new System.Drawing.Size(44, 29);
            this.lbl3Turdes.TabIndex = 54;
            this.lbl3Turdes.Text = "0";
            this.lbl3Turdes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4Turdes
            // 
            this.lbl4Turdes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl4Turdes.Location = new System.Drawing.Point(3, 327);
            this.lbl4Turdes.Name = "lbl4Turdes";
            this.lbl4Turdes.Size = new System.Drawing.Size(44, 29);
            this.lbl4Turdes.TabIndex = 55;
            this.lbl4Turdes.Text = "0";
            this.lbl4Turdes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoluEv
            // 
            this.lblDoluEv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoluEv.Location = new System.Drawing.Point(3, 363);
            this.lblDoluEv.Name = "lblDoluEv";
            this.lblDoluEv.Size = new System.Drawing.Size(44, 29);
            this.lblDoluEv.TabIndex = 56;
            this.lblDoluEv.Text = "0";
            this.lblDoluEv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDarSokak
            // 
            this.lblDarSokak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDarSokak.Location = new System.Drawing.Point(3, 399);
            this.lblDarSokak.Name = "lblDarSokak";
            this.lblDarSokak.Size = new System.Drawing.Size(44, 29);
            this.lblDarSokak.TabIndex = 57;
            this.lblDarSokak.Text = "0";
            this.lblDarSokak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenisSokak
            // 
            this.lblGenisSokak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenisSokak.Location = new System.Drawing.Point(3, 435);
            this.lblGenisSokak.Name = "lblGenisSokak";
            this.lblGenisSokak.Size = new System.Drawing.Size(44, 29);
            this.lblGenisSokak.TabIndex = 58;
            this.lblGenisSokak.Text = "0";
            this.lblGenisSokak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYahtzee
            // 
            this.lblYahtzee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYahtzee.Location = new System.Drawing.Point(3, 471);
            this.lblYahtzee.Name = "lblYahtzee";
            this.lblYahtzee.Size = new System.Drawing.Size(44, 29);
            this.lblYahtzee.TabIndex = 59;
            this.lblYahtzee.Text = "0";
            this.lblYahtzee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSans
            // 
            this.lblSans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSans.Location = new System.Drawing.Point(3, 507);
            this.lblSans.Name = "lblSans";
            this.lblSans.Size = new System.Drawing.Size(44, 29);
            this.lblSans.TabIndex = 60;
            this.lblSans.Text = "0";
            this.lblSans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(53, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Toplam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(542, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.82138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.17862F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(711, 594);
            this.tableLayoutPanel3.TabIndex = 49;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnSalla, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.chkAcemiyim, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblZarSay, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblKalsin1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblKalsin2, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblZar5, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblKalsin3, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblZar4, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblKalsin5, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblZar3, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblKalsin4, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblZar2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblZar1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.button15, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(397, 588);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.Location = new System.Drawing.Point(3, 3);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 29);
            this.lbl1.TabIndex = 32;
            this.lbl1.Text = "0";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_1
            // 
            this.lbl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_1.Location = new System.Drawing.Point(245, 3);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(54, 29);
            this.lbl_1.TabIndex = 62;
            this.lbl_1.Text = "0";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_2
            // 
            this.lbl_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_2.Location = new System.Drawing.Point(245, 39);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(54, 29);
            this.lbl_2.TabIndex = 63;
            this.lbl_2.Text = "0";
            this.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_3
            // 
            this.lbl_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_3.Location = new System.Drawing.Point(245, 75);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(54, 29);
            this.lbl_3.TabIndex = 64;
            this.lbl_3.Text = "0";
            this.lbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_4
            // 
            this.lbl_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_4.Location = new System.Drawing.Point(245, 111);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(54, 29);
            this.lbl_4.TabIndex = 65;
            this.lbl_4.Text = "0";
            this.lbl_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_5
            // 
            this.lbl_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_5.Location = new System.Drawing.Point(245, 147);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(54, 29);
            this.lbl_5.TabIndex = 66;
            this.lbl_5.Text = "0";
            this.lbl_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_6
            // 
            this.lbl_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_6.Location = new System.Drawing.Point(245, 183);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(54, 29);
            this.lbl_6.TabIndex = 67;
            this.lbl_6.Text = "0";
            this.lbl_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_araTop
            // 
            this.lbl_araTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_araTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_araTop.Location = new System.Drawing.Point(245, 219);
            this.lbl_araTop.Name = "lbl_araTop";
            this.lbl_araTop.Size = new System.Drawing.Size(54, 29);
            this.lbl_araTop.TabIndex = 68;
            this.lbl_araTop.Text = "0";
            this.lbl_araTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_bonus
            // 
            this.lbl_bonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bonus.Location = new System.Drawing.Point(245, 255);
            this.lbl_bonus.Name = "lbl_bonus";
            this.lbl_bonus.Size = new System.Drawing.Size(54, 29);
            this.lbl_bonus.TabIndex = 69;
            this.lbl_bonus.Text = "0";
            this.lbl_bonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_3turdes
            // 
            this.lbl_3turdes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_3turdes.Location = new System.Drawing.Point(245, 291);
            this.lbl_3turdes.Name = "lbl_3turdes";
            this.lbl_3turdes.Size = new System.Drawing.Size(54, 29);
            this.lbl_3turdes.TabIndex = 70;
            this.lbl_3turdes.Text = "0";
            this.lbl_3turdes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_4turdes
            // 
            this.lbl_4turdes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_4turdes.Location = new System.Drawing.Point(245, 327);
            this.lbl_4turdes.Name = "lbl_4turdes";
            this.lbl_4turdes.Size = new System.Drawing.Size(54, 29);
            this.lbl_4turdes.TabIndex = 71;
            this.lbl_4turdes.Text = "0";
            this.lbl_4turdes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_doluEv
            // 
            this.lbl_doluEv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_doluEv.Location = new System.Drawing.Point(245, 363);
            this.lbl_doluEv.Name = "lbl_doluEv";
            this.lbl_doluEv.Size = new System.Drawing.Size(54, 29);
            this.lbl_doluEv.TabIndex = 72;
            this.lbl_doluEv.Text = "0";
            this.lbl_doluEv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_darS
            // 
            this.lbl_darS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_darS.Location = new System.Drawing.Point(245, 399);
            this.lbl_darS.Name = "lbl_darS";
            this.lbl_darS.Size = new System.Drawing.Size(54, 29);
            this.lbl_darS.TabIndex = 73;
            this.lbl_darS.Text = "0";
            this.lbl_darS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_genisS
            // 
            this.lbl_genisS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_genisS.Location = new System.Drawing.Point(245, 435);
            this.lbl_genisS.Name = "lbl_genisS";
            this.lbl_genisS.Size = new System.Drawing.Size(54, 29);
            this.lbl_genisS.TabIndex = 74;
            this.lbl_genisS.Text = "0";
            this.lbl_genisS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yahtzee
            // 
            this.lbl_yahtzee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_yahtzee.Location = new System.Drawing.Point(245, 471);
            this.lbl_yahtzee.Name = "lbl_yahtzee";
            this.lbl_yahtzee.Size = new System.Drawing.Size(54, 29);
            this.lbl_yahtzee.TabIndex = 75;
            this.lbl_yahtzee.Text = "0";
            this.lbl_yahtzee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sans
            // 
            this.lbl_sans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sans.Location = new System.Drawing.Point(245, 507);
            this.lbl_sans.Name = "lbl_sans";
            this.lbl_sans.Size = new System.Drawing.Size(54, 29);
            this.lbl_sans.TabIndex = 76;
            this.lbl_sans.Text = "0";
            this.lbl_sans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toplam.Location = new System.Drawing.Point(245, 543);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(54, 29);
            this.lbl_toplam.TabIndex = 77;
            this.lbl_toplam.Text = "0";
            this.lbl_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 594);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSans;
		private System.Windows.Forms.Label lbl3Turdes;
		private System.Windows.Forms.Label lbl4Turdes;
		private System.Windows.Forms.Label lblDoluEv;
		private System.Windows.Forms.Label lblDarSokak;
		private System.Windows.Forms.Label lblGenisSokak;
		private System.Windows.Forms.Label lblYahtzee;
		private System.Windows.Forms.Label lbl6;
		private System.Windows.Forms.Label lbl5;
		private System.Windows.Forms.Label lbl4;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lblZarSay;
		private System.Windows.Forms.CheckBox chkAcemiyim;
		private System.Windows.Forms.Label lblKalsin5;
		private System.Windows.Forms.Label lblZar5;
		private System.Windows.Forms.Label lblKalsin4;
		private System.Windows.Forms.Label lblZar4;
		private System.Windows.Forms.Label lblKalsin3;
		private System.Windows.Forms.Label lblZar3;
		private System.Windows.Forms.Label lblKalsin2;
		private System.Windows.Forms.Label lblZar2;
		private System.Windows.Forms.Label lblZar1;
		private System.Windows.Forms.Timer tmrZarlar;
		private System.Windows.Forms.Label lblKalsin1;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button btnSalla;
		private System.Windows.Forms.Button btnSans;
		private System.Windows.Forms.Button btnYahtzee;
		private System.Windows.Forms.Button btnGenisSokak;
		private System.Windows.Forms.Button btnDarSokak;
		private System.Windows.Forms.Button btnDoluEv;
		private System.Windows.Forms.Button btn4turdes;
		private System.Windows.Forms.Button btn3turdes;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btn1;
		
		void ListView1SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_araTop;
        private System.Windows.Forms.Label lbl_bonus;
        private System.Windows.Forms.Label lbl_3turdes;
        private System.Windows.Forms.Label lbl_4turdes;
        private System.Windows.Forms.Label lbl_doluEv;
        private System.Windows.Forms.Label lbl_darS;
        private System.Windows.Forms.Label lbl_genisS;
        private System.Windows.Forms.Label lbl_yahtzee;
        private System.Windows.Forms.Label lbl_sans;
        private System.Windows.Forms.Label lbl_toplam;
    }
}
