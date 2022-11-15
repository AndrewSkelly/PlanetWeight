using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetWeights.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlanetWeights.Tests
{
    [TestClass()]
    public class PlanetWeightTests
    {
		// Calculate Weight On Planet
		public static double Calculation(double test_weight, Planets planet, int gravityselection)
        {
			List<double> planetsSurfaceGravity = new List<double> { 0.378, 0.907, 0.166, 0.377, 2.36, 0.916, 0.889, 1.12, 0.071 };
			var calculation = test_weight * planetsSurfaceGravity[(int)planet];
            return (double)calculation;
        }

		// Check NOT Null
		[TestMethod()]
        public void PlanetWeight_PlanetNameIsNotNull_IsTrue()
        {
            // Arange
            PlanetWeight planetWeight = new PlanetWeight();
            var planetName = planetWeight.planet;
            // Act
            var result = planetName;
            // Assert
            Assert.IsNotNull(result);
        }

		// Check NOT Null
		[TestMethod()]
        public void PlanetWeight_WeightIsNotNull_IsTrue()
        {
            // Arange
            PlanetWeight planetWeight = new PlanetWeight();
            var planetName = planetWeight.weight;
            // Act
            var result = planetName;
            // Assert
            Assert.IsNotNull(result);
        }

		// Check NOT Null
		[TestMethod()]
        public void PlanetWeight_WeightOnPlanetIsNotNull_IsTrue()
        {
            // Arange
            PlanetWeight planetWeight = new PlanetWeight();
            var planetName = planetWeight.weightOnPlanet;
            // Act
            var result = planetName;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void Planets_weightOnPlanetVenusIsUnder500_IsTrue()
        {
            // Arange
            PlanetWeight expected = new PlanetWeight();
			// Act
			expected.weight = 87;
			expected.planet = Planets.venus;
			var calculation = Calculation(expected.weight, expected.planet, 1);
			var result = calculation < 500;
            // Assert
            Assert.IsTrue(result);
        }

		[TestMethod()]
		public void Planets_weightOnPlanetVenusIsAbove1_IsTrue()
		{
			// Arange
			PlanetWeight expected = new PlanetWeight();
			// Act
			expected.weight = 87;
			expected.planet = Planets.venus;
			var calculation = Calculation(expected.weight, expected.planet, 1);
			var result = calculation > 1;
			// Assert
			Assert.IsTrue(result);
		}

		[TestMethod()]
		public void Planets_weightOnPlanetVenus_IsTrue()
		{

			// Arange
			PlanetWeight expected = new PlanetWeight();

			// Act
			expected.weight = 75;
			expected.planet = Planets.venus;

			// weight, gravity
			var result = Calculation(expected.weight, expected.planet, 1);
			// Assert
			Assert.IsTrue(result == 68.025);
		}

		[TestMethod()]
		public void Planets_weightOnPlanetMars_IsTrue()
		{

			// Arange
			PlanetWeight expected = new PlanetWeight();

			// Act
			expected.weight = 34;
			expected.planet = Planets.mars;

			// weight, gravity
			var result = Calculation(expected.weight, expected.planet, 3);
			// Assert
			Assert.IsTrue(result == 12.818);
		}

		[TestMethod()]
		public void Planets_weightOnPlanetJupiter_IsTrue()
		{

			// Arange
			PlanetWeight expected = new PlanetWeight();

			// Act
			expected.weight = 102;
			expected.planet = Planets.jupiter;

			// weight, gravity
			var result = Calculation(expected.weight, expected.planet, 4);
			// Assert
			Assert.IsTrue(result == 240.72);
		}
	}
}
