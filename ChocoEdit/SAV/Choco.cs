/*
 * Created by SharpDevelop.
 * User: LAURA
 * Date: 10/07/2016
 * Time: 16:04
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
	/// Description of Choco.
	/// </summary>
	public class Choco
	{
			public static int PSXSIZE = 57472;
	        public byte[] Data;
	        public Choco(byte[] data = null, int size = 0)
	        {
	            Data = data ?? new byte[size];
	            if (size == PSXSIZE)
	            	get_current_save();
	            else //CHOCORPG Uncompressed
	            	save_offset = 0x02;
	        }
	        public byte[] getData(int Offset, int Length)
	        {
	            return Data.Skip(Offset).Take(Length).ToArray();
	        }
	        public void setData(byte[] input, int Offset)
	        {
	            input.CopyTo(Data, Offset);
	        }
	        
	        private int save_offset = 0x280;
	        
	        private void get_current_save()
	        {
	        	if (BitConverter.ToUInt32(Data, 0x380+8) > BitConverter.ToUInt32(Data, 0x280+8) )
	        		save_offset = 0x380;
	        }
	        public byte mog_event_control{
	        	get{
	        		return Data[save_offset+0];
	        	}
	        	set{
	        		Data[save_offset+0] = (byte) (value&0xFF);
	        	}
	        }
	        public bool Eventflag0{
	        	get { return Convert.ToBoolean(mog_event_control&0x1); }
	        	set { if (value == true) mog_event_control |= (byte)(0x1); else mog_event_control &= unchecked((byte)(~(0x1))); } }
	        public bool Away{
	        	get { return Convert.ToBoolean(mog_event_control&0x2); }
	        	set { if (value == true) mog_event_control |= (byte)(0x2); else mog_event_control &= unchecked((byte)(~(0x2))); } }
	        public bool MoguFound{
	        	get { return Convert.ToBoolean(mog_event_control&0x4); }
	        	set { if (value == true) mog_event_control |= (byte)(0x4); else mog_event_control &= unchecked((byte)(~(0x4))); } }
	        public bool MoguHave{
	        	get { return Convert.ToBoolean(mog_event_control&0x8); }
	        	set { if (value == true) mog_event_control |= (byte)(0x8); else mog_event_control &= unchecked((byte)(~(0x8))); } }
	        public bool MoguStandby{
	        	get { return Convert.ToBoolean(mog_event_control&0x10); }
	        	set { if (value == true) mog_event_control |= (byte)(0x10); else mog_event_control &= unchecked((byte)(~(0x10))); } }
	        public bool DemonDefeated{
	        	get { return Convert.ToBoolean(mog_event_control&0x20); }
	        	set { if (value == true) mog_event_control |= (byte)(0x20); else mog_event_control &= unchecked((byte)(~(0x20))); } }
	        public bool LvlEvent{
	        	get { return Convert.ToBoolean(mog_event_control&0x40); }
	        	set { if (value == true) mog_event_control |= (byte)(0x40); else mog_event_control &= unchecked((byte)(~(0x40))); } }
	        public bool EventWait{
	        	get { return Convert.ToBoolean(mog_event_control&0x80); }
	        	set { if (value == true) mog_event_control |= (byte)(0x80); else mog_event_control &= unchecked((byte)(~(0x80))); } }
			public int level{
	        	get{
	        		if (ReadAsDecimal(Data[save_offset+1]) == 0)
	        		    return 100;
	        		else
	        			return ReadAsDecimal(Data[save_offset+1]);
	        	}
	        	set{
	        		if (value >= 100 ) Data[save_offset+1] = DecimalAsHex(0); else if (value < 1 ) Data[save_offset+1] = DecimalAsHex(1); else Data[save_offset+1] = DecimalAsHex(value);
	        	}
	        }
			public int HP_cur{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+2]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+2] = DecimalAsHex(99); else Data[save_offset+2] = DecimalAsHex(value);
	        	}
	        }
			public int HP_max{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+3]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+3] = DecimalAsHex(99); else Data[save_offset+3] = DecimalAsHex(value);
	        	}
	        }
	        private int weapon_last{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+4]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+4] = DecimalAsHex(99); else Data[save_offset+4] = DecimalAsHex(value);
	        	}
	        }
	        private int weapon_first{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+5]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+5] = DecimalAsHex(99); else Data[save_offset+5] = DecimalAsHex(value);
	        	}
	        }
	        public int weapon{
	        	get{
	        		return (weapon_first*100) + weapon_last;
	        	}
	        	set{
	        		weapon_last = value - (value/100)*100;
	        		weapon_first = value/100;
	        	}
	        }
	        public int rank{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+6]);
	        	}
	        	set{
	        		if (value > 6 ) Data[save_offset+6] = DecimalAsHex(6); else Data[save_offset+6] = DecimalAsHex(value);
	        	}
	        }
	        public int movement_rate{ //It's best to not edit this value
	        	get{
	        		return ReadAsDecimal(Data[save_offset+7]);
	        	}
	        	set{
	        		if (value > 5 ) Data[save_offset+7] = DecimalAsHex(5); else Data[save_offset+7] = DecimalAsHex(value);
	        	}
	        }
	        public UInt32 counter{
	        	get{
	        		return BitConverter.ToUInt32(Data, save_offset+8);
	        	}
	        	set{
	        		setData(BitConverter.GetBytes(value).ToArray(), save_offset + 8);
	        	}
	        }
	        private int ID_low{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+0xC]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+0xC] = DecimalAsHex(99); else Data[save_offset+0xC] = DecimalAsHex(value);
	        	}
	        }
	        private int ID_HI{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+0xD]);
	        	}
	        	set{
	        		if (value > 9 ) Data[save_offset+0xD] |= DecimalAsHex(9); else Data[save_offset+0xD] |= DecimalAsHex(value);
	        	}
	        }
			public int ID{
	        	get{
	        		return (ID_HI*100) + ID_low;
	        	}
	        	set{
	        		ID_low = value - (value/100)*100;
	        		ID_HI = value/100;
	        	}
	        }
	        public int ITEM_A{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+0x14]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+0x14] = DecimalAsHex(99); else Data[save_offset+0x14] = DecimalAsHex(value);
	        	}
	        }
	        public int ITEM_B{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+0x15]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+0x15] = DecimalAsHex(99); else Data[save_offset+0x15] = DecimalAsHex(value);
	        	}
	        }
	        public int ITEM_C{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+0x16]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+0x16] = DecimalAsHex(99); else Data[save_offset+0x16] = DecimalAsHex(value);
	        	}
	        }
	        public int ITEM_D{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+0x17]);
	        	}
	        	set{
	        		if (value > 99 ) Data[save_offset+0x17] = DecimalAsHex(99); else Data[save_offset+0x17] = DecimalAsHex(value);
	        	}
	        }
			public int Powerups{
	        	get{
	        		return ReadAsDecimal(Data[save_offset+0x2D]);
	        	}
	        	set{
	        		if (value > 3 ) Data[save_offset+0x2D] = DecimalAsHex(3); else Data[save_offset+0x2D] = DecimalAsHex(value);
	        	}
	        }
			public UInt32 FF8ID{
	        	get{
	        		return BitConverter.ToUInt32(Data, save_offset+0x28);
	        	}
	        	set{
	        		setData(BitConverter.GetBytes((UInt32)value).ToArray(), save_offset + 0x28);
	        	}
	        }
	        
	        private int ReadAsDecimal(byte hexvalue)
	        {
	        	return (((hexvalue&(0xF0))>>4)*10) + (hexvalue&0x0F);
	        }
	        
	        private byte DecimalAsHex(int decvalue)
	        {
	        	if (decvalue > 99)
	        		decvalue = 99;
	        	//Get base 10
	        	int decenas = decvalue/10;
	        	//Get units
	        	int units = decvalue - (decenas*10);
	        	//Build byte
	        	//MessageBox.Show(decenas.ToString()+" - "+units.ToString());
	        	//MessageBox.Show(decvalue.ToString()+" - "+((byte)((decenas<<4)|units)).ToString("X"));
	        	return (byte)((decenas<<4)|units);
	        	
	        }
	        
	}
}
