using Class_Library;
using System.Diagnostics.CodeAnalysis;

namespace MyClassesTest
{
#nullable disable
    [TestClass]
    public class FileProcessTest : TestBase
    {
        private const string faddress = @"C:\Windows\Regedit.exe"; //using constant

        [ClassInitialize()]
        public static void ClassInitialize(TestContext tc)
        {
            tc.WriteLine("In ClassInitialize() method");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }

       

       
       

        [TestMethod]
        public void FileNameDoesExist()
        {
            FileExists obj = new FileExists();
            bool fromCall;

            SetGoodFileName();
            if(!string.IsNullOrEmpty(GoodWay))
            {
                File.AppendAllText(GoodWay, "some text");
            }
            TestContext.WriteLine("Checking File " + GoodWay);

/*Good Way->fromCall = obj.File_Exists(@"C:\Windows\Regedit.exe");  */
/*Good Way->*/fromCall = obj.File_Exists(GoodWay);  

            if (File.Exists(GoodWay))
            {
                File.Delete(GoodWay);
            }
            Assert.IsTrue(fromCall);
        }


        [TestMethod]
        
        public void FileNameDoesNotExist()
        {
            FileExists obj = new FileExists();
            bool fromCall;
            TestContext.WriteLine("File is not exist in pc!");
            fromCall = obj.File_Exists(@"C:\Windows\ghj.exe");
            Assert.IsFalse(fromCall);
        }
         
        
        [TestMethod]


        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNull()
        { 
            FileExists obj = new FileExists();
            TestContext.WriteLine("File is Exist but it's name was null!!");
            obj.File_Exists("");
        }
       
        
        
        
        
        [TestMethod]

        public void FileNameNullUsingTryCatch()
        { 
             FileExists obj= new FileExists();
            try
            {
                obj.File_Exists("");
            }
            catch(ArgumentNullException)  
            {
                return;
            }

        Assert.Fail("Call to File_Exists() did not throw an Argument Null Exception. ");
        }


     


    }
}