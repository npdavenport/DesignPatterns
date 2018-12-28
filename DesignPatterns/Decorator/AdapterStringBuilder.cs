using System;
using System.Runtime.Serialization;
using System.Text;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// A combination of a decorator pattern with an adapter pattern.
    /// </summary>
    public class AdapterStringBuilder
    {
        private StringBuilder _builder = new StringBuilder();

        public static implicit operator AdapterStringBuilder(string s)
        {
            var sb = new AdapterStringBuilder();
            sb.Append(s);
            return sb;
        }

        public static AdapterStringBuilder operator +(AdapterStringBuilder sb, string s)
        {
            sb.Append(s);
            return sb;
        }

        public override string ToString()
        {
            return _builder.ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)_builder).GetObjectData(info, context);
        }

        public AdapterStringBuilder Append(bool value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(byte value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(char value)
        {
            _builder.Append(value);
            return this;
        }

        public unsafe AdapterStringBuilder Append(char* value, int valueCount)
        {
            _builder.Append(value, valueCount);
            return this;
        }

        public AdapterStringBuilder Append(char value, int repeatCount)
        {
            _builder.Append(value, repeatCount);
            return this;
        }

        public AdapterStringBuilder Append(char[] value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(char[] value, int startIndex, int charCount)
        {
            _builder.Append(value, startIndex, charCount);
            return this;
        }

        public AdapterStringBuilder Append(decimal value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(double value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(short value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(int value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(long value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(object value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(sbyte value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(float value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(string value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(string value, int startIndex, int count)
        {
            _builder.Append(value, startIndex, count);
            return this;
        }

        public AdapterStringBuilder Append(ushort value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(uint value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder Append(ulong value)
        {
            _builder.Append(value);
            return this;
        }

        public AdapterStringBuilder AppendFormat(IFormatProvider provider, string format, object arg0)
        {
            _builder.AppendFormat(provider, format, arg0);
            return this;
        }

        public AdapterStringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1)
        {
            _builder.AppendFormat(provider, format, arg0, arg1);
            return this;
        }

        public AdapterStringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            _builder.AppendFormat(provider, format, arg0, arg1, arg2);
            return this;
        }

        public AdapterStringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
        {
            _builder.AppendFormat(provider, format, args);
            return this;
        }

        public AdapterStringBuilder AppendFormat(string format, object arg0)
        {
            _builder.AppendFormat(format, arg0);
            return this;
        }

        public AdapterStringBuilder AppendFormat(string format, object arg0, object arg1)
        {
            _builder.AppendFormat(format, arg0, arg1);
            return this;
        }

        public AdapterStringBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
        {
            _builder.AppendFormat(format, arg0, arg1, arg2);
            return this;
        }

        public AdapterStringBuilder AppendFormat(string format, params object[] args)
        {
            _builder.AppendFormat(format, args);
            return this;
        }

        public AdapterStringBuilder AppendLine()
        {
            _builder.AppendLine();
            return this;
        }

        public AdapterStringBuilder AppendLine(string value)
        {
            _builder.AppendLine(value);
            return this;
        }

        public AdapterStringBuilder Clear()
        {
            _builder.Clear();
            return this;
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            _builder.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public int EnsureCapacity(int capacity)
        {
            return _builder.EnsureCapacity(capacity);
        }

        public bool Equals(AdapterStringBuilder sb)
        {
            return _builder.Equals(sb);
        }

        public AdapterStringBuilder Insert(int index, bool value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, byte value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, char value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, char[] value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, char[] value, int startIndex, int charCount)
        {
            _builder.Insert(index, value, startIndex, charCount);
            return this;
        }

        public AdapterStringBuilder Insert(int index, decimal value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, double value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, short value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, int value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, long value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, object value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, sbyte value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, float value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, string value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, string value, int count)
        {
            _builder.Insert(index, value, count);
            return this;
        }

        public AdapterStringBuilder Insert(int index, ushort value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, uint value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Insert(int index, ulong value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public AdapterStringBuilder Remove(int startIndex, int length)
        {
            _builder.Remove(startIndex, length);
            return this;
        }

        public AdapterStringBuilder Replace(char oldChar, char newChar)
        {
            _builder.Replace(oldChar, newChar);
            return this;
        }

        public AdapterStringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            _builder.Replace(oldChar, newChar, startIndex, count);
            return this;
        }

        public AdapterStringBuilder Replace(string oldValue, string newValue)
        {
            _builder.Replace(oldValue, newValue);
            return this;
        }

        public AdapterStringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
        {
            _builder.Replace(oldValue, newValue, startIndex, count);
            return this;
        }

        public string ToString(int startIndex, int length)
        {
            return _builder.ToString(startIndex, length);
        }

        public int Capacity
        {
            get => _builder.Capacity;
            set => _builder.Capacity = value;
        }

        public char this[int index]
        {
            get => _builder[index];
            set => _builder[index] = value;
        }

        public int Length
        {
            get => _builder.Length;
            set => _builder.Length = value;
        }

        public int MaxCapacity => _builder.MaxCapacity;
    }
}