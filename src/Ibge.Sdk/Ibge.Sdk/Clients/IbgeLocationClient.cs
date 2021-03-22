using Ibge.Sdk.Interfaces;
using Ibge.Sdk.Models;
using Ibge.Sdk.Services;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ibge.Sdk.Clients
{
    public class IbgeLocationClient
    {
        private readonly IIbgeConnector _connector;
        public IbgeLocationClient(IIbgeConnector connector)
        {
            _connector = connector;
        }

        public IbgeLocationClient()
        {
            _connector = IbgeConnectorFactory.GetIbgeConnector(Enums.IbgeApis.Locations);
        }

        #region Mesorregiões 

        public async Task<IEnumerable<MesoRegion>> GetMesoRegionAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "mesorregioes/");
            return JsonSerializer.Deserialize<List<MesoRegion>>(result);
        }

        public async Task<IEnumerable<MesoRegion>> GetMesoRegionByIdAsync(List<int> ids)
        {
            var result = await _connector.GetClientResponseAsync(string.Join("|", ids), "mesorregioes/");

            if (ids.Count > 1)
            {
                return JsonSerializer.Deserialize<List<MesoRegion>>(result);
            }
            var mesoRegion = JsonSerializer.Deserialize<MesoRegion>(result);

            return new List<MesoRegion> { mesoRegion };
        }

        public async Task<IEnumerable<MesoRegion>> GetMesoRegionByUfAsync(List<int> ufIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "estados/" + string.Join(" | ", ufIds) + "/mesorregioes/");
            return JsonSerializer.Deserialize<List<MesoRegion>>(result);
        }

        public async Task<IEnumerable<MesoRegion>> GetMesoRegionByRegionAsync(List<int> regionIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "regioes/" + string.Join(" | ", regionIds) + "/mesorregioes/");
            return JsonSerializer.Deserialize<List<MesoRegion>>(result);
        }

        #endregion

        #region Microrregiões

        public async Task<IEnumerable<MicroRegion>> GetMicroRegionAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "microrregioes/");
            return JsonSerializer.Deserialize<List<MicroRegion>>(result);
        }

        public async Task<IEnumerable<MicroRegion>> GetMicroRegionByUfAsync(List<int> ufIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "estados/" + string.Join(" | ", ufIds) + "/microrregioes/");
            return JsonSerializer.Deserialize<List<MicroRegion>>(result);
        }

        public async Task<IEnumerable<MicroRegion>> GetMicroRegionByMesoRegionAsync(List<int> mesoIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "mesorregioes/" + string.Join(" | ", mesoIds) + "/microrregioes/");
            return JsonSerializer.Deserialize<List<MicroRegion>>(result);
        }

        public async Task<IEnumerable<MicroRegion>> GetMicroRegionByIdAsync(List<int> ids)
        {
            var result = await _connector.GetClientResponseAsync(string.Join("|", ids), "microrregioes/");

            if (ids.Count > 1)
            {
                return JsonSerializer.Deserialize<List<MicroRegion>>(result);
            }
            var microRegion = JsonSerializer.Deserialize<MicroRegion>(result);

            return new List<MicroRegion> { microRegion };
        }

        public async Task<IEnumerable<MicroRegion>> GetMicroRegionByRegionAsync(List<int> regionIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "regioes/" + string.Join(" | ", regionIds) + "/microrregioes/");
            return JsonSerializer.Deserialize<List<MicroRegion>>(result);
        }

        #endregion

        #region Municipio

        public async Task<IEnumerable<County>> GetCountyAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "municipios/");
            return JsonSerializer.Deserialize<List<County>>(result);
        }

        public async Task<IEnumerable<County>> GetCountyByIdAsync(List<int> ids)
        {
            var result = await _connector.GetClientResponseAsync(string.Join(" | ", ids), "municipios/");

            if (ids.Count > 1)
            {
                return JsonSerializer.Deserialize<List<County>>(result);
            }
            var county = JsonSerializer.Deserialize<County>(result);

            return new List<County> { county };

        }

        public async Task<IEnumerable<County>> GetCountyByUfAsync(List<int> ufList)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "estados/" + string.Join(" | ", ufList) + "/municipios/");
            return JsonSerializer.Deserialize<List<County>>(result);
        }

        public async Task<IEnumerable<County>> GetCountyByMesoRegionAsync(List<int> mesoIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "mesorregioes/" + string.Join(" | ", mesoIds) + "/municipios/");
            return JsonSerializer.Deserialize<List<County>>(result);
        }

        public async Task<IEnumerable<County>> GetCountByMicroRegionAsync(List<int> microIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "microrregioes/" + string.Join(" | ", microIds) + "/municipios/");
            return JsonSerializer.Deserialize<List<County>>(result);
        }

        public async Task<IEnumerable<County>> GetCountyByRegionAsync(List<int> regionIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "regioes/" + string.Join(" | ", regionIds) + "/municipios/");
            return JsonSerializer.Deserialize<List<County>>(result);
        }

        #endregion

        #region Regiões

        public async Task<IEnumerable<Region>> GetRegionAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "regioes/");
            return JsonSerializer.Deserialize<List<Region>>(result);
        }

        public async Task<IEnumerable<Region>> GetRegionByIdAsync(List<int> ids)
        {
            var result = await _connector.GetClientResponseAsync(string.Join(" | ", ids), "regioes/");

            if (ids.Count > 1)
            {
                return JsonSerializer.Deserialize<List<Region>>(result);
            }
            var region = JsonSerializer.Deserialize<Region>(result);

            return new List<Region> { region };
        }

        #endregion

        #region UF

        public async Task<IEnumerable<Uf>> GetUfsAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "estados/");
            return JsonSerializer.Deserialize<List<Uf>>(result);
        }

        public async Task<IEnumerable<Uf>> GetUfsByIdAsync(List<int> ids)
        {
            var result = await _connector.GetClientResponseAsync(string.Join(" | ", ids), "estados/");

            if (ids.Count > 1)
            {
                return JsonSerializer.Deserialize<List<Uf>>(result);
            }
            var uf = JsonSerializer.Deserialize<Uf>(result);

            return new List<Uf> { uf };
        }

        public async Task<IEnumerable<Uf>> GetUfsByRegionAsync(List<int> regionIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "regioes/" + string.Join(" | ", regionIds) + "/estados/");
            return JsonSerializer.Deserialize<List<Uf>>(result);
        }

        #endregion

        #region Distrito

        public async Task<IEnumerable<District>> GetDistrictsAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "distritos/");
            return JsonSerializer.Deserialize<List<District>>(result);
        }

        public async Task<IEnumerable<District>> GetDistrictsByIdAsync(List<int> ids)
        {
            var result = await _connector.GetClientResponseAsync(string.Join(" | ", ids), "distritos/");
            return JsonSerializer.Deserialize<List<District>>(result);
        }

        public async Task<IEnumerable<District>> GetDistrictByUfsAsync(List<int> ufIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "estados/" + string.Join(" | ", ufIds) + "/distritos/");
            return JsonSerializer.Deserialize<List<District>>(result);
        }

        public async Task<IEnumerable<District>> GetDistrictByMesoRegionAsync(List<int> mesoIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "mesorregioes/" + string.Join(" | ", mesoIds) + "/distritos/");
            return JsonSerializer.Deserialize<List<District>>(result);
        }

        public async Task<IEnumerable<District>> GetDistrictByMicroRegionAsync(List<int> microIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "microrregioes/" + string.Join(" | ", microIds) + "/distritos/");
            return JsonSerializer.Deserialize<List<District>>(result);
        }

        public async Task<IEnumerable<District>> GetDistrictByCountyAsync(List<int> countyIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "municipios/" + string.Join(" | ", countyIds) + "/distritos/");
            return JsonSerializer.Deserialize<List<District>>(result);
        }

        public async Task<IEnumerable<District>> GetDistrictByRegionAsync(List<int> regionIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "regioes/" + string.Join(" | ", regionIds) + "/distritos/");
            return JsonSerializer.Deserialize<List<District>>(result);
        }

        #endregion

        #region SubDistritos

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsAsync()
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsByIdAsync(List<ulong> ids)
        {
            var result = await _connector.GetClientResponseAsync(string.Join(" | ", ids), "subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsByUfsAsync(List<int> ufIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "estados/" + string.Join(" | ", ufIds) + "/subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsByMesoRegionAsync(List<int> ufIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "mesorregioes/" + string.Join(" | ", ufIds) + "/subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsByMicroRegionAsync(List<int> microIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "microrregioes/" + string.Join(" | ", microIds) + "/subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsByCountyAsync(List<int> countyIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "municipios/" + string.Join(" | ", countyIds) + "/subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsByRegionAsync(List<int> regionIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "regioes/" + string.Join(" | ", regionIds) + "/subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }

        public async Task<IEnumerable<SubDistrict>> GetSubDistrictsByDistrictsAsync(List<int> districtIds)
        {
            var result = await _connector.GetClientResponseAsync(string.Empty, "distritos/" + string.Join(" | ", districtIds) + "/subdistritos/");
            return JsonSerializer.Deserialize<List<SubDistrict>>(result);
        }
       
        #endregion
    }
}
