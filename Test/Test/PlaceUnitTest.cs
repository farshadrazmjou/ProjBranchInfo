using System.Security.Principal;
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
                new PlaceAddRequest() {Name="Shraz",Code=7693,Grade=2,Address="170 Roxbury Plaza"},
                new PlaceAddRequest() {Name="Lar",Code=7231,Grade=2,Address="5840 Fallview Lane"},
                new PlaceAddRequest() {Name="Lamerd",Code=7214,Grade=1,Address="7 Melody Point"},
                new PlaceAddRequest() {Name="Kousar",Code=7218,Grade=2,Address="76 Blaine Center"},
                new PlaceAddRequest() {Name="Zand",Code=7564,Grade=3,Address="6 Susan Drive"},
                new PlaceAddRequest() {Name="Sadi",Code=7669,Grade=1,Address="15 Meadow Valley Junction"},
                new PlaceAddRequest() {Name="Kazerun",Code=7251,Grade=2,Address="97 Drewry Center"},
                new PlaceAddRequest() {Name="Jahrom",Code=7390,Grade=3,Address="5 Glendale Place"},
                new PlaceAddRequest() {Name="Fasa",Code=7268,Grade=2,Address="529 Packers Point"},
                new PlaceAddRequest() {Name="Abadeh",Code=7440,Grade=3,Address="99 Eastwood Center"}
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

        #region GetAll

        [Fact]
        public async Task GetAll_Successfully()
        {
            // Arrange
            List<PlaceResponse> list_placeResponse_from_add=new List<PlaceResponse>();

            foreach(PlaceAddRequest placeAddRequest in get_PlacesData())
            {
                list_placeResponse_from_add.Add(await _placeService.AddAsync(placeAddRequest));
            }

            // Act
            List<PlaceResponse> list_placeResponse_from_getAll=await _placeService.GetAllAsync();

            // Assert
            for(int i=0;i<list_placeResponse_from_getAll.Count;i++)
            {
                Assert.Equal(list_placeResponse_from_add[i],list_placeResponse_from_getAll[i]);
            }

        }

        #endregion

        #region Delete

        [Fact]
        public async Task Delete_NullArgument()
        {
            // Arrange

            // Act

            // Assert
            await Assert.ThrowsAsync<ArgumentNullException>(async ()=> {
                await _placeService.DeleteAsync(null);
            });
        }

        [Fact]
        public async Task Delete_InvalidId()
        {
            // Arrange
            PlaceAddRequest placeAddRequest=new PlaceAddRequest()
            {
                Name="Shiraz",
                Address="shiraz zand street",
                Code=7201,
                Grade=1
            };
            PlaceResponse placeResponse_from_add= await _placeService.AddAsync(placeAddRequest);
            
            // Act
            bool delete_result=await _placeService.DeleteAsync(Guid.NewGuid());
            // Assert
            Assert.False(delete_result);

        }

        [Fact]
        public async Task Delete_Successfully()
        {
            // Arrange
            PlaceAddRequest placeAddRequest=new PlaceAddRequest()
            {
                Name="Shiraz",
                Address="shiraz zand street",
                Code=7201,
                Grade=1
            };
            PlaceResponse placeResponse_from_add= await _placeService.AddAsync(placeAddRequest);
            
            // Act
            bool delete_result=await _placeService.DeleteAsync(placeResponse_from_add.Id);

            // Assert
            Assert.True(delete_result);
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