using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatMMT
{
	public class MySolution
	{
		static string temp = "00000000";
		public static string toBinary(int x)
		{
			Stack<int> st = new Stack<int>();
			StringBuilder sb = new StringBuilder();
			while (x != 0)
			{
				int t = x % 2;
				x /= 2;
				st.Push(t);
			}
			while (st.Count!=0)
			{
				int top = st.Peek(); st.Pop();
				sb.Append(top.ToString());
			}
			string s = sb.ToString();
			while (s.Length < 8) s = "0" + s;
			return s;
		}
		public static string getCheckSum(string s)
		{
			string res = "";
			if (s.Length > 4) return null;
			StringBuilder sb = new StringBuilder();
			int index = 0,surplus=0;
			foreach(char c in s)
			{
				sb.Append(toBinary((int)c));
				index++;
			}
			for(int i = index; i<4; i++)
			{
				sb.Append(temp);
			}
			string a = sb.ToString().Substring(0, 16);
			string b = sb.ToString().Substring(16, 16);
			//System.Windows.Forms.MessageBox.Show(a + "|\n" + b);
			for(int i=a.Length-1;i>=0;i--)
			{
				int t = (a[i] - '0' + b[i] - '0');
				if (t == 2)
				{
					if (t + surplus > 2)
					{
						surplus = 1;
						res = "0" + res;
					}
					else
					{
						surplus = 1;
						res = "1" + res;
					}
				}
				else
				{
					string t2 = t+surplus >= 1 ? "0" : "1";
					res =  t2 + res;
					surplus = 0;
				}
			}
			return res;
		}
		public static string getDataCRC(string s)
		{
			StringBuilder sb = new StringBuilder();
			foreach (char c in s) sb.Append(toBinary((int)c));
			return sb.ToString();
		}
		public static string getCRC(string s,string k)
		{
			int i, j, keylen, msglen;
			char[] input = new char[100];
			char[] key = k.ToCharArray();
			char[] temp = new char[30];
			char[] quot = new char[100];
			char[] rem = new char[30];
			char[] key1=new char[30];

			keylen = k.Length;
			msglen = s.Length;
			Array.Copy(key, key1, key.Length);
			string t1 = "";
			for (i = 0; i < keylen; i++)
			{
				//input[msglen + i] = '0';
				t1 += "0";
			}
			input = (s + t1).ToCharArray();
			for (i = 0; i < keylen; i++) temp[i] = input[i];
			for (i = 0; i < msglen; i++)
			{
				quot[i] = temp[0];
				if (quot[i] == '0')
					for (j = 0; j < keylen; j++) key[j] = '0';
				else
					for (j = 0; j < keylen; j++) key[j] = key1[j];
				for (j = keylen - 1; j > 0; j--)
				{
					if (temp[j] == key[j]) rem[j - 1] = '0';
					else rem[j - 1] = '1';
				}
				rem[keylen - 1] = input[i + keylen];
				Array.Copy(rem, temp,rem.Length);
			}
			Array.Copy(temp, rem,temp.Length);

			string res = "";
			for (i = 0; i < keylen-1; i++) res += rem[i].ToString();
			return res;
		}

		public static string getHammingEndcode(string msg)
		{
			int r = 0, m = msg.Length;
			//calculate number of parity bits needed using m+r+1<=2^r
			while (true)
			{
				if (m + r + 1 <= Math.Pow(2, r))
				{
					break;
				}
				r++;
			}
			int transLength = msg.Length + r, temp = 0, temp2 = 0, j = 0;
			int []transMsg = new int[transLength + 1]; //+1 because starts with 1
			for (int i = 1; i <= transLength; i++)
			{
				temp2 = (int)Math.Pow(2, temp);
				if (i % temp2 != 0)
				{
					transMsg[i] = msg[j] - '0';
					j++;
				}
				else
				{
					temp++;
				}
			}

			for (int i = 0; i < r; i++)
			{
				int smallStep = (int)Math.Pow(2, i);
				int bigStep = smallStep * 2;
				int start = smallStep, checkPos = start;
				while (true)
				{
					for (int k = start; k <= start + smallStep - 1; k++)
					{
						checkPos = k;
						if (k > transLength)
						{
							break;
						}
						transMsg[smallStep] ^= transMsg[checkPos];
					}
					if (checkPos > transLength)
					{
						break;
					}
					else
					{
						start = start + bigStep;
					}
				}
			}

			string res = "";
			for (int i = 1; i <= transLength; i++)
			{
				res+=transMsg[i].ToString();
			}
			
			return res;
		}
		public static string DectectAndFix(string input)
		{
			int r = 0;
			while (input.Length >= Math.Pow(2, r)) r++;

			int[] temp = new int[input.Length + 1];
			int[] transMsg = new int[input.Length + 1];

			for (int i = 0; i < input.Length; i++) temp[i + 1] = input[i] - '0';
			Array.Copy(temp, transMsg, temp.Length);

			for(int i = 0; i < r; i++)
			{
				transMsg[(int)Math.Pow(2, i)] = 0;
			}

			for (int i = 0; i < r; i++)
			{
				int smallStep = (int)Math.Pow(2, i);
				int bigStep = smallStep * 2;
				int start = smallStep, checkPos = start;
				while (true)
				{
					for (int k = start; k <= start + smallStep - 1; k++)
					{
						checkPos = k;
						if (k > input.Length)
						{
							break;
						}
						transMsg[smallStep] ^= transMsg[checkPos];
					}
					if (checkPos > input.Length)
					{
						break;
					}
					else
					{
						start = start + bigStep;
					}
				}
			}

			int error = 0;
			for(int i =0;i<r;i++)
			{
				int index = (int)Math.Pow(2, i);
				if (temp[index] != transMsg[index]) error+=index;
			}

			StringBuilder res = new StringBuilder();
			
			temp[error] = temp[error] == 1 ? 0 : 1;
			int j = 0;
			for(int i = 1; i < temp.Length; i++)
			{
				if (i != (int)Math.Pow(2, j))
				{
					res.Append(temp[i].ToString());
				}
				else j++;
				//res.Append(temp[i].ToString());
			}
			return res.ToString()+"|error: "+error;
		}

		public static char toChar(string bin)
		{
			while (bin.Length < 8) bin = "0" + bin;
			int s = 0;
			for(int i = 0; i < bin.Length; i++)
			{
				int temp = (bin[i] - '0');
				if (temp > 0) s += (int)(Math.Pow(2, 7 - i));
			}
			return (char)s;
		}
	}
}
