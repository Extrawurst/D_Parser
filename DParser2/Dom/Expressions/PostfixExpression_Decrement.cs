﻿using System;

namespace D_Parser.Dom.Expressions
{
	public class PostfixExpression_Decrement : PostfixExpression
	{
		public override string ToString()
		{
			return PostfixForeExpression.ToString() + "--";
		}

		public sealed override CodeLocation EndLocation
		{
			get;
			set;
		}

		public override void Accept(ExpressionVisitor vis)
		{
			vis.Visit(this);
		}

		public override R Accept<R>(ExpressionVisitor<R> vis)
		{
			return vis.Visit(this);
		}

		public override ulong GetHash()
		{
			var hashCode = base.GetHash();
			unchecked
			{
				hashCode += 1000000021;
			}
			return hashCode;
		}
	}
}

