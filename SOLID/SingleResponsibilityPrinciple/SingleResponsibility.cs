namespace SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// Multiple responsibilities in a single class can lead to a violation of the Single Responsibility Principle (SRP).
    /// </summary>

    class Company
    {
        public string HR_Department()
        {
            return "HR Department";
        }

        public string Accounting_Department()
        {
            return "Accounting Department";
        }

        public string IT_Department()
        {
            return "IT Department";
        }

        public string Sales_Department()
        {
            return "Sales Department";
        }
        public string Marketing_Department()
        {
            return "Marketing Department";
        }
    }

    /// <summary>
    /// In this code, we have separated the responsibilities of the Company class into different classes for each department.
    /// so each clas now has a single reponsibility instead of having multiple responsibilities in a single class.
    /// </summary>

    class Company_HRDepartment
    {
        public string HRDepartment()
        {
            return "HR Department";
        }
    }

    class Company_AccountingDepartment
    {
        public string AccountingDepartment()
        {
            return "Accounting Department";
        }
    }

    class Company_ITDepartment 
    {
        public string ITDepartment()
        {
            return "IT Department";
        }
    }

    class Company_SalesDepartment
    {
        public string SalesDepartment()
        {
            return "Sales Department.";
        }
    }

    class Company_MarketingDepartment
    {
        public string MarketingDepartment()
        {
            return "Marketing Department";
        }
    }
}
