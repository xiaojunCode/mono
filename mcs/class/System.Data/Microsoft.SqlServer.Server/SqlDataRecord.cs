//
// SqlDataRecord.cs
//
// Authors:
//   Marek Safar (marek.safar@gmail.com)
//
// Copyright (C) 2015 Novell, Inc (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System;
using System.Data;
using System.Data.SqlTypes;

namespace Microsoft.SqlServer.Server 
{
	public sealed class SqlDataRecord : IDataRecord
	{
		public bool GetBoolean (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public byte GetByte (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public long GetBytes (int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length)
		{
			throw new NotImplementedException ();
		}

		public char GetChar (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public long GetChars (int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length)
		{
			throw new NotImplementedException ();
		}

		public IDataReader GetData (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public string GetDataTypeName (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public DateTime GetDateTime (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public decimal GetDecimal (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public double GetDouble (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public System.Type GetFieldType (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public float GetFloat (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public Guid GetGuid (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public short GetInt16 (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public int GetInt32 (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public long GetInt64 (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public string GetName (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public int GetOrdinal (string name)
		{
			throw new NotImplementedException ();
		}

		public string GetString (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public object GetValue (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public int GetValues (object[] values)
		{
			throw new NotImplementedException ();
		}

		public bool IsDBNull (int ordinal)
		{
			throw new NotImplementedException ();
		}

		public int FieldCount {
			get {
				throw new NotImplementedException ();
			}
		}

		public object this [string name] {
			get {
				throw new NotImplementedException ();
			}
		}

		public object this [int ordinal] {
			get {
				throw new NotImplementedException ();
			}
		}
	}
}