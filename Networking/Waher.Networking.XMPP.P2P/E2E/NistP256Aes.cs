﻿using System.Numerics;
using Waher.Security.EllipticCurves;

namespace Waher.Networking.XMPP.P2P.E2E
{
	/// <summary>
	/// NIST P-256 Curve
	/// </summary>
	public class NistP256Aes : EcAes256
	{
		/// <summary>
		/// NIST P-256 Curve
		/// </summary>
		public NistP256Aes()
			: this(new NistP256())
		{
		}

		/// <summary>
		/// NIST P-256 Curve
		/// </summary>
		/// <param name="Curve">Curve instance</param>
		public NistP256Aes(NistP256 Curve)
			: base(Curve)
		{
		}

		/// <summary>
		/// NIST P-256 Curve
		/// </summary>
		/// <param name="X">X-coordinate of remote public key.</param>
		/// <param name="Y">Y-coordinate of remote public key.</param>
		public NistP256Aes(byte[] X, byte[] Y)
			: base(X, Y)
		{
		}

		/// <summary>
		/// Local name of the E2E encryption scheme
		/// </summary>
		public override string LocalName => "p256";

		/// <summary>
		/// Security strength of End-to-End encryption scheme.
		/// </summary>
		public override int SecurityStrength => 128;

		/// <summary>
		/// Creates a new key.
		/// </summary>
		/// <param name="SecurityStrength">Overall desired security strength, if applicable.</param>
		/// <returns>New E2E endpoint.</returns>
		public override IE2eEndpoint Create(int SecurityStrength)
		{
			return new NistP256Aes();
		}

		/// <summary>
		/// Creates a new endpoint.
		/// </summary>
		/// <param name="D">Private key.</param>
		/// <returns>Endpoint object.</returns>
		public override EcAes256 Create(BigInteger D)
		{
			return new NistP256Aes(new NistP256(D));
		}

		/// <summary>
		/// Creates a new endpoint.
		/// </summary>
		/// <param name="X">X-coordinate of remote public key.</param>
		/// <param name="Y">Y-coordinate of remote public key.</param>
		/// <returns>Endpoint object.</returns>
		public override EcAes256 Create(byte[] X, byte[] Y)
		{
			return new NistP256Aes(X, Y);
		}
	}
}
