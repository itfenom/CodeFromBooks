﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductWcfAgent
{
	public class ClosedCircuitState : ICircuitState
	{
		private readonly TimeSpan timeout;
		private bool tripped;

		public ClosedCircuitState(TimeSpan timeout)
		{
			this.timeout = timeout;
		}

		public void Guard()
		{
		}

		public ICircuitState NextState()
		{
			if (this.tripped)
			{
				return new OpenCircuitState(this.timeout);
			}
			return this;
		}

		public void Succeed()
		{
		}

		public void Trip(Exception e)
		{
			this.tripped = true;
		}
	}
}
