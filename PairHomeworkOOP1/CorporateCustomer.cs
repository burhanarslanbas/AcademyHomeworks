class CorporateCustomer : IndividualCustomer
{
    private string _companyName;

    private string _companyAddress;

    public string CompanyAddress
    {
        get
        {
            return _companyAddress;
        }
        set
        {
            _companyAddress = value;
        }
    }
    public string CompanyName
    {
        get
        {
            return _companyName;
        }
        set
        {
            _companyName = value;
        }

    }

}