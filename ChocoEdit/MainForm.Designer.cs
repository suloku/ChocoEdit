/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 01/03/2016
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ChocoEdit
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button loadsave_but;
		private System.Windows.Forms.TextBox savegamename;
		private System.Windows.Forms.Button save_but;
		private System.Windows.Forms.Label versiontext;
		private System.Windows.Forms.Button about;
		private System.Windows.Forms.NumericUpDown level;
		private System.Windows.Forms.NumericUpDown rank;
		private System.Windows.Forms.NumericUpDown item_a;
		private System.Windows.Forms.NumericUpDown item_b;
		private System.Windows.Forms.NumericUpDown item_d;
		private System.Windows.Forms.NumericUpDown item_c;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.NumericUpDown hp_max;
		private System.Windows.Forms.NumericUpDown hp_curr;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.NumericUpDown ID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown powerups;
		private System.Windows.Forms.TextBox ff8_id;
		private System.Windows.Forms.Button ff8id_set;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button about_rank;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button about_flags;
		private System.Windows.Forms.CheckBox flag1;
		private System.Windows.Forms.CheckBox flag0;
		private System.Windows.Forms.CheckBox event_wait;
		private System.Windows.Forms.CheckBox lvlevent;
		private System.Windows.Forms.CheckBox demon_defeat;
		private System.Windows.Forms.CheckBox mogu_standby;
		private System.Windows.Forms.CheckBox mogu_have;
		private System.Windows.Forms.CheckBox mogu_found;
		private System.Windows.Forms.NumericUpDown weapon;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		
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
		/// </summary>
		private void InitializeComponent()
		{
			this.loadsave_but = new System.Windows.Forms.Button();
			this.savegamename = new System.Windows.Forms.TextBox();
			this.save_but = new System.Windows.Forms.Button();
			this.versiontext = new System.Windows.Forms.Label();
			this.about = new System.Windows.Forms.Button();
			this.ff8_id = new System.Windows.Forms.TextBox();
			this.ff8id_set = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.level = new System.Windows.Forms.NumericUpDown();
			this.rank = new System.Windows.Forms.NumericUpDown();
			this.item_a = new System.Windows.Forms.NumericUpDown();
			this.item_b = new System.Windows.Forms.NumericUpDown();
			this.item_d = new System.Windows.Forms.NumericUpDown();
			this.item_c = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.hp_max = new System.Windows.Forms.NumericUpDown();
			this.hp_curr = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.about_rank = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.powerups = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.about_flags = new System.Windows.Forms.Button();
			this.flag1 = new System.Windows.Forms.CheckBox();
			this.flag0 = new System.Windows.Forms.CheckBox();
			this.event_wait = new System.Windows.Forms.CheckBox();
			this.lvlevent = new System.Windows.Forms.CheckBox();
			this.demon_defeat = new System.Windows.Forms.CheckBox();
			this.mogu_standby = new System.Windows.Forms.CheckBox();
			this.mogu_have = new System.Windows.Forms.CheckBox();
			this.mogu_found = new System.Windows.Forms.CheckBox();
			this.weapon = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rank)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.item_a)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.item_b)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.item_d)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.item_c)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hp_max)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hp_curr)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.powerups)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.weapon)).BeginInit();
			this.SuspendLayout();
			// 
			// loadsave_but
			// 
			this.loadsave_but.Location = new System.Drawing.Point(12, 12);
			this.loadsave_but.Name = "loadsave_but";
			this.loadsave_but.Size = new System.Drawing.Size(132, 23);
			this.loadsave_but.TabIndex = 0;
			this.loadsave_but.Text = "Load Savegame";
			this.loadsave_but.UseVisualStyleBackColor = true;
			this.loadsave_but.Click += new System.EventHandler(this.Loadsave_butClick);
			// 
			// savegamename
			// 
			this.savegamename.Location = new System.Drawing.Point(12, 41);
			this.savegamename.Name = "savegamename";
			this.savegamename.Size = new System.Drawing.Size(526, 20);
			this.savegamename.TabIndex = 1;
			this.savegamename.TextChanged += new System.EventHandler(this.SavegamenameTextChanged);
			// 
			// save_but
			// 
			this.save_but.Enabled = false;
			this.save_but.Location = new System.Drawing.Point(12, 67);
			this.save_but.Name = "save_but";
			this.save_but.Size = new System.Drawing.Size(132, 23);
			this.save_but.TabIndex = 2;
			this.save_but.Text = "Save";
			this.save_but.UseVisualStyleBackColor = true;
			this.save_but.Click += new System.EventHandler(this.Save_butClick);
			// 
			// versiontext
			// 
			this.versiontext.Location = new System.Drawing.Point(150, 17);
			this.versiontext.Name = "versiontext";
			this.versiontext.Size = new System.Drawing.Size(100, 18);
			this.versiontext.TabIndex = 3;
			// 
			// about
			// 
			this.about.Location = new System.Drawing.Point(521, 13);
			this.about.Name = "about";
			this.about.Size = new System.Drawing.Size(17, 22);
			this.about.TabIndex = 14;
			this.about.Text = "?";
			this.about.UseVisualStyleBackColor = true;
			this.about.Click += new System.EventHandler(this.AboutClick);
			// 
			// ff8_id
			// 
			this.ff8_id.Location = new System.Drawing.Point(294, 70);
			this.ff8_id.Name = "ff8_id";
			this.ff8_id.ReadOnly = true;
			this.ff8_id.Size = new System.Drawing.Size(100, 20);
			this.ff8_id.TabIndex = 15;
			// 
			// ff8id_set
			// 
			this.ff8id_set.Enabled = false;
			this.ff8id_set.Location = new System.Drawing.Point(400, 68);
			this.ff8id_set.Name = "ff8id_set";
			this.ff8id_set.Size = new System.Drawing.Size(138, 22);
			this.ff8id_set.TabIndex = 16;
			this.ff8id_set.Text = "Load from FF8 savegame";
			this.ff8id_set.UseVisualStyleBackColor = true;
			this.ff8id_set.Click += new System.EventHandler(this.Ff8id_setClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(243, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "FF8 ID:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// level
			// 
			this.level.Location = new System.Drawing.Point(101, 114);
			this.level.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.level.Name = "level";
			this.level.Size = new System.Drawing.Size(44, 20);
			this.level.TabIndex = 18;
			this.level.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// rank
			// 
			this.rank.Location = new System.Drawing.Point(58, 19);
			this.rank.Maximum = new decimal(new int[] {
									6,
									0,
									0,
									0});
			this.rank.Name = "rank";
			this.rank.Size = new System.Drawing.Size(44, 20);
			this.rank.TabIndex = 19;
			// 
			// item_a
			// 
			this.item_a.Location = new System.Drawing.Point(22, 35);
			this.item_a.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.item_a.Name = "item_a";
			this.item_a.Size = new System.Drawing.Size(44, 20);
			this.item_a.TabIndex = 20;
			// 
			// item_b
			// 
			this.item_b.Location = new System.Drawing.Point(78, 35);
			this.item_b.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.item_b.Name = "item_b";
			this.item_b.Size = new System.Drawing.Size(44, 20);
			this.item_b.TabIndex = 21;
			// 
			// item_d
			// 
			this.item_d.Location = new System.Drawing.Point(78, 77);
			this.item_d.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.item_d.Name = "item_d";
			this.item_d.Size = new System.Drawing.Size(44, 20);
			this.item_d.TabIndex = 22;
			// 
			// item_c
			// 
			this.item_c.Location = new System.Drawing.Point(22, 77);
			this.item_c.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.item_c.Name = "item_c";
			this.item_c.Size = new System.Drawing.Size(44, 20);
			this.item_c.TabIndex = 23;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.item_c);
			this.groupBox1.Controls.Add(this.item_d);
			this.groupBox1.Controls.Add(this.item_b);
			this.groupBox1.Controls.Add(this.item_a);
			this.groupBox1.Location = new System.Drawing.Point(400, 111);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(138, 107);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Items";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(78, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 16);
			this.label5.TabIndex = 28;
			this.label5.Text = "D";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(22, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "C";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(78, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "B";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "A";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.hp_max);
			this.groupBox3.Controls.Add(this.hp_curr);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(151, 111);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(114, 78);
			this.groupBox3.TabIndex = 28;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "HP";
			// 
			// hp_max
			// 
			this.hp_max.Location = new System.Drawing.Point(57, 45);
			this.hp_max.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.hp_max.Minimum = new decimal(new int[] {
									6,
									0,
									0,
									0});
			this.hp_max.Name = "hp_max";
			this.hp_max.Size = new System.Drawing.Size(44, 20);
			this.hp_max.TabIndex = 31;
			this.hp_max.Value = new decimal(new int[] {
									6,
									0,
									0,
									0});
			this.hp_max.ValueChanged += new System.EventHandler(this.Hp_maxValueChanged);
			// 
			// hp_curr
			// 
			this.hp_curr.Location = new System.Drawing.Point(57, 19);
			this.hp_curr.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.hp_curr.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.hp_curr.Name = "hp_curr";
			this.hp_curr.Size = new System.Drawing.Size(44, 20);
			this.hp_curr.TabIndex = 29;
			this.hp_curr.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.hp_curr.ValueChanged += new System.EventHandler(this.Hp_currValueChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 23);
			this.label7.TabIndex = 30;
			this.label7.Text = "Max:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 23);
			this.label6.TabIndex = 29;
			this.label6.Text = "Current:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.ID);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.rank);
			this.groupBox4.Location = new System.Drawing.Point(271, 111);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(114, 78);
			this.groupBox4.TabIndex = 28;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Rank and ID";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(7, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 23);
			this.label12.TabIndex = 35;
			this.label12.Text = "ID:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ID
			// 
			this.ID.Location = new System.Drawing.Point(58, 45);
			this.ID.Maximum = new decimal(new int[] {
									999,
									0,
									0,
									0});
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(44, 20);
			this.ID.TabIndex = 25;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 23);
			this.label9.TabIndex = 30;
			this.label9.Text = "Rank:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// about_rank
			// 
			this.about_rank.Location = new System.Drawing.Point(150, 195);
			this.about_rank.Name = "about_rank";
			this.about_rank.Size = new System.Drawing.Size(235, 24);
			this.about_rank.TabIndex = 34;
			this.about_rank.Text = "About Rank, ID and Max HP";
			this.about_rank.UseVisualStyleBackColor = true;
			this.about_rank.Click += new System.EventHandler(this.About_rankClick);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(50, 111);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 23);
			this.label8.TabIndex = 29;
			this.label8.Text = "Level:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// powerups
			// 
			this.powerups.Location = new System.Drawing.Point(100, 140);
			this.powerups.Maximum = new decimal(new int[] {
									3,
									0,
									0,
									0});
			this.powerups.Name = "powerups";
			this.powerups.Size = new System.Drawing.Size(44, 20);
			this.powerups.TabIndex = 31;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(32, 140);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 23);
			this.label11.TabIndex = 33;
			this.label11.Text = "PowerUps:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.about_flags);
			this.groupBox5.Controls.Add(this.flag1);
			this.groupBox5.Controls.Add(this.flag0);
			this.groupBox5.Controls.Add(this.event_wait);
			this.groupBox5.Controls.Add(this.lvlevent);
			this.groupBox5.Controls.Add(this.demon_defeat);
			this.groupBox5.Controls.Add(this.mogu_standby);
			this.groupBox5.Controls.Add(this.mogu_have);
			this.groupBox5.Controls.Add(this.mogu_found);
			this.groupBox5.Location = new System.Drawing.Point(82, 224);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(373, 100);
			this.groupBox5.TabIndex = 34;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Game Flags";
			// 
			// about_flags
			// 
			this.about_flags.Location = new System.Drawing.Point(259, 66);
			this.about_flags.Name = "about_flags";
			this.about_flags.Size = new System.Drawing.Size(102, 24);
			this.about_flags.TabIndex = 35;
			this.about_flags.Text = "About Flags";
			this.about_flags.UseVisualStyleBackColor = true;
			this.about_flags.Click += new System.EventHandler(this.About_flagsClick);
			// 
			// flag1
			// 
			this.flag1.AutoCheck = false;
			this.flag1.Location = new System.Drawing.Point(259, 40);
			this.flag1.Name = "flag1";
			this.flag1.Size = new System.Drawing.Size(104, 24);
			this.flag1.TabIndex = 7;
			this.flag1.Text = "Flag 1 (away?)";
			this.flag1.UseVisualStyleBackColor = true;
			// 
			// flag0
			// 
			this.flag0.AutoCheck = false;
			this.flag0.Location = new System.Drawing.Point(259, 19);
			this.flag0.Name = "flag0";
			this.flag0.Size = new System.Drawing.Size(104, 24);
			this.flag0.TabIndex = 6;
			this.flag0.Text = "Flag 0 (unknown)";
			this.flag0.UseVisualStyleBackColor = true;
			// 
			// event_wait
			// 
			this.event_wait.Location = new System.Drawing.Point(116, 60);
			this.event_wait.Name = "event_wait";
			this.event_wait.Size = new System.Drawing.Size(104, 24);
			this.event_wait.TabIndex = 5;
			this.event_wait.Text = "Event Wait ON";
			this.event_wait.UseVisualStyleBackColor = true;
			// 
			// lvlevent
			// 
			this.lvlevent.Location = new System.Drawing.Point(116, 40);
			this.lvlevent.Name = "lvlevent";
			this.lvlevent.Size = new System.Drawing.Size(137, 24);
			this.lvlevent.TabIndex = 4;
			this.lvlevent.Text = "Level event happened";
			this.lvlevent.UseVisualStyleBackColor = true;
			// 
			// demon_defeat
			// 
			this.demon_defeat.Location = new System.Drawing.Point(116, 19);
			this.demon_defeat.Name = "demon_defeat";
			this.demon_defeat.Size = new System.Drawing.Size(137, 24);
			this.demon_defeat.TabIndex = 3;
			this.demon_defeat.Text = "Demon King Defeated";
			this.demon_defeat.UseVisualStyleBackColor = true;
			// 
			// mogu_standby
			// 
			this.mogu_standby.Location = new System.Drawing.Point(6, 60);
			this.mogu_standby.Name = "mogu_standby";
			this.mogu_standby.Size = new System.Drawing.Size(104, 24);
			this.mogu_standby.TabIndex = 2;
			this.mogu_standby.Text = "Mogu Standby";
			this.mogu_standby.UseVisualStyleBackColor = true;
			// 
			// mogu_have
			// 
			this.mogu_have.Location = new System.Drawing.Point(6, 40);
			this.mogu_have.Name = "mogu_have";
			this.mogu_have.Size = new System.Drawing.Size(104, 24);
			this.mogu_have.TabIndex = 1;
			this.mogu_have.Text = "Have Mogu";
			this.mogu_have.UseVisualStyleBackColor = true;
			// 
			// mogu_found
			// 
			this.mogu_found.Location = new System.Drawing.Point(6, 19);
			this.mogu_found.Name = "mogu_found";
			this.mogu_found.Size = new System.Drawing.Size(104, 24);
			this.mogu_found.TabIndex = 0;
			this.mogu_found.Text = "Mogu found";
			this.mogu_found.UseVisualStyleBackColor = true;
			// 
			// weapon
			// 
			this.weapon.Location = new System.Drawing.Point(100, 166);
			this.weapon.Maximum = new decimal(new int[] {
									9999,
									0,
									0,
									0});
			this.weapon.Name = "weapon";
			this.weapon.Size = new System.Drawing.Size(45, 20);
			this.weapon.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(32, 163);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 23);
			this.label10.TabIndex = 35;
			this.label10.Text = "Weapon:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 345);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.about_rank);
			this.Controls.Add(this.weapon);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.powerups);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.level);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ff8id_set);
			this.Controls.Add(this.ff8_id);
			this.Controls.Add(this.about);
			this.Controls.Add(this.versiontext);
			this.Controls.Add(this.save_but);
			this.Controls.Add(this.savegamename);
			this.Controls.Add(this.loadsave_but);
			this.Name = "MainForm";
			this.Text = "Chocobo World Editor 0.2a by suloku";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainScreenDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainScreenDragEnter);
			((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rank)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.item_a)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.item_b)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.item_d)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.item_c)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.hp_max)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hp_curr)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.powerups)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.weapon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
