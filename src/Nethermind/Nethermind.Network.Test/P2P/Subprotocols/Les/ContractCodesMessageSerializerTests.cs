/// SPDX-FileCopyrightText: 2022 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using Nethermind.Core.Test.Builders;
using Nethermind.Network.P2P.Subprotocols.Les.Messages;
using NUnit.Framework;

namespace Nethermind.Network.Test.P2P.Subprotocols.Les
{
    [TestFixture]
    public class ContractCodesMessageSerializerTests
    {
        [Test]
        public void RoundTrip()
        {
            byte[][] data = { TestItem.KeccakA.BytesToArray(), TestItem.KeccakB.BytesToArray(), TestItem.KeccakC.BytesToArray() };
            ContractCodesMessage message = new(data, 13452, 134);

            ContractCodesMessageSerializer serializer = new();

            SerializerTester.TestZero(serializer, message);
        }
    }
}
