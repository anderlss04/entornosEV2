
using System;
using Xunit;

namespace Metaverso
{

    public class SistemaTest
    {

        [Fact]
        public void MetaVersoTestNormal()
        {
            // Given
            var sis = new Sistema();
            var param = 5;
            var esperado = "Verso";

            // When
            var result = sis.Divisible(param);

            // Then
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void MetaVersoTestArray()
        {
            // Given
            var sis = new Sistema();
            var param = new int[5] {5 , 3 , 15 , 20 , 9};
            var esperado = "VersoMetaMetaVersoMeta";
        
            // When
            var result = sis.DivisibleArray(param);
        
            // Then
            Assert.Equal(esperado, result);
        }
    }
}