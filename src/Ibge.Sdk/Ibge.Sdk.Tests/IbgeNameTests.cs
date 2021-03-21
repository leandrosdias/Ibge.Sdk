using Ibge.Sdk.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;
using Ibge.Sdk.Models;

namespace Ibge.Sdk.Tests
{
    public class IbgeNameTests
    {
        [Fact]
        public async void GetFrequencyToLeandroName()
        {
            try
            {
                var client = new IbgeNameClient();
                var result = await client.GetNamesAsync(new List<string> { "Leandro" });

                ValidateListLen(result, 1);

                var leandroResult = result.FirstOrDefault(x => x.Name.ToUpper() == "LEANDRO");
                ValidateNameLeandroResult(leandroResult);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetFrequencyToTwoNames()
        {
            try
            {
                var client = new IbgeNameClient();
                var result = await client.GetNamesAsync(new List<string> { "Leandro", "Ana" });

                ValidateListLen(result, 2);

                var leandroResult = result.FirstOrDefault(x => x.Name.ToUpper() == "LEANDRO");
                ValidateNameLeandroResult(leandroResult);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetRakingNames()
        {
            try
            {
                var client = new IbgeNameClient();
                var result = await client.GetNamesByRankingAsync();

                result.Should().NotBeNull();

                ValidateListLen(result.First().Details, 20);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        private static void ValidateListLen(IEnumerable<object> list, int len)
        {
            list.Should().NotBeNull();
            list.ToList().Count.Should().Equals(len);
            Assert.Equal(len, list.ToList().Count);
        }

        private static void ValidateNameLeandroResult(NameResult leandro)
        {
            leandro.Should().NotBeNull();
            leandro.Details.Should().NotBeNull();

            var leandro1930 = leandro.Details.FirstOrDefault(x => x.Period == "1930[");
            leandro1930.Should().NotBeNull();
            leandro1930.Frequency.Should().Be(339);
        }
    }
}
