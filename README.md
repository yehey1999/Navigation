# Important Files

* App.xaml.cs => Register the DataStore, sets the root page to PersonalInfoView
* Services/IDataStore.cs => interface for DataStore
* Services/DataStore.cs => implements the IDataStore, initialize Person
* ViewModels/BaseViewModel.cs => initiatelize the DataStore, and extends and implements INotifyChanged
* Models/Person.cs => contains person members
