namespace CODC.Models;

public class CamoSet
{
    //Any game prior to Call of Duty 4: Modern Warfare does not have camos. However, I am not covering those games, only the ones from 2007 and onward.
    //Do note that World At War (2008) does not have camos at all.
    private string[]? BaseCamos { get; init; }
    private string[]? BaseRequirements { get; init; }
    private bool[]? BaseComplete { get; init; }
    
    //For games that don't have special camos, these arrays should be null.
    //Note that Modern Warfare II's base camos are considered special, as they are unique per-gun.
    private string[]? SpecialCamos  { get; init; }
    private string[]? SpecialRequirements { get; init; }
    private bool[]? SpecialComplete { get; init; }
    
    //For games that don't have mastery camos, these arrays should be null.
    private string[]? MasteryCamos  { get; init; }
    private string[]? MasteryRequirements { get; init; }
    private bool[]? MasteryComplete { get; init; }

    public CamoSet(string[]? b1, string[]? b2, bool[]? b3, string[]? s1, string[]? s2, bool[]? s3, string[]? m1, string[]? m2, bool[]? m3)
    {
        BaseCamos = b1;
        BaseRequirements = b2;
        BaseComplete = b3;
        
        SpecialCamos = s1;
        SpecialRequirements = s2;
        SpecialComplete = s3;
        
        MasteryCamos = m1;
        MasteryRequirements = m2;
        MasteryComplete = m3;
    }
    
}