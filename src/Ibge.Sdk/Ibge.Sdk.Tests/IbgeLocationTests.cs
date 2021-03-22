using FluentAssertions;
using Ibge.Sdk.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Ibge.Sdk.Tests
{
    public class IbgeLocationTests
    {
        #region MesoRegion
        
        [Fact]
        public async void GetMesoRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMesoRegionAsync();

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetMesoRegionByIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMesoRegionByIdAsync(new List<int> { 3301 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetMesoRegionByUfIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMesoRegionByUfAsync(new List<int> { 33 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetMesoRegionByRegionIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMesoRegionByRegionAsync(new List<int> { 3 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        #endregion

        #region County

        [Fact]
        public async void GetCountyTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetCountyAsync();

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetCountyByIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetCountyByIdAsync(new List<int> { 1600303 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetCountyByUfTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetCountyByUfAsync(new List<int> { 33 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetCountyByMesoRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetCountyByMesoRegionAsync(new List<int> { 3303 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetCountyByRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetCountyByRegionAsync(new List<int> { 3 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        #endregion

        #region MicroRegion

        [Fact]
        public async void GetMicroRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMicroRegionAsync();

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetMicroRegionByIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMicroRegionByIdAsync(new List<int> { 33007 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetMicroRegionByUfTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMicroRegionByUfAsync(new List<int> { 33 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetMicroRegionByMesoRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMicroRegionByMesoRegionAsync(new List<int> { 3303 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetMicroRegionByRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetMicroRegionByRegionAsync(new List<int> { 3 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        #endregion

        #region Region

        [Fact]
        public async void GetRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetRegionAsync();

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetRegionByIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetRegionByIdAsync(new List<int> { 1 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        #endregion

        #region Uf

        [Fact]
        public async void GetUfTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetUfsAsync();

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetUfByIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetUfsByIdAsync(new List<int> { 33 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GeUfByRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetUfsByRegionAsync(new List<int> { 3 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        #endregion

        #region District

        [Fact]
        public async void GetDistrictTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetDistrictsAsync();

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetDistrictByIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetDistrictsByIdAsync(new List<int> { 160030312 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetDistrictByRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetDistrictByRegionAsync(new List<int> { 3 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetDistrictByUfTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetDistrictByUfsAsync(new List<int> { 33 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetDistrictByMesoRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetDistrictByMesoRegionAsync(new List<int> { 1602 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetDistrictByMicroRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetDistrictByMicroRegionAsync(new List<int> { 16003 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetDistrictByCountyTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetDistrictByCountyAsync(new List<int> { 3550308 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        #endregion

        #region SubDistrict

        [Fact]
        public async void GetSubDistrictTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsAsync();

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetSubDistrictByIdTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsByIdAsync(new List<ulong> { 53001080517 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetSubDistrictByRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsByRegionAsync(new List<int> { 3 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetSubDistrictByUfTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsByUfsAsync(new List<int> { 43 });

                //TODO nenhum estado está retornando resultados, verificar API.
                //result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetSubDistrictByMesoRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsByMesoRegionAsync(new List<int> { 4305 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetSubDistrictByMicroRegionTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsByMicroRegionAsync(new List<int> { 11001 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetSubDistrictByCountyTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsByCountyAsync(new List<int> { 3304557 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }

        [Fact]
        public async void GetSubDistrictByDistrictTest()
        {
            try
            {
                var client = new IbgeLocationClient();
                var result = await client.GetSubDistrictsByDistrictsAsync(new List<int> { 110020505 });

                result.ToList().Should().HaveCountGreaterThan(0);
            }
            catch (Exception e)
            {
                Assert.Empty(e.Message);
            }
        }
        #endregion
    }
}
