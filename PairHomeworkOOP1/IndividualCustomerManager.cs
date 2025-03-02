class IndividualCustomerManager
{
    private List<IndividualCustomer> _individualCustomers;
    public IndividualCustomerManager()
    {
        _individualCustomers = new List<IndividualCustomer>();
    }
    public void Add(IndividualCustomer individualCustomer)
    {
        _individualCustomers.Add(individualCustomer);
    }

    //public void Update(IndividualCustomer individualCustomer)
    //{
    //    var customer = _individualCustomers.FirstOrDefault(x => x.Id == individualCustomer.Id);
    //    if (customer != null)
    //    {
    //        customer.Name = individualCustomer.Name;
    //        customer.Address = individualCustomer.Address;
    //        customer.Email = individualCustomer.Email;
    //        customer.Phone = individualCustomer.Phone;
    //        customer.DateOfBirth = individualCustomer.DateOfBirth;
    //        customer.Gender = individualCustomer.Gender;
    //        customer.UpdatedDate = DateTime.Now;
    //    }
    //}

    public void Delete(int id)
    {
        var customer = _individualCustomers.FirstOrDefault(x => x.Id == id);
        if (customer != null)
        {
            customer.IsDeleted = true;
            customer.DeletedDate = DateTime.Now;
        }
    }

    public List<IndividualCustomer> GetList()
    {
        return _individualCustomers;
    }

    public IndividualCustomer GetById(int id)
    {
        return _individualCustomers.FirstOrDefault(x => x.Id == id);
    }
}