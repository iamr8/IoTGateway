﻿using System;
using System.Collections.Generic;
using System.Text;
using Waher.Networking.XMPP.P2P.E2E;

namespace Waher.Networking.XMPP.Contracts
{
	/// <summary>
	/// Delegate for smart contracts callback methods.
	/// </summary>
	/// <param name="Sender">Sender</param>
	/// <param name="e">Event arguments</param>
	public delegate void SmartContractsEventHandler(object Sender, SmartContractsEventArgs e);

	/// <summary>
	/// Event arguments for smart contracts responses
	/// </summary>
	public class SmartContractsEventArgs : IqResultEventArgs
	{
		private readonly Contract[] contracts;

		/// <summary>
		/// Event arguments for smart contracts responses
		/// </summary>
		/// <param name="e">IQ response event arguments.</param>
		/// <param name="Contracts">Smart Contracts.</param>
		public SmartContractsEventArgs(IqResultEventArgs e, Contract[] Contracts)
			: base(e)
		{
			this.contracts = Contracts;
		}

		/// <summary>
		/// Smart Contracts
		/// </summary>
		public Contract[] Contracts => this.contracts;
	}
}
