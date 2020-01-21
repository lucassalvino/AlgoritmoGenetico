using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticAlgorithm
{
    public class GeneticAlgorithm<GeneType>
    {
        public List<Generation<GeneType>> Population { get; set; }
        public void CreateInitialPopulation(int numberOfIndividuals, int numberOfGenesOfIndividuals)
        {

        }
    }
}