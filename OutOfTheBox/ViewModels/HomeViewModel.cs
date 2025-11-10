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
        Trips.Add(new TripModel("savane.png", "Trips 1", "Garoua"));
        Trips.Add(new TripModel("elephant", "Trips 2", "parck de waza"));
        Trips.Add(new TripModel("chute.png", "Trips 3", "Lobé"));
        Trips.Add(new TripModel("pirogue.png", "Trips 4", "kribi"));
    }
 }

