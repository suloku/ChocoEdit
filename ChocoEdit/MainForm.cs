﻿/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 01/03/2016
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChocoEdit
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		public string mcsfilter = "PSXGameEdit single save|*.mcs|All Files (*.*)|*.*";
		public byte[] savebuffer;
		public byte[] ff8buffer;
		public UInt32 ff8ID;
		public static Choco save;

		void MainScreenDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}
		void MainScreenDragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			load_savegame(files[0]);
		}
		void Loadsave_butClick(object sender, EventArgs e)
		{
			load_savegame(null);
		}
		void load_savegame(string filepath)
		{
			string path = filepath;
			int filesize = FileIO.load_file(ref savebuffer, ref path, mcsfilter);
			versiontext.Text = "";

			if( filesize == Choco.SIZE )
			{
				savegamename.Text = path;
				save = new Choco(savebuffer);
			
					versiontext.Text = "PSX";
					save_but.Enabled = true;
					
					load_data();
				
			}else{
				MessageBox.Show("Invalid file.");
				savegamename.Text = "";
				save_but.Enabled = false;
			}
		}
		void Save_butClick(object sender, EventArgs e)
		{
			save_data();
			FileIO.save_file(save.Data, mcsfilter);
		}
		void SavegamenameTextChanged(object sender, EventArgs e)
		{

		}
		void AboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("Chocobo World Editor 0.1 by suloku");
		}
		void load_data()
		{
			hp_curr.Value = save.HP_cur;
			hp_max.Value = save.HP_max;
			
			level.Value = save.level;
			rank.Value = save.rank;
			powerups.Value = save.Powerups;
			
			weapon_hi.Value = save.weapon_first;
			weapon_lo.Value = save.weapon_last;
			id_hi.Value = save.ID_HI;
			id_lo.Value = save.ID_low;
			
			ff8_id.Text = save.FF8ID.ToString("X");
			
			item_a.Value = save.ITEM_A;
			item_b.Value = save.ITEM_B;
			item_c.Value = save.ITEM_C;
			item_d.Value = save.ITEM_D;
			
			//Flags
			flag0.Checked = save.Eventflag0;
			flag1.Checked = save.Away;
			mogu_found.Checked = save.MoguFound;
			mogu_have.Checked = save.MoguHave;
			mogu_standby.Checked = save.MoguStandby;
			demon_defeat.Checked = save.DemonDefeated;
			lvlevent.Checked = save.LvlEvent;
			event_wait.Checked = save.EventWait;
		}
		void save_data()
		{
			save.HP_cur = (int)hp_curr.Value;
			//save.HP_max = (int)hp_max.Value;
			
			save.level = (int)level.Value;
		 	save.rank = (int)rank.Value;
			save.Powerups = (int)powerups.Value;
			
			save.weapon_first = (int)weapon_hi.Value;
			save.weapon_last = (int)weapon_lo.Value;
			save.ID_HI = (int)id_hi.Value;
			save.ID_low = (int)id_lo.Value;
			
			//ff8_id.Text = save.FF8ID.ToString("X");
			
			save.ITEM_A = (int)item_a.Value;
			save.ITEM_B = (int)item_b.Value;
			save.ITEM_C = (int)item_c.Value;
			save.ITEM_D = (int)item_d.Value;
			
			//Flags
			//save.Eventflag0 = flag0.Checked;
			//save.Away = flag1.Checked;
			save.MoguFound = mogu_found.Checked;
			save.MoguHave = mogu_have.Checked;
			save.MoguStandby = mogu_standby.Checked;
			save.DemonDefeated = demon_defeat.Checked;
			save.LvlEvent = lvlevent.Checked;
			save.EventWait = event_wait.Checked;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Hp_currValueChanged(object sender, EventArgs e)
		{
			if (hp_curr.Value > save.HP_max) hp_curr.Value = save.HP_max;
		}
		void Ff8id_setClick(object sender, EventArgs e)
		{
			string path = null;
			int filesize = FileIO.load_file(ref ff8buffer, ref path, mcsfilter);
			versiontext.Text = "";

			if( filesize == 8320 )
			{
				ff8ID = BitConverter.ToUInt32(ff8buffer, 0x1588);
				save.FF8ID = ff8ID;
				
				ff8_id.Text = save.FF8ID.ToString("X");
				
			}else{
				MessageBox.Show("Invalid file.");
			}
		}
		void About_rankClick(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Rank---Max.----Max.-------Probability-of-item----#ID----ID"+
				"\n--##----HP---Weapon------A----B-----C-----D-----------Requirement"+
				"\n----------------------------------------------------------------------"+
				"\n--00-----41-----9999------25%--25%--25%--25%-----1---211"+
				"\n--01-----37-----9998-------5%--35%--30%--30%-----3---000,0008,777"+
				"\n--02-----35-----9898-------4%--10%--46%--40%-----8---All-digits-the-same"+
				"\n--03-----34-----9888-------3%--10%--37%--50%-----9---Ending-in-00"+
				"\n--04-----33-----9698-------2%--10%--28%--60%-----9---Ending-in-77"+
				"\n--05-----32-----9698-------0%?--5%--25%--70%----90---Ending-in-7"+
				"\n--06-----31-----9698?------0%---5%--15%--80%---880---Any-other-number"
			);
		}
		void About_flagsClick(object sender, EventArgs e)
		{
			MessageBox.Show("About Level event happened:\n"
				+"Events happen at level 20, 50 (Boko PowerUp), 75, 100. I guess it is unset after every level up. Needs to be set to be able to battle the Demon King at level 100 (and Demon King defeated flag needs to be unset)"
				+"\n\nAbout Mogu found flag:"
				+"\nIn normal gameplay you can only encounter Mogu after reaching level 10. If you set this before level 10 you can encounter mogu even at level 1."
			);
		}
	}
}