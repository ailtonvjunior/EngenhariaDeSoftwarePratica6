using inter.people.central.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace inter.people.central.Tests.Models
{
    public class UserDboTest
    {
        [Fact]
        public void TestCaseOrdererAttribute()
        {
            UserDboMocks.GetUserDboMock();
            Assert.NotNull(UserDboMocks.GetUserDboMock());  
        }

    }
}
