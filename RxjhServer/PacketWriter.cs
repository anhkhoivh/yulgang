using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RxjhServer
{
	public class PacketWriter
	{
		private static Stack<PacketWriter> eval_a;

		private MemoryStream eval_b;

		private int eval_c;

		private static byte[] eval_d;

		public long Length => eval_b.Length;

		public long Position
		{
			get
			{
				return eval_b.Position;
			}
			set
			{
				eval_b.Position = value;
			}
		}

		public MemoryStream UnderlyingStream => eval_b;

		static PacketWriter()
		{
			old_acctor_mc();
		}

		public PacketWriter()
			: this(32)
		{
		}

		public PacketWriter(int capacity)
		{
			eval_b = new MemoryStream(capacity);
			eval_c = capacity;
		}

		public static PacketWriter CreateInstance()
		{
			return CreateInstance(32);
		}

		public static PacketWriter CreateInstance(int capacity)
		{
			PacketWriter packetWriter = null;
			lock (eval_a)
			{
				if (eval_a.Count > 0)
				{
					packetWriter = eval_a.Pop();
					if (packetWriter != null)
					{
						packetWriter.eval_c = capacity;
						packetWriter.eval_b.SetLength(0L);
					}
				}
			}
			if (packetWriter == null)
			{
				packetWriter = new PacketWriter(capacity);
			}
			return packetWriter;
		}

		public void Fill()
		{
			Fill(eval_c - (int)eval_b.Length);
		}

		public void Fill(int length)
		{
			if (eval_b.Position == eval_b.Length)
			{
				eval_b.SetLength(eval_b.Length + length);
				eval_b.Seek(0L, SeekOrigin.End);
			}
			else
			{
				eval_b.Write(new byte[length], 0, length);
			}
		}

		public void method_0(int value)
		{
			eval_b.WriteByte((byte)(value & 0xFF));
			eval_b.WriteByte((byte)((value >> 8) & 0xFF));
			eval_b.WriteByte((byte)((value >> 16) & 0xFF));
			eval_b.WriteByte((byte)((value >> 24) & 0xFF));
		}

		public void method_1(int value)
		{
			eval_b.WriteByte((byte)(value & 0xFF));
			eval_b.WriteByte((byte)((value >> 8) & 0xFF));
		}

		public void method_2(int value)
		{
			eval_b.WriteByte((byte)(value & 0xFF));
		}

		private static void old_acctor_mc()
		{
			eval_a = new Stack<PacketWriter>();
			eval_d = new byte[4];
		}

		public static void ReleaseInstance(PacketWriter pw)
		{
			lock (eval_a)
			{
				if (!eval_a.Contains(pw))
				{
					eval_a.Push(pw);
				}
				else
				{
					try
					{
						using (StreamWriter streamWriter = new StreamWriter("neterr.log"))
						{
							streamWriter.WriteLine("{0}\tInstance pool contains writer", DateTime.Now);
						}
					}
					catch
					{
						Console.WriteLine("net error");
					}
				}
			}
		}

		public long Seek(long offset, SeekOrigin origin)
		{
			return eval_b.Seek(offset, origin);
		}

		public byte[] ToArray()
		{
			return eval_b.ToArray();
		}

		public void Write(bool value)
		{
			eval_b.WriteByte((byte)(value ? 1 : 0));
		}

		public void Write(byte value)
		{
			eval_b.WriteByte(value);
		}

		public void Write(short value)
		{
			eval_d[0] = (byte)(value >> 8);
			eval_d[1] = (byte)value;
			eval_b.Write(eval_d, 0, 2);
		}

		public void Write(int value)
		{
			eval_d[0] = (byte)(value >> 24);
			eval_d[1] = (byte)(value >> 16);
			eval_d[2] = (byte)(value >> 8);
			eval_d[3] = (byte)value;
			eval_b.Write(eval_d, 0, 4);
		}

		public void Write(sbyte value)
		{
			eval_b.WriteByte((byte)value);
		}

		public void Write(ushort value)
		{
			eval_d[0] = (byte)(value >> 8);
			eval_d[1] = (byte)value;
			eval_b.Write(eval_d, 0, 2);
		}

		public void Write(uint value)
		{
			eval_d[0] = (byte)(value >> 24);
			eval_d[1] = (byte)(value >> 16);
			eval_d[2] = (byte)(value >> 8);
			eval_d[3] = (byte)value;
			eval_b.Write(eval_d, 0, 4);
		}

		public void Write(byte[] buffer, int offset, int size)
		{
			eval_b.Write(buffer, offset, size);
		}

		public void WriteAsciiFixed(string value, int size)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				value = string.Empty;
			}
			byte[] bytes = Encoding.ASCII.GetBytes(value);
			if (bytes.Length >= size)
			{
				eval_b.Write(bytes, 0, size);
				return;
			}
			eval_b.Write(bytes, 0, bytes.Length);
			Fill(size - bytes.Length);
		}

		public void WriteAsciiNull(string value)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiNull() with null value");
				value = string.Empty;
			}
			byte[] bytes = Encoding.ASCII.GetBytes(value);
			eval_b.Write(bytes, 0, bytes.Length);
			eval_b.WriteByte(0);
		}

		public void WriteBigUniFixed(string value, int size)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteBigUniFixed() with null value");
				value = string.Empty;
			}
			size *= 2;
			byte[] bytes = Encoding.BigEndianUnicode.GetBytes(value);
			if (bytes.Length >= size)
			{
				eval_b.Write(bytes, 0, size);
				return;
			}
			eval_b.Write(bytes, 0, bytes.Length);
			Fill(size - bytes.Length);
		}

		public void WriteBigUniNull(string value)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteBigUniNull() with null value");
				value = string.Empty;
			}
			byte[] bytes = Encoding.BigEndianUnicode.GetBytes(value);
			eval_b.Write(bytes, 0, bytes.Length);
			eval_d[0] = 0;
			eval_d[1] = 0;
			eval_b.Write(eval_d, 0, 2);
		}

		public void WriteLittleUniFixed(string value, int size)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteLittleUniFixed() with null value");
				value = string.Empty;
			}
			size *= 2;
			byte[] bytes = Encoding.Unicode.GetBytes(value);
			if (bytes.Length >= size)
			{
				eval_b.Write(bytes, 0, size);
				return;
			}
			eval_b.Write(bytes, 0, bytes.Length);
			Fill(size - bytes.Length);
		}

		public void WriteLittleUniNull(string value)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteLittleUniNull() with null value");
				value = string.Empty;
			}
			byte[] bytes = Encoding.Unicode.GetBytes(value);
			eval_b.Write(bytes, 0, bytes.Length);
			eval_d[0] = 0;
			eval_d[1] = 0;
			eval_b.Write(eval_d, 0, 2);
		}
	}
}
