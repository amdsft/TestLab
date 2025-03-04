using Xunit;
using LabTest; 

namespace LabTest.Unit.Tests;

public class LabUnitTest
{

    
        
       [Fact]
        public void GetEntity_WithValidCall_ReturnsExpectedEntity()
        {
            // Act: استدعاء الدالة المنطقية مباشرةً من الـ EntityService.
            var entity = EntityService.GetEntity();

            // Assert: التحقق من صحة خصائص الكيان المرتجع.
            Assert.NotNull(entity); // التأكد من أن الكيان ليس نلل.
            Assert.Equal(1, entity.Id); // التحقق من أن قيمة الخاصية Id => 1.
            Assert.Equal("Test Entity", entity.Name); // التحقق من أن قيمة الخاصية Name => "Test Entity".
        }
    
}
