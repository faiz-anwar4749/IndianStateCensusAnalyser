using System;
using System.Collections.Generic;
using System.Text;
namespace IndianStateCensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, Brazil
        }

        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }

        public void LoadCensusData(string wrongIndianStateCensusFileType, Country iNDIA, string indianStateCensusHeaders)
        {
            throw new NotImplementedException();
        }
    }
}
