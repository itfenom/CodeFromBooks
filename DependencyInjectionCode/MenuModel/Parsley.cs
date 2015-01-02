﻿using System;

namespace MenuModel
{
	public class Parsley : IIngredient, IDisposable
	{
		public bool IsDisposed { get; set; }

		#region IDisposable Members

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.IsDisposed = true;
			}
		}
	}
}