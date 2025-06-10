/// Dependency Inversion Principle (DIP) is one of the SOLID principles that states that high-level modules should not depend on low-level modules, but both should depend on abstractions.
/// This principle helps to reduce coupling between modules and makes the code more flexible and maintainable.
namespace SOLID.DependencyInversionPrinciple
{
    /// <summary>
    /// Below code violates the Dependency Inversion Principle (DIP) because high-level modules (ReportGenerator) depend on low-level modules (SqlDataBase) directly.
    /// </summary>
    class BrokeDependencyInversionPrinciple
    {
        class SqlDataBase
        {
            public string GetData()
            {
                return "Get data from database";
            }
        }

        class ReportGenerator
        {
            private SqlDataBase _sqlDataBase;
            public ReportGenerator()
            {
                _sqlDataBase = new SqlDataBase();
            }

            public string GenerateReport()
            {
                // Use the SqlDataBase to get data for the report
                return _sqlDataBase.GetData();
            }
        }  
    }

    /// <summary>
    /// Below code adheres to the Dependency Inversion Principle (DIP) by introducing an abstraction (ISQLDataBase) that both high-level and low-level modules depend on.
    /// This allows for easier testing and flexibility in changing the implementation without affecting the high-level module.
    /// </summary>
    class DependencyInversionPrinciple
    {
        interface ISQLDataBase
        {
            string GetData();
        }

        class SQLDataBase : ISQLDataBase
        {
            public string GetData()
            {
                return "Get data from database";
            }
        }

        class ReportGenerator
        {
            private ISQLDataBase _sqlDataBase;
            // The ReportGenerator class now depends on the abstraction (ISQLDataBase) instead of the concrete implementation (SQLDataBase).
            public ReportGenerator(ISQLDataBase sqlDataBase)
            {
                _sqlDataBase = sqlDataBase;
            }
            public string GenerateReport()
            {
                // Use the ISQLDataBase to get data for the report
                return _sqlDataBase.GetData();
            }
        }
    }
}