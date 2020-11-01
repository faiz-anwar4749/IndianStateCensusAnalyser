using IndianStateCensusAnalyser;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static IndianStateCensusAnalyser.CensusAnalyser;

namespace CensusAnalyserTestLive
{
    class CensusAnalyserTest
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string indianStateCodeFilePath = @"C:\Users\User\Desktop\C# RPA\Repos\CensusAnalyser\IndianStateCensusAnalyser\CensusAnalyserTest\CSVFiles\IndiaStateCode.csv";
        static string indianStateCensusFilePath = @"C:\Users\User\Desktop\C# RPA\Repos\CensusAnalyser\IndianStateCensusAnalyser\CensusAnalyserTest\CSVFiles\IndiaStateCensusData.csv";

        IndianStateCensusAnalyser.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new IndianStateCensusAnalyser.CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(29, totalRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}
