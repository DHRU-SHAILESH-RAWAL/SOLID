namespace SOLID.LISKOVPrinciple
{
    /// Objects of base class should be replaceable with objects of derived class without affecting the correctness of the program.

    /// <summary>
    /// Below class violates the Liskov Substitution Principle (LSP) because the derived class RegularUser does not implement the WriteData method, which is expected by the base class FileDataAccess.
    /// </summary>
    class BrokeLISKOVPrinciple
    {
        public abstract class FileDataAccess
        {
            public abstract string ReadData();

            public abstract void WrtiteData(string data);
        }

        public class Admin : FileDataAccess
        {
            public override string ReadData()
            {
                // Logic to read data for premium user
                return "Premium User Data";
            }
            public override void WrtiteData(string data)
            {
                // Logic to write data for premium user
            }
        }

        public class RegularUser : FileDataAccess
        {
            public override string ReadData()
            {
                // Logic to read data for regular user
                return "Regular User Data";
            }
            // This method violates the Liskov Substitution Principle because it does not implement the WriteData method.
            public override void WrtiteData(string data)
            {
                throw new System.NotImplementedException("Regular users cannot write data.");
            }
        }
    }

    /// <summary>
    /// Below code adheres to the Liskov Substitution Principle by ensuring that derived classes can be used interchangeably with their base class without breaking functionality.
    /// </summary>
    class LISKOVPrinciple
    {
        public interface IFileDataAccessRead
        {
            public string ReadData();
        }

        public interface IFileDataAccessWrite
        {
            public void WriteData(string data);
        }

        public class Admin : IFileDataAccessRead, IFileDataAccessWrite
        {
            public string ReadData()
            {
                // Logic to read data for premium user
                return "Premium User Data";
            }
            public void WriteData(string data)
            {
                // Logic to write data for premium user
            }
        }
        public class RegularUser : IFileDataAccessRead
        {
            public string ReadData()
            {
                // Logic to read data for regular user
                return "Regular User Data";
            }
        }
    }
}
