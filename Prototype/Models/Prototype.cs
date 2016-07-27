using System;
namespace Models
{
	public class Prototype : AbstractPrototype
	{
		public Prototype(AbstractPrototype proto) : base(proto)
		{
		}

		public Prototype(int id, int height, int width) : base (id, height, width)
		{ }

		public override AbstractPrototype Clone()
		{
			return new Prototype(this);
		}
	}
}

