using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security.Composite
{
	public class Familia : Component
	{

		private List<Component> children;

		public Familia()
		{
            children = new List<Component>();

        }


		public List<Component> GetChildren()
		{
			return children;
		}

		public override void Add(Component component)
		{
			children.Add(component);
		}

		public override int ChildrenCount()
		{
			return children.Count;
		}

		public override void Remove(Component component)
		{
			children.RemoveAll(o => o.IdComponent == component.IdComponent);
		}

	}
}
