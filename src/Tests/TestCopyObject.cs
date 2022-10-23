using PatternPrototype;
using Xunit;

namespace Tests
{
    public class TestCopyObject
    {
        public Sneakers GetTestData()
        {
            return new Sneakers
            (
                brandName: "Nike",
                modelName: "Revolution 6 Next Nature",
                size: 42,
                composition: new Сomposition("Текстиль, искусственная кожа", "Резина, пластик"),
                color: "Черный"
            )
            .SetFeatures("Защита от влаги")
            .SetSportType("Бег")
            .SetWorkoutType("Комфортный бег")
            .SetPrice(6999);
        }

        [Fact]
        public void Test_AllPropertiesAreEquel()
        {
            var sneakers = GetTestData();
            var replica = (Sneakers)sneakers.Clone();

            Assert.Equal(sneakers.BrandName, replica.BrandName);
            Assert.Equal(sneakers.ModelName, replica.ModelName);
            Assert.Equal(sneakers.Size, replica.Size);
            Assert.Equal(sneakers.Composition.TopMaterial, replica.Composition.TopMaterial);
            Assert.Equal(sneakers.Composition.OutsoleMaterial, replica.Composition.OutsoleMaterial);
            Assert.Equal(sneakers.Color, replica.Color);
            Assert.Equal(sneakers.Price, replica.Price);
            Assert.Equal(sneakers.SportType, replica.SportType);
            Assert.Equal(sneakers.WorkoutType, replica.WorkoutType);
            Assert.Equal(sneakers.Features, replica.Features);
        }

        [Fact]
        public void Test_SomePropertiesAreNotEqual()
        {
            var sneakers = GetTestData();
            var replica = sneakers.Copy();

            sneakers.SetPrice(7000)
                .SetWorkoutType("Скоростной бег");

            Assert.Equal(sneakers.BrandName, replica.BrandName);
            Assert.Equal(sneakers.ModelName, replica.ModelName);
            Assert.Equal(sneakers.Size, replica.Size);
            Assert.Equal(sneakers.Composition.TopMaterial, replica.Composition.TopMaterial);
            Assert.Equal(sneakers.Composition.OutsoleMaterial, replica.Composition.OutsoleMaterial);
            Assert.Equal(sneakers.Color, replica.Color);
            Assert.NotEqual(sneakers.Price, replica.Price);
            Assert.Equal(sneakers.SportType, replica.SportType);
            Assert.NotEqual(sneakers.WorkoutType, replica.WorkoutType);
            Assert.Equal(sneakers.Features, replica.Features);
        }
    }
}