using DatabaseManagerV1.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseManagerV1.Structures
{
	public class ManagersTemplate
	{
        public virtual object? RequestQuery(string query, bool returns = false) { return null; }
		public override string ToString()
		{
			return "Name\t\t:" + this.GetType().Name + "\nTotal Methods\t:" + (this.GetType().GetMethods().Length - 4);
		}
	}
}
