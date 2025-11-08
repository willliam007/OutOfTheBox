using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OutOfTheBox.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.ViewModels;

    public partial class HomeViewModel : ObservableObject
    {
    public ObservableCollection<TripModel> Trips { get; set; } = [];

    [RelayCommand]
    public void AddTrip() 
    {
        Trips.Add(new TripModel("logo.png", "Trips 1", "Some location"));
        Trips.Add(new TripModel("logo.png", "Trips 2", "Saome Location"));
        Trips.Add(new TripModel("user.png", "Trips 3", "Other Location"));
        Trips.Add(new TripModel("logo.png", "Trips 4", "Some Location"));
    }
 }

