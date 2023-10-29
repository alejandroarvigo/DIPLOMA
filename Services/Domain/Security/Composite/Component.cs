using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security.Composite
{
    public abstract class Component
    {
		public Guid IdComponent { get; set; }

		public string NameView { get; set; }

		public abstract void Add(Component component);

		public abstract void Remove(Component component);

		public abstract int ChildrenCount();
	}
}
