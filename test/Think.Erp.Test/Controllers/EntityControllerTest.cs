using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Think.Erp.Api.Domain.Entities;
using Think.Erp.Api.IntegrationTests.Configuration;
using Xunit;

namespace UnitTest
{


    public class RootObject
    {
        public bool success { get; set; }
        public string message { get; set; }
        public object data { get; set; }
        public string errors { get; set; }
    }


    public class EntityControllerTest : BaseIntegrationTest
    {
        private const string BaseUrl = "/v1/entities";

        public EntityControllerTest(BaseTestFixture fixture) : base(fixture)
        {

        }




        [Fact]
        public async Task PostWithValidModelShouldReturnCreated()
        {
            var person = new Entity(

                 "Wandelson",
                 "Bezerra",
                 "Wandelson Bezerra",
                 "Wans",
                 "W"
            );

            var content = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(BaseUrl, content);
            response.EnsureSuccessStatusCode();

            var root = JsonConvert.DeserializeObject<RootObject>(await response.Content.ReadAsStringAsync());

            var output = JsonConvert.DeserializeObject<Entity>(root.data.ToString());

            Assert.Equal(output.FullName, person.FullName);
        }



        [Fact]
        public async Task GetListIsEmpty()
        {
            var response = await Client.GetAsync(BaseUrl);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<Entity>>(responseString);

            Assert.Equal(data.Count, 1);
        }
    }
}