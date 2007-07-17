using System;
using System.Collections.Generic;
using System.Text;
using BluntDirectX.Direct3D;

namespace OpenRa.Game
{
	class ConstructionYard : Building
	{
		public ConstructionYard( int2 location, int palette )
			: base( "fact", location, palette )
		{
			animation.PlayThen( "make", delegate { animation.PlayRepeating( "build" ); } );
		}
	}
}
