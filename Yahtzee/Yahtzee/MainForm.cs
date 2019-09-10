/*
 * Created by SharpDevelop.
 * User: OM
 * Date: 4/9/2012
 * Time: 1:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Yahtzee
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 		
	/// 
	public partial class MainForm : Form
	{
   		const int _birler =0;
  		const int _ikiler =1;
  		const int _ucler  =2;
  		const int _dortler=3;
  		const int _besler =4;
  		const int _altilar=5;
  		const int _araTop =6;
  		const int _bonus  =7;
  		const int _3Turdes=8;
  		const int _4Turdes=9;
  		const int _doluEv =10;
  		const int _darS   =11;
  		const int _genisS =12;
  		const int _yahtzee=13;
  		const int _sans   =14;
  		const int _toplam =15;
		
		public bool ZarAt;
    	int zarAnim;
    	int[] zarlar = new int[5] {1,1,1,1,1};
    	int iZarSay;
    	//int OyuncuSay;
   		int Siradaki;

		int[][] Tablo = new int[3][]
		{
		    new int[] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
		    new int[] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
		    new int[] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}
		};


		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
/*		
		void deneme(){
			
		}
*/		
		void ButonlarDiz(){
		  
/*    
?: conditional operator.
classify = (input < 0) ? "negative" : "positive";
if(x != 0.0) s = Math.Sin(x)/x; else s = 1.0;

or, using the conditional operator,


Copy
 s = x != 0.0 ? Math.Sin(x)/x : 1.0;

*/
			Siradaki = 1;
			btn1.Enabled =  Tablo[Siradaki][_birler] == -1 ? true : false;
			btn2.Enabled =  Tablo[Siradaki][_ikiler] == -1 ? true : false;
			btn3.Enabled =  Tablo[Siradaki][_ucler] == -1 ? true : false;
			btn4.Enabled =  Tablo[Siradaki][_dortler] == -1 ? true : false;
			btn5.Enabled =  Tablo[Siradaki][_besler] == -1 ? true : false;
			btn6.Enabled =  Tablo[Siradaki][_altilar] == -1 ? true : false;

			
			btn3turdes.Enabled =  Tablo[Siradaki][_3Turdes] == -1 ? true : false;
			btn4turdes.Enabled =  Tablo[Siradaki][_4Turdes] == -1 ? true : false;
			btnDoluEv.Enabled =  Tablo[Siradaki][_doluEv] == -1 ? true : false;
			btnDarSokak.Enabled =  Tablo[Siradaki][_darS] == -1 ? true : false;
			btnGenisSokak.Enabled =  Tablo[Siradaki][_genisS] == -1 ? true : false;
			btnYahtzee.Enabled =  Tablo[Siradaki][_yahtzee] == -1 ? true : false;
			btnSans.Enabled =  Tablo[Siradaki][_sans] == -1 ? true : false;

		}
   
		
		int TurdesSay(int hane){	
			int sonuc = 0;
			int say=0;
			
			for (int z = 1; z <= 6; z++) {
				say = 0;
				
				for (int i = 0; i <= 4; i++) {
					if (zarlar[i] == z) {
						say++;
					}
				}
				
				if (say >= hane) {
					sonuc = say;
				}
				
			}
						
			return sonuc;
		}

		
		int ZarlarToplam(){
			int t = 0;			
			for (int i = 0; i <= 4; i++) {
				t = t + zarlar[i];
			}
			return t;
		}

		int EnCokBitisik(){
			int say = 0;
			int sonuc = 0;
			char[] s = new char[6] {'-','-','-','-','-','-'};
			
			for (int i = 0; i <= 4; i++) {
				s[(zarlar[i])-1] = '+';
			}
			

			/*
 		     *      -++++-
    	     *      --++++
    	     *      ++++-+
    	     *      +-++++
    	     */
        
		  	//en cok bitisik zarlar toplami=resume
		  	for (int i = 0; i <= 5; i++) {
		  		if (s[i]=='+') {
		  			say++;
		  		}
		  		else {
		  			say=0;
		  		}
		  		
		  		if (say>sonuc) {
		  			
		  			sonuc = say;
		  		}
		  	}
		  	
			return sonuc;		  	
		}
		
		
		int DoluEv(){
			int aSay = 1;
			int aDeg = zarlar[0];
			int bSay = 0;
			int bDeg = 0;
			int sonuc=0;

			for (int i = 1; i <= 4; i++) {
				if (bSay==0 && aDeg!=zarlar[i]) {
				    bDeg = zarlar[i];
				}
				
				if (zarlar[i]==aDeg) {
					aSay++;
				}
				
				if (zarlar[i]==bDeg) {
					bSay++;
				}
			}

 			//iki turun toplamlari 5 ve farklari 3 degilse (4 1 gibi)
 			if  (((aSay+bSay)==5 )&&(   (Math.Abs(aSay-bSay)!=3)   )) {
 				sonuc = 25;
 			}
        return sonuc;
		}

		//muhakkak return olmali yoksa hata veriyor
		int RakamTop(int hane){
			int sonuc = 0;
			for (int i = 0; i <= 4; i++) {
				if (zarlar[i]==hane) {
					sonuc = sonuc + hane;
				}
			}
			return sonuc;
		}


		void Yazdirilabilirler(){
			if (!chkAcemiyim.Checked) {
				return;
			}

			lbl1.Text = Convert.ToString(RakamTop(1));
			lbl2.Text = Convert.ToString(RakamTop(2));
			lbl3.Text = Convert.ToString(RakamTop(3));
			lbl4.Text = Convert.ToString(RakamTop(4));
			lbl5.Text = Convert.ToString(RakamTop(5));
			lbl6.Text = Convert.ToString(RakamTop(6));

            if (TurdesSay(3)>=3) {
				lbl3Turdes.Text = Convert.ToString(ZarlarToplam());
			} else {
				lbl3Turdes.Text = "0";
			}
			
            if (TurdesSay(4)>=4) {
				lbl4Turdes.Text = Convert.ToString(ZarlarToplam());
			} else {
				lbl4Turdes.Text = "0";
			}

			lblDoluEv.Text = Convert.ToString(DoluEv());

			if (EnCokBitisik()>=4) {
				lblDarSokak.Text = "30";
			} else {
				lblDarSokak.Text = "0";
			}
			

			if (EnCokBitisik()>=5) {
				lblGenisSokak.Text = "40";
			} else {
				lblGenisSokak.Text = "0";
			}			
			
			if (TurdesSay(5)>=5) {
				lblYahtzee.Text = "50";
			} else {
				lblYahtzee.Text = "0";
			}
			
			lblSans.Text = Convert.ToString(ZarlarToplam());
			
		}


		
		void TabloYaz(){
		    int c=1;
			int araTop = 0;
			int toplam = 0;

            string gizle(string s)
            {
                if (s == "-1") s = "";
                return s;
            }

            for (int r = 0; r <= 14; r++) {

				if (r<=5 && Tablo[c][r]!=-1) {
					araTop = araTop + Tablo[c][r];

					if (araTop>=63) {
						Tablo[c][_bonus] = 35;
					}
					
				}
								
				if (Tablo[c][r]!=-1) {
					toplam = toplam + Tablo[c][r];
				}

			}

            //lstYazBoz.Items[_araTop] = Convert.ToString(araTop);
            //lstYazBoz.Items[_toplam] = Convert.ToString(toplam);


            lbl_1.Text       = gizle(Convert.ToString(Tablo[c][_birler]));
            lbl_2.Text       = gizle(Convert.ToString(Tablo[c][_ikiler]));
            lbl_3.Text       = gizle(Convert.ToString(Tablo[c][_ucler]));
            lbl_4.Text       = gizle(Convert.ToString(Tablo[c][_dortler]));
            lbl_5.Text       = gizle(Convert.ToString(Tablo[c][_besler]));
            lbl_6.Text       = gizle(Convert.ToString(Tablo[c][_altilar]));
            lbl_araTop.Text  = gizle(Convert.ToString(araTop));
            lbl_bonus.Text   = gizle(Convert.ToString(Tablo[c][_bonus]));
            lbl_3turdes.Text = gizle(Convert.ToString(Tablo[c][_3Turdes]));
            lbl_4turdes.Text = gizle(Convert.ToString(Tablo[c][_4Turdes]));
            lbl_doluEv.Text  = gizle(Convert.ToString(Tablo[c][_doluEv]));
            lbl_darS.Text    = gizle(Convert.ToString(Tablo[c][_darS]));
            lbl_genisS.Text  = gizle(Convert.ToString(Tablo[c][_genisS]));
            lbl_yahtzee.Text = gizle(Convert.ToString(Tablo[c][_yahtzee]));
            lbl_sans.Text    = gizle(Convert.ToString(Tablo[c][_sans]));
            lbl_toplam.Text  = gizle(Convert.ToString(toplam));


        }


        void Button15Click(object sender, EventArgs e)
		{
			frmAbout frmAbout = new frmAbout();
		    frmAbout.Show();			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			/*
		  for (int o = 1; o < 3; o++) 
		  	for (int p = 1; p < 16; p++)
		  	   Tablo[o][p]=-1;
*/
		  
		  
  		  //frmOyuncular.ShowModal;

 		  ZarAt = true;
  		  Siradaki = 1;
  		  //OyuncuSay = 1;
  		  /*
  		  lblOyuncu1.Caption := frmOyuncular.txtOyuncu1.Text;
  		  lblOyuncu2.Caption := frmOyuncular.txtOyuncu2.Text;
		  lblOyuncu3.Caption := frmOyuncular.txtOyuncu3.Text;

		  if frmOyuncular.txtOyuncu2.Text<>'' then
 			OyuncuSay :=2;

		  if frmOyuncular.txtOyuncu3.Text<>'' then
			OyuncuSay :=3;
    */   
		}
		
		void BtnSallaClick(object sender, EventArgs e)
		{
			iZarSay++;
  			ZarAt = false; 

  			lblZarSay.Text = Convert.ToString(iZarSay);
  			
  			btnSalla.Enabled = false;
  			tmrZarlar.Enabled = true; 	
			
		}
		
		void TmrZarlarTick(object sender, EventArgs e)
		{
			Random randObj = new Random();

			if (!lblKalsin1.Visible) zarlar[0] = randObj.Next(6)+1;
			if (!lblKalsin2.Visible) zarlar[1] = randObj.Next(6)+1;
			if (!lblKalsin3.Visible) zarlar[2] = randObj.Next(6)+1;
			if (!lblKalsin4.Visible) zarlar[3] = randObj.Next(6)+1;
			if (!lblKalsin5.Visible) zarlar[4] = randObj.Next(6)+1;

			lblZar1.ImageIndex = zarlar[0]-1;
			lblZar2.ImageIndex = zarlar[1]-1;
			lblZar3.ImageIndex = zarlar[2]-1;
			lblZar4.ImageIndex = zarlar[3]-1;
			lblZar5.ImageIndex = zarlar[4]-1;

			zarAnim++;
			
			if (zarAnim>10) {
				zarAnim = 0;
				tmrZarlar.Enabled = false;
				if (iZarSay<3) {
					btnSalla.Enabled = true;
				}
				Yazdirilabilirler();
			}
		}
		
		
		void btnTuslar(object sender, EventArgs e)
		{
			if (ZarAt) {
				MessageBox.Show("El yazdirin, Zar atmanız gerekiyor");
				return;
			}

			ZarAt = true;
			Siradaki = 1;
			if (sender==btn1) Tablo[Siradaki][_birler] = RakamTop(1);
			if (sender==btn2) Tablo[Siradaki][_ikiler] = RakamTop(2);
			if (sender==btn3) Tablo[Siradaki][_ucler] = RakamTop(3);
			if (sender==btn4) Tablo[Siradaki][_dortler] = RakamTop(4);
			if (sender==btn5) Tablo[Siradaki][_besler] = RakamTop(5);
		 	if (sender==btn6) Tablo[Siradaki][_altilar] = RakamTop(6);

			//3 Turdes, Zarlarin toplami
			if (sender==btn3turdes) {
				if (TurdesSay(3)>=3) {
					Tablo[Siradaki][_3Turdes] = ZarlarToplam();
				} else {
					Tablo[Siradaki][_3Turdes] = 0;
					
				}
			}

			//4 Turdes, Zarlarin toplami
			if (sender==btn4turdes) {
				if (TurdesSay(4)>=4) {
					Tablo[Siradaki][_4Turdes] = ZarlarToplam();
				} else {
					Tablo[Siradaki][_4Turdes] = 0;
					
				}
			}

			
			//Dolu ev, 25 puan
			if (sender==btnDoluEv) {
				Tablo[Siradaki][_doluEv] = DoluEv();
			}

			
			//Dar sokak, 30 puan
			if (sender==btnDarSokak) {
				if (EnCokBitisik()>=4) {
					Tablo[Siradaki][_darS] = 30;
				} else {
					Tablo[Siradaki][_darS] = 0;
				}
			}
			
			
			//Genis sokak, 40 puan
			if (sender==btnGenisSokak) {
				if (EnCokBitisik()==5 ) {
					Tablo[Siradaki][_genisS] = 40;
				} else {
					Tablo[Siradaki][_genisS] = 0;
				}
			}
			
			
			//5 Turdes Yahtzee, 50 puan
			if (sender==btnYahtzee) {
				if (TurdesSay(5)>=5) {
					Tablo[Siradaki][_yahtzee] = 50;
				} else {
					Tablo[Siradaki][_yahtzee] = 0;
				}
			}


			//Sans, Zarlarin Toplami
			if (sender==btnSans) {
				Tablo[Siradaki][_sans] = ZarlarToplam();
			}
			
			
  			lblKalsin1.Visible = false;
  			lblKalsin2.Visible = false;
  			lblKalsin3.Visible = false;
  			lblKalsin4.Visible = false;
  			lblKalsin5.Visible = false;

  			TabloYaz();
/*
  if Siradaki>=OyuncuSay then
    Siradaki:=1
  else
    inc(Siradaki);
*/
			ButonlarDiz();

//  lblOyuncu1.Transparent := Siradaki<>1;
//  lblOyuncu2.Transparent := Siradaki<>2;
//  lblOyuncu3.Transparent := Siradaki<>3;

  			iZarSay = 0;
  			btnSalla.Enabled = true;
  			lblZarSay.Text = "Tekrar zar atin";       
		}
		
		
		void lblZarClick(object sender, EventArgs e)
		{
		  	//ilk el zar tutma olmaz
			if (iZarSay==0) {
				return;
			}
			
		  	
			if (sender==lblZar1) lblKalsin1.Visible = ! lblKalsin1.Visible;
			if (sender==lblZar2) lblKalsin2.Visible = ! lblKalsin2.Visible;
			if (sender==lblZar3) lblKalsin3.Visible = ! lblKalsin3.Visible;
			if (sender==lblZar4) lblKalsin4.Visible = ! lblKalsin4.Visible;
			if (sender==lblZar5) lblKalsin5.Visible = ! lblKalsin5.Visible;
		  				
		}
		
		void ChkAcemiyimCheckedChanged(object sender, EventArgs e)
		{
			if (chkAcemiyim.Checked) {
				Yazdirilabilirler();
			}

			lbl1.Visible = chkAcemiyim.Checked;
  			lbl2.Visible = chkAcemiyim.Checked;
  			lbl3.Visible = chkAcemiyim.Checked;
  			lbl4.Visible = chkAcemiyim.Checked;
  			lbl5.Visible = chkAcemiyim.Checked;
  			lbl6.Visible = chkAcemiyim.Checked;

  			lbl3Turdes.Visible    = chkAcemiyim.Checked;
  			lbl4Turdes.Visible    = chkAcemiyim.Checked;
  			lblDoluEv.Visible     = chkAcemiyim.Checked;
  			lblDarSokak.Visible   = chkAcemiyim.Checked;
  			lblGenisSokak.Visible = chkAcemiyim.Checked;
  			lblYahtzee.Visible    = chkAcemiyim.Checked;
  			lblSans.Visible       = chkAcemiyim.Checked;
		}
		
	}
}
