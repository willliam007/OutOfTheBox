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

public partial class TripViewModel : ObservableObject 
{
    public ObservableCollection<TripModel> Trips { get; set; } = [];

    public  TripViewModel()
    {
        //LoadTrips();
    }


    private void LoadTrips()
    {
        Trips.Add(new TripModel("savane.png", "Safari à la Savane", "Garoua", DateTime.Now));
        Trips.Add(new TripModel("elephant.png", "Parc de Waza", "Waza", DateTime.Now));
        Trips.Add(new TripModel("chute.png", "Chutes de la Lobé", "Lobé", DateTime.Now));
        Trips.Add(new TripModel("pirogue.png", "Balade en Pirogue", "Kribi", DateTime.Now));
    }

    [RelayCommand]
    public void AddTrip()
    {
        // Ajoute un nouveau voyage pour la démo
        //Trips.Add(new TripModel("rhino.png", "Nouveau Voyage", "Destination", DateTime.Now));
        Trips.Add(new TripModel("savane.png", "Safari à la Savane", "Garoua", DateTime.Now));
        Trips.Add(new TripModel("elephant.png", "Parc de Waza", "Waza", DateTime.Now));
        Trips.Add(new TripModel("chute.png", "Chutes de la Lobé", "Lobé", DateTime.Now));
        Trips.Add(new TripModel("pirogue.png", "Balade en Pirogue", "Kribi", DateTime.Now));
    }
}
