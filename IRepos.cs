interface IRepository{

    int Index {get;}
    void Append(params Person[] people);
    public Person GetPersonById(int id);
}