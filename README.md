# Important Files

#### Follow the default file structure of xamarin app 

* App.xaml.cs => Register the DataStore, sets the root page to PersonalInfoView
* Services/IDataStore.cs => interface for DataStore
* Services/DataStore.cs => implements the IDataStore, initialize Person
* ViewModels/BaseViewModel.cs => initiatelize the DataStore, and extends and implements INotifyChanged
* Models/Person.cs => contains person members


#### Links

* [Navigation Xamarin](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/navigation/hierarchical)
* [Dependency Service](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/registration-and-resolution)

