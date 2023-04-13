﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IDestinationService:IGenericService<Destination>
	{
		public Destination GetDestinationWithGuide(int id);
		public List<Destination> TGetLast4Destination();


    }
}
