using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    public class TestBase
    {
#nullable disable
        public TestContext TestContext { get; set; }
        protected string GoodWay;


        protected void SetGoodFileName()
        {
            GoodWay = TestContext.Properties["GoodFileName"].ToString();
            if (GoodWay.Contains("[AppPath]"))
            {
                GoodWay = GoodWay.Replace("[AppPath]",
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }
    }
}
