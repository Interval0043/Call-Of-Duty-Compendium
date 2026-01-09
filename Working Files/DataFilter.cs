using CODC.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace CODC.Working_Files;

public class DataFilter
{
    //What I need to do is to take input from both the user, and DataInit, and spit out a view available to DataGrids.
    //Planned methods:
    /*
     * GetFamilies: Pull and expose each gun family, all in alphabetical order.
     * GetGames: Pull and expose each game, letting them be clickable in the .axaml files, or however it's needed.
     * SearchDatabase (string query): In the overall search, we're gonna take in the user query (sent by taking the value of the textbox and pushing it with the button),-
     * - and search, closest results first.
     * I don't know if I want return statements yet. Maybe I'll modify a public variable instead?
     */

    public static ObservableCollection<Gun> result = new();

    public static void SearchDatabase(string query)
    {
        
    }
}