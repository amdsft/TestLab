using System;
using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace LabTest.IntegrationTests;

public class FakeControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public FakeControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

       [Fact]
        public async Task GetEntityEndpoint_WithValidRequest_ReturnsOkAndExpectedEntity()
        {
            // Arrange: إنشاء HttpClient باستخدام خادم الاختبار في الذاكرة.
            var client = _factory.CreateClient();

            // Act: إرسال طلب GET إلى نقطة النهاية "/entity".
            var response = await client.GetAsync("/entity");

            // Assert: التحقق من أن حالة الاستجابة هي 200 (OK).
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            // تحويل محتوى الاستجابة من JSON إلى كائن من نوع SampleEntity.
            var entity = await response.Content.ReadFromJsonAsync<SampleEntity>();

            // Assert: التحقق من أن الكيان غير فارغ وصح خصائصه.
            Assert.NotNull(entity);
            Assert.Equal(1, entity!.Id);
            Assert.Equal("Test Entity", entity.Name);
        }
    }