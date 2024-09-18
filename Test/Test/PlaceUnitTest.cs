using Contract.DTO;
using Service;

namespace Test
{
    public class PlaceUnitTest
    {
        PlaceService _placeService;

        public PlaceUnitTest()
        {
            _placeService = new PlaceService();
        }

        List<PlaceAddRequest> get_PlacesData()
        {
            return new List<PlaceAddRequest>
            {
                new PlaceAddRequest() {Name="Briano",Code=7693,Grade=2,Address="170 Roxbury Plaza"},
                new PlaceAddRequest() {Name="Brenden",Code=7231,Grade=2,Address="5840 Fallview Lane"},
                new PlaceAddRequest() {Name="Hasheem",Code=7214,Grade=1,Address="7 Melody Point"},
                new PlaceAddRequest() {Name="Reggis",Code=7218,Grade=2,Address="76 Blaine Center"},
                new PlaceAddRequest() {Name="Barnebas",Code=7564,Grade=3,Address="6 Susan Drive"},
                new PlaceAddRequest() {Name="Marshal",Code=7669,Grade=1,Address="15 Meadow Valley Junction"},
                new PlaceAddRequest() {Name="Basil",Code=7251,Grade=2,Address="97 Drewry Center"},
                new PlaceAddRequest() {Name="Ned",Code=7390,Grade=3,Address="5 Glendale Place"},
                new PlaceAddRequest() {Name="Raynard",Code=7268,Grade=2,Address="529 Packers Point"},
                new PlaceAddRequest() {Name="Wittie",Code=7440,Grade=3,Address="99 Eastwood Center"}
            };
        }

        #region Add

        [Fact]
        public async Task AddAsync_NullArgument()
        {
            // Assert
            await Assert.ThrowsAsync<ArgumentNullException>(async () => {
                // Act
                await _placeService.AddAsync(null);
            });
        }

        [Fact]
        public async Task AddAsync_Successfully()
        {
            // Arrange
            PlaceAddRequest placeAddRequest = new PlaceAddRequest()
            {
                Address = "شیراز",
                Code = 7302,
                Grade = 1,
                Name = "کوثر"
            };

            // Act
            PlaceResponse placeResponse=await _placeService.AddAsync(placeAddRequest);

            // Assert
            Assert.True(placeResponse.Id!=Guid.Empty);
        }

        #endregion

        #region GetById

        [Fact]
        public async Task GetByIdAsync_NullArgument()
        {
            // Assert
            await Assert.ThrowsAsync<ArgumentNullException>(async () => {
                // Act
                await _placeService.GetByIdAsync(null);
            });

        }

        [Fact]
        public async Task GetByIdAsync_Successfully()
        {
            // Arrange
            PlaceAddRequest placeAddRequest
                = new PlaceAddRequest()
                {
                    Address = "شیراز",
                    Code = 7302,
                    Grade = 1,
                    Name = "کوثر"
                };
            
            PlaceResponse placeResponse_from_add = await _placeService.AddAsync(placeAddRequest);

            // Act
            PlaceResponse placeResponse_from_get= await _placeService.GetByIdAsync(placeResponse_from_add.Id);

            // Assert
            Assert.Equal(placeResponse_from_add,placeResponse_from_get);
        }

        #endregion


        [Fact]
        public async Task test()
        {
            // Arrange

            // Act

            // Assert

        }

    }
}