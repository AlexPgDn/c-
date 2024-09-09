class Repository : IRepository
{

    private Person[] storage;
    private int count;
    private int index = 0;
    public int Index{get => index;} 
    public Repository(int count)
    {

        this.count = count;
        storage = new Person[this.count];
    }
    public void Append(params Person[] people)
    {
        foreach (var person in people)
        {

            if (this.index >= this.count) return;
            storage[index] = person;
            this.index++;
        }
    }
    public Person GetPersonById(int id)
    {

        if (id < 0 || id >= index)
        {
            return new NullPerson();

        }

        return storage[id];
    }
    
}