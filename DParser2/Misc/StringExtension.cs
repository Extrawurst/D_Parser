//
// StringExtension.cs
//
// Author:
//       Alexander Bothe <info@alexanderbothe.com>
//
// Copyright (c) 2013 Alexander Bothe
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System.Text;

namespace D_Parser
{
	public static class StringExtension
	{
		public static StringBuilder Trim(this StringBuilder sb)
		{
			int trimLen = 0;
			for (;trimLen < sb.Length && char.IsWhiteSpace (sb [trimLen]); trimLen++);
			if(trimLen != 0)
				sb.Remove (0, trimLen);

			if (sb.Length != 0) {
				for (trimLen = sb.Length - 1; trimLen >= 0 && char.IsWhiteSpace (sb [trimLen]); trimLen--);
				sb.Length = trimLen + 1;
			}
			return sb;
		}
	}
}

