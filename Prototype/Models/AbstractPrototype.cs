using System;
namespace Models
{
	public abstract class AbstractPrototype
	{
		public int Id { get; private set;}
		public int Height { get; set; }
		public int Width { get; set;}

		public AbstractPrototype(AbstractPrototype proto) 
		{
			Id = proto.Id;
			Height = proto.Height;
			Width = proto.Width;
		}

		public AbstractPrototype(int id, int height, int width)
		{
			Id = id;
			Height = height;
			Width = width;
		}

		public abstract AbstractPrototype Clone();
	}
}

